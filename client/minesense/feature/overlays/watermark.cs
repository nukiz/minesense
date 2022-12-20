using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkeetUI;

namespace WindowsFormsApp1.minesense.feature.overlays
{
    public partial class watermark : skeetForm
    {
        string mnsns = "[MINESENSE] ";
        string hooknotif = "[HOOK] ";
        string eNotif = "[ERROR] ";
        public const string WINDOW_NAME = "Minecraft";

        [DllImport("user32.dll")]
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
        public watermark()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.TopMost = true;
            string USER = global.USER + " |"; // MADE IT! Watermark now uses a global variable stored in the class global.cs which is gotten from Program.cs on load!

            int initialStyle = GetWindowLong(this.Handle, -40);
            SetWindowLong(this.Handle, -40, initialStyle | 0x8000 | 0x20);
            this.MaximumSize = new System.Drawing.Size(283, 42);
            this.MinimumSize = new System.Drawing.Size(283, 42);
            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Left = rect.left;
            this.Top = rect.top;
            backgroundWorker1.RunWorkerAsync();           
            label2.Text = USER;
            dateTimer.Start();
            Console.WriteLine(mnsns + "Initializing overlay...");           
            Console.WriteLine(hooknotif + "Setuping GetWindow hooks...");
            Console.WriteLine(hooknotif + "Getting WindowRect...");
            Thread.Sleep(200);
            Console.WriteLine(hooknotif + "Finished!");
            Console.WriteLine(mnsns + "Finished overlay!");
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                GetWindowRect(handle, out rect);                
                this.Left = rect.left + 15;
                this.Top = rect.top + 37;
                Thread.Sleep(100);
                
            }
        }

        

        private void shadowLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
