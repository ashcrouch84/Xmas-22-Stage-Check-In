using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Xmas_22_Stage_Check_In
{
    public partial class frmStagePhotos : Form
    {
        int i, intPicCount,intx,inty, intPicSize;
        List<string> lstPhotoNames = new List<string>();
        Image img1;
        string strSelected;
        Object strSender;
        public frmStagePhotos()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to close Stage Photos?", "Close Check In", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("F");
        }

        private void frmStagePhotos_Resize(object sender, EventArgs e)
        {
            resizeAll();
        }

        private void resizeAll()
        {
            cmdClose.Top = pnlLeft.Height - cmdClose.Height - 20;
            lblTime.Left = pnlTop.Width - lblTime.Width - 30;
            pnlPictures.Width = pnlMain.Width - 10 - pnlPictures.Left;
            pnlPictures.Height = pnlMain.Height - 10 - gbSelected.Height - 50;
            lblTaken.Left = pnlPictures.Left + (pnlPictures.Width / 2) - (lblTaken.Width/2);
            gbSelected.Left = (pnlPictures.Width/2) - (gbSelected.Width/2);
            gbSelected.Top = pnlMain.Height - 10 - gbSelected.Height;
            lblTitle.Left = (pnlTop.Width/2) -(lblTitle.Width/2);
            pnlBigPic.Width = pnlMain.Width;
            pnlBigPic.Height = pnlMain.Height;
            picSelected1.Width = pnlBigPic.Width - 20;
            picSelected1.Height = pnlBigPic.Height - 20 - 60;
            cmdDelete1.Left = pnlBigPic.Width - cmdDelete1.Width - 10;
            reloadPictures();
        }

        private void frmStagePhotos_Load(object sender, EventArgs e)
        {
            loadSettings();
            resizeAll();
        }

        private void loadSettings()
        {
            lblTime.Text = DateTime.Now.ToString("F");
            timer1.Interval = Properties.Settings.Default.sciMInterval * 1000;
            timer1.Start();
            timer2.Interval = Properties.Settings.Default.sciPInterval * 1000;
            timer2.Start();
            intPicCount = 0;
            intx = 10;
            inty = 10;
            intPicSize = Properties.Settings.Default.sciPicSize;
            lblLocation.Text = "";
            gbSelected.Visible = false;
            cmdStartTimer.Visible = false;
            cmdSend.Visible = false;
            intPicSize = Properties.Settings.Default.sciPicSize;
            pnlPictures.AutoScroll = false;
            pnlPictures.HorizontalScroll.Enabled = false;
            pnlPictures.HorizontalScroll.Visible = false;
            pnlPictures.HorizontalScroll.Maximum = 0;
            pnlPictures.AutoScroll = true;

            pnlBigPic.Visible = false;
            pnlBigPic.Left = 0;
            pnlBigPic.Top = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var list = new List<string>();
            bool bRead = false;
            string b = Properties.Settings.Default.sciMonitor.ToString() + "\\stage.txt";

            try
            {
                var fileStream = new FileStream(b, FileMode.Open, System.IO.FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                fileStream.Close();
                bRead = true;
            }
            catch
            {
                bRead = false;
                MessageBox.Show("Can't read the stage/monitor file, please check if the address is valid in the settings menu", "Table read error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                timer1.Stop();
                cmdStartTimer.Visible = true;
            }

            if (bRead==true)
            {
                try
                {
                    lstRef.Items.Clear();
                    string[] strRef = list[0].ToString().Split(',');
                    if (strRef.Length > 0)
                    {
                        for (i = 0; i < strRef.Count(); i++)
                        {
                            lstRef.Items.Add(strRef[i]);
                        }
                    }
                    if (lstRef.Items.Count > 0)
                    {
                        cmdSend.Enabled = true;
                    }
                    cmdSend.Visible = true;
                }
                catch { }
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            deletedSelected();
        }

        private void deletedSelected()
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to delete this picture?", "Delete Picture?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                File.Delete(strSelected);
                lblLocation.Text = "";
                lblLocation1.Text = "";
                gbSelected.Visible = false;
                picSelected.BackgroundImage = null;

                reloadPictures();
                pnlBigPic.Visible = false;
            }
        }

        private void reloadPictures()
        {
            pnlPictures.Controls.Clear();
            intPicCount = 0;
            intx = 10;
            inty = 10;
            lstPhotoNames.Clear();
            loadPictures();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            loadPictures();
        }

        private void loadPictures()
        {
            string destination = Properties.Settings.Default.sciPhotoLocation;
            string[] files = Directory.GetFiles(destination);
            if (files.Length > 0)
            {
                foreach (string file in files)
                {
                    if (Ready(file) == true)
                    {
                        if (lstPhotoNames.Contains(file))
                        { }
                        else
                        {
                            string ext = Path.GetExtension(file);
                            if (ext == ".jpg" || ext == ".JPG" || ext == ".png")
                            {
                                lstPhotoNames.Add(file);

                                PictureBox pb = new PictureBox();
                                pb.Name = "Pic" + intPicCount;

                                pb.Click += new EventHandler(Button_Click);
                                
                                pb.Location = new System.Drawing.Point(intx, inty);
                                pb.Size = new System.Drawing.Size(intPicSize, intPicSize);

                                using (FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                                {
                                    img1 = Image.FromStream(stream);
                                }
                                pb.BackgroundImage = img1;
                                pb.BackgroundImageLayout = ImageLayout.Stretch;
                                pnlPictures.Controls.Add(pb);

                                intx = intx + 10 + intPicSize;
                                if (intx + 20 + intPicSize > pnlPictures.Width)
                                {
                                    intx = 10;
                                    inty = inty + 10 + intPicSize;
                                }

                                intPicCount = intPicCount + 1;
                            }
                        }
                    }
                }
            }
        }

            private void Button_Click(object sender, EventArgs e)
        {
            strSender = sender;
            updatePicture();
        }

        private void updatePicture()
        {
            foreach (var item in pnlPictures.Controls.OfType<PictureBox>())
            {
                item.BorderStyle = BorderStyle.None;
            }
            PictureBox btn = (PictureBox)strSender;
            btn.BorderStyle = BorderStyle.FixedSingle;
            cmdDelete.Enabled = true;

            for (int i = 0; i < intPicCount; i++)
            {
                if (btn.Name == ("Pic" + i))
                {
                    strSelected = lstPhotoNames[i].ToString();
                }
            }
            using (FileStream stream = new FileStream(strSelected, FileMode.Open, FileAccess.Read))
            {
                img1 = Image.FromStream(stream);
            }
            picSelected.Image = img1;
            picSelected.BackgroundImageLayout = ImageLayout.Stretch;
            picSelected1.Image = img1;
            picSelected1.BackgroundImageLayout = ImageLayout.Zoom;
            lblLocation.Text = strSelected.ToString();
            lblLocation1.Text = strSelected.ToString();
            gbSelected.Visible = true;
        }

        private void picSelected_Click(object sender, EventArgs e)
        {

        }

        private void cmdClosePhoto_Click(object sender, EventArgs e)
        {
            pnlBigPic.Visible = false;
        }

        private void picSelected_DoubleClick(object sender, EventArgs e)
        {
            pnlBigPic.Visible = true;
        }

        private void cmdDelete1_Click(object sender, EventArgs e)
        {
            deletedSelected();
        }

        private void cmdEnlarge_Click(object sender, EventArgs e)
        {
            pnlBigPic.Visible = true;
        }

        public static bool Ready(string filename)
        {
            try
            {
                using (FileStream inputStream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
                    return inputStream.Length > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void cmdStartTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            cmdStartTimer.Visible = false;
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to send photos, remove pictures and clear the references?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                //rename photos and send
                string destination = Properties.Settings.Default.sciPhotoLocation;
                string[] files = Directory.GetFiles(destination);
                string strRef = lstRef.Items[0].ToString();
                for (i=1;i<lstRef.Items.Count;i++)
                {
                    strRef = strRef + " " + lstRef.Items[i].ToString();
                }
                i = 0;
                if (files.Length > 0)
                {
                    foreach (string file in files)
                    {
                        if (Ready(file) == true)
                        {
                            string ext = Path.GetExtension(file);
                            if (ext == ".jpg" || ext == ".JPG" || ext == ".png")
                            {
                                //find extension and rename the file
                                var strext = file.ToString().Split('.');
                                string strTime = DateTime.Now.ToString("hhmmss");
                                string strPhotoBooth = Path.Combine(Properties.Settings.Default.sciPhotobooth, strRef + " Stage " + strTime + " " + i + "." + strext[1].ToString());
                                string strSend1 = Path.Combine(Properties.Settings.Default.sciSend1, strRef + " Stage " + strTime + " " + i + "." + strext[1].ToString());
                                string strSend2 = Path.Combine(Properties.Settings.Default.sciSend2, strRef + " Stage " + strTime + " " + i + "." + strext[1].ToString());
                                i++;

                                if (Properties.Settings.Default.sciU1 == true)
                                {
                                    try
                                    {
                                        File.Copy(file, strSend1);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Can't send to Send Address 1, please check address and network connection", "Can't send to Send 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }

                                if (Properties.Settings.Default.sciU2 == true)
                                {
                                    try
                                    {
                                        File.Copy(file, strSend2);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Can't send to Send Address 2, please check address and network connection", "Can't send to Send 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }

                                try
                                {
                                    File.Move(file, strPhotoBooth);
                                }
                                catch
                                {
                                    MessageBox.Show("Can't send to photobooth, please check address and network connection", "Can't send to photobooth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                                
                            }
                        }
                    }
                }

                //clear panel of photos
                pnlPictures.Controls.Clear();

                //clear list box
                lstRef.Items.Clear();
                lstPhotoNames.Clear();

                try
                {

                    string gs = Properties.Settings.Default.sciMonitor + "\\stage.txt";
                    using (StreamWriter writer = new StreamWriter(gs))
                    {
                        writer.WriteLine("");
                    }
                    var lines = File.ReadAllLines(gs).Where(arg => !string.IsNullOrWhiteSpace(arg));
                    File.WriteAllLines(gs, lines);
                }
                catch
                {
                    MessageBox.Show("Failed to write to file, please check address and restart timer", "error writing to file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timer1.Enabled = false;
                    cmdStartTimer.Enabled = true;
                }




                //disable buttons
                cmdSend.Enabled = false;
                cmdDelete.Enabled = false;
                lstPhotoNames.Clear();
                intPicCount= 0;
                intx = 10;
                inty = 10;
                lblLocation.Text = "";
                gbSelected.Visible = false;
                lblLocation.Text = "";
                picSelected.BackgroundImage = null;
            }
        }

        private void pnlPictures_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
