namespace Xmas_22_Stage_Check_In
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCloseSettings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSaveInterval = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cmdPhotoInterval = new System.Windows.Forms.Button();
            this.txtPhotoInterval = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdPhotoLocation = new System.Windows.Forms.Button();
            this.txtPhotoLocation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkUse1 = new System.Windows.Forms.CheckBox();
            this.chkUse2 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdSend2 = new System.Windows.Forms.Button();
            this.txtSend2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdSend1 = new System.Windows.Forms.Button();
            this.txtSend1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdPhotoBooth = new System.Windows.Forms.Button();
            this.txtPhotoBooth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdMonitorTimer = new System.Windows.Forms.Button();
            this.txtMonitorTimer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdMonitor = new System.Windows.Forms.Button();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmdPicSize = new System.Windows.Forms.Button();
            this.txtPicSize = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.cmdCloseSettings);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 559);
            this.panel1.TabIndex = 0;
            // 
            // cmdCloseSettings
            // 
            this.cmdCloseSettings.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdCloseSettings.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdCloseSettings.FlatAppearance.BorderSize = 5;
            this.cmdCloseSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdCloseSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCloseSettings.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdCloseSettings.Location = new System.Drawing.Point(28, 477);
            this.cmdCloseSettings.Name = "cmdCloseSettings";
            this.cmdCloseSettings.Size = new System.Drawing.Size(104, 66);
            this.cmdCloseSettings.TabIndex = 10;
            this.cmdCloseSettings.Text = "Close Settings";
            this.cmdCloseSettings.UseVisualStyleBackColor = false;
            this.cmdCloseSettings.Click += new System.EventHandler(this.cmdCloseSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 559);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmdSaveInterval);
            this.tabPage1.Controls.Add(this.txtInterval);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmdBrowse);
            this.tabPage1.Controls.Add(this.txtBrowse);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stage Check In Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stage Check In Settings";
            // 
            // cmdSaveInterval
            // 
            this.cmdSaveInterval.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSaveInterval.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSaveInterval.FlatAppearance.BorderSize = 5;
            this.cmdSaveInterval.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSaveInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveInterval.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSaveInterval.Location = new System.Drawing.Point(230, 187);
            this.cmdSaveInterval.Name = "cmdSaveInterval";
            this.cmdSaveInterval.Size = new System.Drawing.Size(73, 40);
            this.cmdSaveInterval.TabIndex = 12;
            this.cmdSaveInterval.Text = "Save";
            this.cmdSaveInterval.UseVisualStyleBackColor = false;
            this.cmdSaveInterval.Click += new System.EventHandler(this.cmdSaveInterval_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInterval.Location = new System.Drawing.Point(150, 191);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(74, 29);
            this.txtInterval.TabIndex = 11;
            this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Timer Interval";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdBrowse.FlatAppearance.BorderSize = 5;
            this.cmdBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBrowse.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdBrowse.Location = new System.Drawing.Point(495, 97);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(104, 43);
            this.cmdBrowse.TabIndex = 9;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = false;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrowse.Location = new System.Drawing.Point(6, 102);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(483, 29);
            this.txtBrowse.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(144, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Show Marquee Capture Location";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cmdPhotoInterval);
            this.tabPage2.Controls.Add(this.txtPhotoInterval);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cmdPhotoLocation);
            this.tabPage2.Controls.Add(this.txtPhotoLocation);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.chkUse1);
            this.tabPage2.Controls.Add(this.chkUse2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.cmdSend2);
            this.tabPage2.Controls.Add(this.txtSend2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmdSend1);
            this.tabPage2.Controls.Add(this.txtSend1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cmdPhotoBooth);
            this.tabPage2.Controls.Add(this.txtPhotoBooth);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmdMonitorTimer);
            this.tabPage2.Controls.Add(this.txtMonitorTimer);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmdMonitor);
            this.tabPage2.Controls.Add(this.txtMonitor);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Photo Capture Settings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(342, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Photo";
            // 
            // cmdPhotoInterval
            // 
            this.cmdPhotoInterval.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdPhotoInterval.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdPhotoInterval.FlatAppearance.BorderSize = 5;
            this.cmdPhotoInterval.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdPhotoInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPhotoInterval.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPhotoInterval.Location = new System.Drawing.Point(539, 472);
            this.cmdPhotoInterval.Name = "cmdPhotoInterval";
            this.cmdPhotoInterval.Size = new System.Drawing.Size(73, 40);
            this.cmdPhotoInterval.TabIndex = 40;
            this.cmdPhotoInterval.Text = "Save";
            this.cmdPhotoInterval.UseVisualStyleBackColor = false;
            this.cmdPhotoInterval.Click += new System.EventHandler(this.cmdPhotoInterval_Click);
            // 
            // txtPhotoInterval
            // 
            this.txtPhotoInterval.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhotoInterval.Location = new System.Drawing.Point(459, 476);
            this.txtPhotoInterval.Name = "txtPhotoInterval";
            this.txtPhotoInterval.Size = new System.Drawing.Size(74, 29);
            this.txtPhotoInterval.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(316, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "Timer Interval";
            // 
            // cmdPhotoLocation
            // 
            this.cmdPhotoLocation.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdPhotoLocation.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdPhotoLocation.FlatAppearance.BorderSize = 5;
            this.cmdPhotoLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdPhotoLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPhotoLocation.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPhotoLocation.Location = new System.Drawing.Point(502, 254);
            this.cmdPhotoLocation.Name = "cmdPhotoLocation";
            this.cmdPhotoLocation.Size = new System.Drawing.Size(104, 43);
            this.cmdPhotoLocation.TabIndex = 37;
            this.cmdPhotoLocation.Text = "Browse";
            this.cmdPhotoLocation.UseVisualStyleBackColor = false;
            this.cmdPhotoLocation.Click += new System.EventHandler(this.cmdPhotoLocation_Click);
            // 
            // txtPhotoLocation
            // 
            this.txtPhotoLocation.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhotoLocation.Location = new System.Drawing.Point(13, 259);
            this.txtPhotoLocation.Name = "txtPhotoLocation";
            this.txtPhotoLocation.Size = new System.Drawing.Size(483, 29);
            this.txtPhotoLocation.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(88, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(379, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "Photo Location (Where Photos are Saved)";
            // 
            // chkUse1
            // 
            this.chkUse1.AutoSize = true;
            this.chkUse1.Location = new System.Drawing.Point(285, 303);
            this.chkUse1.Name = "chkUse1";
            this.chkUse1.Size = new System.Drawing.Size(161, 27);
            this.chkUse1.TabIndex = 34;
            this.chkUse1.Text = "Use Location 1";
            this.chkUse1.UseVisualStyleBackColor = true;
            this.chkUse1.CheckedChanged += new System.EventHandler(this.chkUse1_CheckedChanged);
            // 
            // chkUse2
            // 
            this.chkUse2.AutoSize = true;
            this.chkUse2.Location = new System.Drawing.Point(285, 383);
            this.chkUse2.Name = "chkUse2";
            this.chkUse2.Size = new System.Drawing.Size(161, 27);
            this.chkUse2.TabIndex = 33;
            this.chkUse2.Text = "Use Location 2";
            this.chkUse2.UseVisualStyleBackColor = true;
            this.chkUse2.CheckedChanged += new System.EventHandler(this.chkUse2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(39, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Monitor";
            // 
            // cmdSend2
            // 
            this.cmdSend2.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSend2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSend2.FlatAppearance.BorderSize = 5;
            this.cmdSend2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSend2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSend2.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSend2.Location = new System.Drawing.Point(502, 405);
            this.cmdSend2.Name = "cmdSend2";
            this.cmdSend2.Size = new System.Drawing.Size(104, 43);
            this.cmdSend2.TabIndex = 31;
            this.cmdSend2.Text = "Browse";
            this.cmdSend2.UseVisualStyleBackColor = false;
            this.cmdSend2.Click += new System.EventHandler(this.cmdSend2_Click);
            // 
            // txtSend2
            // 
            this.txtSend2.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSend2.Location = new System.Drawing.Point(13, 410);
            this.txtSend2.Name = "txtSend2";
            this.txtSend2.Size = new System.Drawing.Size(483, 29);
            this.txtSend2.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(110, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Send Location 2";
            // 
            // cmdSend1
            // 
            this.cmdSend1.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSend1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSend1.FlatAppearance.BorderSize = 5;
            this.cmdSend1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSend1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSend1.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSend1.Location = new System.Drawing.Point(502, 325);
            this.cmdSend1.Name = "cmdSend1";
            this.cmdSend1.Size = new System.Drawing.Size(104, 43);
            this.cmdSend1.TabIndex = 28;
            this.cmdSend1.Text = "Browse";
            this.cmdSend1.UseVisualStyleBackColor = false;
            this.cmdSend1.Click += new System.EventHandler(this.cmdSend1_Click);
            // 
            // txtSend1
            // 
            this.txtSend1.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSend1.Location = new System.Drawing.Point(13, 330);
            this.txtSend1.Name = "txtSend1";
            this.txtSend1.Size = new System.Drawing.Size(483, 29);
            this.txtSend1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(110, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Send Location 1";
            // 
            // cmdPhotoBooth
            // 
            this.cmdPhotoBooth.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdPhotoBooth.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdPhotoBooth.FlatAppearance.BorderSize = 5;
            this.cmdPhotoBooth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdPhotoBooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPhotoBooth.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPhotoBooth.Location = new System.Drawing.Point(503, 179);
            this.cmdPhotoBooth.Name = "cmdPhotoBooth";
            this.cmdPhotoBooth.Size = new System.Drawing.Size(104, 43);
            this.cmdPhotoBooth.TabIndex = 25;
            this.cmdPhotoBooth.Text = "Browse";
            this.cmdPhotoBooth.UseVisualStyleBackColor = false;
            this.cmdPhotoBooth.Click += new System.EventHandler(this.cmdPhotoBooth_Click);
            // 
            // txtPhotoBooth
            // 
            this.txtPhotoBooth.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhotoBooth.Location = new System.Drawing.Point(14, 184);
            this.txtPhotoBooth.Name = "txtPhotoBooth";
            this.txtPhotoBooth.Size = new System.Drawing.Size(483, 29);
            this.txtPhotoBooth.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(198, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Photobooth Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(110, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(386, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Stage Photo Capture Settings";
            // 
            // cmdMonitorTimer
            // 
            this.cmdMonitorTimer.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdMonitorTimer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdMonitorTimer.FlatAppearance.BorderSize = 5;
            this.cmdMonitorTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdMonitorTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMonitorTimer.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdMonitorTimer.Location = new System.Drawing.Point(237, 474);
            this.cmdMonitorTimer.Name = "cmdMonitorTimer";
            this.cmdMonitorTimer.Size = new System.Drawing.Size(73, 40);
            this.cmdMonitorTimer.TabIndex = 20;
            this.cmdMonitorTimer.Text = "Save";
            this.cmdMonitorTimer.UseVisualStyleBackColor = false;
            this.cmdMonitorTimer.Click += new System.EventHandler(this.cmdMonitorTimer_Click);
            // 
            // txtMonitorTimer
            // 
            this.txtMonitorTimer.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonitorTimer.Location = new System.Drawing.Point(157, 478);
            this.txtMonitorTimer.Name = "txtMonitorTimer";
            this.txtMonitorTimer.Size = new System.Drawing.Size(74, 29);
            this.txtMonitorTimer.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Timer Interval";
            // 
            // cmdMonitor
            // 
            this.cmdMonitor.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdMonitor.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdMonitor.FlatAppearance.BorderSize = 5;
            this.cmdMonitor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMonitor.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdMonitor.Location = new System.Drawing.Point(502, 99);
            this.cmdMonitor.Name = "cmdMonitor";
            this.cmdMonitor.Size = new System.Drawing.Size(104, 43);
            this.cmdMonitor.TabIndex = 17;
            this.cmdMonitor.Text = "Browse";
            this.cmdMonitor.UseVisualStyleBackColor = false;
            this.cmdMonitor.Click += new System.EventHandler(this.cmdMonitor_Click);
            // 
            // txtMonitor
            // 
            this.txtMonitor.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonitor.Location = new System.Drawing.Point(13, 104);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(483, 29);
            this.txtMonitor.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(135, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Monitor Location for Stage Check In";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.cmdPicSize);
            this.tabPage3.Controls.Add(this.txtPicSize);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(618, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Photo Size";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmdPicSize
            // 
            this.cmdPicSize.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdPicSize.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdPicSize.FlatAppearance.BorderSize = 5;
            this.cmdPicSize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdPicSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPicSize.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPicSize.Location = new System.Drawing.Point(347, 123);
            this.cmdPicSize.Name = "cmdPicSize";
            this.cmdPicSize.Size = new System.Drawing.Size(73, 40);
            this.cmdPicSize.TabIndex = 43;
            this.cmdPicSize.Text = "Save";
            this.cmdPicSize.UseVisualStyleBackColor = false;
            this.cmdPicSize.Click += new System.EventHandler(this.cmdPicSize_Click);
            // 
            // txtPicSize
            // 
            this.txtPicSize.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPicSize.Location = new System.Drawing.Point(235, 130);
            this.txtPicSize.Name = "txtPicSize";
            this.txtPicSize.Size = new System.Drawing.Size(74, 29);
            this.txtPicSize.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(18, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 23);
            this.label14.TabIndex = 41;
            this.label14.Text = "Photo Size in Pixels";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(102, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(414, 29);
            this.label15.TabIndex = 44;
            this.label15.Text = "Size of Photos on Stage Capture";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Stage Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button cmdSaveInterval;
        private TextBox txtInterval;
        private Label label2;
        private Button cmdBrowse;
        private TextBox txtBrowse;
        private Label label1;
        private TabPage tabPage2;
        private Button cmdCloseSettings;
        private PictureBox pictureBox1;
        private Label label3;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox chkUse1;
        private CheckBox chkUse2;
        private Label label10;
        private Button cmdSend2;
        private TextBox txtSend2;
        private Label label9;
        private Button cmdSend1;
        private TextBox txtSend1;
        private Label label8;
        private Button cmdPhotoBooth;
        private TextBox txtPhotoBooth;
        private Label label7;
        private Label label4;
        private Button cmdMonitorTimer;
        private TextBox txtMonitorTimer;
        private Label label5;
        private Button cmdMonitor;
        private TextBox txtMonitor;
        private Label label6;
        private Button cmdPhotoLocation;
        private TextBox txtPhotoLocation;
        private Label label11;
        private Label label12;
        private Button cmdPhotoInterval;
        private TextBox txtPhotoInterval;
        private Label label13;
        private TabPage tabPage3;
        private Label label15;
        private Button cmdPicSize;
        private TextBox txtPicSize;
        private Label label14;
    }
}