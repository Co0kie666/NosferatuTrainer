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

        private void Form1_Load(object sender, EventArgs e)
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
                        // "Nosferatu.exe"+0014A1EC

                        string ammoValue = "9999";
                        mem.WriteMemory("Nosferatu.exe+0x0014A1EC,40,14C,158,8,35C,310", "int", ammoValue); // Set all ammo to a permanent 9999 
                    }

                    if (this.checkBoxHealth.Checked)
                    {
                        // "Nosferatu.exe"+0014A1EC
                        mem.WriteMemory("Nosferatu.exe+0x0014A1EC,D68,14C,398,158,4,14C,3C0", "float", "100"); // Set health to a permanent 100
                    }

                    if (this.checkBoxStamina.Checked)
                    {
                        // "Nosferatu.exe"+0014C09C
                        mem.WriteMemory("Nosferatu.exe+0x0014C09C,A0,1D4,38,14,38,3B0", "float", "1"); // Set Stamina to a permanent 1 (No exhaustion)
                    }

                    Thread.Sleep(50);
                }
            }
        }

        private void checkBoxes_KeyDown(object sender, KeyEventArgs e) // Keypresses are NOT global, app needs to be the selected one
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                this.checkBoxEnableTrainer.Checked = !this.checkBoxEnableTrainer.Checked;
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
    }
}
