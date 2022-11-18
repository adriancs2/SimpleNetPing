namespace NetPing
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbAlertIfOnline = new System.Windows.Forms.CheckBox();
            this.cbAlertIfOffline = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bwPlayAlert = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCollapse = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShowAlertMessage = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NetPing.Properties.Resources.offline;
            this.pictureBox1.Location = new System.Drawing.Point(331, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(301, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "8.8.8.8";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(284, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 18);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Check For Internet Connection";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.Location = new System.Drawing.Point(284, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(121, 32);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Check Specific IP or\r\nWebsite Connection";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbAlertIfOnline
            // 
            this.cbAlertIfOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlertIfOnline.AutoSize = true;
            this.cbAlertIfOnline.BackColor = System.Drawing.Color.Transparent;
            this.cbAlertIfOnline.Checked = true;
            this.cbAlertIfOnline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlertIfOnline.Location = new System.Drawing.Point(284, 148);
            this.cbAlertIfOnline.Name = "cbAlertIfOnline";
            this.cbAlertIfOnline.Size = new System.Drawing.Size(89, 18);
            this.cbAlertIfOnline.TabIndex = 4;
            this.cbAlertIfOnline.Text = "Alert if online";
            this.cbAlertIfOnline.UseVisualStyleBackColor = false;
            this.cbAlertIfOnline.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbAlertIfOffline
            // 
            this.cbAlertIfOffline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlertIfOffline.AutoSize = true;
            this.cbAlertIfOffline.BackColor = System.Drawing.Color.Transparent;
            this.cbAlertIfOffline.Checked = true;
            this.cbAlertIfOffline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlertIfOffline.Location = new System.Drawing.Point(379, 148);
            this.cbAlertIfOffline.Name = "cbAlertIfOffline";
            this.cbAlertIfOffline.Size = new System.Drawing.Size(91, 18);
            this.cbAlertIfOffline.TabIndex = 5;
            this.cbAlertIfOffline.Text = "Alert if offline";
            this.cbAlertIfOffline.UseVisualStyleBackColor = false;
            this.cbAlertIfOffline.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(281, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alert repeat:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(354, 173);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(390, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "(Zero = Endless)";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bwPlayAlert
            // 
            this.bwPlayAlert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPlayAlert_DoWork);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(232, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "https://github.com/adriancs2/SimpleNetPing";
            // 
            // cbCollapse
            // 
            this.cbCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCollapse.AutoSize = true;
            this.cbCollapse.BackColor = System.Drawing.Color.Transparent;
            this.cbCollapse.Location = new System.Drawing.Point(411, 35);
            this.cbCollapse.Name = "cbCollapse";
            this.cbCollapse.Size = new System.Drawing.Size(67, 18);
            this.cbCollapse.TabIndex = 11;
            this.cbCollapse.Text = "Collapse";
            this.cbCollapse.UseVisualStyleBackColor = false;
            this.cbCollapse.CheckedChanged += new System.EventHandler(this.cbCollapse_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbShowAlertMessage);
            this.panel1.Location = new System.Drawing.Point(275, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 25);
            this.panel1.TabIndex = 12;
            // 
            // cbShowAlertMessage
            // 
            this.cbShowAlertMessage.AutoSize = true;
            this.cbShowAlertMessage.Location = new System.Drawing.Point(1, 3);
            this.cbShowAlertMessage.Name = "cbShowAlertMessage";
            this.cbShowAlertMessage.Size = new System.Drawing.Size(126, 18);
            this.cbShowAlertMessage.TabIndex = 0;
            this.cbShowAlertMessage.Text = "Show alert message";
            this.cbShowAlertMessage.UseVisualStyleBackColor = true;
            this.cbShowAlertMessage.CheckedChanged += new System.EventHandler(this.cbShowAlertMessage_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::NetPing.Properties.Resources.bg_offline;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(478, 221);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbCollapse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAlertIfOffline);
            this.Controls.Add(this.cbAlertIfOnline);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Offline - Simple NetPing";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox cbAlertIfOnline;
        private System.Windows.Forms.CheckBox cbAlertIfOffline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker bwPlayAlert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbCollapse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbShowAlertMessage;
    }
}