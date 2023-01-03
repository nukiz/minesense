using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.minesense.feature.Global;
using WindowsFormsApp1.minesense.feature.overlays;
using Timer = System.Windows.Forms.Timer;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class clicker
    {
        public static void Enable()
        {
            Form1 form = new Form1();

            if (form.skeetCheckbox1.Checked == true)
            {

                Console.WriteLine(GlobalVarHandler.module + "Autoclicker enabled.");
                form.autoclickTimer.Enabled = true;
                form.autoclickTimer.Start();
            }
                                                                                               
        }

        public static void RandomizerEnable()
        {
            Form1 form = new Form1();

            if (form.skeetCheckbox2.Checked == true)
            {
                Console.WriteLine(GlobalVarHandler.module + "Autoclicker randomizer enabled.");
                form.randomizeCps.Start();
                if (form.skeetCheckbox1.Checked == true)
                {
                    form.autoclickTimer.Interval = 1000 / Convert.ToInt32(form.skeetSlider3.Value);
                }
            }            
        }

        public static void RandomizerDisable()
        {
            Form1 form = new Form1();
 
            if (form.skeetCheckbox2.Checked == false)
            {
                Console.WriteLine(GlobalVarHandler.module + "Autoclicker randomizer disabled.");
                form.randomizeCps.Stop();
                if (form.skeetCheckbox1.Checked == true)
                {
                    form.autoclickTimer.Interval = 1000 / Convert.ToInt32(form.skeetSlider3.Value);
                }
            }
            
        }

        public static void Disable()
        {
            Form1 form = new Form1();

            if (form.skeetCheckbox1.Checked == false)
            {
                Console.WriteLine(GlobalVarHandler.module + "Autoclicker disabled.");
                form.autoclickTimer.Stop();
                form.randomizeCps.Stop();
            }
        }
    }
}
