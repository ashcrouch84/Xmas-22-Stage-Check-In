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
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void cmdStageCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn frmCheckIn = new frmCheckIn();
            frmCheckIn.Show();
        }

        private void cmdPhoto_Click(object sender, EventArgs e)
        {
            frmStagePhotos frmStagePhotos = new frmStagePhotos();
            frmStagePhotos.Show();
        }

        private void cmdSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.Show();
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            closeStartup();
        }

        private void frmStartup_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void closeStartup()
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to close this program?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
