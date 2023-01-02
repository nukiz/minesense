using DiscordRPC;
using Memory;
using SkeetUI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.minesense.config;
using WindowsFormsApp1.minesense.feature.module;
using WindowsFormsApp1.minesense.feature.overlays;

namespace WindowsFormsApp1
{
    public partial class Form1 : skeetForm
    {
         // autoclicker utils!
         
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        // autoclicker utils!

        api ScriptApi = new api();
        string mnsns = "[MINESENSE] ";
        string hooknotif = "[HOOK] ";
        string eNotif = "[ERROR] ";
        string discord = "[DISCORD] ";
        string module = "[MODULE] ";
        Color enabledColor = Color.FromArgb(17, 17, 17);
        Color disabledColor = Color.FromArgb(15, 15, 15);
        Color DEFAULTBUTTON = Color.FromArgb(154, 197, 39);
        public static Timestamps rpctimestamp { get; set; }

        

        skeetForm form = new skeetForm();
        watermark watermark = new watermark();
        // arraylist arlst = new arraylist();
        

        Mem m = new Mem();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();


        }

        

        public void reachRandomizeTimer_Tick(object sender, EventArgs e)
        {
            int minReach = Convert.ToInt32(skeetSlider6.Value);
            int maxReach = Convert.ToInt32(skeetSlider5.Value);        // REACH - DO NOT TOUCH - VALUES FOR 1.19.50/51
            float result = rnd.Next(minReach, maxReach);               
            
            // arlst.ReachAmt.Text = result.ToString();                      

            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                if (skeetCheckbox12.Checked == true)
                {
                    m.WriteMemory("base+3FAE0D0", "float", Convert.ToString(result));
                   
                }
                else
                {                     
                    m.WriteMemory("base+3FAE0D0", "float", "3");
                    reachRandomizeTimer.Stop();
                    Console.WriteLine(module + "Randomizer disabled.");
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                Console.WriteLine(hooknotif + "Minecraft.Windows.exe now attached");     // Not actually necessary, just makes shit clearer
                Console.WriteLine(mnsns + "MineSense now ready to use.");

                RPC.client.SetPresence(new RichPresence()
                {
                    Details = "Cheating in MC:BE",
                    State = "as " + global.USER,
                    Assets = new Assets()
                    {
                        LargeImageKey = "large",
                        LargeImageText = "minesense beta",
                        SmallImageKey = "large",
                        SmallImageText = "b1.5"
                    }

                });                                                                     // console logging :D
                Console.WriteLine(discord + "RPC Updated. ");
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
                reachRandomizeTimer.Start();
            }
            else
            {
                reachRandomizeTimer.Stop();
            }
            
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
            ScriptTabButton.ForeColor = Color.DarkGray;
            ScriptTabButton.BackColor = disabledColor;
            ScriptTab.Visible = false;
            CombatTab.Visible = false;
            VisualTab.Visible = true;
            SettingsTab.Visible = false;
            CustomizationTab.Visible = false;
            form.ResumeLayout();
        }

