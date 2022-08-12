namespace Xmas_22_Stage_Check_In
{
    partial class frmStartup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSettings = new System.Windows.Forms.Button();
            this.cmdPhoto = new System.Windows.Forms.Button();
            this.cmdStageCheckIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Controls.Add(this.cmdSettings);
            this.panel1.Controls.Add(this.cmdPhoto);
            this.panel1.Controls.Add(this.cmdStageCheckIn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 430);
            this.panel1.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdClose.FlatAppearance.BorderSize = 5;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Font = new System.Drawing.Font("Century", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdClose.Location = new System.Drawing.Point(150, 364);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(95, 54);
            this.cmdClose.TabIndex = 4;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSettings
            // 
            this.cmdSettings.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdSettings.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdSettings.FlatAppearance.BorderSize = 5;
            this.cmdSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSettings.Font = new System.Drawing.Font("Century", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSettings.Location = new System.Drawing.Point(35, 364);
            this.cmdSettings.Name = "cmdSettings";
            this.cmdSettings.Size = new System.Drawing.Size(95, 55);
            this.cmdSettings.TabIndex = 3;
            this.cmdSettings.Text = "Settings";
            this.cmdSettings.UseVisualStyleBackColor = false;
            this.cmdSettings.Click += new System.EventHandler(this.cmdSettings_Click);
            // 
            // cmdPhoto
            // 
            this.cmdPhoto.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdPhoto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdPhoto.FlatAppearance.BorderSize = 5;
            this.cmdPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPhoto.Font = new System.Drawing.Font("Century", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdPhoto.Location = new System.Drawing.Point(35, 277);
            this.cmdPhoto.Name = "cmdPhoto";
            this.cmdPhoto.Size = new System.Drawing.Size(210, 60);
            this.cmdPhoto.TabIndex = 2;
            this.cmdPhoto.Text = "Stage Photos";
            this.cmdPhoto.UseVisualStyleBackColor = false;
            this.cmdPhoto.Click += new System.EventHandler(this.cmdPhoto_Click);
            // 
            // cmdStageCheckIn
            // 
            this.cmdStageCheckIn.BackColor = System.Drawing.Color.Goldenrod;
            this.cmdStageCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.cmdStageCheckIn.FlatAppearance.BorderSize = 5;
            this.cmdStageCheckIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdStageCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStageCheckIn.Font = new System.Drawing.Font("Century", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdStageCheckIn.Location = new System.Drawing.Point(35, 195);
            this.cmdStageCheckIn.Name = "cmdStageCheckIn";
            this.cmdStageCheckIn.Size = new System.Drawing.Size(210, 60);
            this.cmdStageCheckIn.TabIndex = 1;
            this.cmdStageCheckIn.Text = "Stage Check In";
            this.cmdStageCheckIn.UseVisualStyleBackColor = false;
            this.cmdStageCheckIn.Click += new System.EventHandler(this.cmdStageCheckIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 430);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartup";
            this.Text = "Stage Photos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStartup_FormClosing);
            this.Load += new System.EventHandler(this.frmStartup_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button cmdSettings;
        private Button cmdPhoto;
        private Button cmdStageCheckIn;
        private PictureBox pictureBox1;
        private Button cmdClose;
    }
}