using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class device
    {
        //field
        private string version;
        private double rsrp;
        private double rsrq;
        private double rssi;
        private double snr;
        private int device_id;
        private string port;

        //properties

        public double Rsrp { get => rsrp; set => rsrp = value; }
        public string Version { get => version; set => version = value; }
        public double Rsrq { get => rsrq; set => rsrq = value; }
        public double Rssi { get => rssi; set => rssi = value; }
        public double Snr { get => snr; set => snr = value; }
        public int Device_id { get => device_id; set => device_id = value; }
        public string Port { get => port; set => port = value; }

        //constructs
        public device() {
        }

        public device(string aport, string aversion, int aid, int arsrp, int arsrq, int asnr, int arssi) {
            this.port = aport; this.version = aversion; this.device_id = aid; this.rsrp = arsrp;
            this.rsrq = arsrq; this.snr = CalculateSnr(asnr); this.rssi = arssi;
        }
        //methods
        private int CalculateSnr(int value) {
            int snr1 = value * 30 / 250;
            return snr1;
        }

    }
}
