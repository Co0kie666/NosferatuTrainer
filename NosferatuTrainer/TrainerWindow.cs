using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Memory;
using System.Threading;

namespace NosferatuTrainer
{
    public partial class MainWindow : Form
    {
        Mem mem = new Mem();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TrainerWindow_Load(object sender, EventArgs e)
        {
            // CheckForIllegalCrossThreadCalls = false;

            int PID = mem.GetProcIdFromName("Nosferatu");

            if (PID > 0)
            {
                mem.OpenProcess(PID);

                Thread TH = new Thread(WriteMemory);
                TH.Start();
            }

            else
            {
                Application.Exit(); // Nosferatu needs to be running otherwise nothing will happen when the trainer is launched.
            }
        }

        private void WriteMemory()
        {            
            while (true)
            {
                if (this.CheckBoxEnableTrainer.Checked)
                {
                    if (this.CheckBoxAmmo.Checked)
                    {
                        this.SetAmmo(9999); // Unlimited Ammo
                    }
                    if (this.CheckBoxHealth.Checked && !this.CheckBoxEnableDeathInOneHit.Checked)
                    {
                        this.SetHealth(100); // Unlimited Health
                    }
                    if (this.CheckBoxStamina.Checked)
                    {
                        this.SetStamina(1); // Unlimited Stamina
                    }
                    if (this.CheckBoxAville.Checked)
                    {
                        this.KillAville(); // Father Aville immediately dies when he jumpes out of the window
                    }
                    if (this.CheckBoxEnableDeathInOneHit.Checked && !this.CheckBoxHealth.Checked)
                    {
                        this.SetHealth(1); // Player dies in one hit
                    }
                    Thread.Sleep(50);
                }      
            }
        }

        #region Trainer Options

        private void SetAmmo(int ammoValue)
        {
            // "Nosferatu.exe"+0014A1EC
            mem.WriteMemory("Nosferatu.exe+0x0014A1EC,40,14C,158,8,35C,310", "int", ammoValue.ToString()); // Set loaded ammo for the currently equipped weapon
        }

        private void SetHealth(int healthValue)
        {
            // "Nosferatu.exe"+0014A1EC
            mem.WriteMemory("Nosferatu.exe+0x0014A1EC,D68,14C,398,158,4,14C,3C0", "float", healthValue.ToString()); // Set health
        }

        private void SetStamina(int staminaValue)
        {
            // "Nosferatu.exe"+0014C09C
            mem.WriteMemory("Nosferatu.exe+0x0014C09C,A0,1D4,38,14,38,3B0", "float", staminaValue.ToString()); // Set Stamina
        }

        private void KillAville()
        {
            // "Nosferatu.exe"+0014C09C
            mem.WriteMemory("Nosferatu.exe+0x0014C09C,44,14C,14C,14C,3B0,C, 3C0", "float", "-1"); // Kills Father Aville when he jumps out of the window
                                                                                                 
        }

        private void ResetClock()
        {
            // "Nosferatu.exe"+14BF6C
            mem.WriteMemory("Nosferatu.exe+0x14BF6C", "int", "0"); // Game clock gets reset to 22:30:00 (starting time)
                                                                   // int value does not matter, reset is always to 22:30:00
        }

        #endregion

        #region Inputs
        private void checkBoxes_KeyDown(object sender, KeyEventArgs e) // Input detection is NOT global, game window needs to be selected 
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                this.CheckBoxEnableTrainer.Checked = !this.CheckBoxEnableTrainer.Checked;
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                this.CheckBoxEnableAll.Checked = !this.CheckBoxEnableAll.Checked;
                this.ToggleAllOptions();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                this.CheckBoxEnableDeathInOneHit.Checked = !this.CheckBoxEnableDeathInOneHit.Checked;
            }      
            if (e.KeyCode == Keys.NumPad5)
            {
                if (this.CheckBoxEnableTrainer.Checked)
                {
                    this.ResetClock();
                }
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                this.CheckBoxAville.Checked = !this.CheckBoxAville.Checked;
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                this.CheckBoxAmmo.Checked = !this.CheckBoxAmmo.Checked;
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                this.CheckBoxHealth.Checked = !this.CheckBoxHealth.Checked;
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                this.CheckBoxStamina.Checked = !this.CheckBoxStamina.Checked;
            }
        }
        #endregion

        //private int getInitialAmmo()
        //{
        //    return mem.ReadInt("Nosferatu.exe+0x0014A1EC,40,14C,158,8,35C,310");
        //}

        private void ToggleAllOptions()
        {
            if (this.CheckBoxEnableAll.Checked)
            {
                this.CheckBoxAmmo.Checked = true;
                this.CheckBoxHealth.Checked = true;
                this.CheckBoxStamina.Checked = true;
                this.CheckBoxAville.Checked = true;
            }

            else if (this.CheckBoxEnableAll.Checked == false)
            {
                this.CheckBoxAmmo.Checked = false;
                this.CheckBoxHealth.Checked = false;
                this.CheckBoxStamina.Checked = false;
                this.CheckBoxAville.Checked = false;
            }
        }

        private void ButtonResetClock_Click(object sender, EventArgs e)
        {
            this.ResetClock();
        }

        private void CheckBoxEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            this.ToggleAllOptions();
        }

        private void CheckBoxHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxHealth.Checked == this.CheckBoxEnableDeathInOneHit.Checked)
            {
                this.CheckBoxEnableDeathInOneHit.Checked = false;
            }
        }

        private void CheckBoxEnableDeathInOneHit_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxHealth.Checked == this.CheckBoxEnableDeathInOneHit.Checked)
            {
                this.CheckBoxHealth.Checked = false;
            }
        }

        // Jump height?
        // Movement speed?
    }
}
