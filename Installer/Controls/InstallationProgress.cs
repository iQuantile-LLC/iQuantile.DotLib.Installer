using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer.Controls
{
    public partial class InstallationProgress : UserControl
    {
     
        public BackgroundWorker BackgroundWorker1 { get; set; }

        public InstallationProgress()
        {
            InitializeComponent();
            BackgroundWorker1=new BackgroundWorker();
            BackgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;



        }

        //private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    using (ZipArchive archive = ZipFile.OpenRead(ZippedFilePath))
        //    {
        //        int total = archive.Entries.Count;
        //        int count = 0;
        //        foreach (ZipArchiveEntry entry in archive.Entries)
        //        {
        //            backgroundWorker1.ReportProgress(count++ * 100 / total);
        //            entry.ExtractToFile(Path.Combine(MainForm.FilePath, entry.FullName));

        //        }
        //    }
        //}

        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
         {
            progressBar1.Value = e.ProgressPercentage;
            ProgressLable.Text = e.ProgressPercentage + @"%";
        }

        
    }
}
