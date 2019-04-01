namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listports = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listbaud = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.freq = new System.Windows.Forms.Label();
            this.snr = new System.Windows.Forms.Label();
            this.rsrq = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rsrp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tech = new System.Windows.Forms.Label();
            this.rssi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ver = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.table1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get First Location";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.map.Bearing = 0F;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(263, 136);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(694, 390);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Connect Device";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listports
            // 
            this.listports.FormattingEnabled = true;
            this.listports.Location = new System.Drawing.Point(94, 37);
            this.listports.Name = "listports";
            this.listports.Size = new System.Drawing.Size(157, 24);
            this.listports.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "COM Ports";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Baud Rate";
            // 
            // listbaud
            // 
            this.listbaud.FormattingEnabled = true;
            this.listbaud.Location = new System.Drawing.Point(94, 65);
            this.listbaud.Name = "listbaud";
            this.listbaud.Size = new System.Drawing.Size(157, 24);
            this.listbaud.TabIndex = 14;
            this.listbaud.SelectedIndexChanged += new System.EventHandler(this.listbaud_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(775, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 48);
            this.button3.TabIndex = 17;
            this.button3.Text = "Disconnect Device";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // table1
            // 
            this.table1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.table1.ColumnCount = 2;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.55932F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.44068F));
            this.table1.Controls.Add(this.freq, 1, 3);
            this.table1.Controls.Add(this.snr, 1, 2);
            this.table1.Controls.Add(this.rsrq, 1, 1);
            this.table1.Controls.Add(this.label3, 0, 1);
            this.table1.Controls.Add(this.rsrp, 1, 0);
            this.table1.Controls.Add(this.label1, 0, 0);
            this.table1.Controls.Add(this.label12, 0, 5);
            this.table1.Controls.Add(this.label13, 0, 6);
            this.table1.Controls.Add(this.latitude, 1, 5);
            this.table1.Controls.Add(this.longitude, 1, 6);
            this.table1.Controls.Add(this.label7, 0, 2);
            this.table1.Controls.Add(this.label4, 0, 4);
            this.table1.Controls.Add(this.label11, 0, 7);
            this.table1.Controls.Add(this.tech, 1, 7);
            this.table1.Controls.Add(this.rssi, 1, 4);
            this.table1.Controls.Add(this.label8, 0, 8);
            this.table1.Controls.Add(this.ver, 1, 8);
            this.table1.Controls.Add(this.label9, 0, 3);
            this.table1.Location = new System.Drawing.Point(12, 152);
            this.table1.Name = "table1";
            this.table1.RowCount = 9;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1137F));
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1137F));
            this.table1.Size = new System.Drawing.Size(245, 277);
            this.table1.TabIndex = 18;
            // 
            // freq
            // 
            this.freq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.freq.AutoSize = true;
            this.freq.Location = new System.Drawing.Point(97, 96);
            this.freq.Name = "freq";
            this.freq.Size = new System.Drawing.Size(54, 17);
            this.freq.TabIndex = 7;
            this.freq.Text = "label10";
            // 
            // snr
            // 
            this.snr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.snr.AutoSize = true;
            this.snr.Location = new System.Drawing.Point(97, 66);
            this.snr.Name = "snr";
            this.snr.Size = new System.Drawing.Size(46, 17);
            this.snr.TabIndex = 5;
            this.snr.Text = "label8";
            // 
            // rsrq
            // 
            this.rsrq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rsrq.AutoSize = true;
            this.rsrq.Location = new System.Drawing.Point(97, 36);
            this.rsrq.Name = "rsrq";
            this.rsrq.Size = new System.Drawing.Size(46, 17);
            this.rsrq.TabIndex = 3;
            this.rsrq.Text = "label4";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "RSRQ";
            // 
            // rsrp
            // 
            this.rsrp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rsrp.AutoSize = true;
            this.rsrp.Location = new System.Drawing.Point(97, 6);
            this.rsrp.Name = "rsrp";
            this.rsrp.Size = new System.Drawing.Size(46, 17);
            this.rsrp.TabIndex = 1;
            this.rsrp.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSRP";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Latitude";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Longitude";
            // 
            // latitude
            // 
            this.latitude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.latitude.AutoSize = true;
            this.latitude.Location = new System.Drawing.Point(97, 156);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(54, 17);
            this.latitude.TabIndex = 12;
            this.latitude.Text = "label15";
            // 
            // longitude
            // 
            this.longitude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.longitude.AutoSize = true;
            this.longitude.Location = new System.Drawing.Point(97, 186);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(54, 17);
            this.longitude.TabIndex = 13;
            this.longitude.Text = "label16";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "SNR";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "RSSI";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Technology";
            // 
            // tech
            // 
            this.tech.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tech.AutoSize = true;
            this.tech.Location = new System.Drawing.Point(97, 216);
            this.tech.Name = "tech";
            this.tech.Size = new System.Drawing.Size(54, 17);
            this.tech.TabIndex = 11;
            this.tech.Text = "label14";
            // 
            // rssi
            // 
            this.rssi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rssi.AutoSize = true;
            this.rssi.Location = new System.Drawing.Point(97, 126);
            this.rssi.Name = "rssi";
            this.rssi.Size = new System.Drawing.Size(30, 17);
            this.rssi.TabIndex = 15;
            this.rssi.Text = "rssi";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Version";
            // 
            // ver
            // 
            this.ver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ver.AutoSize = true;
            this.ver.Location = new System.Drawing.Point(97, 250);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(0, 17);
            this.ver.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Frequency";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "MAP";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 468);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 53);
            this.button4.TabIndex = 22;
            this.button4.Text = "Start logging";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 468);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 53);
            this.button5.TabIndex = 23;
            this.button5.Text = "Stop logging";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(94, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Refresh Ports";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 533);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.map);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listbaud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listports);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Drive Test Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.table1.ResumeLayout(false);
            this.table1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox listports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox listbaud;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel table1;
        private System.Windows.Forms.Label freq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label snr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rsrq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rsrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label tech;
        private System.Windows.Forms.Label latitude;
        private System.Windows.Forms.Label longitude;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rssi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ver;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
    }
}

