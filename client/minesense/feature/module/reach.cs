using System;
using Memory;
using WindowsFormsApp1.minesense.feature.overlays;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class reach
    {               
        public static void Enable() // enables reach, if minecraft is open
        {
            Form1 form = new Form1();
            string module = "[MODULE] ";
            Mem m = new Mem();
            arraylist arlst = new arraylist();
            
            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                if (form.skeetCheckbox12.Checked == true)
                {
                    arlst.ReachArLst.Show();
                    arlst.reachPanel.Show();
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

        public static void Disable() // disables reach
        {
            Form1 form = new Form1();
            string module = "[MODULE] ";
            Mem m = new Mem();
            arraylist arlst = new arraylist();

            if (form.skeetCheckbox12.Checked == false)
            {
                arlst.ReachArLst.Hide();
                arlst.reachPanel.Hide();
                form.reachRandomizeTimer.Stop();
                global.MODULEAMOUNT = global.MODULEAMOUNT - 1;
                m.WriteMemory("base+3FAE0D0", "float", "3");
                Console.WriteLine(module + "Reach disabled.");
            }
        }

        public static void reachRandomizer() // initializes randomizer for reach
        {
            Form1 form = new Form1();
            string module = "[MODULE] ";
            Mem m = new Mem();
            arraylist arlst = new arraylist();

            if (form.skeetCheckbox11.Checked == true && form.skeetCheckbox12.Checked == true)
            {
                arlst.ReachArLst.Show();
                arlst.reachPanel.Show();
                form.reachRandomizeTimer.Start();
                Console.WriteLine(module + "Reach randomizer active.");
            }
            else
            {
                arlst.ReachArLst.Hide();
                form.reachRandomizeTimer.Stop();
                Console.WriteLine(module + "Reach randomizer disabled.");
            }
        }
    }
}
