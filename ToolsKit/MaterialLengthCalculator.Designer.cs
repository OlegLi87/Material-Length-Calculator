namespace ToolsKit
{
    partial class MaterialLengthCalculator
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
            this.lblOuterDim = new System.Windows.Forms.Label();
            this.lblInnerDim = new System.Windows.Forms.Label();
            this.lblMatThickness = new System.Windows.Forms.Label();
            this.txtOuterDim = new System.Windows.Forms.TextBox();
            this.txtInnerDim = new System.Windows.Forms.TextBox();
            this.txtMatThickness = new System.Windows.Forms.TextBox();
            this.grpDimensions = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.grpDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOuterDim
            // 
            this.lblOuterDim.AutoSize = true;
            this.lblOuterDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOuterDim.ForeColor = System.Drawing.Color.Black;
            this.lblOuterDim.Location = new System.Drawing.Point(146, 30);
            this.lblOuterDim.Name = "lblOuterDim";
            this.lblOuterDim.Size = new System.Drawing.Size(125, 25);
            this.lblOuterDim.TabIndex = 1;
            this.lblOuterDim.Text = "קוטר חיצוני";
            // 
            // lblInnerDim
            // 
            this.lblInnerDim.AutoSize = true;
            this.lblInnerDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInnerDim.ForeColor = System.Drawing.Color.Black;
            this.lblInnerDim.Location = new System.Drawing.Point(154, 107);
            this.lblInnerDim.Name = "lblInnerDim";
            this.lblInnerDim.Size = new System.Drawing.Size(117, 25);
            this.lblInnerDim.TabIndex = 2;
            this.lblInnerDim.Text = "קוטר פנימי";
            // 
            // lblMatThickness
            // 
            this.lblMatThickness.AutoSize = true;
            this.lblMatThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMatThickness.ForeColor = System.Drawing.Color.Black;
            this.lblMatThickness.Location = new System.Drawing.Point(160, 187);
            this.lblMatThickness.Name = "lblMatThickness";
            this.lblMatThickness.Size = new System.Drawing.Size(110, 25);
            this.lblMatThickness.TabIndex = 3;
            this.lblMatThickness.Text = "עובי חומר";
            // 
            // txtOuterDim
            // 
            this.txtOuterDim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOuterDim.Location = new System.Drawing.Point(18, 63);
            this.txtOuterDim.Name = "txtOuterDim";
            this.txtOuterDim.Size = new System.Drawing.Size(256, 26);
            this.txtOuterDim.TabIndex = 4;
            this.txtOuterDim.Tag = "...הכנס מידה";
            this.txtOuterDim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOuterDim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtOuterDim_MouseClick);
            // 
            // txtInnerDim
            // 
            this.txtInnerDim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInnerDim.Location = new System.Drawing.Point(18, 140);
            this.txtInnerDim.Name = "txtInnerDim";
            this.txtInnerDim.Size = new System.Drawing.Size(256, 26);
            this.txtInnerDim.TabIndex = 5;
            this.txtInnerDim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInnerDim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtInnerDim_MouseClick);
            // 
            // txtMatThickness
            // 
            this.txtMatThickness.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMatThickness.Location = new System.Drawing.Point(18, 220);
            this.txtMatThickness.Name = "txtMatThickness";
            this.txtMatThickness.Size = new System.Drawing.Size(256, 26);
            this.txtMatThickness.TabIndex = 6;
            this.txtMatThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMatThickness.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMatThickness_MouseClick);
            // 
            // grpDimensions
            // 
            this.grpDimensions.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpDimensions.Controls.Add(this.lblOuterDim);
            this.grpDimensions.Controls.Add(this.txtMatThickness);
            this.grpDimensions.Controls.Add(this.txtOuterDim);
            this.grpDimensions.Controls.Add(this.lblMatThickness);
            this.grpDimensions.Controls.Add(this.txtInnerDim);
            this.grpDimensions.Controls.Add(this.lblInnerDim);
            this.grpDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpDimensions.ForeColor = System.Drawing.Color.White;
            this.grpDimensions.Location = new System.Drawing.Point(29, 152);
            this.grpDimensions.Name = "grpDimensions";
            this.grpDimensions.Size = new System.Drawing.Size(290, 276);
            this.grpDimensions.TabIndex = 7;
            this.grpDimensions.TabStop = false;
            this.grpDimensions.Text = "הכנס נתונים";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackgroundImage = global::ToolsKit.Properties.Resources._1969936;
            this.btnCalculate.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Snow;
            this.btnCalculate.Location = new System.Drawing.Point(227, 459);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 36);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "חשב";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToolsKit.Properties.Resources.Diameters;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 119);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackgroundImage = global::ToolsKit.Properties.Resources._1580321;
            this.btnGoBack.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoBack.ForeColor = System.Drawing.Color.Snow;
            this.btnGoBack.Location = new System.Drawing.Point(29, 459);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(92, 36);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "חזרה";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // MaterialLengthCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToolsKit.Properties.Resources._9Z7AnV;
            this.ClientSize = new System.Drawing.Size(347, 516);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpDimensions);
            this.Controls.Add(this.btnGoBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MaterialLengthCalculator";
            this.Text = "מחשבון לחישוב אורך החומר";
            this.grpDimensions.ResumeLayout(false);
            this.grpDimensions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblOuterDim;
        private System.Windows.Forms.Label lblInnerDim;
        private System.Windows.Forms.Label lblMatThickness;
        private System.Windows.Forms.TextBox txtOuterDim;
        private System.Windows.Forms.TextBox txtInnerDim;
        private System.Windows.Forms.TextBox txtMatThickness;
        private System.Windows.Forms.GroupBox grpDimensions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalculate;
    }
}