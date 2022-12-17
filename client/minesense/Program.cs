using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DiscordRPC;

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


            string discord = "[DISCORD] ";
            string mnsns = "[MINESENSE] ";
            string hooknotif = "[HOOK] ";
            string eNotif = "[ERROR] ";

                      


            Console.Title = "TUlORVNFTlNFIE9XTlMgVEhFIENIRUFUIEdBTUU=";
            Console.WriteLine("Welcome to MineSense. What will we call you?");
            var USER = Console.ReadLine();
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
            Console.WriteLine(mnsns + "Beginning MineSense utilization...");
            RPC.rpctimestamp = Timestamps.Now;
            RPC.InitializeRPC();
            Console.WriteLine(mnsns + "Registering Console prefixes... ");
            Thread.Sleep(400);
            Console.WriteLine(hooknotif + "REGISTERED HOOK PREFIX...");
            Console.WriteLine(eNotif + "REGISTERED ERROR PREFIX...");
            Console.WriteLine(discord + "REGISTERED DISCORD PREFIX...");
            RPC.SetState("as " + USER);
            Console.WriteLine(discord + "Discord RPC updated");
            Thread.Sleep(1000);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());            
            Console.WriteLine(mnsns + "MineSense utilized. Beginning utilization of modules...");
                       
            

        }
    }
}
