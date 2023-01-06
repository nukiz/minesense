using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DiscordRPC;
using System.Runtime.Remoting.Messaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Reflection;
using WindowsFormsApp1.minesense.feature.overlays;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using WindowsFormsApp1.minesense.feature.Global;

namespace WindowsFormsApp1
{
    
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            GlobalVarHandler.CheckDlls();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            InitializeMineSense();
        }
        public static void InitializeMineSense()
        {
            api api = new api();
            GlobalVarHandler.GenerateRandomConsoleName();
            GlobalVarHandler.GetUser();
            var USER = GlobalVarHandler.USER;
            Console.WriteLine("Hello, " + USER + ". We are happy to see you using our cheats. Don't get banned.");
            Thread.Sleep(1000);
            GlobalVarHandler.MinesenseLogoAscii();
            Console.WriteLine(" ");
            Console.WriteLine(GlobalVarHandler.mnsns + "Beginning MineSense initialization.");
            RPC.rpctimestamp = Timestamps.Now;
            RPC.InitializeRPC();
            api.Initialize();
            Console.WriteLine(GlobalVarHandler.mnsns + "Registering Console prefixes... ");
            Thread.Sleep(400);
            Console.WriteLine(GlobalVarHandler.hooknotif + "REGISTERED HOOK PREFIX.");
            Console.WriteLine(GlobalVarHandler.eNotif + "REGISTERED ERROR PREFIX.");
            Console.WriteLine(GlobalVarHandler.discord + "REGISTERED DISCORD PREFIX.");
            RPC.SetState("as " + USER);
            Console.WriteLine(GlobalVarHandler.discord + "Discord RPC updated");
            Thread.Sleep(1000);
            Application.Run(new Form1());
            Console.WriteLine(GlobalVarHandler.mnsns + "MineSense initialized. Beginning initialization of modules..."); //pretty basic shit
        }

    }
}
