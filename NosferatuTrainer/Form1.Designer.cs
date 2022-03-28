namespace NosferatuTrainer
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
            this.checkBoxAmmo = new System.Windows.Forms.CheckBox();
            this.checkBoxHealth = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxAmmo
            // 
            this.checkBoxAmmo.AutoSize = true;
            this.checkBoxAmmo.Location = new System.Drawing.Point(49, 43);
            this.checkBoxAmmo.Name = "checkBoxAmmo";
            this.checkBoxAmmo.Size = new System.Drawing.Size(101, 17);
            this.checkBoxAmmo.TabIndex = 0;
            this.checkBoxAmmo.Text = "Unlimited Ammo";
            this.checkBoxAmmo.UseVisualStyleBackColor = true;
            // 
            // checkBoxHealth
            // 
            this.checkBoxHealth.AutoSize = true;
            this.checkBoxHealth.Location = new System.Drawing.Point(231, 43);
            this.checkBoxHealth.Name = "checkBoxHealth";
            this.checkBoxHealth.Size = new System.Drawing.Size(103, 17);
            this.checkBoxHealth.TabIndex = 1;
            this.checkBoxHealth.Text = "Unlimited Health";
            this.checkBoxHealth.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 198);
            this.Controls.Add(this.checkBoxHealth);
            this.Controls.Add(this.checkBoxAmmo);
            this.Name = "Form1";
            this.Text = "Nosferatu Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAmmo;
        private System.Windows.Forms.CheckBox checkBoxHealth;
    }
}

