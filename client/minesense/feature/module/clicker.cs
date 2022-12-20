using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class clicker
    {
        public static void Enable()
        {
            
            string module = "[MODULE] ";
            Form1 form = new Form1();

            if (form.skeetCheckbox1.Checked == true)
            {
                Console.WriteLine(module + "Autoclicker enabled.");
            }
            
            
            
            if (form.skeetCheckbox2.Checked == true)
            {
                form.randomizeCps.Start();
                if (form.skeetCheckbox1.Checked == true) 
                { 
                    form.autoclickTimer.Interval = 1000 / Convert.ToInt32(form.skeetSlider3.Value);
                }
            }
            else
            {
                form.autoclickTimer.Interval = 1000 / Convert.ToInt32(form.skeetSlider1.Value);
                form.randomizeCps.Stop();
            }
            
                                      
        }

        public static void Disable()
        {
            string module = "[MODULE] ";
            Form1 form = new Form1();

            if (form.skeetCheckbox1.Checked == false)
            {
                Console.WriteLine(module + "Autoclicker disabled.");
                form.autoclickTimer.Stop();
                form.randomizeCps.Stop();
            }





        }
    }
}
