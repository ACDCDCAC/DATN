namespace GiaoTiepPC
{
    partial class Themes
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
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCom = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbxIdIn = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timelabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxTimeIn = new System.Windows.Forms.TextBox();
            this.tbxDateIn = new System.Windows.Forms.TextBox();
            this.timeIn = new System.Windows.Forms.Label();
            this.dateIn = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbxTimeOut = new System.Windows.Forms.TextBox();
            this.tbxDateOut = new System.Windows.Forms.TextBox();
            this.tbxIdOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txNumIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txNumOccupied = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txNumFree = new System.Windows.Forms.TextBox();
            this.lbIn = new System.Windows.Forms.Label();
            this.lbOut = new System.Windows.Forms.Label();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // UART
            // 
            this.UART.BaudRate = 115200;
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceived);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port COM";
            // 
            // cbxCom
            // 
            this.cbxCom.FormattingEnabled = true;
            this.cbxCom.Location = new System.Drawing.Point(100, 27);
            this.cbxCom.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCom.Name = "cbxCom";
            this.cbxCom.Size = new System.Drawing.Size(182, 32);
            this.cbxCom.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(100, 62);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(76, 26);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Conect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(201, 62);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(81, 26);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(913, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Status";
            // 
            // tbxIdIn
            // 
            this.tbxIdIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdIn.Location = new System.Drawing.Point(115, 50);
            this.tbxIdIn.Name = "tbxIdIn";
            this.tbxIdIn.Size = new System.Drawing.Size(254, 29);
            this.tbxIdIn.TabIndex = 12;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(20, 50);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(89, 29);
            this.lb2.TabIndex = 13;
            this.lb2.Text = "ID In ";
            // 
            // tm1
            // 
            this.tm1.Enabled = true;
            this.tm1.Interval = 1000;
            this.tm1.Tick += new System.EventHandler(this.tm1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.timelabel);
            this.groupBox1.Controls.Add(this.Datelabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(474, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 103);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date & Time";
            // 
            // timelabel
            // 
            this.timelabel.Location = new System.Drawing.Point(96, 70);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(103, 29);
            this.timelabel.TabIndex = 3;
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Datelabel
            // 
            this.Datelabel.Location = new System.Drawing.Point(87, 35);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(133, 26);
            this.Datelabel.TabIndex = 2;
            this.Datelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Time :";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.cbxCom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(35, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 103);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conecting";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Controls.Add(this.tbxTimeIn);
            this.groupBox3.Controls.Add(this.tbxDateIn);
            this.groupBox3.Controls.Add(this.timeIn);
            this.groupBox3.Controls.Add(this.dateIn);
            this.groupBox3.Controls.Add(this.lb2);
            this.groupBox3.Controls.Add(this.tbxIdIn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 221);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GATE IN";
            // 
            // tbxTimeIn
            // 
            this.tbxTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTimeIn.Location = new System.Drawing.Point(115, 144);
            this.tbxTimeIn.Name = "tbxTimeIn";
            this.tbxTimeIn.Size = new System.Drawing.Size(254, 29);
            this.tbxTimeIn.TabIndex = 17;
            // 
            // tbxDateIn
            // 
            this.tbxDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDateIn.Location = new System.Drawing.Point(115, 99);
            this.tbxDateIn.Name = "tbxDateIn";
            this.tbxDateIn.Size = new System.Drawing.Size(255, 29);
            this.tbxDateIn.TabIndex = 16;
            // 
            // timeIn
            // 
            this.timeIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeIn.Location = new System.Drawing.Point(20, 146);
            this.timeIn.Name = "timeIn";
            this.timeIn.Size = new System.Drawing.Size(89, 27);
            this.timeIn.TabIndex = 15;
            this.timeIn.Text = "Time In";
            // 
            // dateIn
            // 
            this.dateIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIn.Location = new System.Drawing.Point(20, 99);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(89, 28);
            this.dateIn.TabIndex = 14;
            this.dateIn.Text = "Date In";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Controls.Add(this.tbxTimeOut);
            this.groupBox4.Controls.Add(this.tbxDateOut);
            this.groupBox4.Controls.Add(this.tbxIdOut);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(474, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 221);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GATE OUT";
            // 
            // tbxTimeOut
            // 
            this.tbxTimeOut.Location = new System.Drawing.Point(116, 144);
            this.tbxTimeOut.Name = "tbxTimeOut";
            this.tbxTimeOut.Size = new System.Drawing.Size(263, 29);
            this.tbxTimeOut.TabIndex = 5;
            // 
            // tbxDateOut
            // 
            this.tbxDateOut.Location = new System.Drawing.Point(116, 97);
            this.tbxDateOut.Name = "tbxDateOut";
            this.tbxDateOut.Size = new System.Drawing.Size(263, 29);
            this.tbxDateOut.TabIndex = 4;
            // 
            // tbxIdOut
            // 
            this.tbxIdOut.Location = new System.Drawing.Point(116, 52);
            this.tbxIdOut.Name = "tbxIdOut";
            this.tbxIdOut.Size = new System.Drawing.Size(263, 29);
            this.tbxIdOut.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(16, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time Out";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date Out";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Out";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số xe vào trong ngày";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txNumIn
            // 
            this.txNumIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumIn.Location = new System.Drawing.Point(203, 522);
            this.txNumIn.Name = "txNumIn";
            this.txNumIn.Size = new System.Drawing.Size(68, 23);
            this.txNumIn.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Số xe trong bãi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txNumOccupied
            // 
            this.txNumOccupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumOccupied.Location = new System.Drawing.Point(423, 520);
            this.txNumOccupied.Name = "txNumOccupied";
            this.txNumOccupied.Size = new System.Drawing.Size(100, 23);
            this.txNumOccupied.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(550, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Số chỗ trống";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txNumFree
            // 
            this.txNumFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumFree.Location = new System.Drawing.Point(683, 520);
            this.txNumFree.Name = "txNumFree";
            this.txNumFree.Size = new System.Drawing.Size(100, 23);
            this.txNumFree.TabIndex = 25;
            // 
            // lbIn
            // 
            this.lbIn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIn.Location = new System.Drawing.Point(236, 392);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(187, 29);
            this.lbIn.TabIndex = 26;
            this.lbIn.Text = "XE VÀO BÃI";
            this.lbIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOut
            // 
            this.lbOut.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOut.Location = new System.Drawing.Point(474, 392);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(176, 29);
            this.lbOut.TabIndex = 27;
            this.lbOut.Text = "XE RA KHỎI BÃI";
            this.lbOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxInfo
            // 
            this.tbxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInfo.Location = new System.Drawing.Point(289, 447);
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(552, 29);
            this.tbxInfo.TabIndex = 28;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(55, 447);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(216, 29);
            this.lbInfo.TabIndex = 29;
            this.lbInfo.Text = "THÔNG TIN VÀO - RA";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(913, 591);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbxInfo);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.lbIn);
            this.Controls.Add(this.txNumFree);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txNumOccupied);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txNumIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Themes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ BÃI GIỮ XE CÔNG CỘNG";
            this.Load += new System.EventHandler(this.UART_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCom;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox tbxIdIn;
        public System.IO.Ports.SerialPort UART;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Timer tm1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxTimeIn;
        private System.Windows.Forms.TextBox tbxDateIn;
        private System.Windows.Forms.Label timeIn;
        private System.Windows.Forms.Label dateIn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxTimeOut;
        private System.Windows.Forms.TextBox tbxDateOut;
        private System.Windows.Forms.TextBox tbxIdOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txNumIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txNumOccupied;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txNumFree;
        private System.Windows.Forms.Label lbIn;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.Label lbInfo;
    }
}