        private void skeetCheckbox12_Click(object sender, EventArgs e) // REACH !!!!
        {
            if (skeetSlider6.Value > skeetSlider5.Value)
            {
                skeetSlider5.Value = skeetSlider6.Value;
            }

            if (skeetCheckbox12.Checked == true)
            {
                reach.Enable();

                if (skeetCheckbox11.Checked == true) //enable reach
                { 
                    reach.reachRandomizer();
                }

            }
            else
            {
                reach.Disable();
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
            ScriptTabButton.ForeColor = Color.DarkGray;
            CustomizationTabButton.BackColor = disabledColor;
            VisualTabButton.BackColor = disabledColor; ;
            SettingsTabButton.BackColor = disabledColor;
            ScriptTabButton.BackColor = disabledColor;
            ScriptTab.Visible = false;
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
            ScriptTabButton.ForeColor = Color.DarkGray;
            CombatTabButton.BackColor = disabledColor;
            CustomizationTabButton.BackColor = disabledColor;
            VisualTabButton.BackColor = disabledColor;
            ScriptTabButton.BackColor = disabledColor;
            ScriptTab.Visible = false;
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
            ScriptTabButton.ForeColor = Color.DarkGray;
            CombatTabButton.BackColor = disabledColor;
            VisualTabButton.BackColor = disabledColor;
            SettingsTabButton.BackColor = disabledColor;
            ScriptTabButton.BackColor = disabledColor;
            ScriptTab.Visible = false;
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
            if (skeetCheckbox11.Checked == true & skeetCheckbox12.Checked == true)
            {
                reachRandomizeTimer.Start();
            }
            else
            {
                return;
            }
            
        }

        private void skeetSlider13_Load(object sender, EventArgs e)
        {

        }

        private void skeetSlider13_Click(object sender, EventArgs e)
        {
            int WINDOWOPACITY = Convert.ToInt32(skeetSlider13.Value) / 100;
            form.Opacity = WINDOWOPACITY;
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
                Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 1 & Del " + Application.StartupPath);
                Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 1 & Del " + Application.ExecutablePath); // we start a cmd process with required commands to delete
                Application.Exit();  // trying to delete just the app path with this app may result in access violation, cause a running program is deleting itself and also closing itself
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
                global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
                obsHideTimer.Start();
                Console.WriteLine(mnsns + "Hide from OBS now active. This module may be unstable.");
                Console.WriteLine(mnsns + "Make sure to only use this module after configuring the client. You will not be able to interact with this client if OBS is open.");
            }
            else // this is rather simple for now, since i don't yet know how to remove a specific window from obs' hooks or something  
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
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
                ScriptTextBox.LineNumberColor = colorDialog1.Color;
                // arlst.AcArLst.ForeColor = colorDialog1.Color;
                // arlst.ReachArLst.ForeColor = colorDialog1.Color;
                // arlst.VeloArLst.ForeColor = colorDialog1.Color;
                // arlst.FakeLagArLst.ForeColor = colorDialog1.Color;
                panel3.BackColor = colorDialog1.Color;
                skeetCheckbox1.ColorChecked = colorDialog1.Color;
                skeetCheckbox2.ColorChecked = colorDialog1.Color;
                skeetCheckbox3.ColorChecked = colorDialog1.Color;
                skeetCheckbox4.ColorChecked = colorDialog1.Color;
                FluctuateCheck.ColorChecked = colorDialog1.Color;
                ReachFluc.ColorChecked = colorDialog1.Color;
                skeetCheckbox7.ColorChecked = colorDialog1.Color;
                FakeLagStart.ColorChecked = colorDialog1.Color;
                skeetCheckbox9.ColorChecked = colorDialog1.Color;
                skeetCheckbox10.ColorChecked = colorDialog1.Color;
                skeetCheckbox11.ColorChecked = colorDialog1.Color;
                skeetCheckbox12.ColorChecked = colorDialog1.Color;
                skeetCheckbox13.ColorChecked = colorDialog1.Color;
                skeetCheckbox14.ColorChecked = colorDialog1.Color;
                skeetCheckbox15.ColorChecked = colorDialog1.Color;
                MovingFluc.ColorChecked = colorDialog1.Color;
                skeetCheckbox17.ColorChecked = colorDialog1.Color;
                skeetCheckbox18.ColorChecked = colorDialog1.Color;
                skeetCheckbox19.ColorChecked = colorDialog1.Color;
                skeetCheckbox20.ColorChecked = colorDialog1.Color;
                skeetCheckbox21.ColorChecked = colorDialog1.Color;
                skeetCheckbox22.ColorChecked = colorDialog1.Color;
                skeetCheckbox23.ColorChecked = colorDialog1.Color;
                skeetCheckbox24.ColorChecked = colorDialog1.Color;
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
                maxFakeLagDelay.SliderColor = colorDialog1.Color;
                minFakeLagDelay.SliderColor = colorDialog1.Color;
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

        
        private void skeetSlider13_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void skeetSlider13_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            gradient1.AnyColor = true;

            if (gradient1.ShowDialog() == DialogResult.OK)
            {
                panel4.BackColor = gradient2.Color;
                form.GradientColor2 = gradient2.Color;
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
            // arlst.AcArLst.ForeColor = DEFAULTBUTTON;
            ScriptTextBox.LineNumberColor = DEFAULTBUTTON;
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
            FluctuateCheck.ColorChecked = DEFAULTBUTTON;
            ReachFluc.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox7.ColorChecked = DEFAULTBUTTON;
            FakeLagStart.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox9.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox10.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox11.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox12.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox13.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox14.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox15.ColorChecked = DEFAULTBUTTON;
            MovingFluc.ColorChecked = DEFAULTBUTTON;
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
            skeetCheckbox33.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox34.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox35.ColorChecked = DEFAULTBUTTON;
            skeetCheckbox37.ColorChecked = DEFAULTBUTTON;            
            skeetCheckbox36.ColorChecked = DEFAULTBUTTON;
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
            maxFakeLagDelay.SliderColor = DEFAULTBUTTON;
            minFakeLagDelay.SliderColor = DEFAULTBUTTON;
            skeetSlider13.SliderColor = DEFAULTBUTTON;
            skeetCheckbox25.Checked = false;
            rgbTimer.Stop();
            form.ResumeLayout();
        }

        private void skeetCheckbox26_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox26.Checked == false)
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
                Console.WriteLine(discord + "RPC Cleared´'.");
                RPC.client.Dispose();
            }
            else
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
                RPC.client.SetPresence(new RichPresence()
                {
                    Details = "Cheating in MC:BE",
                    State = "as " + global.USER,
                    Assets = new Assets()
                    {
                        LargeImageKey = "large",
                        LargeImageText = "minesense beta",
                        SmallImageKey = "large",
                        SmallImageText = "b1.5"
                    }
                    
                });
                Console.WriteLine(discord + "RPC active again.");
            }
        }

        private void skeetCheckbox25_Click(object sender, EventArgs e)
        {
            rnbSpeed.Visible = true;
            if (skeetCheckbox25.Checked == true)
            {
                rgbTimer.Start();
            }
            else
            {
                rnbSpeed.Visible = false;
                rgbTimer.Stop();
            }
        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skeetButton6_Load(object sender, EventArgs e)
        {
            
        }

        private void skeetButton6_Click(object sender, EventArgs e)
        {
            ScriptTextBox.Text = "";
        }

        private void skeetCheckbox35_Load(object sender, EventArgs e)
        {
            
        }

        private void skeetCheckbox35_Click(object sender, EventArgs e)
        {
            
        }

        private void skeetButton4_Load(object sender, EventArgs e)
        {

        }

        private void skeetButton4_Click(object sender, EventArgs e)
        {

            if (skeetCheckbox37.Checked == true)
            {
                ScriptTextBox.AppendText("");
                ScriptTextBox.AppendText("// written by " + global.USER + ". script written with minesense.");
                api.Execute();
            }
            else
            {
                api.Execute();
            }
        }

        private void skeetButton5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ScriptTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void skeetCheckbox33_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox33.Checked == true)
            {               
                
            }
        }

        private void skeetCheckbox1_Click(object sender, EventArgs e) //AUTOCLICKING :)))
        {
            if (skeetCheckbox1.Checked == true)
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
                clicker.Enable();             
            }
            else
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
                clicker.Disable();
            }
        }

        private void skeetCheckbox2_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox2.Checked == true)
            {
                clicker.RandomizerEnable();
            }
            else
            {
                clicker.RandomizerDisable();
            }
        }

            public void randomizeCps_Tick(object sender, EventArgs e) // autoclicker needs this ! might do a clicker rewrite where all of these are in clicker.cs class
            {
                int minimumCps = Convert.ToInt32(skeetSlider1.Value);
                int maximumCps = Convert.ToInt32(skeetSlider2.Value);
                skeetSlider3.Value = rnd.Next(minimumCps, maximumCps);
            }

        IntPtr hwnd;
        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if(activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch
            {

            }return null;
        }
        public async void autoclickTimer_Tick(object sender, EventArgs e)
        {
            
            Process[] processes = Process.GetProcessesByName("Minecraft.Windows");
                foreach (Process process in processes)
                {
                    hwnd = FindWindow(null, process.MainWindowTitle);
                }

                string currentwin = getActiveWindowName();
                if(currentwin == null)
                {
                    return;
                }

            if (currentwin.Contains("Minecraft"))
            {
            if (MouseButtons == MouseButtons.Left)
            {
                PostMessage(hwnd, 0x0201, 0, 0);
                await Task.Delay(30);
                PostMessage(hwnd, 0x0202, 0, 0);
            }
            }
        }

        private void ModuleAmtTimer_Tick(object sender, EventArgs e)
        {
            RPC.SetState(global.MODULEAMOUNT + "/" + global.MAXMODULES + " modules active");
            NameTimer.Start();
            ModuleAmtTimer.Stop();
        }

        private void NameTimer_Tick(object sender, EventArgs e)
        {
            RPC.SetState("as " + global.USER);
            Thread.Sleep(100);
            ModuleAmtTimer.Start();
            NameTimer.Stop();
        }

        private void skeetCheckbox30_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox30.Checked == true)
            {
                ModuleAmtTimer.Start();
            }
            else
            {
                RPC.SetState("as " + global.USER);
                ModuleAmtTimer.Stop();
                NameTimer.Stop();
            }
        }

        private void skeetCheckbox36_Click(object sender, EventArgs e)
        {
            if(skeetCheckbox36.Checked == true)
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
            }
            else
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
            }
        }

        private void skeetCheckbox31_Click(object sender, EventArgs e)
        {
            if(skeetCheckbox31.Checked == true)
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
            }
            else
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
            }
        }

        private void skeetCheckbox8_Click(object sender, EventArgs e)
        {
            if(FakeLagStart.Checked == true)
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
            }
            else
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
            }
        }

        private void skeetCheckbox23_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox23.Checked == true)
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
            }
            else
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
            }
        }

        private void skeetCheckbox15_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox15.Checked == true)
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
            }
            else
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
            }
        }

        private void skeetCheckbox37_Load(object sender, EventArgs e)
        {

        }

        private void skeetCheckbox22_Click(object sender, EventArgs e)
        {
            if (skeetCheckbox22.Checked == true)
            {
                Console.WriteLine(mnsns + "Arraylist updated.");
                // arlst.Show();
                // arlst.Activate();
                ArrayListUpdateTimer.Start();
            }
            else
            {
                ArrayListUpdateTimer.Stop();
                // arlst.Close();
                Console.WriteLine(mnsns + "Arraylist updated.");
            }
        }
        private void ArrayListUpdateTimer_Tick(object sender, EventArgs e) // arraylist updater - will be rewritten sooner or later
        {
            //REACH
            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                if (skeetCheckbox12.Checked == true)
                {
                    // arlst.ReachArLst.Show();
                }
                else
                {
                    // arlst.ReachArLst.Hide();
                }
            } 
            else
            {
                return;
            }            

            
            // CLICKER
            if (skeetCheckbox1.Checked == true)
            {
                // arlst.AcArLst.Show();
            }
            else
            {
                // arlst.AcArLst.Hide();             // to zyph - ur code is written by ai shut it
            }
            // VELOCITY
            if (skeetCheckbox15.Checked == true)
            {
                // arlst.VeloArLst.Show();

            }
            else
            {
                // arlst.VeloArLst.Hide();           // to a cracker - dont laugh i know its bad LMAO

            }

        }

        private void skeetCheckbox43_Click(object sender, EventArgs e)
        {
            WelcomeUser wlcm = new WelcomeUser();

            if(skeetCheckbox43.Checked == true)
            {
                wlcm.Show();
            }
            else
            {
                wlcm.Hide();
            }
        }

        private void skeetButton8_Load(object sender, EventArgs e)
        {
            
        }

        private void skeetButton9_Click(object sender, EventArgs e)
        {
            CfgList.Items.Clear();
            configlistmanager.Populate(CfgList, "./Config", "*.txt");
        }

        private void RefreshBtn_Load(object sender, EventArgs e)
        {

        }

        private void skeetButton8_Click(object sender, EventArgs e)
        {
            configmanager.SaveConfig();
        }

        private void skeetButton7_Click(object sender, EventArgs e)
        {
            configmanager.LoadConfig();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {            
            ScriptTabButton.ForeColor = Color.WhiteSmoke;
            CombatTabButton.ForeColor = Color.DarkGray;
            VisualTabButton.ForeColor = Color.DarkGray;
            CustomizationTabButton.ForeColor = Color.DarkGray;
            SettingsTabButton.ForeColor = Color.DarkGray;

            ScriptTabButton.BackColor = enabledColor;
            SettingsTabButton.BackColor = disabledColor;
            CustomizationTabButton.BackColor = disabledColor;
            CombatTabButton.BackColor = disabledColor;
            VisualTabButton.BackColor = disabledColor;

            ScriptTab.Visible = true;
            VisualTab.Visible = false;
            CombatTab.Visible = false;
            CustomizationTab.Visible = false;
            SettingsTab.Visible = false;
        }

        int r = 255, g = 0, b = 0;

        private void skeetCheckbox24_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi.Text = "Hides the client when" +
                " \r\nOBS is running.";
        }

        private void skeetCheckbox26_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi.Text = "Enables Discord integration.";
        }

        private void skeetSlider13_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi.Text = "Set client opacity.";
        }

        private void skeetCheckbox32_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi.Text = "When enabled, the client" +
                " \r\nwont go under anything.";
        }

        private void skeetCheckbox44_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi.Text = "This toggle hides the client" +
                " \r\ntemporarily in an emergency.";
        }

        private void skeetCheckbox17_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi.Text = "Draws minesense watermark in " +
                "\r\ntop left corner. A bit buggy.";
        }

        private void skeetCheckbox22_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi.Text = "Draws enabled modules." +
                " \r\nVery buggy.";
        }

        private void skeetCheckbox43_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi.Text = "Draws your username.";
        }

        private void skeetCheckbox36_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Raises your gamma" +
                " \r\nbrightness.";
        }

        private void skeetCheckbox31_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Changes clientside" +
                " \r\ntime to night.";
        }

        private void skeetCheckbox8_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Makes you look" +
                " \r\nchoppier.";
        }

        private void skeetCheckbox4_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Essentially blink, but" +
                " \r\nmay cause disconnects.";
        }

        private void skeetSlider17_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Because lagswitch is a" +
                " \r\ntoggle, this is the duration of it.";
        }

        private void skeetSlider11_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Maximum amount of delay" +
                " \r\nfor FakeLag.";
        }

        private void skeetSlider12_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Minimum amount of delay" +
                " \r\nfor FakeLag.";
        }

        private void skeetCheckbox5_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Toggles fluctuation for FakeLag." +
                " \r\nMultiplies FakeLag delay when" +
                " \r\nset triggers are true.";
        }

        private void skeetSlider14_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Multiplier for fluctuation.";
        }

        private void skeetCheckbox18_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Walk on water like " +
                "\r\nJesus himself.";
        }

        private void skeetCheckbox19_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Speed for water.";
        }

        private void skeetSlider15_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Speed multiplier for" +
                " \r\nwaterspeed.";
        }

        private void skeetCheckbox20_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Attempts to negate fall damage" +
                " \r\nby canceling packets/NOPing memory" +
                " \r\naddress for fall damage.";
        }

        private void skeetCheckbox35_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Sprint in all directions!";
        }

        private void skeetCheckbox21_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "OnGround speed mode. Good for" +
                " \r\nvanilla, probably wont bypass" +
                " \r\nservers.";
        }

        private void skeetSlider16_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Multiplier for OnGround" +
                " \r\nspeed";
        }

        private void skeetCheckbox23_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Allows you to jump infinitely." +
                " \r\nLess blatant fly, but might" +
                " \r\nnot bypass.";
        }

        private void skeetCheckbox38_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Attempts to negate damage from airjump." +
                " \r\nRather buggy, also doubles" +
                " \r\nas a sort of strafe.";
        }

        private void skeetCheckbox39_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Freely move in air at" +
                " \r\nfull speed.";
        }

        private void skeetCheckbox40_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi2.Text = "Locks your Y axis coordinate." +
                " \r\nVery buggy, causes noclip" +
                " \r\nover time.";
        }

        private void skeetCheckbox1_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Very customizable clicker.";
        }

        private void skeetSlider1_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Minimum CPS that the clicker" +
                " \r\nrandomizes between if randomizer" +
                " \r\nis enabled.";
        }

        private void skeetSlider2_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Maximum CPS for clicker to" +
                " \r\nuse in randomizing.";
        }

        private void skeetCheckbox2_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Toggles randomizer" +
                " \r\nfor clicker.";
        }

        private void skeetCheckbox3_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Allows clicker to send right" +
                " \r\nclicks when MB2 is down.";
        }

        private void skeetSlider3_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "This slider shows the result" +
                " \r\nof the randomizer.";
        }

        private void skeetCheckbox15_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Modifies your horizontal/vertical" +
                " \r\nknockback velocity.";
        }

        private void skeetCheckbox14_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Randomizes knockback amount." +
                " \r\nPretty much makes you undetectable.";
        }

        private void skeetSlider9_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Horizontal knockback %" +
                " \r\nmodifier.";
        }

        private void skeetSlider8_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Vertical knockback %" +
                " \r\nmodifier.";
        }

        private void skeetCheckbox13_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "When enabled and after being " +
                "\r\nin the air for" +
                " \r\nsome time will negate all knockback.";
        }

        private void skeetCheckbox9_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Chance of negating " +
                "\r\nknockback for velocity.";
        }

        private void skeetSlider7_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Customize % of" +
                " \r\nshit happening.";
        }

        private void skeetCheckbox42_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Automatically throws" +
                " \r\npots in NoDebuff.";
        }

        private void shadowLabel5_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Choose which of your" +
                " \r\nhotbar slots have pots.";
        }

        private void skeetCheckbox12_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Modifies the amount" +
                " \r\nof reach you have.";
        }

        private void skeetCheckbox11_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Randomize reach between" +
                " \r\nmin/max values.";
        }

        private void skeetSlider6_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Minimum reach for" +
                " \r\nrandomizer.";
        }

        private void skeetSlider5_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Maxiumum reach for" +
                " randomizer.";
        }

        private void skeetCheckbox10_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Attempts to misplace enemies" +
                " \r\ncloser to you." +
                " \r\nGreat in streams/videos.";
        }

        private void skeetSlider4_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Amount to use for" +
                " \r\nmisplace.";
        }

        private void skeetGroupBox5_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Snaps you back to" +
                " \r\nyour original Y" +
                " \r\nlevel if you fall too far.";
        }

        private void skeetGroupBox11_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "When enabled and going below HP" +
                " \r\nthreshold will crank your" +
                " \r\nsettings to the max.";
        }

        private void DestructButton_MouseHover(object sender, EventArgs e)
        {
            ToolTipExhi3.Text = "Deletes minesense and" +
                "\r\nrelated dlls.";
        }

        private void skeetSlider12_Load(object sender, EventArgs e)
        {

        }

        private void skeetButton9_Click_1(object sender, EventArgs e)
        {
            configmanager.SaveConfig();
            global.CONFIGNAME = configName.Text;
        }

        private void rgbTimer_Tick(object sender, EventArgs e)
        {
            rgbTimer.Interval = Convert.ToInt32(rnbSpeed.Value);

            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0)
            {
                g--;
                b++;
            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }

            panel3.BackColor = Color.FromArgb(r, g, b);
            rnbSpeed.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider1.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider2.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider3.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider4.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider5.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider6.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider7.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider8.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider9.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider10.SliderColor = Color.FromArgb(r, g, b);
            maxFakeLagDelay.SliderColor = Color.FromArgb(r, g, b);
            minFakeLagDelay.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider13.SliderColor = Color.FromArgb(r, g, b);
            FlucAmountVal.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider15.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider16.SliderColor = Color.FromArgb(r, g, b);
            LagSwitchTime.SliderColor = Color.FromArgb(r, g, b);
            skeetSlider18.SliderColor = Color.FromArgb(r, g, b);
            skeetCheckbox1.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox2.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox3.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox4.ColorChecked = Color.FromArgb(r, g, b);
            FluctuateCheck.ColorChecked = Color.FromArgb(r, g, b);
            ReachFluc.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox7.ColorChecked = Color.FromArgb(r, g, b);
            FakeLagStart.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox9.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox10.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox11.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox12.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox13.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox14.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox15.ColorChecked = Color.FromArgb(r, g, b);
            MovingFluc.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox17.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox18.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox19.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox20.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox21.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox22.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox23.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox24.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox25.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox26.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox27.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox28.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox29.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox30.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox31.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox32.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox33.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox34.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox35.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox36.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox37.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox38.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox39.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox40.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox41.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox42.ColorChecked = Color.FromArgb(r, g, b);
            skeetCheckbox43.ColorChecked = Color.FromArgb(r, g, b);
            ScriptTextBox.LineNumberColor = Color.FromArgb(r, g, b);
            // arlst.AcArLst.ForeColor = Color.FromArgb(r, g, b);
            // arlst.ReachArLst.ForeColor = Color.FromArgb(r, g, b);
            // arlst.FakeLagArLst.ForeColor = Color.FromArgb(r, g, b);
            // arlst.VeloArLst.ForeColor = Color.FromArgb(r, g, b);

        }
    }
}
