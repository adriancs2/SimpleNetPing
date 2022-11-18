using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetPing
{
    public partial class FormAlertMessageBox : Form
    {
        public enum NetworkStatus
        {
            Online,
            Offline
        }

        NetworkStatus n;

        public FormAlertMessageBox(NetworkStatus networkStatus, string address)
        {
            n = networkStatus;

            InitializeComponent();

            string b = address;
            if (b == "8.8.8.8")
                b = "Internet Connection";

            if (networkStatus == NetworkStatus.Online)
            {
                this.Text = "Online - NetPing Alert Message";
            }
            else
            {
                this.Text = "Offline - NetPing Alert Message";
            }

            lbAddress.Text = b;

            if (networkStatus == NetworkStatus.Online)
            {
                lbStatus.Text = "ONLINE";
                lbStatus.ForeColor = Color.GreenYellow;
            }
            else
            {
                timer2.Interval = 500;
                lbStatus.Text = "OFFLINE";
                lbStatus.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Activate();
        }

        private void FormAlertMessageBox_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (n == NetworkStatus.Offline)
                timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbStatus.Visible = !lbStatus.Visible;
        }
    }
}
