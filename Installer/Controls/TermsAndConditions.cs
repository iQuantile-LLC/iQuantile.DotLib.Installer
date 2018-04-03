using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer.Controls
{
    public partial class TermsAndConditions : UserControl
    {
        public TermsAndConditions()
        {
            InitializeComponent();
            AgreeCheckbox.CheckedChanged += MainForm.AgreeCheckbox_CheckedChanged;
        }

       
    }
}
