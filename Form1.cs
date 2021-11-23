using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KillExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Process processo = new Process();

            processo.StartInfo = new ProcessStartInfo("taskkill", "/F /IM explorer.exe");

            processo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            processo.Start();

            processo.WaitForExit();
        }
    
    }
}
