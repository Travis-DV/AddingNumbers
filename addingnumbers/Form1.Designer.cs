namespace addingnumbers
{
    partial class Form1
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
            this.outputLB = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.inputLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLB
            // 
            this.outputLB.AutoSize = true;
            this.outputLB.Location = new System.Drawing.Point(12, 81);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(135, 25);
            this.outputLB.TabIndex = 0;
            this.outputLB.Text = "The sum was:";
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(17, 37);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(100, 29);
            this.inputTB.TabIndex = 1;
            this.inputTB.TextChanged += new System.EventHandler(this.inputTB_TextChanged);
            // 
            // inputLB
            // 
            this.inputLB.AutoSize = true;
            this.inputLB.Location = new System.Drawing.Point(12, 9);
            this.inputLB.Name = "inputLB";
            this.inputLB.Size = new System.Drawing.Size(397, 25);
            this.inputLB.TabIndex = 2;
            this.inputLB.Text = "Input  numbers with a comma between them.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 376);
            this.Controls.Add(this.inputLB);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.outputLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLB;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label inputLB;
    }
}

