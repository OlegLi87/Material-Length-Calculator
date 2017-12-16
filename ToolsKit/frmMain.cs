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
    public partial class frmMain : Form
    {       
        public frmMain()
        {
            InitializeComponent();
            InitializeComboBox();
            this.ControlBox = false;

            AdditionalFunctionality.ButtonStatusChange("dis", this.btnSelect);
        }
        
        private void InitializeComboBox()
        {
            this.cmbToolsList.Items.Add("מחשבון לחישוב אורך החומר");
            this.cmbToolsList.Items.Add("מעקב אחרי מספר החזרות");
        }

        private void cmbToolsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdditionalFunctionality.ButtonStatusChange("en", this.btnSelect);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.cmbToolsList.SelectedIndex == 0)
            {
                MaterialLengthCalculator calc = new MaterialLengthCalculator(this);
                calc.Show();
            }

            else
            {
                JobSendingTracer tracer = new JobSendingTracer(this);
                tracer.Show();
            }         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ExitPopUpWindow exitFrm = new ExitPopUpWindow(this);
            exitFrm.Show();
        }
    }
}
