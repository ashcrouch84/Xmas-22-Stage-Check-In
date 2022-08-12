using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xmas_22_Stage_Check_In
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void loadSettings()
        {
            txtSend1.Text = Properties.Settings.Default.sciSend1.ToString();
            txtSend2.Text = Properties.Settings.Default.sciSend2.ToString();
            txtBrowse.Text = Properties.Settings.Default.sciSend.ToString();
            txtMonitor.Text = Properties.Settings.Default.sciMonitor.ToString();
            txtPhotoBooth.Text = Properties.Settings.Default.sciPhotobooth.ToString();
            txtInterval.Text = Properties.Settings.Default.sciCInterval.ToString();
            txtMonitorTimer.Text = Properties.Settings.Default.sciMInterval.ToString();
            txtPhotoLocation.Text = Properties.Settings.Default.sciPhotoLocation.ToString();
            txtPhotoInterval.Text = Properties.Settings.Default.sciPInterval.ToString();
            txtPicSize.Text = Properties.Settings.Default.sciPicSize.ToString();
            chkUse1.Checked = Properties.Settings.Default.sciU1;
            chkUse2.Checked = Properties.Settings.Default.sciU2;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void txtInterval_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCloseSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMonitor_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtMonitor.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.sciMonitor = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdPhotoBooth_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPhotoBooth.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.sciPhotobooth = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdSend1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSend1.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.sciSend1 = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdSend2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSend2.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.sciSend2 = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBrowse.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.sciSend = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdSaveInterval_Click(object sender, EventArgs e)
        {
            try 
            { 
                Properties.Settings.Default.sciCInterval = Int32.Parse(txtInterval.Text.ToString());
                Properties.Settings.Default.Save();
                MessageBox.Show("Timer Saved", "Timer Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Wait interval not saved, please try again","Timer Saved Fail",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txtInterval.Focus();
            }
        }

        private void cmdMonitorTimer_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.sciMInterval = Int32.Parse(txtMonitorTimer.Text.ToString());
                Properties.Settings.Default.Save();
                MessageBox.Show("Timer Saved","Timer Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Monitor interval not saved, please try again", "Timer Saved Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMonitor.Focus();
            }
        }

        private void chkUse1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sciU1 = chkUse1.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkUse2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sciU2 = chkUse1.Checked;
            Properties.Settings.Default.Save();
        }

        private void cmdPhotoLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPhotoLocation.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.sciPhotoLocation = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        private void cmdPhotoInterval_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.sciPInterval = Int32.Parse(txtPhotoInterval.Text.ToString());
                Properties.Settings.Default.Save();
                MessageBox.Show("Timer Saved", "Timer Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Photo interval not saved, please try again", "Timer Saved Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMonitor.Focus();
            }
        }

        private void cmdPicSize_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.sciPicSize = Int32.Parse(txtPicSize.Text.ToString());
                Properties.Settings.Default.Save();
                MessageBox.Show("Picture Size Saved", "Picture Size Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Can't save the picture size, please try another integer and try again", "Picture Size Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPicSize.Focus();
            }
        }
    }
}
