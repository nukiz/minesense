using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp1.minesense.feature.Global
{
    public class GlobalVarHandler
    {
        public static int MODULEAMOUNT = 0;
        public static int MAXMODULES = 15;

        public static string USER;
        public static string CONFIGNAME;
        public static string discord = "[DISCORD] ";
        public static string mnsns = "[MINESENSE] ";
        public static string hooknotif = "[HOOK] ";
        public static string eNotif = "[ERROR] ";
        public static string fakelag = "[FAKELAG] ";
        public static string module = "[MODULE] ";
        public static string api = "[API] ";

        public const string WINDOW_NAME = "Minecraft";


        public static void GetUser()
        {
            Console.WriteLine("Welcome to minesense. What will we call you?");
            USER = Console.ReadLine();
        }

        public static void CheckDlls()
        {
            string[] dlls = { "DiscordRPC.dll", "FastColoredTextBox.dll", "KeraLua.dll", "lua54.dll", "Memory.dll", "NLua.dll", "SkeetUI.dll" };

            foreach (string dll in dlls)
            {
                if (!File.Exists(dll))
                {
                    Console.WriteLine(eNotif + $"FATAL ERROR: {dll} not found.");
                    Console.WriteLine(eNotif + "minesense cannot operate further, if this dll doesn't exist.");
                    Console.WriteLine(eNotif + "If you have deleted dll files, RETURN THEM NOW! If you don't know what causes this issue, ask for support in the Discord.");
                    Thread.Sleep(3000);
                    Environment.Exit(1);
                }
                else
                {
                    return;
                }
            }
        }

        public static void GenerateRandomConsoleName()
        {
            string[] titles = { "bWluZXNlbnNlIG9uIHRvcCE=", "bWluZXNlbnNlIGRlc3Ryb3lzIGhvcmlvbg==", "c2lnbWEgbWluZXNlbnNlIHVzZXI=", "bWFkZSBieSB5b3VyIGRlYXJlc3QgbnVraXo=", "bWluZXNlbnNlIC0gdGhlIHNwYWdoZXR0aSBjb2RlIGhlcm8gb2YgYWxsIGdob3N0IGNsaWVudHM=" };
            Random rnd = new Random(); // to select a random one of those titles :D
            int result = rnd.Next(titles.Length);
            Console.Title = $"{titles[result]}"; // random title selector for CMD window :D
        }

        public static void MinesenseLogoAscii()
        {
            Console.Clear();
            Console.WriteLine("__________________________________________________________________________________________________");
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
        }

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