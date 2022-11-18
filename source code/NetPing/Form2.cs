using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;
using System.Media;
using System.IO;
using System.Reflection;

namespace NetPing
{
    public partial class Form2 : Form
    {
        string version = "1.1";

        FormAlertMessageBox formAlertMessageBox;

        Icon iconOffline = null;
        Icon iconOnline = null;

        Size sizeCollapse = new Size(223, 259);
        Size sizeMax = new Size(494, 259);

        Config config = new Config();

        Stream musicYes = null;
        Stream musicNo = null;

        bool _online = false;
        bool online
        {
            get
            {
                return _online;
            }
            set
            {
                _online = value;
            }
        }

        Ping p = new Ping();

        SoundPlayer sp = new SoundPlayer();

        string address = "8.8.8.8";
        bool isOnlineImage = false;

        int alertLeft = 0;
        bool alertOnline, alertOffline;
        bool alertForever = false;

        bool preventWrite = false;

        bool startEngine = false;
        bool firstLaunch = true;

        bool showAlertMessage = false;

        public Form2()
        {
            InitializeComponent();

            Stream streamIconOffline = Assembly.GetExecutingAssembly().GetManifestResourceStream("NetPing.logo_offline.ico");
            Stream streamIconOnline = Assembly.GetExecutingAssembly().GetManifestResourceStream("NetPing.logo_online.ico");
            iconOffline = new Icon(streamIconOffline);
            iconOnline = new Icon(streamIconOnline);

            this.Icon = iconOffline;

            musicYes = Assembly.GetExecutingAssembly().GetManifestResourceStream("NetPing.yes.wav");
            musicNo = Assembly.GetExecutingAssembly().GetManifestResourceStream("NetPing.no.wav");

            ReadConfig();
        }

        void ReadConfig()
        {
            config.Read();

            preventWrite = true;

            cbShowAlertMessage.Checked = config.ShowAlertMessage;
            cbCollapse.Checked = config.Collapse;
            cbAlertIfOnline.Checked = config.AlertIfOnline;
            cbAlertIfOffline.Checked = config.AlertIfOffline;
            radioButton1.Checked = config.CheckForInternetConnection;
            radioButton2.Checked = !config.CheckForInternetConnection;
            numericUpDown1.Value = config.AlertTimes;
            textBox1.Text = config.SpecificAddress;

            showAlertMessage = cbShowAlertMessage.Checked;
            SetPingAddress();
            ResetPlayTimesCounter();
            RedrawForm();

            preventWrite = false;
        }

        void WriteConfig()
        {
            if (preventWrite)
                return;

            preventWrite = true;

            config.ShowAlertMessage = cbShowAlertMessage.Checked;
            config.Collapse = cbCollapse.Checked;
            config.AlertIfOnline = cbAlertIfOnline.Checked;
            config.AlertIfOffline = cbAlertIfOffline.Checked;
            config.CheckForInternetConnection = radioButton1.Checked;
            config.AlertTimes = (int)numericUpDown1.Value;
            config.SpecificAddress = textBox1.Text;

            config.Write();

            preventWrite = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            startEngine = true;

            alertOnline = cbAlertIfOnline.Checked;
            alertOffline = cbAlertIfOffline.Checked;
            alertLeft = (int)numericUpDown1.Value;

            timer1.Start();
            bw.RunWorkerAsync();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (online)
            {
                if (!isOnlineImage || firstLaunch)
                {
                    this.Text = "Online - NetPing V" + version;

                    ResetPlayTimesCounter();
                    isOnlineImage = true;

                    PlayAlertSound();

                    ChangeBackgroundImage();

                    if (showAlertMessage)
                    {
                        ShowAlertMessageBox();
                    }
                }
            }
            else
            {
                if (isOnlineImage || firstLaunch)
                {
                    this.Text = "Offline - NetPing V" + version;

                    ResetPlayTimesCounter();
                    isOnlineImage = false;

                    PlayAlertSound();

                    ChangeBackgroundImage();

                    if (showAlertMessage)
                    {
                        ShowAlertMessageBox();
                    }
                }
            }

            firstLaunch = false;
        }

        void ChangeBackgroundImage()
        {
            if (isOnlineImage)
            {
                RedrawForm();
                this.pictureBox1.Image = global::NetPing.Properties.Resources.online;
            }
            else
            {
                this.SuspendLayout();

                RedrawForm();

                this.pictureBox1.Image = global::NetPing.Properties.Resources.offline;
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    PingReply rp = p.Send(address);

                    if (rp.Status == IPStatus.Success)
                        online = true;
                    else
                        online = false;
                }
                catch
                {
                    online = false;
                }
                Thread.Sleep(100);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!startEngine)
                return;

