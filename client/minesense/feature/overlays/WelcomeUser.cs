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
using WindowsFormsApp1.minesense.feature.Global;

namespace WindowsFormsApp1
{
    public partial class WelcomeUser : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static IntPtr handle = FindWindow(null, GlobalVarHandler.WINDOW_NAME);

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


        public WelcomeUser()
        {
            InitializeComponent();
        }

        private void WelcomeUser_Load(object sender, EventArgs e)
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

            Console.WriteLine(GlobalVarHandler.mnsns + "Initializing username renderer...");
            Console.WriteLine(GlobalVarHandler.hooknotif + "Setuping GetWindow hooks...");
            Console.WriteLine(GlobalVarHandler.hooknotif + "Getting WindowRect...");
            Thread.Sleep(200);
            Console.WriteLine(GlobalVarHandler.hooknotif + "Finished!");
            Console.WriteLine(GlobalVarHandler.mnsns + "Finished!");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Form1 form = new Form1();
                GetWindowRect(handle, out rect);
                this.Left = rect.left + 870;
                this.Top = rect.top + 10;
                Thread.Sleep(100);
            }
        }
    }
}
