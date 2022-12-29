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

            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            InitializeMineSense();
        }
        public static void InitializeMineSense()
        {
            arraylist arlst = new arraylist();      
            api api = new api();
            
            string discord = "[DISCORD] ";
            string mnsns = "[MINESENSE] ";
            string hooknotif = "[HOOK] ";
            string eNotif = "[ERROR] ";
            string[] titles = { "bWluZXNlbnNlIG9uIHRvcCE=", "bWluZXNlbnNlIGRlc3Ryb3lzIGhvcmlvbg==", "c2lnbWEgbWluZXNlbnNlIHVzZXI=", "bWFkZSBieSB5b3VyIGRlYXJlc3QgbnVraXo=", "bWluZXNlbnNlIC0gdGhlIHNwYWdoZXR0aSBjb2RlIGhlcm8gb2YgYWxsIGdob3N0IGNsaWVudHM=" };
            Random rnd = new Random(); // to select a random one of those titles :D
            int result = rnd.Next(titles.Length);
            Console.Title = $"{titles[result]}"; // random title selector for CMD window :D

            global.GetUser();
            var USER = global.USER;
            Console.WriteLine("Hello, " + USER + ". We are happy to see you using our cheats. Don't get banned.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(" /$$      /$$ /$$$$$$ /$$   /$$ /$$$$$$$$  /$$$$$$  /$$$$$$$$ /$$   /$$  /$$$$$$  /$$$$$$$$");
            Console.WriteLine("| $$$    /$$$|_  $$_/| $$$ | $$| $$_____/ /$$__  $$| $$_____/| $$$ | $$ /$$__  $$| $$_____/");
            Console.WriteLine("| $$$$  /$$$$  | $$  | $$$$| $$| $$      | $$  \\__/| $$      | $$$$| $$| $$  \\__/| $$    ");
            Console.WriteLine("| $$ $$/$$ $$  | $$  | $$ $$ $$| $$$$$   |  $$$$$$ | $$$$$   | $$ $$ $$|  $$$$$$ | $$$$$   ");
            Console.WriteLine("| $$  $$$| $$  | $$  | $$  $$$$| $$__/    \\____  $$| $$__/   | $$  $$$$ \\____  $$| $$__/   ");
            Console.WriteLine("| $$\\  $ | $$  | $$  | $$\\  $$$| $$       /$$  \\ $$| $$      | $$\\  $$$ /$$  \\ $$| $$      ");
            Console.WriteLine("| $$ \\/  | $$ /$$$$$$| $$ \\  $$| $$$$$$$$|  $$$$$$/| $$$$$$$$| $$ \\  $$|  $$$$$$/| $$$$$$$$");
            Console.WriteLine("|__/     |__/|______/|__/  \\__/|________/ \\______/ |________/|__/  \\__/ \\______/ |________/");
            Console.WriteLine(" ");
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine(" ");
            Console.WriteLine(mnsns + "Beginning MineSense initialization.");
            RPC.rpctimestamp = Timestamps.Now;
            RPC.InitializeRPC();
            api.Initialize();
            Console.WriteLine(mnsns + "Registering Console prefixes... ");
            Thread.Sleep(400);
            Console.WriteLine(hooknotif + "REGISTERED HOOK PREFIX.");
            Console.WriteLine(eNotif + "REGISTERED ERROR PREFIX.");
            Console.WriteLine(discord + "REGISTERED DISCORD PREFIX.");
            RPC.SetState("as " + USER);
            Console.WriteLine(discord + "Discord RPC updated");
            Thread.Sleep(1000);
            Application.Run(new Form1());
            Console.WriteLine(mnsns + "MineSense initialized. Beginning initialization of modules...");
        }

    }
}
