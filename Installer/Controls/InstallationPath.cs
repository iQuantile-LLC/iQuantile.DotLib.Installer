using System;
using System.Windows.Forms;

namespace Installer.Controls
{
    public partial class InstallationPath : UserControl
    {
        public InstallationPath()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog saveFileDialog=new FolderBrowserDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            FilePath.Text = saveFileDialog.SelectedPath;
            MainForm.FilePath = saveFileDialog.SelectedPath;
        }

        private void DesktopCheck_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.DesktopShortcut = DesktopCheck.Checked;
        }

        private void StarttMenuCheck_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.StartMenuShortcut = StarttMenuCheck.Checked;
        }
    }
}
