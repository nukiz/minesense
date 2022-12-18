using System;
using System.Drawing;
using System.Windows.Forms;
using SkeetUI;
using Memory;
using WindowsFormsApp1.minesense.feature.overlays;
using System.Diagnostics;
using DiscordRPC;

namespace WindowsFormsApp1
{
    public partial class Form1 : skeetForm
    {
        string mnsns = "[MINESENSE] ";
        string hooknotif = "[HOOK] ";
        string eNotif = "[ERROR] ";
        Color enabledColor = Color.FromArgb(17, 17, 17);
        Color disabledColor = Color.FromArgb(15, 15, 15);
        Color DEFAULTBUTTON = Color.FromArgb(154, 197, 39);

        Color GradientColor1 = Color.FromArgb(55, 177, 218);
        Color GradientColor2 = Color.FromArgb(204, 91, 184);
        Color GradientColor3 = Color.FromArgb(204, 227, 53);

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
            VisualTabButton.ForeColor = Color.WhiteSmoke;
            SettingsTabButton.ForeColor = Color.DarkGray;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            VisualTabButton.BackColor = enabledColor;           
            CombatTabButton.BackColor = disabledColor;
            CustomizationTabButton.BackColor = disabledColor;
            SettingsTabButton.BackColor = disabledColor;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            SettingsTabButton.ForeColor = Color.DarkGray;

            CombatTab.Visible = false;
            VisualTab.Visible = true;
            SettingsTab.Visible = false;
            CustomizationTab.Visible = false;
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
            CombatTabButton.ForeColor = Color.WhiteSmoke;
            CombatTabButton.BackColor = enabledColor;
            VisualTabButton.ForeColor = Color.DarkGray;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            SettingsTabButton.ForeColor = Color.DarkGray;            
            CustomizationTabButton.BackColor = disabledColor;
            VisualTabButton.BackColor = disabledColor; ;
            SettingsTabButton.BackColor = disabledColor;

            CombatTab.Visible = true;
            VisualTab.Visible = false;
            SettingsTab.Visible = false;
            CustomizationTab.Visible = false;
            form.ResumeLayout();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.SuspendLayout();
            SettingsTabButton.ForeColor = Color.WhiteSmoke;
            SettingsTabButton.BackColor = enabledColor;
            VisualTabButton.ForeColor = Color.DarkGray;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            CombatTabButton.ForeColor = Color.DarkGray;
            CombatTabButton.BackColor = disabledColor;
            CustomizationTabButton.BackColor = disabledColor;
            VisualTabButton.BackColor = disabledColor;

            SettingsTab.Visible = true;
            VisualTab.Visible = false;
            CombatTab.Visible = false;
            CustomizationTab.Visible = false;
            form.ResumeLayout();
        }

        private void CustomizationTabButton_Click(object sender, EventArgs e)
        {
            form.SuspendLayout();
            CustomizationTabButton.ForeColor = Color.WhiteSmoke;
            CustomizationTabButton.BackColor = enabledColor;    
            VisualTabButton.ForeColor = Color.DarkGray;
            SettingsTabButton.ForeColor = Color.DarkGray;
            CombatTabButton.ForeColor = Color.DarkGray;
            CombatTabButton.BackColor = disabledColor;
            VisualTabButton.BackColor = disabledColor;
            SettingsTabButton.BackColor = disabledColor;

            CustomizationTab.Visible = true;
            SettingsTab.Visible = false;
            VisualTab.Visible = false;
            CombatTab.Visible = false;
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
            
        }

        private void DestructButton_Load(object sender, EventArgs e)
        {
            
        }

