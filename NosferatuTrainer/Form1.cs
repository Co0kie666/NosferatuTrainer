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
    public partial class Form1 : Form
    {
        Mem mem = new Mem();

        public Form1()
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
                if (this.checkBox1.Checked)
                {
                    // "Nosferatu.exe"+0014A1EC
                    mem.WriteMemory("Nosferatu.exe+0x0014A1EC,40,14C,158,8,35C,310","int","9999"); // Set loaded pistol ammo to 9999
                }
                Thread.Sleep(50);
            }
        }
    }
}
