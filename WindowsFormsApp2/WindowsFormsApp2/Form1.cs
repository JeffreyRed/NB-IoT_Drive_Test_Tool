using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Device.Location;
using GMap.NET;
using GMap.NET.Projections;
using GMap.NET.MapProviders;
using System.Threading;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.IO;
using System.IO.Ports;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
        //create a new layer for the map.
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        double lat;
        double longt;
        device d1 = new device();
        string datain;
        string pathlog;
        StreamWriter log;
        Bitmap red = new Bitmap(Path.GetFullPath(Application.StartupPath) + "\\red_point.bmp");
        Bitmap blue = new Bitmap(Path.GetFullPath(Application.StartupPath) + "\\blue_point.bmp");
        Bitmap yellow = new Bitmap(Path.GetFullPath(Application.StartupPath) + "\\yellow_point.bmp");
        Bitmap green = new Bitmap(Path.GetFullPath(Application.StartupPath) + "\\green_point.bmp");
        Bitmap black = new Bitmap(Path.GetFullPath(Application.StartupPath) + "\\black_point.bmp");
        Bitmap orange = new Bitmap(Path.GetFullPath(Application.StartupPath) + "\\orange_point.bmp");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeoCoordinate coord = watcher.Position.Location;
            //Console.WriteLine("Latitude: "+watcher.Position.Location.Latitude);
            //Console.WriteLine("Longitude: "+watcher.Position.Location.Longitude);
            

            //Console.ReadLine();
            if (coord.IsUnknown) {
                MessageBox.Show("Error");
            }
            else {
                lat = coord.Latitude;
                longt = coord.Longitude;
                map.Position = new PointLatLng(lat,longt);
                try { 
                
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, longt), red);
                    //add my own point picture.
                    markersOverlay.Markers.Add(marker);
                    map.Overlays.Add(markersOverlay);
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.ToString());
                }
                
                //GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, longt), GMarkerGoogleType.blue_pushpin);
               
                //MessageBox.Show(coord.Latitude.ToString());
            }

            //switch (coord.Latitude)
            //{
            //    case 0:
            //        MessageBox.Show("Error");
            //        break;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialization at the load of the form.
           
            watcher.TryStart(true, TimeSpan.FromMilliseconds(15000));
            watcher.Start();
            //MessageBox.Show("Position Permission: " + watcher.Permission.ToString());
            //MessageBox.Show("Watcher Status: " + watcher.Status.ToString());
            Thread.Sleep(2000);
            map.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 16;
            map.MarkersEnabled=true;
            map.CanDragMap = true;
            map.PolygonsEnabled = true;

            string[] ports = SerialPort.GetPortNames();
                listports.Items.AddRange(ports);
                listbaud.Items.Add(115200);
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            serialPort1.PortName = Convert.ToString(listports.Text);
            serialPort1.BaudRate = Convert.ToInt32(listbaud.Text);
            serialPort1.DataBits = 8;
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
            //serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
            serialPort1.Open();

            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.Write("AT+CPIN=0000\r\n");
                Thread.Sleep(25);
                serialPort1.DiscardInBuffer();
                serialPort1.Write("ATI\r\n");
                Thread.Sleep(25);
                datain = serialPort1.ReadExisting();
                this.Invoke(new EventHandler(ShowData));
                serialPort1.DiscardInBuffer();
                serialPort1.Write("AT+QNWINFO\r\n");
                Thread.Sleep(40);
                datain = serialPort1.ReadExisting();
                this.Invoke(new EventHandler(ShowData));
            }
            
            //snr3 = ((snr3 * 30) / 250);//conver to dB.
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            log.Close();
            MessageBox.Show($"File was save in {pathlog}");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //datain = serialPort1.ReadExisting();
            //this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            try
            {
                if (datain.Contains("NOSERVICE"))
                {
                    rsrp.Text = "-";
                    rssi.Text = "-";
                    snr.Text = "-";
                    rsrq.Text = "-";
                    tech.Text = "-";
                    //freq.Text = "-";
                    label10.Text ="No Service";
                }
                else if (!datain.Contains("\n"))
                {
                    rsrp.Text = "-";
                    rssi.Text = "-";
                    snr.Text = "-";
                    rsrq.Text = "-";
                    tech.Text = "-";
                    //freq.Text = "-";
                    label10.Text = "No Service";
                }
                else if (datain.Contains("+QCSQ"))
                {

                    string[] data = datain.Split(',');
                    rsrp.Text = data[2];
                    rssi.Text = data[1];
                    snr.Text = (Convert.ToInt32 (data[3]) * 30 / 250).ToString();
                    rsrq.Text = data[4].Substring(0,data[4].IndexOf("\r"));
                    tech.Text = data[0].Substring(data[0].IndexOf(":")+3, 7);
                    label10.Text = "In Service";

                }
                else if (datain.Contains("Revision"))
                {
                    ver.Text = datain.Substring(datain.IndexOf(':') + 2,15);
                }
                else if (datain.Contains("QNWINFO"))
                {
                    string[] data = datain.Split(',');
                    freq.Text = data[2].Substring(1, 11);
                }
                
            }
            catch (Exception b){
                //MessageBox.Show("Problaby, there is not service");
                //timer1.Stop();
                //button4.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
            if (serialPort1.IsOpen) {
                serialPort1.Close();
            }
            if (!button4.Enabled)
            {
                log.Close();
            }
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = false;
            MessageBox.Show("Finished");
            
        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult folder= fd.ShowDialog();
            string datelog = DateTime.Now.ToString().Replace(':', '_');
            pathlog = Path.Combine(fd.SelectedPath.ToString(),datelog.Replace('/','_') + "_Test.txt");
            //if (!File.Exists(pathlog))
            //{
            //    File.Create((pathlog));
            //    File.SetAttributes(pathlog, new FileInfo(pathlog).Attributes | FileAttributes.Normal);
                
            //    Thread.Sleep(200);
            //}
            
            log = new StreamWriter(pathlog);
            log.Write("Latitude;Longitude;SNR;RSRP;RSPQ;RSSI;Technology;VERSION;DATE\r\n");
            timer1.Start();
            button5.Enabled = true;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            log.Close();
            button4.Enabled = true;
            button5.Enabled = false;
            MessageBox.Show("Saved");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            GeoCoordinate coord = watcher.Position.Location;
            try {
            latitude.Text = coord.Latitude.ToString();
            longitude.Text = coord.Longitude.ToString();
            serialPort1.DiscardInBuffer();
                Thread.Sleep(2);
                serialPort1.Write("AT+QCSQ\r\n"); // to get the signal
                Thread.Sleep(5);
            datain = serialPort1.ReadExisting();
                if (datain.Contains("NOSERVICE")|| (!datain.Contains("\n")))
                {
                    this.Invoke(new EventHandler(ShowData));
                    d1.Snr = 0;
                    d1.Port = listports.Text;
                    d1.Rsrp = 0;
                    d1.Rsrq = 0;
                    d1.Rssi = 0;
                    if (datain.Contains("NOSERVICE")){ 
                    log.Write($"{latitude.Text};{longitude.Text};{0};{0};{0};{0};{0};{0};{DateTime.Now.ToString()}\r\n");
                    }
                }
                else {
                    this.Invoke(new EventHandler(ShowData));
                    d1.Device_id = 1;
                    d1.Port = listports.Text;
                    d1.Version = ver.Text;
                    d1.Snr = Convert.ToInt32(snr.Text) * 30 / 250;
                    d1.Rsrp = Convert.ToInt32(rsrp.Text);
                    d1.Rsrq = Convert.ToInt32(rsrq.Text);
                    d1.Rssi = Convert.ToInt32(rssi.Text);

                    log.Write($"{latitude.Text};{longitude.Text};{snr.Text};{rsrp.Text};{rsrq.Text};{rssi.Text};{tech.Text};{ver.Text};{DateTime.Now.ToString()}\r\n");

                }

            }
            catch (Exception b)
            {
                //MessageBox.Show(b.ToString());
            }
            if (coord.IsUnknown)
            {
                //MessageBox.Show("Error");
            }
            else
            {
                lat = coord.Latitude;
                longt = coord.Longitude;
                map.Position = new PointLatLng(lat, longt);
                try
                {
                    if (d1.Rsrp>=-84){ 
                        //Bitmap bmp = new Bitmap(@"C:\Users\jeff_\source\repos\WindowsFormsApp2\red_point.bmp");
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, longt), red);
                        //add my own point picture.
                        markersOverlay.Markers.Add(marker);
                        map.Overlays.Add(markersOverlay);
                    }else if (d1.Rsrp <=-85 && d1.Rsrp > -102)
                    {
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, longt), orange);
                        markersOverlay.Markers.Add(marker);
                        map.Overlays.Add(markersOverlay);
                    }
                    else if (d1.Rsrp <= -102 && d1.Rsrp > -111)
                    {
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, longt), yellow);
                        markersOverlay.Markers.Add(marker);
                        map.Overlays.Add(markersOverlay);
                    }
                    else if (d1.Rsrp <= -111 && d1.Rsrp > -120)
                    {
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, longt), green);
                        markersOverlay.Markers.Add(marker);
                        map.Overlays.Add(markersOverlay);
                    }
                    else if (d1.Rsrp == 0)
                    {
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, longt), black);
                        markersOverlay.Markers.Add(marker);
                        map.Overlays.Add(markersOverlay);
                    }
                    else 
                    {
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, longt), black);
                        markersOverlay.Markers.Add(marker);
                        map.Overlays.Add(markersOverlay);
                    }
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.ToString());
                    
                }
            }
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult comment = MessageBox.Show("Do you want to close the program", "Exit", MessageBoxButtons.YesNo);
            if (comment == DialogResult.Yes)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
              
            }
            else if (comment == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listports.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            listports.Items.AddRange(ports);
        }

        private void listbaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