        private void DestructButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to self-destruct? This will delete minesense from your computer.";
            string title = "minesense";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; //don't wanna bother making custom boxes lmao
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath); // we start a cmd process with required commands to delete
                Application.Exit(); // trying to delete just the app path with this app may result in access violation, cause a running program is deleting itself and also closing itself
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
            else // more customization for the user :)
            {
                this.TopMost = true;
            }
        }

        private void skeetCheckbox24_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox24.Checked == true)
            {
                obsHideTimer.Start();
                Console.WriteLine(mnsns + "Hide from OBS now active. This module may be unstable.");
                Console.WriteLine(mnsns + "Make sure to only use this module after configuring the client. You will not be able to interact with this client if OBS is open.");
            }
            else // this is rather simple for now, since i don't yet know how to remove a specific window from obs' hooks or something  
            {
                obsHideTimer.Stop();
                this.Show();               
            }
        }

        private void obsHideTimer_Tick(object sender, EventArgs e)
        {
            string obsproc = "obs64";
            
            if (Process.GetProcessesByName(obsproc).Length > 0)
            {               
                this.Hide();
                watermark.Hide();
                Console.WriteLine(mnsns + "OBS DETECTED! HIDING...");
                obsHideTimer.Interval = 1000;
            }
            else
            {
                this.Show();
                Console.WriteLine(mnsns + "OBS no longer detectable. Showing.");
                obsHideTimer.Interval = 10000;
            }
        }

        
        private void panel3_Click(object sender, EventArgs e)
        {                      
            colorDialog1.AnyColor = true;            

            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                panel3.BackColor = colorDialog1.Color;
                skeetCheckbox1.ColorChecked = colorDialog1.Color;
                skeetCheckbox2.ColorChecked = colorDialog1.Color;
                skeetCheckbox3.ColorChecked = colorDialog1.Color;
                skeetCheckbox4.ColorChecked = colorDialog1.Color;
                skeetCheckbox5.ColorChecked = colorDialog1.Color;
                skeetCheckbox6.ColorChecked = colorDialog1.Color;
                skeetCheckbox7.ColorChecked = colorDialog1.Color;
                skeetCheckbox8.ColorChecked = colorDialog1.Color;
                skeetCheckbox9.ColorChecked = colorDialog1.Color;
                skeetCheckbox10.ColorChecked = colorDialog1.Color;
                skeetCheckbox11.ColorChecked = colorDialog1.Color;
                skeetCheckbox12.ColorChecked = colorDialog1.Color;
                skeetCheckbox13.ColorChecked = colorDialog1.Color;
                skeetCheckbox14.ColorChecked = colorDialog1.Color;
                skeetCheckbox15.ColorChecked = colorDialog1.Color;
                skeetCheckbox16.ColorChecked = colorDialog1.Color;
                skeetCheckbox17.ColorChecked = colorDialog1.Color;
                skeetCheckbox18.ColorChecked = colorDialog1.Color;
                skeetCheckbox19.ColorChecked = colorDialog1.Color;
                skeetCheckbox20.ColorChecked = colorDialog1.Color;
                skeetCheckbox21.ColorChecked = colorDialog1.Color;
                skeetCheckbox22.ColorChecked = colorDialog1.Color;
                skeetCheckbox23.ColorChecked = colorDialog1.Color;
                skeetCheckbox24.ColorChecked = colorDialog1.Color;
                skeetCheckbox25.ColorChecked = colorDialog1.Color;
                skeetCheckbox26.ColorChecked = colorDialog1.Color;
                skeetCheckbox27.ColorChecked = colorDialog1.Color;
                skeetCheckbox28.ColorChecked = colorDialog1.Color;
                skeetCheckbox29.ColorChecked = colorDialog1.Color;
                skeetCheckbox30.ColorChecked = colorDialog1.Color;
                skeetCheckbox31.ColorChecked = colorDialog1.Color;
                skeetCheckbox32.ColorChecked = colorDialog1.Color;
                skeetSlider1.SliderColor = colorDialog1.Color;
                skeetSlider2.SliderColor = colorDialog1.Color;
                skeetSlider3.SliderColor = colorDialog1.Color;
                skeetSlider4.SliderColor = colorDialog1.Color;
                skeetSlider5.SliderColor = colorDialog1.Color;
                skeetSlider6.SliderColor = colorDialog1.Color;
                skeetSlider7.SliderColor = colorDialog1.Color;
                skeetSlider8.SliderColor = colorDialog1.Color;
                skeetSlider9.SliderColor = colorDialog1.Color;
                skeetSlider10.SliderColor = colorDialog1.Color;
                skeetSlider11.SliderColor = colorDialog1.Color;
                skeetSlider12.SliderColor = colorDialog1.Color;
                skeetSlider13.SliderColor = colorDialog1.Color;               
            }
        }

        private void skeetCheckbox28_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox28.Checked == false)
            {
                RPC.SetState("as unknown");
            }
            else
            {
                RPC.SetState("as " + global.USER);
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void opacityTimer_Tick(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            int WindowOpacity = Convert.ToInt32(skeetSlider13.Value / 100);
            form.Opacity = WindowOpacity;
        }

        bool mousedown = false;
        private void skeetSlider13_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;

            if (mousedown == true) 
            { 
                opacityTimer.Start();
            }
            else 
            { 
                opacityTimer.Stop();
            }
        }

        private void skeetSlider13_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            gradient1.AnyColor = true;

            if (gradient1.ShowDialog() == DialogResult.OK)
            {
                gradientColor1.BackColor = gradient1.Color;
                form.GradientColor1 = gradient1.Color;
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            gradient2.AnyColor = true;

            if (gradient2.ShowDialog() == DialogResult.OK)
            {
                panel4.BackColor = gradient2.Color;
                form.GradientColor2 = gradient2.Color;
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (gradient3.ShowDialog() == DialogResult.OK)
            {
                panel5.BackColor = gradient3.Color;
                form.GradientColor3 = gradient3.Color;
            }
        }

        private void skeetButton1_Load(object sender, EventArgs e) 
        {

        }

        private void skeetButton1_Click(object sender, EventArgs e)// 154; 197; 39 - RGB for default color...
        {
            form.SuspendLayout();
            form.GradientColor1 = GradientColor1;
            form.GradientColor2 = GradientColor2;
            form.GradientColor3 = GradientColor3;      
            gradientColor1.BackColor = GradientColor1;
            panel4.BackColor = GradientColor2;
            panel5.BackColor = GradientColor3;
            panel3.BackColor = DEFAULTBUTTON;
            skeetCheckbox1.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox2.ColorChecked = DEFAULTBUTTON;              // there's probably a more efficient way to do this, but i don't care
            skeetCheckbox3.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox4.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox5.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox6.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox7.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox8.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox9.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox10.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox11.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox12.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox13.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox14.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox15.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox16.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox17.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox18.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox19.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox20.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox21.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox22.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox23.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox24.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox25.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox26.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox27.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox28.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox29.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox30.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox31.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox32.ColorChecked = DEFAULTBUTTON;
            skeetSlider1.SliderColor = DEFAULTBUTTON;
            skeetSlider2.SliderColor = DEFAULTBUTTON;
            skeetSlider3.SliderColor = DEFAULTBUTTON;
            skeetSlider4.SliderColor = DEFAULTBUTTON;
            skeetSlider5.SliderColor = DEFAULTBUTTON;
            skeetSlider6.SliderColor = DEFAULTBUTTON;
            skeetSlider7.SliderColor = DEFAULTBUTTON;
            skeetSlider8.SliderColor = DEFAULTBUTTON;
            skeetSlider9.SliderColor = DEFAULTBUTTON;
            skeetSlider10.SliderColor = DEFAULTBUTTON;
            skeetSlider11.SliderColor = DEFAULTBUTTON;
            skeetSlider12.SliderColor = DEFAULTBUTTON;
            skeetSlider13.SliderColor = DEFAULTBUTTON;
            form.ResumeLayout();
        }
    }
}
