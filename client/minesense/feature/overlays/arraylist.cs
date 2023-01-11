using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.minesense.feature.overlays
{
    public partial class arraylist : Form
    {
        string mnsns = "[MINESENSE] ";
        
        public const string WINDOW_NAME = "Minecraft"; // BTW YES I KNOW ITS PROBABLY NOT GOOD TO MAKE A SEPARATE FORM FOR ARRAYLIST! 

        [DllImport("user32.dll")] // DIDN'T KNOW AT THE TIME OF MAKING ABOUT DRAWING STUFF
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static IntPtr handle = FindWindow(null, WINDOW_NAME);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

        public static RECT rect;

        public struct RECT
        {
            public int left, top, right, bottom;

        }
        public arraylist()
        {
            InitializeComponent();
        }

        Form1 form = new Form1();
        public void arraylist_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.TopMost = true;

            int initialStyle = GetWindowLong(this.Handle, -40);
            SetWindowLong(this.Handle, -40, initialStyle | 0x8000 | 0x20);
            this.MaximumSize = new System.Drawing.Size(225, 132);
            this.MinimumSize = new System.Drawing.Size(225, 132);
            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Left = rect.left;
            this.Top = rect.top;
            backgroundWorker1.RunWorkerAsync();
            
            

            AcArLst.Show();
            VeloArLst.Show();
            ReachArLst.Show();
            FakeLagArLst.Show();

            clickerPanel.Show();
            reachPanel.Show();
            veloPanel.Show();
            fakeLagPanel.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {               
                GetWindowRect(handle, out rect);
                this.Left = rect.left + 7;
                this.Top = rect.top + 144;
                Thread.Sleep(100);               
            }
        }

        private void shadowLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void ModuleHandler_Tick(object sender, EventArgs e)
        {
            CpsAmt.Text = form.skeetSlider3.Value.ToString();
            

            if (form.skeetCheckbox15.Checked == true)
            {
                VeloArLst.Show();
            }
            else
            {
                VeloArLst.Hide();
            }

            if (form.skeetCheckbox12.Checked == true) // i know its painful to watch ;)
            {
                ReachArLst.Show();
            }
            else
            {
                ReachArLst.Hide();
            }

            if (form.skeetCheckbox1.Checked == true)
            {
                AcArLst.Show();
            }
            else
            {
                AcArLst.Hide();
            }
        }
    }
}
