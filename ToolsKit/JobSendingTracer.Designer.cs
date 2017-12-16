namespace ToolsKit
{
    partial class JobSendingTracer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIteration = new System.Windows.Forms.Label();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.grpBoxIterationDate = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGoBackSec = new System.Windows.Forms.Button();
            this.grpBoxIterationDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIteration
            // 
            this.lblIteration.AutoSize = true;
            this.lblIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIteration.Location = new System.Drawing.Point(35, 16);
            this.lblIteration.Name = "lblIteration";
            this.lblIteration.Size = new System.Drawing.Size(151, 29);
            this.lblIteration.TabIndex = 11;
            this.lblIteration.Text = "מספר החזרות";
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(33, 53);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(151, 20);
            this.txtIteration.TabIndex = 12;
            this.txtIteration.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtIteration_MouseClick);
            // 
            // grpBoxIterationDate
            // 
            this.grpBoxIterationDate.Controls.Add(this.lblIteration);
            this.grpBoxIterationDate.Controls.Add(this.txtIteration);
            this.grpBoxIterationDate.Location = new System.Drawing.Point(33, 12);
            this.grpBoxIterationDate.Name = "grpBoxIterationDate";
            this.grpBoxIterationDate.Size = new System.Drawing.Size(215, 100);
            this.grpBoxIterationDate.TabIndex = 13;
            this.grpBoxIterationDate.TabStop = false;
            this.grpBoxIterationDate.Text = "הכנס מספר";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackgroundImage = global::ToolsKit.Properties.Resources._1969936;
            this.btnStart.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.Snow;
            this.btnStart.Location = new System.Drawing.Point(183, 148);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 37);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "התחל";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGoBackSec
            // 
            this.btnGoBackSec.BackgroundImage = global::ToolsKit.Properties.Resources._1580321;
            this.btnGoBackSec.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoBackSec.ForeColor = System.Drawing.Color.Snow;
            this.btnGoBackSec.Location = new System.Drawing.Point(12, 149);
            this.btnGoBackSec.Name = "btnGoBackSec";
            this.btnGoBackSec.Size = new System.Drawing.Size(92, 36);
            this.btnGoBackSec.TabIndex = 1;
            this.btnGoBackSec.Text = "חזרה";
            this.btnGoBackSec.UseVisualStyleBackColor = true;
            this.btnGoBackSec.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // JobSendingTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 206);
            this.Controls.Add(this.grpBoxIterationDate);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnGoBackSec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "JobSendingTracer";
            this.Text = "מעקב אחרי מספר החזרות";
            this.grpBoxIterationDate.ResumeLayout(false);
            this.grpBoxIterationDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBackSec;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblIteration;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.GroupBox grpBoxIterationDate;
    }
}