﻿using System;
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
                Application.Exit();
            }
        }

        private void writeMemory()
        {
            while (true)
            {
                if (this.checkBoxAmmo.Checked)
                {
                    // "Nosferatu.exe"+0014A1EC
                    mem.WriteMemory("Nosferatu.exe+0x0014A1EC,40,14C,158,8,35C,310","int","9999"); // Set all ammo to 9999
                }
                if (this.checkBoxHealth.Checked)
                {
                    // "Nosferatu.exe"+0014A1EC
                    mem.WriteMemory("Nosferatu.exe+0x0014A1EC,D68,14C,398,158,4,14C,3C0", "float", "100"); // Set health to a permanent 100
                }
                Thread.Sleep(50);
            }
        }

        private void checkBoxAmmo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad8)
            {
                this.checkBoxAmmo.Checked = !this.checkBoxAmmo.Checked;
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                this.checkBoxHealth.Checked = !this.checkBoxHealth.Checked;
            }
        }
    }
}
