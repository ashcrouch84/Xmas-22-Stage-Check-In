namespace Xmas_22_Stage_Check_In
{
    partial class frmStagePhotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStagePhotos));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdStartTimer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBigPic = new System.Windows.Forms.Panel();
            this.cmdClosePhoto = new System.Windows.Forms.Button();
            this.picSelected1 = new System.Windows.Forms.PictureBox();
            this.cmdDelete1 = new System.Windows.Forms.Button();
            this.lblLocation1 = new System.Windows.Forms.Label();
            this.gbSelected = new System.Windows.Forms.GroupBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.picSelected = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmdSend = new System.Windows.Forms.Button();
            this.lblTaken = new System.Windows.Forms.Label();
            this.pnlPictures = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRef = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cmdEnlarge = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlBigPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected1)).BeginInit();
            this.gbSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).BeginInit();
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
            this.pnlLeft.Size = new System.Drawing.Size(161, 759);
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
            this.cmdClose.Location = new System.Drawing.Point(12, 686);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(141, 65);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Close Photos";
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
            this.cmdStartTimer.Location = new System.Drawing.Point(12, 147);
            this.cmdStartTimer.Name = "cmdStartTimer";
            this.cmdStartTimer.Size = new System.Drawing.Size(141, 49);
            this.cmdStartTimer.TabIndex = 6;
            this.cmdStartTimer.Text = "Start Timer";
            this.cmdStartTimer.UseVisualStyleBackColor = false;
            this.cmdStartTimer.Click += new System.EventHandler(this.cmdStartTimer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(161, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1023, 50);
            this.pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century", 18.33962F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(284, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 33);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Stage Photos";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTime.Location = new System.Drawing.Point(803, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(202, 29);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Enter Reference";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.Controls.Add(this.pnlBigPic);
            this.pnlMain.Controls.Add(this.gbSelected);
            this.pnlMain.Controls.Add(this.cmdSend);
            this.pnlMain.Controls.Add(this.lblTaken);
            this.pnlMain.Controls.Add(this.pnlPictures);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lstRef);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(161, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1023, 709);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlBigPic
            // 
            this.pnlBigPic.Controls.Add(this.cmdClosePhoto);
            this.pnlBigPic.Controls.Add(this.picSelected1);
            this.pnlBigPic.Controls.Add(this.cmdDelete1);
            this.pnlBigPic.Controls.Add(this.lblLocation1);
            this.pnlBigPic.Location = new System.Drawing.Point(969, 621);
            this.pnlBigPic.Name = "pnlBigPic";
            this.pnlBigPic.Size = new System.Drawing.Size(1005, 700);
            this.pnlBigPic.TabIndex = 13;
            // 
            // cmdClosePhoto
            // 
            this.cmdClosePhoto.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdClosePhoto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdClosePhoto.FlatAppearance.BorderSize = 5;
            this.cmdClosePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdClosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClosePhoto.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdClosePhoto.ForeColor = System.Drawing.Color.Black;
            this.cmdClosePhoto.Location = new System.Drawing.Point(15, 3);
            this.cmdClosePhoto.Name = "cmdClosePhoto";
            this.cmdClosePhoto.Size = new System.Drawing.Size(138, 49);
            this.cmdClosePhoto.TabIndex = 14;
            this.cmdClosePhoto.Text = "Close Photo";
            this.cmdClosePhoto.UseVisualStyleBackColor = false;
            this.cmdClosePhoto.Click += new System.EventHandler(this.cmdClosePhoto_Click);
            // 
            // picSelected1
            // 
            this.picSelected1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSelected1.Location = new System.Drawing.Point(20, 60);
            this.picSelected1.Name = "picSelected1";
            this.picSelected1.Size = new System.Drawing.Size(967, 633);
            this.picSelected1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelected1.TabIndex = 13;
            this.picSelected1.TabStop = false;
            // 
            // cmdDelete1
            // 
            this.cmdDelete1.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdDelete1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdDelete1.FlatAppearance.BorderSize = 5;
            this.cmdDelete1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete1.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdDelete1.ForeColor = System.Drawing.Color.Black;
            this.cmdDelete1.Location = new System.Drawing.Point(758, 3);
            this.cmdDelete1.Name = "cmdDelete1";
            this.cmdDelete1.Size = new System.Drawing.Size(237, 49);
            this.cmdDelete1.TabIndex = 11;
            this.cmdDelete1.Text = "Delete Selected Photo";
            this.cmdDelete1.UseVisualStyleBackColor = false;
            this.cmdDelete1.Click += new System.EventHandler(this.cmdDelete1_Click);
            // 
            // lblLocation1
            // 
            this.lblLocation1.AutoSize = true;
            this.lblLocation1.Font = new System.Drawing.Font("Century", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation1.ForeColor = System.Drawing.Color.White;
            this.lblLocation1.Location = new System.Drawing.Point(190, 10);
            this.lblLocation1.Name = "lblLocation1";
            this.lblLocation1.Size = new System.Drawing.Size(56, 20);
            this.lblLocation1.TabIndex = 12;
            this.lblLocation1.Text = "Image";
            // 
            // gbSelected
            // 
            this.gbSelected.Controls.Add(this.cmdEnlarge);
            this.gbSelected.Controls.Add(this.cmdDelete);
            this.gbSelected.Controls.Add(this.picSelected);
            this.gbSelected.Controls.Add(this.lblLocation);
            this.gbSelected.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbSelected.ForeColor = System.Drawing.Color.White;
            this.gbSelected.Location = new System.Drawing.Point(264, 570);
            this.gbSelected.Name = "gbSelected";
            this.gbSelected.Size = new System.Drawing.Size(662, 127);
            this.gbSelected.TabIndex = 12;
            this.gbSelected.TabStop = false;
            this.gbSelected.Text = "Selected Image";
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdDelete.FlatAppearance.BorderSize = 5;
            this.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdDelete.ForeColor = System.Drawing.Color.Black;
            this.cmdDelete.Location = new System.Drawing.Point(303, 71);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(237, 49);
            this.cmdDelete.TabIndex = 7;
            this.cmdDelete.Text = "Delete Selected Photo";
            this.cmdDelete.UseVisualStyleBackColor = false;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // picSelected
            // 
            this.picSelected.Location = new System.Drawing.Point(546, 19);
            this.picSelected.Name = "picSelected";
            this.picSelected.Size = new System.Drawing.Size(110, 101);
            this.picSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelected.TabIndex = 11;
            this.picSelected.TabStop = false;
            this.picSelected.Click += new System.EventHandler(this.picSelected_Click);
            this.picSelected.DoubleClick += new System.EventHandler(this.picSelected_DoubleClick);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(6, 34);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(56, 20);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "Image";
            // 
            // cmdSend
            // 
            this.cmdSend.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSend.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSend.FlatAppearance.BorderSize = 5;
            this.cmdSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSend.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSend.Location = new System.Drawing.Point(44, 494);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(141, 93);
            this.cmdSend.TabIndex = 8;
            this.cmdSend.Text = "Send Photos and Clear References";
            this.cmdSend.UseVisualStyleBackColor = false;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // lblTaken
            // 
            this.lblTaken.AutoSize = true;
            this.lblTaken.Font = new System.Drawing.Font("Century", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTaken.ForeColor = System.Drawing.Color.White;
            this.lblTaken.Location = new System.Drawing.Point(511, 3);
            this.lblTaken.Name = "lblTaken";
            this.lblTaken.Size = new System.Drawing.Size(161, 25);
            this.lblTaken.TabIndex = 4;
            this.lblTaken.Text = "Pictures Taken";
            // 
            // pnlPictures
            // 
            this.pnlPictures.BackColor = System.Drawing.Color.White;
            this.pnlPictures.Location = new System.Drawing.Point(224, 31);
            this.pnlPictures.Name = "pnlPictures";
            this.pnlPictures.Size = new System.Drawing.Size(780, 530);
            this.pnlPictures.TabIndex = 3;
            this.pnlPictures.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPictures_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Families on Stage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "References of";
            // 
            // lstRef
            // 
            this.lstRef.Font = new System.Drawing.Font("Century", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstRef.FormattingEnabled = true;
            this.lstRef.ItemHeight = 25;
            this.lstRef.Location = new System.Drawing.Point(15, 71);
            this.lstRef.Name = "lstRef";
            this.lstRef.Size = new System.Drawing.Size(190, 404);
            this.lstRef.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cmdEnlarge
            // 
            this.cmdEnlarge.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdEnlarge.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdEnlarge.FlatAppearance.BorderSize = 5;
            this.cmdEnlarge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdEnlarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEnlarge.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdEnlarge.ForeColor = System.Drawing.Color.Black;
            this.cmdEnlarge.Location = new System.Drawing.Point(6, 71);
            this.cmdEnlarge.Name = "cmdEnlarge";
            this.cmdEnlarge.Size = new System.Drawing.Size(237, 49);
            this.cmdEnlarge.TabIndex = 12;
            this.cmdEnlarge.Text = "See Photo Big";
            this.cmdEnlarge.UseVisualStyleBackColor = false;
            this.cmdEnlarge.Click += new System.EventHandler(this.cmdEnlarge_Click);
            // 
            // frmStagePhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 759);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStagePhotos";
            this.Text = "Stage Photos";
            this.Load += new System.EventHandler(this.frmStagePhotos_Load);
            this.Resize += new System.EventHandler(this.frmStagePhotos_Resize);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlBigPic.ResumeLayout(false);
            this.pnlBigPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected1)).EndInit();
            this.gbSelected.ResumeLayout(false);
            this.gbSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLeft;
        private PictureBox pictureBox1;
        private Button cmdClose;
        private Button cmdStartTimer;
        private Panel pnlTop;
        private Label lblTime;
        private System.Windows.Forms.Timer timer3;
        private Panel pnlMain;
        private Label label1;
        private ListBox lstRef;
        private System.Windows.Forms.Timer timer1;
        private Button cmdSend;
        private Button cmdDelete;
        private Label lblTaken;
        private Panel pnlPictures;
        private Label label2;
        private System.Windows.Forms.Timer timer2;
        private GroupBox gbSelected;
        private PictureBox picSelected;
        private Label lblTitle;
        private Label lblLocation;
        private Panel pnlBigPic;
        private Button cmdClosePhoto;
        private PictureBox picSelected1;
        private Button cmdDelete1;
        private Label lblLocation1;
        private Button cmdEnlarge;
    }
}