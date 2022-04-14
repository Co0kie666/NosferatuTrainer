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
            this.components = new System.ComponentModel.Container();
            this.checkBoxAmmo = new System.Windows.Forms.CheckBox();
            this.checkBoxHealth = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEnableTrainer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxStamina = new System.Windows.Forms.CheckBox();
            this.checkBoxAville = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonResetClock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxEnableAll = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxEnableDeathInOneHit = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipAville = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExtraHardMode = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUnlimitedAmmo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipResetClock = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // checkBoxAmmo
            // 
            this.checkBoxAmmo.AutoSize = true;
            this.checkBoxAmmo.Location = new System.Drawing.Point(77, 112);
            this.checkBoxAmmo.Name = "checkBoxAmmo";
            this.checkBoxAmmo.Size = new System.Drawing.Size(100, 17);
            this.checkBoxAmmo.TabIndex = 0;
            this.checkBoxAmmo.Text = "Unlimited ammo";
            this.toolTipUnlimitedAmmo.SetToolTip(this.checkBoxAmmo, "except for Wooden Stakes");
            this.checkBoxAmmo.UseVisualStyleBackColor = true;
            this.checkBoxAmmo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxes_KeyDown);
            // 
            // checkBoxHealth
            // 
            this.checkBoxHealth.AutoSize = true;
            this.checkBoxHealth.Location = new System.Drawing.Point(77, 134);
            this.checkBoxHealth.Name = "checkBoxHealth";
            this.checkBoxHealth.Size = new System.Drawing.Size(101, 17);
            this.checkBoxHealth.TabIndex = 1;
            this.checkBoxHealth.Text = "Unlimited health";
            this.checkBoxHealth.UseVisualStyleBackColor = true;
            this.checkBoxHealth.CheckedChanged += new System.EventHandler(this.checkBoxHealth_CheckedChanged);
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
            this.checkBoxEnableTrainer.Size = new System.Drawing.Size(91, 17);
            this.checkBoxEnableTrainer.TabIndex = 5;
            this.checkBoxEnableTrainer.Text = "Enable trainer";
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
            this.checkBoxStamina.Size = new System.Drawing.Size(108, 17);
            this.checkBoxStamina.TabIndex = 8;
            this.checkBoxStamina.Text = "Unlimited stamina";
            this.checkBoxStamina.UseVisualStyleBackColor = true;
            // 
            // checkBoxAville
            // 
            this.checkBoxAville.AutoSize = true;
            this.checkBoxAville.Location = new System.Drawing.Point(77, 91);
            this.checkBoxAville.Name = "checkBoxAville";
            this.checkBoxAville.Size = new System.Drawing.Size(89, 17);
            this.checkBoxAville.TabIndex = 9;
            this.checkBoxAville.Text = "Kill Pastewka";
            this.toolTipAville.SetToolTip(this.checkBoxAville, "meaning Father Aville");
            this.checkBoxAville.UseVisualStyleBackColor = true;
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
            this.buttonResetClock.Location = new System.Drawing.Point(269, 152);
            this.buttonResetClock.Name = "buttonResetClock";
            this.buttonResetClock.Size = new System.Drawing.Size(75, 23);
            this.buttonResetClock.TabIndex = 11;
            this.buttonResetClock.Text = "Reset clock";
            this.toolTipResetClock.SetToolTip(this.buttonResetClock, "Resets clock to 22:30:00 (starting time)\r\n");
            this.buttonResetClock.UseVisualStyleBackColor = true;
            this.buttonResetClock.Click += new System.EventHandler(this.buttonResetClock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Numpad 5:";
            // 
            // checkBoxEnableAll
            // 
            this.checkBoxEnableAll.AutoSize = true;
            this.checkBoxEnableAll.Location = new System.Drawing.Point(269, 9);
            this.checkBoxEnableAll.Name = "checkBoxEnableAll";
            this.checkBoxEnableAll.Size = new System.Drawing.Size(111, 17);
            this.checkBoxEnableAll.TabIndex = 13;
            this.checkBoxEnableAll.Text = "Enable everything";
            this.checkBoxEnableAll.UseVisualStyleBackColor = true;
            this.checkBoxEnableAll.CheckedChanged += new System.EventHandler(this.checkBoxEnableAll_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numpad 1:";
            // 
            // checkBoxEnableDeathInOneHit
            // 
            this.checkBoxEnableDeathInOneHit.AutoSize = true;
            this.checkBoxEnableDeathInOneHit.Location = new System.Drawing.Point(77, 32);
            this.checkBoxEnableDeathInOneHit.Name = "checkBoxEnableDeathInOneHit";
            this.checkBoxEnableDeathInOneHit.Size = new System.Drawing.Size(135, 17);
            this.checkBoxEnableDeathInOneHit.TabIndex = 15;
            this.checkBoxEnableDeathInOneHit.Text = "Enable death in one hit";
            this.toolTipExtraHardMode.SetToolTip(this.checkBoxEnableDeathInOneHit, "You die in one hit");
            this.checkBoxEnableDeathInOneHit.UseVisualStyleBackColor = true;
            this.checkBoxEnableDeathInOneHit.CheckedChanged += new System.EventHandler(this.checkBoxEnableDeathInOneHit_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Numpad 2:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 198);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxEnableDeathInOneHit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxEnableAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonResetClock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxAville);
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
        private System.Windows.Forms.CheckBox checkBoxAville;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonResetClock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxEnableAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxEnableDeathInOneHit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipAville;
        private System.Windows.Forms.ToolTip toolTipExtraHardMode;
        private System.Windows.Forms.ToolTip toolTipUnlimitedAmmo;
        private System.Windows.Forms.ToolTip toolTipResetClock;
    }
}

