namespace yourFirstApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_helloUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_helloUser
            // 
            this.lbl_helloUser.AutoSize = true;
            this.lbl_helloUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_helloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_helloUser.Location = new System.Drawing.Point(0, 0);
            this.lbl_helloUser.Margin = new System.Windows.Forms.Padding(10);
            this.lbl_helloUser.MaximumSize = new System.Drawing.Size(620, 460);
            this.lbl_helloUser.Name = "lbl_helloUser";
            this.lbl_helloUser.Size = new System.Drawing.Size(97, 52);
            this.lbl_helloUser.TabIndex = 0;
            this.lbl_helloUser.Text = "test";
            this.lbl_helloUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.lbl_helloUser);
            this.Name = "Form1";
            this.Text = "Your first C# App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_helloUser;
    }
}

