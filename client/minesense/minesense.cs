﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkeetUI;
using Memory;
using System.Security.Cryptography;
using WindowsFormsApp1.minesense.feature.overlays;
using DiscordRPC;
using System.Diagnostics;
using System.Net.Security;

namespace WindowsFormsApp1
{
    public partial class Form1 : skeetForm
    {
        string mnsns = "[MINESENSE] ";
        string hooknotif = "[HOOK] ";
        string eNotif = "[ERROR] ";
        Color enabledColor = Color.FromArgb(17, 17, 17);

        skeetForm form = new skeetForm();
        watermark watermark = new watermark();

        Mem m = new Mem();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();

            
        }

        private string detail = "Cheating on Minecraft";

        public void reachRandomizeTimer_Tick(object sender, EventArgs e)
        {
            int minReach = Convert.ToInt32(skeetSlider6.Value);
            int maxReach = Convert.ToInt32(skeetSlider5.Value);
            int v = rnd.Next(minReach, maxReach);            
        }
                

        private void Form1_Load(object sender, EventArgs e)
        {
            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                Console.WriteLine(hooknotif + "Minecraft.Windows.exe now attached");     // Not actually necessary, just makes shit clearer
                Console.WriteLine(mnsns + "MineSense now ready to use.");                // console logging :D
                
            }
            else
            {
                Console.WriteLine(eNotif + "Couldn't hook to Minecraft. Please open Minecraft, or if the issue persists, contact support.");
                attachTimer.Start();
            }

            

            CombatTabButton.ForeColor = Color.WhiteSmoke;
            VisualTabButton.ForeColor = Color.DarkGray;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            SettingsTabButton.ForeColor = Color.DarkGray;
            VisualTab.Visible = false;
            CombatTab.Visible = true;

        }

        private void skeetSlider4_Load(object sender, EventArgs e)
        {

        }

        private void skeetCheckbox10_Load(object sender, EventArgs e)
        {

        }

        private void skeetSlider2_Load(object sender, EventArgs e)
        {

        }

        private void skeetSlider1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.RShiftKey)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.WhiteSmoke;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.WhiteSmoke;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.WhiteSmoke;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.WhiteSmoke;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.WhiteSmoke;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkGray;
        }

        private void skeetCheckbox12_Load(object sender, EventArgs e)
        {
            
        }

        private void skeetCheckbox11_Load(object sender, EventArgs e)
        {
            if (skeetCheckbox11.Checked == true)
            {
                reachRandomizeTimer.Enabled = true;
            }

            new Reach();
            Console.WriteLine(mnsns + "Modules initialized.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.SuspendLayout();
            CombatTabButton.ForeColor = Color.DarkGray;
            this.BackColor = enabledColor;
            this.ForeColor = Color.WhiteSmoke;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            SettingsTabButton.ForeColor = Color.DarkGray;

            CombatTab.Visible = false;
            VisualTab.Visible = true;
            SettingsTab.Visible = false;
            form.ResumeLayout();
        }

        private void skeetCheckbox12_Click(object sender, EventArgs e)
        {

            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                if (skeetCheckbox12.Checked == true)
                {
                    if (skeetCheckbox11.Checked == true)
                    {

                        Console.WriteLine(mnsns + "Reach RandomizeTimer init...");
                        
                        Console.WriteLine(mnsns + "Done with RandomizeTimer. Reach init...");
                        m.WriteMemory("base+3FAE0D0", "float","");
                        Console.WriteLine(mnsns + "Done. Reach now enabled.");
                    }
                    else
                    {
                        m.WriteMemory("base+3FAE0D0", "float", Convert.ToString(skeetSlider5.Value));
                        Console.WriteLine(mnsns + "Reach enabled.");
                    }
                }
                else
                {
                    m.WriteMemory("base+3FAE0D0", "float", "3");
                    Console.WriteLine(mnsns + "Reach disabled.");
                }
            }
            else
            {
                Console.WriteLine(eNotif + "Fatal error while enabling module, Minecraft is not currently open.");
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                Console.WriteLine(hooknotif + "Minecraft.Windows.exe now attached"); // console logging pt2 :D
                Console.WriteLine(mnsns + "MineSense now engaged. Happy cheating!");
                attachTimer.Stop();
            }
            else
            {
                attachTimer.Start();
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.SuspendLayout();
            this.ForeColor = Color.WhiteSmoke;
            this.BackColor = enabledColor;
            VisualTabButton.ForeColor = Color.DarkGray;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            SettingsTabButton.ForeColor = Color.DarkGray;
            
            CombatTab.Visible = true;
            VisualTab.Visible = false;
            SettingsTab.Visible = false;
            form.ResumeLayout();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.SuspendLayout();
            this.ForeColor = Color.WhiteSmoke;
            VisualTabButton.ForeColor = Color.DarkGray;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            CombatTabButton.ForeColor = Color.DarkGray;
            SettingsTab.Visible = true;
            VisualTab.Visible = false;
            CombatTab.Visible = false;
            form.ResumeLayout();
        }

        private void CustomizationTabButton_Click(object sender, EventArgs e)
        {
            form.SuspendLayout();
            this.ForeColor = Color.WhiteSmoke;
            VisualTabButton.ForeColor = Color.DarkGray;
            SettingsTabButton.ForeColor = Color.DarkGray;
            CombatTabButton.ForeColor = Color.DarkGray;
            
            form.ResumeLayout(); 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void skeetCheckbox17_Load(object sender, EventArgs e)
        {
            
        }

        private void skeetCheckbox17_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox17.Checked == true)
            {
                if (m.OpenProcess("Minecraft.Windows.exe"))
                { 
                watermark.Show();
                watermark.Activate();
                Console.WriteLine(hooknotif + "Watermark now active.");
                }
                else
                {
                    Console.WriteLine(eNotif + "Failed to get window position.");
                    Console.WriteLine(hooknotif + "Please open Minecraft before trying to enable this module.");
                }
            }
            else
            {
                watermark.Hide();
                Console.WriteLine(hooknotif + "Watermark disabled.");
            }
        }

        private void RPCAnimTimer_Tick(object sender, EventArgs e)
        {
                       
        }

        private void RPCAnimTimer2_Tick(object sender, EventArgs e)
        {
                      
        }

        private void skeetCheckbox11_Click(object sender, EventArgs e)
        {
            reachRandomizeTimer.Start();
        }

        private void skeetSlider13_Load(object sender, EventArgs e)
        {

        }

        private void skeetSlider13_Click(object sender, EventArgs e)
        {            
            Form1 form = new Form1();
            form.Opacity = Convert.ToInt32(skeetSlider13.Value);            
        }

        private void DestructButton_Load(object sender, EventArgs e)
        {
            
        }

        private void DestructButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to self-destruct? This will delete minesense from your computer.";
            string title = "minesense";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void skeetCheckbox32_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox32.Checked == false)
            {
                this.TopMost = false;
            }
            else
            {
                this.TopMost = true;
            }
        }
    }
}
