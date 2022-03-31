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
            this.checkBoxEnableTrainer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxStamina = new System.Windows.Forms.CheckBox();
            this.checkBoxPastewka = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonResetClock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxAmmo
            // 
            this.checkBoxAmmo.AutoSize = true;
            this.checkBoxAmmo.Location = new System.Drawing.Point(77, 112);
            this.checkBoxAmmo.Name = "checkBoxAmmo";
            this.checkBoxAmmo.Size = new System.Drawing.Size(101, 17);
            this.checkBoxAmmo.TabIndex = 0;
            this.checkBoxAmmo.Text = "Unlimited Ammo";
            this.checkBoxAmmo.UseVisualStyleBackColor = true;
            this.checkBoxAmmo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxes_KeyDown);
            // 
            // checkBoxHealth
            // 
            this.checkBoxHealth.AutoSize = true;
            this.checkBoxHealth.Location = new System.Drawing.Point(77, 134);
            this.checkBoxHealth.Name = "checkBoxHealth";
            this.checkBoxHealth.Size = new System.Drawing.Size(103, 17);
            this.checkBoxHealth.TabIndex = 1;
            this.checkBoxHealth.Text = "Unlimited Health";
            this.checkBoxHealth.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numpad 7:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numpad 8:";
            // 
            // checkBoxEnableTrainer
            // 
            this.checkBoxEnableTrainer.AutoSize = true;
            this.checkBoxEnableTrainer.Location = new System.Drawing.Point(77, 9);
            this.checkBoxEnableTrainer.Name = "checkBoxEnableTrainer";
            this.checkBoxEnableTrainer.Size = new System.Drawing.Size(95, 17);
            this.checkBoxEnableTrainer.TabIndex = 5;
            this.checkBoxEnableTrainer.Text = "Enable Trainer";
            this.checkBoxEnableTrainer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numpad 0:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numpad 9:";
            // 
            // checkBoxStamina
            // 
            this.checkBoxStamina.AutoSize = true;
            this.checkBoxStamina.Location = new System.Drawing.Point(77, 156);
            this.checkBoxStamina.Name = "checkBoxStamina";
            this.checkBoxStamina.Size = new System.Drawing.Size(110, 17);
            this.checkBoxStamina.TabIndex = 8;
            this.checkBoxStamina.Text = "Unlimited Stamina";
            this.checkBoxStamina.UseVisualStyleBackColor = true;
            // 
            // checkBoxPastewka
            // 
            this.checkBoxPastewka.AutoSize = true;
            this.checkBoxPastewka.Location = new System.Drawing.Point(77, 90);
            this.checkBoxPastewka.Name = "checkBoxPastewka";
            this.checkBoxPastewka.Size = new System.Drawing.Size(89, 17);
            this.checkBoxPastewka.TabIndex = 9;
            this.checkBoxPastewka.Text = "Kill Pastewka";
            this.checkBoxPastewka.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numpad 6:";
            // 
            // buttonResetClock
            // 
            this.buttonResetClock.Location = new System.Drawing.Point(280, 86);
            this.buttonResetClock.Name = "buttonResetClock";
            this.buttonResetClock.Size = new System.Drawing.Size(75, 23);
            this.buttonResetClock.TabIndex = 11;
            this.buttonResetClock.Text = "Reset Clock";
            this.buttonResetClock.UseVisualStyleBackColor = true;
            this.buttonResetClock.Click += new System.EventHandler(this.buttonResetClock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numpad 5:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 198);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonResetClock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxPastewka);
            this.Controls.Add(this.checkBoxStamina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxEnableTrainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxHealth);
            this.Controls.Add(this.checkBoxAmmo);
            this.Name = "MainWindow";
            this.Text = "Nosferatu Trainer";
            this.Load += new System.EventHandler(this.TrainerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAmmo;
        private System.Windows.Forms.CheckBox checkBoxHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxEnableTrainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxStamina;
        private System.Windows.Forms.CheckBox checkBoxPastewka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonResetClock;
        private System.Windows.Forms.Label label6;
    }
}

