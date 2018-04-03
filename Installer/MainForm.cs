using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Installer.Controls;
using Ionic.Zip;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Installer
{
    public partial class MainForm : MaterialForm
    {
        public enum PageNavigation
        {
            Welcome,TermsAndCondition,InstallationPath,Progress,Final
        }
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        public static MainForm Main { get; set; }
        public static string FilePath { get; set; }
        public static bool DesktopShortcut { get; set; }
        public static bool StartMenuShortcut { get; set; }

        private PageNavigation PageNav { get; set; }


        private string ZippedFilePath { get; set; }
        private string ZippedFileName { get; set; }

        public MainForm()
        {
            backgroundWorker.WorkerReportsProgress=true;
            PageNav = PageNavigation.Welcome;
            InitializeComponent();
            ZippedFileName = "robotottf.zip";
            ZippedFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppDirectory", ZippedFileName);
            Main = this;
            NextButton_Click(new object(), new EventArgs());
        }

      
        public static void AgreeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            MaterialCheckBox checkBox = (MaterialCheckBox) sender;
            Main.NextButton.Enabled = checkBox.Checked;
        }


       

        private void NextButton_Click(object sender, EventArgs e)
        {
            switch (PageNav)
            {
                case PageNavigation.Welcome:
                    ViewPanel.Controls.Clear();
                    HeaderLable.Text = @"Welcome";
                    WelcomePage welcomePage=new WelcomePage(){Dock = DockStyle.Fill};
                    ViewPanel.Controls.Add(welcomePage);
                    PageNav = PageNavigation.TermsAndCondition;
                    BackButton.Visible = false;
                    break;
                case PageNavigation.TermsAndCondition:
                    BackButton.Visible = true;
                    HeaderLable.Text = @"Terms And Conditions";
                    ViewPanel.Controls.Clear();
                    TermsAndConditions termsAndConditions = new TermsAndConditions() { Dock = DockStyle.Fill };
                    ViewPanel.Controls.Add(termsAndConditions);
                    PageNav = PageNavigation.InstallationPath;
                    NextButton.Enabled = false;
                    break;
                case PageNavigation.InstallationPath:
                    HeaderLable.Text = @"Installation Directory";
                    ViewPanel.Controls.Clear();
                    InstallationPath installationPath = new InstallationPath() { Dock = DockStyle.Fill };
                    ViewPanel.Controls.Add(installationPath);
                  
                    PageNav = PageNavigation.Progress;
                    break;
                case PageNavigation.Progress:
                    HeaderLable.Text = @"Installing";
                    NextButton.Visible = false;
                    BackButton.Visible = false;
                    ViewPanel.Controls.Clear();
                    InstallationProgress installationProgress = new InstallationProgress() { Dock = DockStyle.Fill };
                    ViewPanel.Controls.Add(installationProgress);
                    PageNav = PageNavigation.Final;
                    backgroundWorker.DoWork += BackgroundWorker_DoWork; 
                    backgroundWorker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
                    backgroundWorker.ProgressChanged += installationProgress.backgroundWorker1_ProgressChanged;
                    backgroundWorker.RunWorkerAsync();
                    break;
                case PageNavigation.Final:
                    HeaderLable.Text = @"Finished";
                    ViewPanel.Controls.Clear();
                    FinalPage final = new FinalPage() { Dock = DockStyle.Fill };
                    ViewPanel.Controls.Add(final);
                    FinishButton.Visible = true;
                    break;
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker backgroundWorker1 = (BackgroundWorker)sender;
            
            ReadFile(backgroundWorker1);
           
            
          
        }


        private void ReadFile(BackgroundWorker backgroundWorker)
        {
           
            
            using (ZipFile zip = ZipFile.Read(ZippedFilePath))
            {
                int total = zip.Entries.Count;
                int count = 0;
                foreach (ZipEntry e in zip)
                {
                    e.Extract(FilePath,ExtractExistingFileAction.OverwriteSilently);
                    backgroundWorker.ReportProgress(count++ * 100 / total);
                }
            }


        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show(@"Are you sure you want to quit installation?", @"Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Close();
            }
        
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
           //
        }


        public void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          
            CancleButton.Hide();
            NextButton_Click(new object(), new EventArgs());
        }

       

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
