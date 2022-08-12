namespace Xmas_22_Stage_Check_In
{
    public partial class frmCheckIn : Form
    {
        string strTemp;
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
            resizeAll();
        }

        private void loadSettings()
        {
            timer1.Interval = Properties.Settings.Default.sciCInterval * 1000;
            timer1.Start();
            cmdClear.Enabled = false;
            lblInfo.Text = "";
            cmdStartTimer.Visible=false;
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to clear the listbox of references?", "Clear List", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                lstRef.Items.Clear();
                cmdClear.Enabled = false;
                txtRef.Focus();
                strTemp = "";
                updateFile();
            }
        }

        private void txtRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateListBox();
            }
        }

        private void updateListBox()
        {
            int intTemp;
            try
            {
                intTemp = Int32.Parse(txtRef.Text);
                lstRef.Items.Add(intTemp);
                txtRef.Text = "";
                txtRef.Focus();
                cmdClear.Enabled = true;
            }
            catch
            {
                MessageBox.Show("References number is not valid, it should only be numbers. Please try again","Reference error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtRef.Focus();
                txtRef.Text = "";
            }
        }

        private void cmdAddReference_Click(object sender, EventArgs e)
        {
            updateListBox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            strTemp = "";
            if (lstRef.Items.Count !=0)
            {
                strTemp = lstRef.Items[0].ToString();
                for (int i = 1; i < lstRef.Items.Count; i++)
                {
                    strTemp = strTemp + "," + lstRef.Items[i].ToString();
                }

                updateFile();
            }
        }

        private void cmdStartTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void updateFile()
        {
            try
            {

                string gs = Properties.Settings.Default.sciSend + "\\stage.txt";
                using (StreamWriter writer = new StreamWriter(gs))
                {
                    writer.WriteLine(strTemp);
                }
                var lines = File.ReadAllLines(gs).Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines(gs, lines);
                lblInfo.Text = "File Uploaded Successfully";
                timer2.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Failed to write to file, please check address and restart timer", "error writing to file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                timer1.Enabled = false;
                cmdStartTimer.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void frmCheckIn_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to close Stage Check In?", "Close Check In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void frmCheckIn_Resize(object sender, EventArgs e)
        {
            resizeAll();
        }

        private void resizeAll()
        {
            gbCheckIn.Left = (pnlMain.Width /2) - (gbCheckIn.Width /2);
            cmdClose.Top = pnlLeft.Height - cmdClose.Height - 20;
            lblTime.Left = pnlTop.Width - lblTime.Width - 30;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmdStartTimer_Click_1(object sender, EventArgs e)
        {

        }
    }
}