using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolsKit
{
    public partial class ExitPopUpWindow : Form
    {
        Form mainFrm;

        public ExitPopUpWindow(Form frm)
        {
            InitializeComponent();

            this.ControlBox = false;

            mainFrm = frm;
            mainFrm.Enabled = false;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((mainFrm.Location.X + (mainFrm.Width / 2) - (Width / 2)), (mainFrm.Location.Y + (mainFrm.Height / 2) - (Height / 2)));
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            mainFrm.Enabled = true;
            this.Close();
        }
    }
}
