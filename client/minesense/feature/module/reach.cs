using System;
using Memory;
using WindowsFormsApp1.minesense.feature.Global;
using WindowsFormsApp1.minesense.feature.overlays;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class reach
    {               
        public static void Enable() // enables reach, if minecraft is open
        {
            Form1 form = new Form1();
            
            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                if (form.skeetCheckbox12.Checked == true)
                {
                    Console.WriteLine(GlobalVarHandler.module + "Reach enabled.");
                }                                    
            }
            else
            {
                Console.WriteLine(GlobalVarHandler.module + "Please open Minecraft before attempting to enable modules.");
                return;
            }
        }

        public static void Disable() // disables reach
        {
            Form1 form = new Form1();

            if (form.skeetCheckbox12.Checked == false)
            {
                Console.WriteLine(GlobalVarHandler.module + "Reach disabled.");
            }
        }

        public static void reachRandomizer() // initializes randomizer for reach
        {
            Form1 form = new Form1();

            if (form.skeetCheckbox11.Checked == true && form.skeetCheckbox12.Checked == true)
            {
                Console.WriteLine(GlobalVarHandler.module + "Reach randomizer active.");
            }
            else
            {
                Console.WriteLine(GlobalVarHandler.module + "Reach randomizer disabled.");
            }
        }
    }
}
