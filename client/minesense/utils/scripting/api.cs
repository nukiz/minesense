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
using System.Runtime.InteropServices;
using NLua;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Memory;
using WindowsFormsApp1.minesense.feature.Global;

namespace WindowsFormsApp1
{
    public class api
    {

        static Lua state;
        public static void Initialize()
        {
            Form1 form = new Form1();
            Mem m = new Mem();

            Console.WriteLine(GlobalVarHandler.api + "Initialize lua scripting API...");
        }

        public static void Execute()
        {
            Form1 form = new Form1();            
            state.DoString(form.ScriptTextBox.Text);
        }

        public static void Funcs()
        {
                            
        }

        public static void Error()
        {
            
        }

    }
}
