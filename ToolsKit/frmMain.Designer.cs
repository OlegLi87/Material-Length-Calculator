namespace ToolsKit
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblChooseTool = new System.Windows.Forms.Label();
            this.cmbToolsList = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSelectTool = new System.Windows.Forms.GroupBox();
            this.lblRightsReserved = new System.Windows.Forms.Label();
            this.grpSelectTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChooseTool
            // 
            this.lblChooseTool.AutoSize = true;
            this.lblChooseTool.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblChooseTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseTool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChooseTool.Location = new System.Drawing.Point(228, 19);
            this.lblChooseTool.Name = "lblChooseTool";
            this.lblChooseTool.Size = new System.Drawing.Size(142, 25);
            this.lblChooseTool.TabIndex = 0;
            this.lblChooseTool.Text = "רשימת הכלים";
            // 
            // cmbToolsList
            // 
            this.cmbToolsList.BackColor = System.Drawing.Color.White;
            this.cmbToolsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToolsList.FormattingEnabled = true;
            this.cmbToolsList.Location = new System.Drawing.Point(16, 23);
            this.cmbToolsList.Name = "cmbToolsList";
            this.cmbToolsList.Size = new System.Drawing.Size(172, 21);
            this.cmbToolsList.TabIndex = 1;
            this.cmbToolsList.SelectedIndexChanged += new System.EventHandler(this.cmbToolsList_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSelect.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(255, 100);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(135, 42);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "הפעל כלי";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(12, 100);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "סגור תוכנה";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpSelectTool
            // 
            this.grpSelectTool.BackColor = System.Drawing.SystemColors.Control;
            this.grpSelectTool.Controls.Add(this.cmbToolsList);
            this.grpSelectTool.Controls.Add(this.lblChooseTool);
            this.grpSelectTool.Location = new System.Drawing.Point(12, 12);
            this.grpSelectTool.Name = "grpSelectTool";
            this.grpSelectTool.Size = new System.Drawing.Size(378, 62);
            this.grpSelectTool.TabIndex = 4;
            this.grpSelectTool.TabStop = false;
            this.grpSelectTool.Text = "בחר כלי";
            // 
            // lblRightsReserved
            // 
            this.lblRightsReserved.AutoSize = true;
            this.lblRightsReserved.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRightsReserved.Location = new System.Drawing.Point(240, 189);
            this.lblRightsReserved.Name = "lblRightsReserved";
            this.lblRightsReserved.Size = new System.Drawing.Size(163, 13);
            this.lblRightsReserved.TabIndex = 5;
            this.lblRightsReserved.Text = "All Rights Reserved To Oleg Livcha";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(402, 204);
            this.Controls.Add(this.lblRightsReserved);
            this.Controls.Add(this.grpSelectTool);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "חלון בחירה";
            this.grpSelectTool.ResumeLayout(false);
            this.grpSelectTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseTool;
        private System.Windows.Forms.ComboBox cmbToolsList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpSelectTool;
        private System.Windows.Forms.Label lblRightsReserved;
    }
}