            if (radioButton2.Checked)
            {
                address = textBox1.Text;
            }

            WriteConfig();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ResetPlayTimesCounter();
            SetPingAddress();
            WriteConfig();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ResetPlayTimesCounter();
            SetPingAddress();
            WriteConfig();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Select(0, 0);
            timer2.Stop();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlertIfOffline.Checked && !online)
            {
                ResetPlayTimesCounter();
                PlayAlertSound();
            }
            alertOffline = cbAlertIfOffline.Checked;
            WriteConfig();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlertIfOnline.Checked && online)
            {
                ResetPlayTimesCounter();
                PlayAlertSound();
            }
            alertOnline = cbAlertIfOnline.Checked;
            WriteConfig();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
                alertForever = true;
            else
                alertForever = false;

            alertLeft = (int)numericUpDown1.Value;

            ResetPlayTimesCounter();

            PlayAlertSound();

            WriteConfig();
        }

        private void cbCollapse_CheckedChanged(object sender, EventArgs e)
        {
            WriteConfig();
            RedrawForm();
        }

        void PlayAlertSound()
        {
            if (!startEngine)
                return;

            if (alertLeft > 0 || alertForever)
            {
                if (!bwPlayAlert.IsBusy)
                {
                    bwPlayAlert.RunWorkerAsync();
                }
            }
        }

        void ShowAlertMessageBox()
        {
            if (formAlertMessageBox != null)
            {
                formAlertMessageBox.Close();
                formAlertMessageBox.Dispose();
                formAlertMessageBox = null;
            }

            FormAlertMessageBox.NetworkStatus n = FormAlertMessageBox.NetworkStatus.Offline;

            if (online)
                n = FormAlertMessageBox.NetworkStatus.Online;

            formAlertMessageBox = new FormAlertMessageBox(n, address);
            formAlertMessageBox.Icon = this.Icon;
            formAlertMessageBox.Show();
        }

        private void bwPlayAlert_DoWork(object sender, DoWorkEventArgs e)
        {
            //ExtractWavFiles();

            bool play = true;

            while (play)
            {
                alertLeft = alertLeft - 1;

                try
                {
                    if (isOnlineImage)
                    {
                        if (!alertOnline)
                            return;

                        if (sp.Stream != musicYes)
                        {
                            sp.Stream = musicYes;
                            sp.Load();
                        }
                    }
                    else
                    {
                        if (!alertOffline)
                            return;

                        if (sp.Stream != musicNo)
                        {
                            sp.Stream = musicNo;
                            sp.Load();
                        }
                    }
                    sp.PlaySync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Wav File Play Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (alertLeft < 0)
                    alertLeft = 0;

                if (alertForever)
                    play = true;
                else if (alertLeft <= 0)
                    play = false;
                else
                    play = true;
            }
        }

        void ResetPlayTimesCounter()
        {
            alertLeft = (int)numericUpDown1.Value;
        }

        void SetPingAddress()
        {
            if (radioButton1.Checked)
            {
                address = "8.8.8.8";
            }
            else
            {
                address = textBox1.Text;
            }
        }

        void RedrawForm()
        {
            if (cbCollapse.Checked)
            {
                this.SuspendLayout();

                if (this.Size != sizeCollapse)
                    this.Size = sizeCollapse;
                this.BackgroundImage = null;

                foreach (Control c in this.Controls)
                {
                    if (c.Location.X > 200)
                        c.Location = new Point(c.Location.X - (sizeMax.Width - sizeCollapse.Width), c.Location.Y);
                }

                this.ResumeLayout();
                this.PerformLayout();
            }
            else
            {
                this.SuspendLayout();

                if (this.Size != sizeMax)
                    this.Size = sizeMax;
                if (online)
                {
                    this.BackgroundImage = global::NetPing.Properties.Resources.bg;
                }
                else
                {
                    this.BackgroundImage = global::NetPing.Properties.Resources.bg_offline;
                }

                foreach (Control c in this.Controls)
                {
                    if (c.Location.X < 200)
                        c.Location = new Point(c.Location.X + (sizeMax.Width - sizeCollapse.Width), c.Location.Y);
                }

                this.ResumeLayout();
                this.PerformLayout();
            }

            if (online)
                this.Icon = iconOnline;
            else
                this.Icon = iconOffline;
        }

        private void cbShowAlertMessage_CheckedChanged(object sender, EventArgs e)
        {
            showAlertMessage = cbShowAlertMessage.Checked;
            WriteConfig();
        }
    }
}