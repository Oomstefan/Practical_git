namespace Git_prac
{
    partial class Jean_MeanCalc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnr = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRands = new System.Windows.Forms.Label();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnr);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 88);
            this.panel1.TabIndex = 0;
            // 
            // txtnr
            // 
            this.txtnr.Location = new System.Drawing.Point(179, 21);
            this.txtnr.Name = "txtnr";
            this.txtnr.Size = new System.Drawing.Size(45, 20);
            this.txtnr.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(461, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 264);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selcect number between 5 and 25";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblRands);
            this.panel3.Location = new System.Drawing.Point(12, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 54);
            this.panel3.TabIndex = 2;
            // 
            // lblRands
            // 
            this.lblRands.AutoSize = true;
            this.lblRands.Location = new System.Drawing.Point(3, 20);
            this.lblRands.Name = "lblRands";
            this.lblRands.Size = new System.Drawing.Size(0, 13);
            this.lblRands.TabIndex = 0;
            // 
            // btnMean
            // 
            this.btnMean.Location = new System.Drawing.Point(12, 237);
            this.btnMean.Name = "btnMean";
            this.btnMean.Size = new System.Drawing.Size(100, 23);
            this.btnMean.TabIndex = 3;
            this.btnMean.Text = "Calculate mean";
            this.btnMean.UseVisualStyleBackColor = true;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(179, 47);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(45, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Jean_MeanCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 307);
            this.Controls.Add(this.btnMean);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Jean_MeanCalc";
            this.Text = "Jean_MeanCalc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtnr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRands;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnMean;
    }
}