namespace NosferatuTrainer
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxAmmo
            // 
            this.checkBoxAmmo.AutoSize = true;
            this.checkBoxAmmo.Location = new System.Drawing.Point(77, 28);
            this.checkBoxAmmo.Name = "checkBoxAmmo";
            this.checkBoxAmmo.Size = new System.Drawing.Size(101, 17);
            this.checkBoxAmmo.TabIndex = 0;
            this.checkBoxAmmo.Text = "Unlimited Ammo";
            this.checkBoxAmmo.UseVisualStyleBackColor = true;
            this.checkBoxAmmo.CheckedChanged += new System.EventHandler(this.checkBoxAmmo_CheckedChanged);
            this.checkBoxAmmo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxAmmo_KeyDown);
            // 
            // checkBoxHealth
            // 
            this.checkBoxHealth.AutoSize = true;
            this.checkBoxHealth.Location = new System.Drawing.Point(77, 56);
            this.checkBoxHealth.Name = "checkBoxHealth";
            this.checkBoxHealth.Size = new System.Drawing.Size(103, 17);
            this.checkBoxHealth.TabIndex = 1;
            this.checkBoxHealth.Text = "Unlimited Health";
            this.checkBoxHealth.UseVisualStyleBackColor = true;
            this.checkBoxHealth.CheckedChanged += new System.EventHandler(this.checkBoxHealth_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numpad 8:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numpad 9:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxHealth);
            this.Controls.Add(this.checkBoxAmmo);
            this.Name = "MainWindow";
            this.Text = "Nosferatu Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAmmo;
        private System.Windows.Forms.CheckBox checkBoxHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

