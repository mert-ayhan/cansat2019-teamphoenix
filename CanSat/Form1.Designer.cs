namespace CanSat
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelPacketCount = new System.Windows.Forms.Label();
            this.labelPacketCountHeader = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelMissionTime = new System.Windows.Forms.Label();
            this.labelMissionTimeHeader = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTeamID = new System.Windows.Forms.Label();
            this.labelTeamIDHeader = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelSoftwareState = new System.Windows.Forms.Label();
            this.labelSoftwareStateHeader = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelBladeSpinRate = new System.Windows.Forms.Label();
            this.labelBladeSpinRateHeader = new System.Windows.Forms.Label();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.labelVoltageHeader = new System.Windows.Forms.Label();
            this.labelRollHeader = new System.Windows.Forms.Label();
            this.labelTemperatureHeader = new System.Windows.Forms.Label();
            this.labelPressureHeader = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.labelAltitudeHeader = new System.Windows.Forms.Label();
            this.labelGeneralInformation = new System.Windows.Forms.Label();
            this.labelPitchHeader = new System.Windows.Forms.Label();
            this.labelSignalRate = new System.Windows.Forms.Label();
            this.labelSignalRateHeader = new System.Windows.Forms.Label();
            this.labelBatteryStatus = new System.Windows.Forms.Label();
            this.labelBatteryStatusHeader = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.labelGPSSats = new System.Windows.Forms.Label();
            this.labelGPSSatsHeader = new System.Windows.Forms.Label();
            this.labelGPSAltitude = new System.Windows.Forms.Label();
            this.labelGPSAltitudeHeader = new System.Windows.Forms.Label();
            this.labelGPSLongitude = new System.Windows.Forms.Label();
            this.labelGPSLongitudeHeader = new System.Windows.Forms.Label();
            this.labelGPSLatitude = new System.Windows.Forms.Label();
            this.labelGPSLatitudeHeader = new System.Windows.Forms.Label();
            this.labelGPSTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGPSTimeHeader = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.labelCurrentSpeedHeader = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelCurrentTimeHeader = new System.Windows.Forms.Label();
            this.labelCurrentStage = new System.Windows.Forms.Label();
            this.labelCurrentSpeed = new System.Windows.Forms.Label();
            this.labelCurrentStageHeader = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonTestMode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.buttonDisconnect);
            this.panel11.Controls.Add(this.buttonConnect);
            this.panel11.Controls.Add(this.buttonRefresh);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 209);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(150, 100);
            this.panel11.TabIndex = 12;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDisconnect.FlatAppearance.BorderSize = 0;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisconnect.Image")));
            this.buttonDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDisconnect.Location = new System.Drawing.Point(0, 63);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(148, 36);
            this.buttonDisconnect.TabIndex = 32;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Image = ((System.Drawing.Image)(resources.GetObject("buttonConnect.Image")));
            this.buttonConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConnect.Location = new System.Drawing.Point(0, 33);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(148, 30);
            this.buttonConnect.TabIndex = 31;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(0, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(148, 33);
            this.buttonRefresh.TabIndex = 30;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.labelPacketCount);
            this.panel7.Controls.Add(this.labelPacketCountHeader);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 305);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(150, 95);
            this.panel7.TabIndex = 11;
            // 
            // labelPacketCount
            // 
            this.labelPacketCount.AutoSize = true;
            this.labelPacketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPacketCount.Location = new System.Drawing.Point(73, 55);
            this.labelPacketCount.Name = "labelPacketCount";
            this.labelPacketCount.Size = new System.Drawing.Size(28, 15);
            this.labelPacketCount.TabIndex = 6;
            this.labelPacketCount.Text = "438";
            // 
            // labelPacketCountHeader
            // 
            this.labelPacketCountHeader.AutoSize = true;
            this.labelPacketCountHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPacketCountHeader.Location = new System.Drawing.Point(73, 23);
            this.labelPacketCountHeader.Name = "labelPacketCountHeader";
            this.labelPacketCountHeader.Size = new System.Drawing.Size(56, 32);
            this.labelPacketCountHeader.TabIndex = 6;
            this.labelPacketCountHeader.Text = "Packet\r\nCount";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.labelMissionTime);
            this.panel6.Controls.Add(this.labelMissionTimeHeader);
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 400);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 100);
            this.panel6.TabIndex = 10;
            // 
            // labelMissionTime
            // 
            this.labelMissionTime.AutoSize = true;
            this.labelMissionTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMissionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMissionTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.labelMissionTime.Location = new System.Drawing.Point(71, 60);
            this.labelMissionTime.Name = "labelMissionTime";
            this.labelMissionTime.Size = new System.Drawing.Size(55, 15);
            this.labelMissionTime.TabIndex = 6;
            this.labelMissionTime.Text = "00:07:16";
            // 
            // labelMissionTimeHeader
            // 
            this.labelMissionTimeHeader.AutoSize = true;
            this.labelMissionTimeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMissionTimeHeader.Location = new System.Drawing.Point(71, 24);
            this.labelMissionTimeHeader.Name = "labelMissionTimeHeader";
            this.labelMissionTimeHeader.Size = new System.Drawing.Size(61, 32);
            this.labelMissionTimeHeader.TabIndex = 6;
            this.labelMissionTimeHeader.Text = "Mission\r\nTime";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelTeamID);
            this.panel4.Controls.Add(this.labelTeamIDHeader);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 100);
            this.panel4.TabIndex = 1;
            // 
            // labelTeamID
            // 
            this.labelTeamID.AutoSize = true;
            this.labelTeamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTeamID.Location = new System.Drawing.Point(71, 58);
            this.labelTeamID.Name = "labelTeamID";
            this.labelTeamID.Size = new System.Drawing.Size(43, 16);
            this.labelTeamID.TabIndex = 5;
            this.labelTeamID.Text = "#2548";
            // 
            // labelTeamIDHeader
            // 
            this.labelTeamIDHeader.AutoSize = true;
            this.labelTeamIDHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTeamIDHeader.Location = new System.Drawing.Point(71, 27);
            this.labelTeamIDHeader.Name = "labelTeamIDHeader";
            this.labelTeamIDHeader.Size = new System.Drawing.Size(66, 18);
            this.labelTeamIDHeader.TabIndex = 4;
            this.labelTeamIDHeader.Text = "TeamID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 109);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelSoftwareState);
            this.panel5.Controls.Add(this.labelSoftwareStateHeader);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 500);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 100);
            this.panel5.TabIndex = 9;
            // 
            // labelSoftwareState
            // 
            this.labelSoftwareState.AutoSize = true;
            this.labelSoftwareState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoftwareState.ForeColor = System.Drawing.Color.Green;
            this.labelSoftwareState.Location = new System.Drawing.Point(71, 59);
            this.labelSoftwareState.Name = "labelSoftwareState";
            this.labelSoftwareState.Size = new System.Drawing.Size(38, 15);
            this.labelSoftwareState.TabIndex = 8;
            this.labelSoftwareState.Text = "Active";
            // 
            // labelSoftwareStateHeader
            // 
            this.labelSoftwareStateHeader.AutoSize = true;
            this.labelSoftwareStateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoftwareStateHeader.Location = new System.Drawing.Point(71, 27);
            this.labelSoftwareStateHeader.Name = "labelSoftwareStateHeader";
            this.labelSoftwareStateHeader.Size = new System.Drawing.Size(68, 32);
            this.labelSoftwareStateHeader.TabIndex = 7;
            this.labelSoftwareStateHeader.Text = "Software\r\nState";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(598, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 42);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(550, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(42, 42);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Controls.Add(this.minimizeButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(150, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 60);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.labelBladeSpinRate);
            this.panel8.Controls.Add(this.labelBladeSpinRateHeader);
            this.panel8.Controls.Add(this.labelVoltage);
            this.panel8.Controls.Add(this.labelRoll);
            this.panel8.Controls.Add(this.labelTemperature);
            this.panel8.Controls.Add(this.labelPressure);
            this.panel8.Controls.Add(this.labelAltitude);
            this.panel8.Controls.Add(this.labelVoltageHeader);
            this.panel8.Controls.Add(this.labelRollHeader);
            this.panel8.Controls.Add(this.labelTemperatureHeader);
            this.panel8.Controls.Add(this.labelPressureHeader);
            this.panel8.Controls.Add(this.labelPitch);
            this.panel8.Controls.Add(this.labelAltitudeHeader);
            this.panel8.Controls.Add(this.labelGeneralInformation);
            this.panel8.Controls.Add(this.labelPitchHeader);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(150, 60);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(216, 540);
            this.panel8.TabIndex = 4;
            // 
            // labelBladeSpinRate
            // 
            this.labelBladeSpinRate.AutoSize = true;
            this.labelBladeSpinRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBladeSpinRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelBladeSpinRate.Location = new System.Drawing.Point(152, 423);
            this.labelBladeSpinRate.Name = "labelBladeSpinRate";
            this.labelBladeSpinRate.Size = new System.Drawing.Size(55, 16);
            this.labelBladeSpinRate.TabIndex = 37;
            this.labelBladeSpinRate.Text = "120 rpm";
            // 
            // labelBladeSpinRateHeader
            // 
            this.labelBladeSpinRateHeader.AutoSize = true;
            this.labelBladeSpinRateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBladeSpinRateHeader.Location = new System.Drawing.Point(7, 419);
            this.labelBladeSpinRateHeader.Name = "labelBladeSpinRateHeader";
            this.labelBladeSpinRateHeader.Size = new System.Drawing.Size(140, 20);
            this.labelBladeSpinRateHeader.TabIndex = 36;
            this.labelBladeSpinRateHeader.Text = "Blade Spin Rate";
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVoltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelVoltage.Location = new System.Drawing.Point(148, 265);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(37, 16);
            this.labelVoltage.TabIndex = 8;
            this.labelVoltage.Text = "3.3 V";
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelRoll.Location = new System.Drawing.Point(152, 368);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(22, 16);
            this.labelRoll.TabIndex = 33;
            this.labelRoll.Text = "14";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelTemperature.Location = new System.Drawing.Point(148, 209);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(34, 16);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "34 C";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelPressure.Location = new System.Drawing.Point(148, 155);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(44, 16);
            this.labelPressure.TabIndex = 6;
            this.labelPressure.Text = "11.5 P";
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAltitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelAltitude.Location = new System.Drawing.Point(148, 101);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(40, 16);
            this.labelAltitude.TabIndex = 5;
            this.labelAltitude.Text = "532m";
            // 
            // labelVoltageHeader
            // 
            this.labelVoltageHeader.AutoSize = true;
            this.labelVoltageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVoltageHeader.Location = new System.Drawing.Point(7, 262);
            this.labelVoltageHeader.Name = "labelVoltageHeader";
            this.labelVoltageHeader.Size = new System.Drawing.Size(71, 20);
            this.labelVoltageHeader.TabIndex = 4;
            this.labelVoltageHeader.Text = "Voltage";
            // 
            // labelRollHeader
            // 
            this.labelRollHeader.AutoSize = true;
            this.labelRollHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRollHeader.Location = new System.Drawing.Point(7, 365);
            this.labelRollHeader.Name = "labelRollHeader";
            this.labelRollHeader.Size = new System.Drawing.Size(40, 20);
            this.labelRollHeader.TabIndex = 32;
            this.labelRollHeader.Text = "Roll";
            // 
            // labelTemperatureHeader
            // 
            this.labelTemperatureHeader.AutoSize = true;
            this.labelTemperatureHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTemperatureHeader.Location = new System.Drawing.Point(5, 206);
            this.labelTemperatureHeader.Name = "labelTemperatureHeader";
            this.labelTemperatureHeader.Size = new System.Drawing.Size(111, 20);
            this.labelTemperatureHeader.TabIndex = 3;
            this.labelTemperatureHeader.Text = "Temperature";
            // 
            // labelPressureHeader
            // 
            this.labelPressureHeader.AutoSize = true;
            this.labelPressureHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPressureHeader.Location = new System.Drawing.Point(5, 152);
            this.labelPressureHeader.Name = "labelPressureHeader";
            this.labelPressureHeader.Size = new System.Drawing.Size(80, 20);
            this.labelPressureHeader.TabIndex = 2;
            this.labelPressureHeader.Text = "Pressure";
            // 
            // labelPitch
            // 
            this.labelPitch.AutoSize = true;
            this.labelPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelPitch.Location = new System.Drawing.Point(152, 317);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(22, 16);
            this.labelPitch.TabIndex = 31;
            this.labelPitch.Text = "25";
            // 
            // labelAltitudeHeader
            // 
            this.labelAltitudeHeader.AutoSize = true;
            this.labelAltitudeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAltitudeHeader.Location = new System.Drawing.Point(7, 98);
            this.labelAltitudeHeader.Name = "labelAltitudeHeader";
            this.labelAltitudeHeader.Size = new System.Drawing.Size(71, 20);
            this.labelAltitudeHeader.TabIndex = 1;
            this.labelAltitudeHeader.Text = "Altitude";
            // 
            // labelGeneralInformation
            // 
            this.labelGeneralInformation.AutoSize = true;
            this.labelGeneralInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGeneralInformation.Location = new System.Drawing.Point(15, 48);
            this.labelGeneralInformation.Name = "labelGeneralInformation";
            this.labelGeneralInformation.Size = new System.Drawing.Size(193, 24);
            this.labelGeneralInformation.TabIndex = 0;
            this.labelGeneralInformation.Text = "General Information";
            // 
            // labelPitchHeader
            // 
            this.labelPitchHeader.AutoSize = true;
            this.labelPitchHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPitchHeader.Location = new System.Drawing.Point(7, 313);
            this.labelPitchHeader.Name = "labelPitchHeader";
            this.labelPitchHeader.Size = new System.Drawing.Size(49, 20);
            this.labelPitchHeader.TabIndex = 30;
            this.labelPitchHeader.Text = "Pitch";
            // 
            // labelSignalRate
            // 
            this.labelSignalRate.AutoSize = true;
            this.labelSignalRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSignalRate.ForeColor = System.Drawing.Color.Green;
            this.labelSignalRate.Location = new System.Drawing.Point(166, 311);
            this.labelSignalRate.Name = "labelSignalRate";
            this.labelSignalRate.Size = new System.Drawing.Size(37, 16);
            this.labelSignalRate.TabIndex = 12;
            this.labelSignalRate.Text = "% 76";
            // 
            // labelSignalRateHeader
            // 
            this.labelSignalRateHeader.AutoSize = true;
            this.labelSignalRateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSignalRateHeader.Location = new System.Drawing.Point(9, 308);
            this.labelSignalRateHeader.Name = "labelSignalRateHeader";
            this.labelSignalRateHeader.Size = new System.Drawing.Size(103, 20);
            this.labelSignalRateHeader.TabIndex = 11;
            this.labelSignalRateHeader.Text = "Signal Rate";
            // 
            // labelBatteryStatus
            // 
            this.labelBatteryStatus.AutoSize = true;
            this.labelBatteryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBatteryStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.labelBatteryStatus.Location = new System.Drawing.Point(166, 263);
            this.labelBatteryStatus.Name = "labelBatteryStatus";
            this.labelBatteryStatus.Size = new System.Drawing.Size(37, 16);
            this.labelBatteryStatus.TabIndex = 10;
            this.labelBatteryStatus.Text = "% 59";
            // 
            // labelBatteryStatusHeader
            // 
            this.labelBatteryStatusHeader.AutoSize = true;
            this.labelBatteryStatusHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBatteryStatusHeader.Location = new System.Drawing.Point(9, 260);
            this.labelBatteryStatusHeader.Name = "labelBatteryStatusHeader";
            this.labelBatteryStatusHeader.Size = new System.Drawing.Size(125, 20);
            this.labelBatteryStatusHeader.TabIndex = 9;
            this.labelBatteryStatusHeader.Text = "Battery Status";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.gMapControl1);
            this.panel9.Controls.Add(this.labelGPSSats);
            this.panel9.Controls.Add(this.labelGPSSatsHeader);
            this.panel9.Controls.Add(this.labelGPSAltitude);
            this.panel9.Controls.Add(this.labelGPSAltitudeHeader);
            this.panel9.Controls.Add(this.labelGPSLongitude);
            this.panel9.Controls.Add(this.labelGPSLongitudeHeader);
            this.panel9.Controls.Add(this.labelGPSLatitude);
            this.panel9.Controls.Add(this.labelGPSLatitudeHeader);
            this.panel9.Controls.Add(this.labelGPSTime);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.labelGPSTimeHeader);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(366, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 540);
            this.panel9.TabIndex = 5;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 388);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 100;
            this.gMapControl1.MinZoom = 5;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(216, 150);
            this.gMapControl1.TabIndex = 23;
            this.gMapControl1.Zoom = 8D;
            // 
            // labelGPSSats
            // 
            this.labelGPSSats.AutoSize = true;
            this.labelGPSSats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSSats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelGPSSats.Location = new System.Drawing.Point(176, 317);
            this.labelGPSSats.Name = "labelGPSSats";
            this.labelGPSSats.Size = new System.Drawing.Size(15, 16);
            this.labelGPSSats.TabIndex = 22;
            this.labelGPSSats.Text = "3";
            // 
            // labelGPSSatsHeader
            // 
            this.labelGPSSatsHeader.AutoSize = true;
            this.labelGPSSatsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSSatsHeader.Location = new System.Drawing.Point(9, 314);
            this.labelGPSSatsHeader.Name = "labelGPSSatsHeader";
            this.labelGPSSatsHeader.Size = new System.Drawing.Size(88, 20);
            this.labelGPSSatsHeader.TabIndex = 21;
            this.labelGPSSatsHeader.Text = "GPS Sats";
            // 
            // labelGPSAltitude
            // 
            this.labelGPSAltitude.AutoSize = true;
            this.labelGPSAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSAltitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelGPSAltitude.Location = new System.Drawing.Point(162, 264);
            this.labelGPSAltitude.Name = "labelGPSAltitude";
            this.labelGPSAltitude.Size = new System.Drawing.Size(43, 16);
            this.labelGPSAltitude.TabIndex = 20;
            this.labelGPSAltitude.Text = "480 m";
            // 
            // labelGPSAltitudeHeader
            // 
            this.labelGPSAltitudeHeader.AutoSize = true;
            this.labelGPSAltitudeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSAltitudeHeader.Location = new System.Drawing.Point(9, 262);
            this.labelGPSAltitudeHeader.Name = "labelGPSAltitudeHeader";
            this.labelGPSAltitudeHeader.Size = new System.Drawing.Size(113, 20);
            this.labelGPSAltitudeHeader.TabIndex = 19;
            this.labelGPSAltitudeHeader.Text = "GPS Altitude";
            // 
            // labelGPSLongitude
            // 
            this.labelGPSLongitude.AutoSize = true;
            this.labelGPSLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSLongitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelGPSLongitude.Location = new System.Drawing.Point(151, 209);
            this.labelGPSLongitude.Name = "labelGPSLongitude";
            this.labelGPSLongitude.Size = new System.Drawing.Size(57, 16);
            this.labelGPSLongitude.TabIndex = 18;
            this.labelGPSLongitude.Text = "-92.1415";
            // 
            // labelGPSLongitudeHeader
            // 
            this.labelGPSLongitudeHeader.AutoSize = true;
            this.labelGPSLongitudeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSLongitudeHeader.Location = new System.Drawing.Point(9, 206);
            this.labelGPSLongitudeHeader.Name = "labelGPSLongitudeHeader";
            this.labelGPSLongitudeHeader.Size = new System.Drawing.Size(131, 20);
            this.labelGPSLongitudeHeader.TabIndex = 17;
            this.labelGPSLongitudeHeader.Text = "GPS Longitude";
            // 
            // labelGPSLatitude
            // 
            this.labelGPSLatitude.AutoSize = true;
            this.labelGPSLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSLatitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelGPSLatitude.Location = new System.Drawing.Point(154, 154);
            this.labelGPSLatitude.Name = "labelGPSLatitude";
            this.labelGPSLatitude.Size = new System.Drawing.Size(53, 16);
            this.labelGPSLatitude.TabIndex = 16;
            this.labelGPSLatitude.Text = "25.1245";
            // 
            // labelGPSLatitudeHeader
            // 
            this.labelGPSLatitudeHeader.AutoSize = true;
            this.labelGPSLatitudeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSLatitudeHeader.Location = new System.Drawing.Point(9, 152);
            this.labelGPSLatitudeHeader.Name = "labelGPSLatitudeHeader";
            this.labelGPSLatitudeHeader.Size = new System.Drawing.Size(117, 20);
            this.labelGPSLatitudeHeader.TabIndex = 15;
            this.labelGPSLatitudeHeader.Text = "GPS Latitude";
            // 
            // labelGPSTime
            // 
            this.labelGPSTime.AutoSize = true;
            this.labelGPSTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.labelGPSTime.Location = new System.Drawing.Point(150, 100);
            this.labelGPSTime.Name = "labelGPSTime";
            this.labelGPSTime.Size = new System.Drawing.Size(56, 16);
            this.labelGPSTime.TabIndex = 14;
            this.labelGPSTime.Text = "00:05:03";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "GPS Information";
            // 
            // labelGPSTimeHeader
            // 
            this.labelGPSTimeHeader.AutoSize = true;
            this.labelGPSTimeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGPSTimeHeader.Location = new System.Drawing.Point(9, 97);
            this.labelGPSTimeHeader.Name = "labelGPSTimeHeader";
            this.labelGPSTimeHeader.Size = new System.Drawing.Size(89, 20);
            this.labelGPSTimeHeader.TabIndex = 13;
            this.labelGPSTimeHeader.Text = "GPS Time";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.buttonTestMode);
            this.panel10.Controls.Add(this.comboBoxComPort);
            this.panel10.Controls.Add(this.stopButton);
            this.panel10.Controls.Add(this.startButton);
            this.panel10.Controls.Add(this.labelSignalRate);
            this.panel10.Controls.Add(this.labelSignalRateHeader);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Controls.Add(this.labelBatteryStatus);
            this.panel10.Controls.Add(this.labelBatteryStatusHeader);
            this.panel10.Controls.Add(this.labelCurrentSpeedHeader);
            this.panel10.Controls.Add(this.labelCurrentTime);
            this.panel10.Controls.Add(this.labelCurrentTimeHeader);
            this.panel10.Controls.Add(this.labelCurrentStage);
            this.panel10.Controls.Add(this.labelCurrentSpeed);
            this.panel10.Controls.Add(this.labelCurrentStageHeader);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(584, 60);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(216, 540);
            this.panel10.TabIndex = 6;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxComPort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxComPort.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(0, 430);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(214, 28);
            this.comboBoxComPort.TabIndex = 32;
            this.comboBoxComPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxComPort_SelectedIndexChanged);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.stopButton.Location = new System.Drawing.Point(0, 458);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(214, 40);
            this.stopButton.TabIndex = 31;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.startButton.Location = new System.Drawing.Point(0, 498);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(214, 40);
            this.startButton.TabIndex = 30;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(25, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 24);
            this.label16.TabIndex = 23;
            this.label16.Text = "Other Information";
            // 
            // labelCurrentSpeedHeader
            // 
            this.labelCurrentSpeedHeader.AutoSize = true;
            this.labelCurrentSpeedHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentSpeedHeader.Location = new System.Drawing.Point(9, 97);
            this.labelCurrentSpeedHeader.Name = "labelCurrentSpeedHeader";
            this.labelCurrentSpeedHeader.Size = new System.Drawing.Size(126, 20);
            this.labelCurrentSpeedHeader.TabIndex = 24;
            this.labelCurrentSpeedHeader.Text = "Current Speed";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.labelCurrentTime.Location = new System.Drawing.Point(150, 153);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(56, 16);
            this.labelCurrentTime.TabIndex = 25;
            this.labelCurrentTime.Text = "14:51:03";
            // 
            // labelCurrentTimeHeader
            // 
            this.labelCurrentTimeHeader.AutoSize = true;
            this.labelCurrentTimeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentTimeHeader.Location = new System.Drawing.Point(9, 152);
            this.labelCurrentTimeHeader.Name = "labelCurrentTimeHeader";
            this.labelCurrentTimeHeader.Size = new System.Drawing.Size(112, 20);
            this.labelCurrentTimeHeader.TabIndex = 26;
            this.labelCurrentTimeHeader.Text = "Current Time";
            // 
            // labelCurrentStage
            // 
            this.labelCurrentStage.AutoSize = true;
            this.labelCurrentStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentStage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelCurrentStage.Location = new System.Drawing.Point(166, 210);
            this.labelCurrentStage.Name = "labelCurrentStage";
            this.labelCurrentStage.Size = new System.Drawing.Size(37, 16);
            this.labelCurrentStage.TabIndex = 29;
            this.labelCurrentStage.Text = "% 44";
            // 
            // labelCurrentSpeed
            // 
            this.labelCurrentSpeed.AutoSize = true;
            this.labelCurrentSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(219)))), ((int)(((byte)(244)))));
            this.labelCurrentSpeed.Location = new System.Drawing.Point(158, 100);
            this.labelCurrentSpeed.Name = "labelCurrentSpeed";
            this.labelCurrentSpeed.Size = new System.Drawing.Size(47, 16);
            this.labelCurrentSpeed.TabIndex = 27;
            this.labelCurrentSpeed.Text = "30 m/s";
            // 
            // labelCurrentStageHeader
            // 
            this.labelCurrentStageHeader.AutoSize = true;
            this.labelCurrentStageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCurrentStageHeader.Location = new System.Drawing.Point(9, 206);
            this.labelCurrentStageHeader.Name = "labelCurrentStageHeader";
            this.labelCurrentStageHeader.Size = new System.Drawing.Size(122, 20);
            this.labelCurrentStageHeader.TabIndex = 28;
            this.labelCurrentStageHeader.Text = "Current Stage";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // buttonTestMode
            // 
            this.buttonTestMode.FlatAppearance.BorderSize = 0;
            this.buttonTestMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestMode.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonTestMode.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTestMode.Location = new System.Drawing.Point(0, 393);
            this.buttonTestMode.Name = "buttonTestMode";
            this.buttonTestMode.Size = new System.Drawing.Size(214, 23);
            this.buttonTestMode.TabIndex = 33;
            this.buttonTestMode.Text = "Test Mode OFF";
            this.buttonTestMode.UseVisualStyleBackColor = true;
            this.buttonTestMode.Click += new System.EventHandler(this.ButtonTestMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelPacketCount;
        private System.Windows.Forms.Label labelPacketCountHeader;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelMissionTime;
        private System.Windows.Forms.Label labelMissionTimeHeader;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTeamID;
        private System.Windows.Forms.Label labelTeamIDHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelSoftwareState;
        private System.Windows.Forms.Label labelSoftwareStateHeader;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label labelSignalRate;
        private System.Windows.Forms.Label labelSignalRateHeader;
        private System.Windows.Forms.Label labelBatteryStatus;
        private System.Windows.Forms.Label labelBatteryStatusHeader;
        private System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.Label labelVoltageHeader;
        private System.Windows.Forms.Label labelTemperatureHeader;
        private System.Windows.Forms.Label labelPressureHeader;
        private System.Windows.Forms.Label labelAltitudeHeader;
        private System.Windows.Forms.Label labelGeneralInformation;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label labelGPSSats;
        private System.Windows.Forms.Label labelGPSSatsHeader;
        private System.Windows.Forms.Label labelGPSAltitude;
        private System.Windows.Forms.Label labelGPSAltitudeHeader;
        private System.Windows.Forms.Label labelGPSLongitude;
        private System.Windows.Forms.Label labelGPSLongitudeHeader;
        private System.Windows.Forms.Label labelGPSLatitude;
        private System.Windows.Forms.Label labelGPSLatitudeHeader;
        private System.Windows.Forms.Label labelGPSTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGPSTimeHeader;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label labelRollHeader;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.Label labelPitchHeader;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelCurrentSpeedHeader;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelCurrentTimeHeader;
        private System.Windows.Forms.Label labelCurrentStage;
        private System.Windows.Forms.Label labelCurrentSpeed;
        private System.Windows.Forms.Label labelCurrentStageHeader;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelBladeSpinRate;
        private System.Windows.Forms.Label labelBladeSpinRateHeader;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button buttonTestMode;
    }
}

