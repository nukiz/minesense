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
            Mem m = new Mem();
            arraylist arlst = new arraylist();
            
            if (m.OpenProcess("Minecraft.Windows.exe"))
            {
                if (form.skeetCheckbox12.Checked == true)
                {
                    arlst.ReachArLst.Show();
                    arlst.reachPanel.Show();
                    GlobalVarHandler.MODULEAMOUNT = GlobalVarHandler.MODULEAMOUNT + 1;
                    m.WriteMemory("base+3FAE0D0", "float", Convert.ToString(form.skeetSlider6.Value));
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
            Mem m = new Mem();
            arraylist arlst = new arraylist();

            if (form.skeetCheckbox12.Checked == false)
            {
                arlst.ReachArLst.Hide();
                arlst.reachPanel.Hide();
                form.reachRandomizeTimer.Stop();
                GlobalVarHandler.MODULEAMOUNT = GlobalVarHandler.MODULEAMOUNT - 1;
                m.WriteMemory("base+3FAE0D0", "float", "3");
                Console.WriteLine(GlobalVarHandler.module + "Reach disabled.");
            }
        }

        public static void reachRandomizer() // initializes randomizer for reach
        {
            Form1 form = new Form1();
            Mem m = new Mem();
            arraylist arlst = new arraylist();

            if (form.skeetCheckbox11.Checked == true && form.skeetCheckbox12.Checked == true)
            {
                arlst.ReachArLst.Show();
                arlst.reachPanel.Show();
                form.reachRandomizeTimer.Start();
                Console.WriteLine(GlobalVarHandler.module + "Reach randomizer active.");
            }
            else
            {
                arlst.ReachArLst.Hide();
                form.reachRandomizeTimer.Stop();
                Console.WriteLine(GlobalVarHandler.module + "Reach randomizer disabled.");
            }
        }
    }
}
