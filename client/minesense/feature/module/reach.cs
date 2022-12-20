using System;
using Memory;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class reach
    {               
        public static void Enable()
        {
            Form1 form = new Form1();
            string module = "[MODULE] ";
            Mem m = new Mem();

            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                if (form.skeetCheckbox12.Checked == true)
                {
                    global.MODULEAMOUNT = global.MODULEAMOUNT + 1;
                    m.WriteMemory("base+3FAE0D0", "float", Convert.ToString(form.skeetSlider6.Value));
                    Console.WriteLine(module + "Reach enabled.");
                }                
            }
            else
            {
                Console.WriteLine(module + "Please open Minecraft before attempting to enable modules.");
                return;
            }
        }

        public static void Disable()
        {
            Form1 form = new Form1();
            string module = "[MODULE] ";
            Mem m = new Mem();

            if (form.skeetCheckbox12.Checked == false)
            {
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
                m.WriteMemory("base+3FAE0D0", "float", "3");
                Console.WriteLine(module + "Reach disabled.");
            }
        }

        public static void randomizeCps()
        {
            Form1 form = new Form1();
            string module = "[MODULE] ";
            Mem m = new Mem();

            if (form.skeetCheckbox11.Checked == true)
            {
                form.randomizeCps.Start();
                Console.WriteLine(module + "Reach randomizer active.");
            }
            else
            {
                form.randomizeCps.Stop();
                Console.WriteLine(module + "Reach randomizer disabled.");
            }
        }
    }
}
