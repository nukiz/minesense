using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace WindowsFormsApp1
{
    public class api
    {

        public static void Initialize()
        {
            string api = "[API] ";
            var script = "[SCRIPT] ";

            Console.WriteLine(api + "Beginning API initialization...");
            Console.WriteLine(script + "No scripts loaded.");

            
            Color DrawGuiColor = new Color();

            // if ()
            Console.WriteLine(api + "Initialization complete.");
        }

        public static void Execute()
        {
            Form1 form = new Form1();
            var exec = form.ScriptTextBox;
            string api = "[API] ";
            string script = "[SCRIPT] ";

            Console.WriteLine(api + "Attempting to execute...");
            if (exec.Text.Length < 24)
            {
                Console.WriteLine(script + "Error while trying to execute - you have not written enough.");
            }
            else
            {
                Funcs();
            }
            Console.WriteLine(script + "Script loaded.");
        }

        public static void Funcs()
        {
            // WIP
        }


    }
}
