using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using WindowsFormsApp1.minesense.feature.module;

namespace WindowsFormsApp1
{
    public static class global
    {
        public static string USER;
        public static void GetUser()
        {
            Console.WriteLine("Welcome to minesense. What will we call you?");
            USER = Console.ReadLine();
        }

        public static string CONFIGNAME;

        public static int MODULEAMOUNT = 0;
        public static int MAXMODULES = 10;

        public static ProcessStartInfo cmdStartInfo = new ProcessStartInfo
        {
            FileName = "cmd",
            RedirectStandardInput = true,
            WindowStyle = ProcessWindowStyle.Hidden,
            UseShellExecute = false,
            CreateNoWindow = true,
            RedirectStandardOutput = true
        };
    }
}
