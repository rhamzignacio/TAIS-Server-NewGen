using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TAIS_Server_NewGen.Class;

namespace TAIS_Server_NewGen
{
    public partial class MainWindow : Form
    {
        //For menu border style
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        int amadeusCTR = 0;

        int cebuPacCTR = 0;

        

        AirFileProcess airProcess = new AirFileProcess();

        public MainWindow()
        {
            InitializeComponent();

            GetPreviousPath();

            clientDropDown();
        }

        private void clientDropDown()
        {
            using (var db = new TravComEntities())
            {
                var profiles = db.Profiles.Where(r => r.ProfileType == 0 && r.FullName != "").ToList();

                AutoCompleteStringCollection col = new AutoCompleteStringCollection();

                profiles.ForEach(item =>
                {
                    col.Add(item.FullName);

                    //cmbBoxClient.Items.Add(item.FullName);
                });

                cmbBoxClient.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cmbBoxClient.AutoCompleteCustomSource = col;

                cmbBoxClient.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
        }

        private void GetPreviousPath()
        {
            txtBoxAmadeusSource.Text = Properties.Settings.Default.AmadeusSourcePath;

            txtBoxAmadeusProcessedPath.Text = Properties.Settings.Default.AmadeusProcessedPath;

            txtBoxIATALocationPath.Text = Properties.Settings.Default.IATALocationPath;

            txtBoxCebuPacificProcessedPath.Text = Properties.Settings.Default.CebuPacificProcessedPath;

            txtBoxCebuPacificLocationPath.Text = Properties.Settings.Default.CebuPacificLocationPath;

            txtBoxCebuPacificSourcePath.Text = Properties.Settings.Default.CebuPacificSourcePath;

            txtBoxSabreLocationPath.Text = Properties.Settings.Default.SabreLocationPath;

            txtBoxSabreProcessedPath.Text = Properties.Settings.Default.SabreProcessedPath;

            txtBoxSabreSourcePath.Text = Properties.Settings.Default.SabreSourcePath;

            txtBoxIASALocationPath.Text = Properties.Settings.Default.IASALocationPath;

            txtBoxSpecialClientLocationPath.Text = Properties.Settings.Default.SpecialClientPath;

            txtBoxOtherInfoPath.Text = Properties.Settings.Default.OtherPath;

            txtBoxLogs.Text = Properties.Settings.Default.LogsPath;

            txtBoxAmadeusErrorPath.Text = Properties.Settings.Default.AmadeusErrorPath;

            txtBoxSabreErrorPath.Text = Properties.Settings.Default.SabreErrorPath;

            txtBoxCebuPacErrorPath.Text = Properties.Settings.Default.CebuPacificErrorPath;

            txtBoxAmadeusTemp.Text = Properties.Settings.Default.AmadeusTempPath;
        }

        private void MenuMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private string SelectPath()
        {
            FolderBrowserDialog folderPath = new FolderBrowserDialog();

            if (folderPath.ShowDialog() == DialogResult.OK)
                return folderPath.SelectedPath;
            else
                return "";
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {           
            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(5, "Running", "TAIS Server", ToolTipIcon.Info);

            this.Hide();
        }


        private void btnAmadeusSource_Click(object sender, EventArgs e)
        {
            //Select folder path for amadeus
            txtBoxAmadeusSource.Text = SelectPath();

            Properties.Settings.Default.AmadeusSourcePath = txtBoxAmadeusSource.Text;

            Properties.Settings.Default.Save();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            amadeusCTR = 0;

            cebuPacCTR = 0;

            amadeusTimer.Start();

            btnStart.Enabled = false;

            btnStop.Enabled = pictureBox.Visible = true;
        }

        private void btnAmadeusProcessedPath_Click(object sender, EventArgs e)
        {
            //Select folder path for amadeus
            txtBoxAmadeusProcessedPath.Text = SelectPath();

            Properties.Settings.Default.AmadeusProcessedPath = txtBoxAmadeusProcessedPath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnIATALocationPath_Click(object sender, EventArgs e)
        {
            //Select folder path for amadeus
            txtBoxIATALocationPath.Text = SelectPath();

            Properties.Settings.Default.IATALocationPath = txtBoxIATALocationPath.Text;

            Properties.Settings.Default.Save();
        }

        private void Process()
        {
            DirectoryInfo amadeusDirector = new DirectoryInfo(@txtBoxAmadeusSource.Text);

            FileInfo[] amadeusAirFiles = amadeusDirector.GetFiles("*.txt");


            foreach (FileInfo amadeusAirFile in amadeusAirFiles)
            {
                try
                {
                    airProcess.ReadAirFile(amadeusAirFile, this);

                    if (File.Exists(txtBoxAmadeusProcessedPath.Text + "\\" + amadeusAirFile.Name))
                        File.Delete(txtBoxAmadeusProcessedPath.Text + "\\" + amadeusAirFile.Name);
                    else
                        File.Move(amadeusAirFile.FullName, txtBoxAmadeusProcessedPath.Text + "\\" + amadeusAirFile.Name);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error");

                    if (File.Exists(txtBoxAmadeusProcessedPath.Text + "\\" + amadeusAirFile.Name))
                        File.Delete(txtBoxAmadeusProcessedPath.Text + "\\" + amadeusAirFile.Name);
                    else
                        File.Move(amadeusAirFile.FullName, txtBoxAmadeusProcessedPath.Text + "\\" + amadeusAirFile.Name);
                }

                //ProcessAmadeus();
            }

            Thread cebuPac = new Thread(new ThreadStart(ProcessCebuPac));

            cebuPac.Start();

            Thread sabre = new Thread(new ThreadStart(ProcessSabre));

            sabre.Start();

            Thread amadeus = new Thread(new ThreadStart(ProcessAmadeus));

            amadeus.Start();
           
        }

        private void ProcessAmadeus()
        {
            try
            {
                DirectoryInfo tempDirectory = new DirectoryInfo(txtBoxAmadeusTemp.Text);

                FileInfo[] tempFiles = tempDirectory.GetFiles("*.txt");

                var temp = tempFiles.FirstOrDefault();

                if (temp != null)
                    File.Move(temp.FullName, txtBoxIATALocationPath.Text + "\\" + temp.Name);
            }
            catch(Exception error)
            {
               // MessageBox.Show(error.Message, "Error");
            }
        }

        private void ProcessSabre()
        {
            DirectoryInfo sabreDirectory = new DirectoryInfo(@txtBoxSabreSourcePath.Text);

            FileInfo[] sabreAirFiles = sabreDirectory.GetFiles("*.txt");

            foreach (FileInfo sabreAirFile in sabreAirFiles)
            {
                try
                {
                    File.Copy(sabreAirFile.FullName, txtBoxSabreLocationPath.Text + "\\" + sabreAirFile.Name, true);

                    if (File.Exists(txtBoxSabreProcessedPath.Text + "\\" + sabreAirFile.Name))
                        File.Delete(txtBoxSabreProcessedPath.Text + "\\" + sabreAirFile.Name);
                    else
                        File.Move(sabreAirFile.FullName, txtBoxSabreProcessedPath.Text + "\\" + sabreAirFile.Name);
                }
                catch
                {
                    //if (File.Exists(txtBoxSabreProcessedPath.Text + "\\" + sabreAirFile.Name))
                    //    File.Delete(txtBoxSabreProcessedPath.Text + "\\" + sabreAirFile.Name);
                    //else
                    //    File.Move(sabreAirFile.FullName, txtBoxSabreProcessedPath.Text + "\\" + sabreAirFile.Name);
                }
            }
        }

        private void ProcessCebuPac()
        {
                DirectoryInfo cebuPacDirectory = new DirectoryInfo(@txtBoxCebuPacificSourcePath.Text);

                FileInfo[] cebuPacAirfiles = cebuPacDirectory.GetFiles("*.txt");

                foreach (FileInfo cebuPacificAirFile in cebuPacAirfiles)
                {
                    try
                    {
                        File.Copy(cebuPacificAirFile.FullName, txtBoxCebuPacificLocationPath.Text + "\\" + cebuPacificAirFile.Name, true);

                        if (File.Exists(txtBoxCebuPacificProcessedPath.Text + "\\" + cebuPacificAirFile.Name))
                            File.Delete(txtBoxCebuPacificProcessedPath.Text + "\\" + cebuPacificAirFile.Name);
                        else
                            File.Move(cebuPacificAirFile.FullName, txtBoxCebuPacificProcessedPath.Text + "\\" + cebuPacificAirFile.Name);
                    }
                    catch
                    {
                        //if (File.Exists(txtBoxCebuPacificProcessedPath.Text + "\\" + cebuPacificAirFile.Name))
                        //    File.Delete(txtBoxCebuPacificProcessedPath.Text + "\\" + cebuPacificAirFile.Name);
                        //else
                        //    File.Move(cebuPacificAirFile.FullName, txtBoxCebuPacificProcessedPath.Text + "\\" + cebuPacificAirFile.Name);
                    }
                }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //amadeusTimer.Stop();

            //amadeusCTR++;
            
            //if(amadeusCTR == 2)
            //{
            //    amadeusCTR = 0;

                Process();
            //}

            //amadeusTimer.Start();

            //amadeusTimer.Stop();

            //amadeusTimer.Start();
        }

        private void btnCebuPacificSourcePath_Click(object sender, EventArgs e)
        {
            //Select folder path for amadeus
            txtBoxCebuPacificSourcePath.Text = SelectPath();

            Properties.Settings.Default.CebuPacificSourcePath = txtBoxCebuPacificSourcePath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnCebuPacificProcessed_Click(object sender, EventArgs e)
        {
            //Select folder path for amadeus
            txtBoxCebuPacificProcessedPath.Text = SelectPath();

            Properties.Settings.Default.CebuPacificProcessedPath = txtBoxCebuPacificProcessedPath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnCebuPacificLocationPath_Click(object sender, EventArgs e)
        {
            //Select folder path for cebu pacific
            txtBoxCebuPacificLocationPath.Text = SelectPath();

            Properties.Settings.Default.CebuPacificLocationPath = txtBoxCebuPacificLocationPath.Text;

            Properties.Settings.Default.Save();
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;

            btnStop.Enabled = pictureBox.Visible = false;

            amadeusTimer.Stop();
        }

        private void btnSabreSourcePath_Click(object sender, EventArgs e)
        {
            //Select folder path for sabre
            txtBoxSabreSourcePath.Text = SelectPath();

            Properties.Settings.Default.SabreSourcePath = txtBoxSabreSourcePath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnSabreProcessedPath_Click(object sender, EventArgs e)
        {
            //Select folder path for sabre
            txtBoxSabreProcessedPath.Text = SelectPath();

            Properties.Settings.Default.SabreProcessedPath = txtBoxSabreProcessedPath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnSabreLocationPath_Click(object sender, EventArgs e)
        {
            //Select folder path for sabre
            txtBoxSabreLocationPath.Text = SelectPath();

            Properties.Settings.Default.SabreLocationPath = txtBoxSabreLocationPath.Text;

            Properties.Settings.Default.Save();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(5, "Running", "TAIS Server", ToolTipIcon.Info);

            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtBoxIASALocationPath.Text = SelectPath();

            Properties.Settings.Default.IASALocationPath = txtBoxIASALocationPath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnSpecialClientLocation_Click(object sender, EventArgs e)
        {
            txtBoxSpecialClientLocationPath.Text = SelectPath();

            Properties.Settings.Default.SpecialClientPath = txtBoxSpecialClientLocationPath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnOtherInfoPath_Click(object sender, EventArgs e)
        {
            txtBoxOtherInfoPath.Text = SelectPath();

            Properties.Settings.Default.OtherPath = txtBoxOtherInfoPath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            txtBoxLogs.Text = SelectPath();

            Properties.Settings.Default.LogsPath = txtBoxLogs.Text;

            Properties.Settings.Default.Save();
        }

        private void btnAmadeusError_Click(object sender, EventArgs e)
        {
            txtBoxAmadeusErrorPath.Text = SelectPath();

            Properties.Settings.Default.AmadeusErrorPath = txtBoxAmadeusErrorPath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnSabreError_Click(object sender, EventArgs e)
        {
            txtBoxSabreErrorPath.Text = SelectPath();

            Properties.Settings.Default.SabreErrorPath = txtBoxSabreErrorPath.Text;

            Properties.Settings.Default.Save();
        }

        private void btnCebuPacificError_Click(object sender, EventArgs e)
        {
            txtBoxCebuPacErrorPath.Text = SelectPath();

            Properties.Settings.Default.CebuPacificErrorPath = txtBoxCebuPacErrorPath.Text;

            Properties.Settings.Default.Save();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxAmadeusProcessedPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAmadeusTemp_Click(object sender, EventArgs e)
        {
            txtBoxAmadeusTemp.Text = SelectPath();

            Properties.Settings.Default.AmadeusTempPath = txtBoxAmadeusTemp.Text;

            Properties.Settings.Default.Save();
        }

        int ctr = 0;
    }
}