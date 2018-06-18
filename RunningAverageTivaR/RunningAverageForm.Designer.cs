namespace RunningAverageTivaR
{
    partial class frmRunningAverage
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
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblTheAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(126, 147);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(141, 23);
            this.btnCalculateAverage.TabIndex = 0;
            this.btnCalculateAverage.Text = "CalculateAverage";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(65, 52);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(136, 13);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Enter a number for 0 to 100";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(290, 52);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 2;
            // 
            // lblTheAverage
            // 
            this.lblTheAverage.AutoSize = true;
            this.lblTheAverage.Location = new System.Drawing.Point(103, 217);
            this.lblTheAverage.Name = "lblTheAverage";
            this.lblTheAverage.Size = new System.Drawing.Size(35, 13);
            this.lblTheAverage.TabIndex = 3;
            this.lblTheAverage.Text = "label1";
            this.lblTheAverage.Visible = false;
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 346);
            this.Controls.Add(this.lblTheAverage);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnCalculateAverage);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label lblTheAverage;
    }
}

