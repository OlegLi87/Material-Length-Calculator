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
    public partial class IterationForm : Form
    {
        Form parentalFrm;
        int iterations;
        DateTime start;

        public IterationForm(Form frm,string iterations)
        {
            InitializeComponent();
            start = DateTime.Now;

            this.iterations = Convert.ToInt32(iterations);
            UpdateIteration();

            parentalFrm = frm;
            parentalFrm.Visible = false;

            this.ControlBox = false;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((parentalFrm.Location.X + (parentalFrm.Width / 2) - (Width / 2)), (parentalFrm.Location.Y + (parentalFrm.Height / 2) - (Height / 2)));          
        }

        private void UpdateIteration()
        {
            if (iterations >= 1000)
            {
                this.lblIterations.Location = new Point(this.lblIterationsToGo.Location.X - 105, this.lblIterationsToGo.Location.Y);
                this.lblIterations.Text = iterations.ToString();
                this.lblIterations.ForeColor = Color.Coral;
            }
            else if (iterations >= 100)
            {
                this.lblIterations.Location = new Point(this.lblIterationsToGo.Location.X - 95, this.lblIterationsToGo.Location.Y);
                this.lblIterations.Text = iterations.ToString();
                this.lblIterations.ForeColor = Color.DarkOrchid;
            }
            else if (iterations >= 10)
            {
                this.lblIterations.Location = new Point(this.lblIterationsToGo.Location.X - 85, this.lblIterationsToGo.Location.Y);
                this.lblIterations.Text = iterations.ToString();
                this.lblIterations.ForeColor = Color.Green;
            }
            else if (iterations == 1)
            {
                this.lblIterations.Location = new Point(this.lblIterationsToGo.Location.X - 105, this.lblIterationsToGo.Location.Y);
                this.lblIterations.Text = "אחרון";
                this.lblIterations.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                this.lblIterations.Location = new Point(this.lblIterationsToGo.Location.X - 73, this.lblIterationsToGo.Location.Y);
                this.lblIterations.Text = iterations.ToString();
                this.lblIterations.ForeColor = Color.Red;
            }
        }

        private void UpdateLastChangeTime()
        {
            string hour = AdditionalFunctionality.TimeFormation(DateTime.Now.Hour);
            string minute = AdditionalFunctionality.TimeFormation(DateTime.Now.Minute);
            string second = AdditionalFunctionality.TimeFormation(DateTime.Now.Second);

            this.lblLastUpdateTime.Text = string.Format("{0} : {1} : {2}",hour,minute,second);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            --iterations;

            if (iterations == 0) CloseForm();

            UpdateIteration();
            UpdateLastChangeTime();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ++iterations;
            UpdateIteration();
            UpdateLastChangeTime();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            parentalFrm.Show();
            this.Close();
        }

        private void CloseForm()
        {
            string totalJobTime = (DateTime.Now - start).ToString();

            this.Close();
            MessageBox.Show(AdditionalFunctionality.TotalTimeFormat(totalJobTime));

            parentalFrm.Show();
            AdditionalFunctionality.FormCentering(parentalFrm);
        }
    }
}
