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
            this.CheckBoxAmmo = new System.Windows.Forms.CheckBox();
            this.CheckBoxHealth = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxEnableTrainer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBoxStamina = new System.Windows.Forms.CheckBox();
            this.CheckBoxAville = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonResetClock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBoxEnableAll = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckBoxEnableDeathInOneHit = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipAville = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExtraHardMode = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUnlimitedAmmo = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipResetClock = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CheckBoxAmmo
            // 
            this.CheckBoxAmmo.AutoSize = true;
            this.CheckBoxAmmo.Location = new System.Drawing.Point(77, 112);
            this.CheckBoxAmmo.Name = "CheckBoxAmmo";
            this.CheckBoxAmmo.Size = new System.Drawing.Size(100, 17);
            this.CheckBoxAmmo.TabIndex = 0;
            this.CheckBoxAmmo.Text = "Unlimited ammo";
            this.toolTipUnlimitedAmmo.SetToolTip(this.CheckBoxAmmo, "except for Wooden Stakes");
            this.CheckBoxAmmo.UseVisualStyleBackColor = true;
            this.CheckBoxAmmo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBoxes_KeyDown);
            // 
            // CheckBoxHealth
            // 
            this.CheckBoxHealth.AutoSize = true;
            this.CheckBoxHealth.Location = new System.Drawing.Point(77, 134);
            this.CheckBoxHealth.Name = "CheckBoxHealth";
            this.CheckBoxHealth.Size = new System.Drawing.Size(101, 17);
            this.CheckBoxHealth.TabIndex = 1;
            this.CheckBoxHealth.Text = "Unlimited health";
            this.CheckBoxHealth.UseVisualStyleBackColor = true;
            this.CheckBoxHealth.CheckedChanged += new System.EventHandler(this.CheckBoxHealth_CheckedChanged);
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
            // CheckBoxEnableTrainer
            // 
            this.CheckBoxEnableTrainer.AutoSize = true;
            this.CheckBoxEnableTrainer.Location = new System.Drawing.Point(77, 9);
            this.CheckBoxEnableTrainer.Name = "CheckBoxEnableTrainer";
            this.CheckBoxEnableTrainer.Size = new System.Drawing.Size(91, 17);
            this.CheckBoxEnableTrainer.TabIndex = 5;
            this.CheckBoxEnableTrainer.Text = "Enable trainer";
            this.CheckBoxEnableTrainer.UseVisualStyleBackColor = true;
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
            // CheckBoxStamina
            // 
            this.CheckBoxStamina.AutoSize = true;
            this.CheckBoxStamina.Location = new System.Drawing.Point(77, 156);
            this.CheckBoxStamina.Name = "CheckBoxStamina";
            this.CheckBoxStamina.Size = new System.Drawing.Size(108, 17);
            this.CheckBoxStamina.TabIndex = 8;
            this.CheckBoxStamina.Text = "Unlimited stamina";
            this.CheckBoxStamina.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAville
            // 
            this.CheckBoxAville.AutoSize = true;
            this.CheckBoxAville.Location = new System.Drawing.Point(77, 91);
            this.CheckBoxAville.Name = "CheckBoxAville";
            this.CheckBoxAville.Size = new System.Drawing.Size(89, 17);
            this.CheckBoxAville.TabIndex = 9;
            this.CheckBoxAville.Text = "Kill Pastewka";
            this.toolTipAville.SetToolTip(this.CheckBoxAville, "meaning Father Aville");
            this.CheckBoxAville.UseVisualStyleBackColor = true;
            this.CheckBoxAville.CheckedChanged += new System.EventHandler(this.CheckBoxAville_CheckedChanged);
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
            // ButtonResetClock
            // 
            this.ButtonResetClock.Location = new System.Drawing.Point(269, 152);
            this.ButtonResetClock.Name = "ButtonResetClock";
            this.ButtonResetClock.Size = new System.Drawing.Size(75, 23);
            this.ButtonResetClock.TabIndex = 11;
            this.ButtonResetClock.Text = "Reset clock";
            this.toolTipResetClock.SetToolTip(this.ButtonResetClock, "Resets clock to 22:30:00 (starting time)\r\n");
            this.ButtonResetClock.UseVisualStyleBackColor = true;
            this.ButtonResetClock.Click += new System.EventHandler(this.ButtonResetClock_Click);
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
            // CheckBoxEnableAll
            // 
            this.CheckBoxEnableAll.AutoSize = true;
            this.CheckBoxEnableAll.Location = new System.Drawing.Point(269, 9);
            this.CheckBoxEnableAll.Name = "CheckBoxEnableAll";
            this.CheckBoxEnableAll.Size = new System.Drawing.Size(111, 17);
            this.CheckBoxEnableAll.TabIndex = 13;
            this.CheckBoxEnableAll.Text = "Enable everything";
            this.CheckBoxEnableAll.UseVisualStyleBackColor = true;
            this.CheckBoxEnableAll.CheckedChanged += new System.EventHandler(this.CheckBoxEnableAll_CheckedChanged);
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
            // CheckBoxEnableDeathInOneHit
            // 
            this.CheckBoxEnableDeathInOneHit.AutoSize = true;
            this.CheckBoxEnableDeathInOneHit.Location = new System.Drawing.Point(77, 32);
            this.CheckBoxEnableDeathInOneHit.Name = "CheckBoxEnableDeathInOneHit";
            this.CheckBoxEnableDeathInOneHit.Size = new System.Drawing.Size(135, 17);
            this.CheckBoxEnableDeathInOneHit.TabIndex = 15;
            this.CheckBoxEnableDeathInOneHit.Text = "Enable death in one hit";
            this.toolTipExtraHardMode.SetToolTip(this.CheckBoxEnableDeathInOneHit, "You die in one hit");
            this.CheckBoxEnableDeathInOneHit.UseVisualStyleBackColor = true;
            this.CheckBoxEnableDeathInOneHit.CheckedChanged += new System.EventHandler(this.CheckBoxEnableDeathInOneHit_CheckedChanged);
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
            this.Controls.Add(this.CheckBoxEnableDeathInOneHit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckBoxEnableAll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonResetClock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckBoxAville);
            this.Controls.Add(this.CheckBoxStamina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckBoxEnableTrainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxHealth);
            this.Controls.Add(this.CheckBoxAmmo);
            this.Name = "MainWindow";
            this.Text = "Nosferatu Trainer";
            this.Load += new System.EventHandler(this.TrainerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBoxAmmo;
        private System.Windows.Forms.CheckBox CheckBoxHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxEnableTrainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBoxStamina;
        private System.Windows.Forms.CheckBox CheckBoxAville;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonResetClock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckBoxEnableAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CheckBoxEnableDeathInOneHit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipAville;
        private System.Windows.Forms.ToolTip toolTipExtraHardMode;
        private System.Windows.Forms.ToolTip toolTipUnlimitedAmmo;
        private System.Windows.Forms.ToolTip toolTipResetClock;
    }
}

