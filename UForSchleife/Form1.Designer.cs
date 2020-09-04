namespace UForSchleife
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
            this.CmdSchleife1 = new System.Windows.Forms.Button();
            this.LblSchleife1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdSchleife1
            // 
            this.CmdSchleife1.Location = new System.Drawing.Point(616, 64);
            this.CmdSchleife1.Name = "CmdSchleife1";
            this.CmdSchleife1.Size = new System.Drawing.Size(126, 46);
            this.CmdSchleife1.TabIndex = 0;
            this.CmdSchleife1.Text = "Schleife 1";
            this.CmdSchleife1.UseVisualStyleBackColor = true;
            this.CmdSchleife1.Click += new System.EventHandler(this.CmdSchleife1_Click);
            // 
            // LblSchleife1
            // 
            this.LblSchleife1.AutoSize = true;
            this.LblSchleife1.Location = new System.Drawing.Point(59, 75);
            this.LblSchleife1.Name = "LblSchleife1";
            this.LblSchleife1.Size = new System.Drawing.Size(0, 25);
            this.LblSchleife1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblSchleife1);
            this.Controls.Add(this.CmdSchleife1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSchleife1;
        private System.Windows.Forms.Label LblSchleife1;
    }
}

