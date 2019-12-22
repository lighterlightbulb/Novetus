﻿using System;
using System.IO;
using System.Windows.Forms;

namespace NovetusLauncher
{
    public partial class NovetusSDK : Form
    {
        public NovetusSDK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemMaker im = new ItemMaker();
            im.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientinfoEditor cie = new ClientinfoEditor();
            cie.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientScriptDocumentation csd = new ClientScriptDocumentation();
            csd.Show();
        }

        private void NovetusSDK_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(GlobalVars.ConfigDir + "\\info.txt"); //File is in System.IO
            string version = lines[0];
            Text = "Novetus SDK " + version;
            label1.Text = version;
            GlobalVars.Version = version;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                ItemMaker im = new ItemMaker();
                im.Show();
            }
            else if (listBox1.SelectedIndex == 1)
            {
                ClientinfoEditor cie = new ClientinfoEditor();
                cie.Show();
            }
            else if (listBox1.SelectedIndex == 2)
            {
                ClientScriptDocumentation csd = new ClientScriptDocumentation();
                csd.Show();
            }
            else if (listBox1.SelectedIndex == 3)
            {
                AssetLocalizer al = new AssetLocalizer();
                al.Show();
            }
            else if (listBox1.SelectedIndex == 4)
            {
                SplashTester st = new SplashTester();
                st.Show();
            }
        }
    }
}