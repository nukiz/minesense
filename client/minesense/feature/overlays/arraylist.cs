using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.minesense.feature.overlays
{
    public partial class arraylist : Form
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
        public arraylist()
        {
            InitializeComponent();
        }

        public void arraylist_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.TopMost = true;

            int initialStyle = GetWindowLong(this.Handle, -40);
            SetWindowLong(this.Handle, -40, initialStyle | 0x8000 | 0x20);
            this.MaximumSize = new System.Drawing.Size(113, 143);
            this.MinimumSize = new System.Drawing.Size(113, 143);
            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Left = rect.left;
            this.Top = rect.top;
            backgroundWorker1.RunWorkerAsync();
            
            Console.WriteLine(mnsns + "Initializing arraylist...");
            Console.WriteLine(hooknotif + "Setuping GetWindow hooks...");
            Console.WriteLine(hooknotif + "Getting WindowRect...");
            Thread.Sleep(200);
            Console.WriteLine(hooknotif + "Finished!");
            Console.WriteLine(mnsns + "Finished arraylist!");

            AcArLst.Hide();
            VeloArLst.Hide();
            ReachArLst.Hide();
            FakeLagArLst.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                GetWindowRect(handle, out rect);
                this.Left = rect.left + 7;
                this.Top = rect.top + 210;
                Thread.Sleep(100);

            }
        }
    }
}
