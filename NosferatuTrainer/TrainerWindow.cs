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
            CheckForIllegalCrossThreadCalls = false;

            int PID = mem.GetProcIdFromName("Nosferatu");

            if (PID > 0)
            {
                mem.OpenProcess(PID);

                Thread TH = new Thread(writeMemory);
                TH.Start();
            }

            else
            {
                Application.Exit(); // Nosferatu needs to be running otherwise nothing will happen when the trainer is launched
            }
        }

        private void writeMemory()
        {   
            while (true)
            {
                if (this.checkBoxEnableTrainer.Checked)
                {
                    if (this.checkBoxAmmo.Checked)
                    {
                        this.unlimitedAmmo();
                    }
                    if (this.checkBoxHealth.Checked && !this.checkBoxEnableExtraHardmode.Checked)
                    {
                        this.unlimitedHealth();
                    }
                    if (this.checkBoxStamina.Checked)
                    {
                        this.unlimitedStamina();   
                    }
                    if (this.checkBoxAville.Checked)
                    {
                        this.killAville();   
                    }
                    if (this.checkBoxEnableExtraHardmode.Checked && !this.checkBoxHealth.Checked)
                    {
                        this.enableExtraHardMode();
                    }
                    Thread.Sleep(50);
                }
            }
        }

        #region Trainer Options

        private void unlimitedAmmo()
        {
            // "Nosferatu.exe"+0014A1EC
            mem.WriteMemory("Nosferatu.exe+0x0014A1EC,40,14C,158,8,35C,310", "int", "9999"); // Set all ammo to a permanent 9999 
        }

        private void unlimitedHealth()
        {
            // "Nosferatu.exe"+0014A1EC
            mem.WriteMemory("Nosferatu.exe+0x0014A1EC,D68,14C,398,158,4,14C,3C0", "float", this.setPlayerHealth(100).ToString()); // Set health to a permanent 100
        }

        private void unlimitedStamina()
        {
            // "Nosferatu.exe"+0014C09C
            mem.WriteMemory("Nosferatu.exe+0x0014C09C,A0,1D4,38,14,38,3B0", "float", "1"); // Set Stamina to a permanent 1 (No exhaustion)
        }

        private void killAville()
        {
            // "Nosferatu.exe"+0014C09C
            mem.WriteMemory("Nosferatu.exe+0x0014C09C,44,14C,14C,14C,3B0,C, 3C0", "float", "-1"); // Kills Father Aville when he jumps out of the window
        }

        private void resetClock()
        {
            // "Nosferatu.exe"+14BF6C
            mem.WriteMemory("Nosferatu.exe+0x14BF6C", "int", "0"); // Game clock gets reset to 22:30:00 (starting time)
                                                                   // int value does not matter, reset is always to 22:30:00
        }

        private void enableExtraHardMode()
        {
            // "Nosferatu.exe"+0014A1EC
            mem.WriteMemory("Nosferatu.exe+0x0014A1EC,D68,14C,398,158,4,14C,3C0", "float", this.setPlayerHealth(1).ToString()); // Set health to a permanent 1 (Ont hit death)
        }

        private float setPlayerHealth(float playerHealth)
        {
            return playerHealth;
        }

        #endregion

        #region Inputs
        private void checkBoxes_KeyDown(object sender, KeyEventArgs e) // Input detection is NOT global, game window needs to be selected 
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                this.checkBoxEnableTrainer.Checked = !this.checkBoxEnableTrainer.Checked;
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                this.checkBoxEnableAll.Checked = !this.checkBoxEnableAll.Checked;
                this.toggleAllOptions();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                this.checkBoxEnableExtraHardmode.Checked = !this.checkBoxEnableExtraHardmode.Checked;
            }      
            if (e.KeyCode == Keys.NumPad5)
            {
                if (this.checkBoxEnableTrainer.Checked)
                {
                    this.resetClock();
                }
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                this.checkBoxAville.Checked = !this.checkBoxAville.Checked;
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                this.checkBoxAmmo.Checked = !this.checkBoxAmmo.Checked;
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                this.checkBoxHealth.Checked = !this.checkBoxHealth.Checked;
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                this.checkBoxStamina.Checked = !this.checkBoxStamina.Checked;
            }
        }
        #endregion

        private int getInitialAmmo() 
        {
            return mem.ReadInt("Nosferatu.exe+0x0014A1EC,40,14C,158,8,35C,310");
        }

        private void toggleAllOptions()
        {
            if (this.checkBoxEnableAll.Checked)
            {
                this.checkBoxAmmo.Checked = true;
                this.checkBoxHealth.Checked = true;
                this.checkBoxStamina.Checked = true;
                this.checkBoxAville.Checked = true;
            }

            else if (this.checkBoxEnableAll.Checked == false)
            {
                this.checkBoxAmmo.Checked = false;
                this.checkBoxHealth.Checked = false;
                this.checkBoxStamina.Checked = false;
                this.checkBoxAville.Checked = false;
            }
        }

        private void buttonResetClock_Click(object sender, EventArgs e)
        {
            this.resetClock();
        }

        private void checkBoxEnableAll_CheckedChanged(object sender, EventArgs e)
        {
            this.toggleAllOptions();
        }

        private void checkHardMode()
        {
            if (this.checkBoxEnableExtraHardmode.Checked == true)
            {
                this.checkBoxHealth.Checked = false;
            }
        }
        private void checkBoxEnableHardmode_CheckedChanged(object sender, EventArgs e)
        {
            this.checkHardMode();
        }

        private void checkBoxHealth_CheckedChanged(object sender, EventArgs e)
        {
            this.checkHardMode();
        }

        // Jump height?
        // Movement speed?
    }
}
