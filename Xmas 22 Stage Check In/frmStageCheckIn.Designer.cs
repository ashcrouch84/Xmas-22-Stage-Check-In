namespace Xmas_22_Stage_Check_In
{
    partial class frmCheckIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckIn));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdStartTimer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbCheckIn = new System.Windows.Forms.GroupBox();
            this.lstRef = new System.Windows.Forms.ListBox();
            this.cmdAddReference = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gbCheckIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Controls.Add(this.cmdClose);
            this.pnlLeft.Controls.Add(this.cmdStartTimer);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(166, 759);
            this.pnlLeft.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdClose.FlatAppearance.BorderSize = 5;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdClose.Location = new System.Drawing.Point(12, 682);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(141, 65);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "Close Check In";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdStartTimer
            // 
            this.cmdStartTimer.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdStartTimer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdStartTimer.FlatAppearance.BorderSize = 5;
            this.cmdStartTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdStartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStartTimer.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdStartTimer.Location = new System.Drawing.Point(12, 143);
            this.cmdStartTimer.Name = "cmdStartTimer";
            this.cmdStartTimer.Size = new System.Drawing.Size(141, 49);
            this.cmdStartTimer.TabIndex = 4;
            this.cmdStartTimer.Text = "Start Timer";
            this.cmdStartTimer.UseVisualStyleBackColor = false;
            this.cmdStartTimer.Click += new System.EventHandler(this.cmdStartTimer_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Controls.Add(this.lblInfo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(166, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1018, 104);
            this.pnlTop.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTime.Location = new System.Drawing.Point(786, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(202, 29);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Enter Reference";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblInfo.Location = new System.Drawing.Point(22, 31);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(202, 29);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Enter Reference";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbCheckIn);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlMain.Location = new System.Drawing.Point(166, 104);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1018, 655);
            this.pnlMain.TabIndex = 2;
            // 
            // gbCheckIn
            // 
            this.gbCheckIn.Controls.Add(this.lstRef);
            this.gbCheckIn.Controls.Add(this.cmdAddReference);
            this.gbCheckIn.Controls.Add(this.label3);
            this.gbCheckIn.Controls.Add(this.label4);
            this.gbCheckIn.Controls.Add(this.cmdClear);
            this.gbCheckIn.Controls.Add(this.txtRef);
            this.gbCheckIn.Location = new System.Drawing.Point(250, 84);
            this.gbCheckIn.Name = "gbCheckIn";
            this.gbCheckIn.Size = new System.Drawing.Size(546, 457);
            this.gbCheckIn.TabIndex = 7;
            this.gbCheckIn.TabStop = false;
            // 
            // lstRef
            // 
            this.lstRef.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstRef.FormattingEnabled = true;
            this.lstRef.ItemHeight = 28;
            this.lstRef.Location = new System.Drawing.Point(177, 169);
            this.lstRef.Name = "lstRef";
            this.lstRef.Size = new System.Drawing.Size(201, 228);
            this.lstRef.TabIndex = 1;
            // 
            // cmdAddReference
            // 
            this.cmdAddReference.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdAddReference.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdAddReference.FlatAppearance.BorderSize = 5;
            this.cmdAddReference.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdAddReference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddReference.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAddReference.Location = new System.Drawing.Point(323, 74);
            this.cmdAddReference.Name = "cmdAddReference";
            this.cmdAddReference.Size = new System.Drawing.Size(175, 43);
            this.cmdAddReference.TabIndex = 6;
            this.cmdAddReference.Text = "Add Reference";
            this.cmdAddReference.UseVisualStyleBackColor = false;
            this.cmdAddReference.Click += new System.EventHandler(this.cmdAddReference_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "References on Stage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Reference";
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdClear.FlatAppearance.BorderSize = 5;
            this.cmdClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClear.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdClear.Location = new System.Drawing.Point(193, 403);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(175, 43);
            this.cmdClear.TabIndex = 3;
            this.cmdClear.Text = "Clear References";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRef.Location = new System.Drawing.Point(44, 78);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(261, 36);
            this.txtRef.TabIndex = 4;
            this.txtRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRef_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 759);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckIn";
            this.Text = "Stage Check In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheckIn_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmCheckIn_Resize);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.gbCheckIn.ResumeLayout(false);
            this.gbCheckIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLeft;
        private PictureBox pictureBox1;
        private Panel pnlTop;
        private Panel pnlMain;
        private System.Windows.Forms.Timer timer1;
        private Button cmdAddReference;
        private Label label4;
        private TextBox txtRef;
        private Button cmdClear;
        private Label label3;
        private ListBox lstRef;
        private Label lblInfo;
        private System.Windows.Forms.Timer timer2;
        private Button cmdStartTimer;
        private Button cmdClose;
        private GroupBox gbCheckIn;
        private Label lblTime;
        private System.Windows.Forms.Timer timer3;
    }
}