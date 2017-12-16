namespace ToolsKit
{
    partial class IterationForm
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblIterationsToGo = new System.Windows.Forms.Label();
            this.lblIterations = new System.Windows.Forms.Label();
            this.grpIterations = new System.Windows.Forms.GroupBox();
            this.lblLastUpdateTime = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.grpIterations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNext.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnNext.Location = new System.Drawing.Point(254, 144);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(198, 61);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = " <<   קדימה";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(12, 144);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(198, 61);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "אחורה   >>";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::ToolsKit.Properties.Resources._1580321;
            this.btnReset.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.Snow;
            this.btnReset.Location = new System.Drawing.Point(174, 237);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 53);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "איפוס";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblIterationsToGo
            // 
            this.lblIterationsToGo.AutoSize = true;
            this.lblIterationsToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIterationsToGo.Location = new System.Drawing.Point(130, 21);
            this.lblIterationsToGo.Name = "lblIterationsToGo";
            this.lblIterationsToGo.Size = new System.Drawing.Size(296, 33);
            this.lblIterationsToGo.TabIndex = 5;
            this.lblIterationsToGo.Text = ": מספר החזרות שנותרו";
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIterations.Location = new System.Drawing.Point(43, 16);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(37, 41);
            this.lblIterations.TabIndex = 6;
            this.lblIterations.Text = "2";
            // 
            // grpIterations
            // 
            this.grpIterations.Controls.Add(this.lblLastUpdateTime);
            this.grpIterations.Controls.Add(this.lblLastUpdate);
            this.grpIterations.Controls.Add(this.lblIterationsToGo);
            this.grpIterations.Controls.Add(this.lblIterations);
            this.grpIterations.Location = new System.Drawing.Point(12, 12);
            this.grpIterations.Name = "grpIterations";
            this.grpIterations.Size = new System.Drawing.Size(440, 117);
            this.grpIterations.TabIndex = 7;
            this.grpIterations.TabStop = false;
            // 
            // lblLastUpdateTime
            // 
            this.lblLastUpdateTime.AutoSize = true;
            this.lblLastUpdateTime.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastUpdateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLastUpdateTime.Location = new System.Drawing.Point(16, 67);
            this.lblLastUpdateTime.Name = "lblLastUpdateTime";
            this.lblLastUpdateTime.Size = new System.Drawing.Size(0, 41);
            this.lblLastUpdateTime.TabIndex = 8;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastUpdate.Location = new System.Drawing.Point(240, 67);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(186, 33);
            this.lblLastUpdate.TabIndex = 7;
            this.lblLastUpdate.Text = ": עדכון אחרון";
            // 
            // IterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 301);
            this.Controls.Add(this.grpIterations);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IterationForm";
            this.Text = "מעקב אחרי מספר החזרות";
            this.grpIterations.ResumeLayout(false);
            this.grpIterations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblIterationsToGo;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.GroupBox grpIterations;
        private System.Windows.Forms.Label lblLastUpdateTime;
        private System.Windows.Forms.Label lblLastUpdate;
    }
}