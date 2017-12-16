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
    public partial class JobSendingTracer : Form
    {
        Form mainFrm;
        string defaultTextBoxStr = "... הכנס מספר";

        public JobSendingTracer(Form frm)
        {
            InitializeComponent();
            mainFrm = frm;
            mainFrm.Visible = false;

            this.ControlBox = false;
            

            AdditionalFunctionality.ButtonStatusChange("dis", this.btnStart);
            FillTextBox();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((mainFrm.Location.X + (mainFrm.Width / 2) - (Width / 2)), (mainFrm.Location.Y + (mainFrm.Height / 2) - (Height / 2)));
        }

        private void FillTextBox()
        {
            this.txtIteration.ForeColor = Color.Gray;
            this.txtIteration.Text = defaultTextBoxStr;
            this.txtIteration.TextAlign = HorizontalAlignment.Center;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            mainFrm.Visible = true;
            AdditionalFunctionality.FormCentering(mainFrm);

            this.Close();
        }

        private void txtIteration_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtIteration.Text = string.Empty;
            this.txtIteration.ForeColor = Color.Black;

            AdditionalFunctionality.ButtonStatusChange("en", this.btnStart);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(this.txtIteration.Text) <= 0) throw new Exception();
                else if (Convert.ToInt32(this.txtIteration.Text) > 9999) throw new LargeNumberException();

                IterationForm itrFrm = new IterationForm(this, this.txtIteration.Text);
                itrFrm.Show();
            }
            catch (LargeNumberException ex)
            {
                this.Visible = false;
                MessageBox.Show(ex.Message);
                this.Visible = true;
                AdditionalFunctionality.ButtonStatusChange("dis", this.btnStart);
            }
            catch (Exception)
            {
                this.Visible = false;
                MessageBox.Show("!!!  נתון חייב להיות מספר שלם גדול מאפס");
                this.Visible = true;
                AdditionalFunctionality.ButtonStatusChange("dis", this.btnStart);               
            }
            finally
            {
                FillTextBox();
                AdditionalFunctionality.FormCentering(this);
                AdditionalFunctionality.ButtonStatusChange("dis", this.btnStart);
            }           
        }
    }
}
