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
    public partial class MaterialLengthCalculator : Form
    {
        private Form mainFrm;
        private string defaultTextBoxString = "... הכנס מידה במילימטרים";

        public MaterialLengthCalculator(Form frm)
        {
            InitializeComponent();
            this.ControlBox = false;

            mainFrm = frm;
            mainFrm.Visible = false;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((mainFrm.Location.X + (mainFrm.Width / 2) - (Width / 2)), (mainFrm.Location.Y + (mainFrm.Height / 2) - (Height / 2)));

            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            txtOuterDim.ForeColor = Color.Gray;
            txtOuterDim.Text = defaultTextBoxString;

            txtInnerDim.ForeColor = Color.Gray;
            txtInnerDim.Text = defaultTextBoxString;

            txtMatThickness.ForeColor = Color.Gray;
            txtMatThickness.Text = defaultTextBoxString;
        }

        private void txtOuterDim_MouseClick(object sender, MouseEventArgs e)
        {           
            txtOuterDim.ForeColor = Color.Black;
            txtOuterDim.Text = string.Empty;
        }

        private void txtInnerDim_MouseClick(object sender, MouseEventArgs e)
        {
            txtInnerDim.ForeColor = Color.Black;
            txtInnerDim.Text = string.Empty;
        }

        private void txtMatThickness_MouseClick(object sender, MouseEventArgs e)
        {
            txtMatThickness.ForeColor = Color.Black;
            txtMatThickness.Text = string.Empty;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            AdditionalFunctionality.FormCentering(mainFrm);
            mainFrm.Visible = true;
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            double pi = 3.14159265358979323846264338327950288419716939937510582097494459;

            try
            {
                if((txtOuterDim.Text == defaultTextBoxString || txtInnerDim.Text == defaultTextBoxString || txtMatThickness.Text == defaultTextBoxString) ||
                (txtOuterDim.Text == string.Empty || txtInnerDim.Text == string.Empty || txtMatThickness.Text == string.Empty)) throw new EmtyTextBoxException();

                double outDim = Convert.ToDouble(txtOuterDim.Text);
                double inDim = Convert.ToDouble(txtInnerDim.Text);
                double thickness = Convert.ToDouble(txtMatThickness.Text);

                if (outDim <= 0 || inDim <= 0 || thickness <= 0) throw new SmallerThanZeroException();

                double res = (((Math.Pow(outDim, 2) / 4) - (Math.Pow(inDim, 2) / 4)) * pi) / thickness;

                MessageBox.Show(string.Format(" אורך החומר בגליל שווה ל {0} מטר", Math.Round(res / 1000,2)));
            }
            catch (EmtyTextBoxException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SmallerThanZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("!!! הנתונים חייבים להכיל רק מספרים");
            }
            finally
            {
                FillTextBoxes();
                AdditionalFunctionality.FormCentering(this);
                this.Visible = true;
            }           
        }
    }
}

