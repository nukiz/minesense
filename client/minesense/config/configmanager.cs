using Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1.minesense.config
{
    public class configmanager
    {

        public static void SaveConfig()
        {
            Form1 form = new Form1();
            StreamWriter sw = new StreamWriter(Application.ExecutablePath + "/cfg/config.txt");
                            // AUTOCLICKER
            sw.WriteLine("acMinCps = " + Convert.ToString(form.skeetSlider1.Value));
            sw.WriteLine("acMaxCps = " + Convert.ToString(form.skeetSlider2.Value));

                            //CPS RANDOMIZER
            if (form.skeetCheckbox2.Checked == true)
            {
                sw.WriteLine("acRandomizer = true");
            }
            else
            {
                sw.WriteLine("acRandomizer = false");
            }
                            // RIGHTCLICKER
            if (form.skeetCheckbox3.Checked == true)
            {
                sw.WriteLine("acRightClicker = true");
            }
            else
            {
                sw.WriteLine("acRightClicker = false");
            }

                            // REACH
            sw.WriteLine("minReach = " + Convert.ToString(form.skeetSlider6.Value));
            sw.WriteLine("maxReach = " + Convert.ToString(form.skeetSlider5.Value));
            if (form.skeetCheckbox11.Checked == true)
            {
                sw.WriteLine("reachRandomizer = true");
            }
            else
            {
                sw.WriteLine("reachRandomizer = false");
            }

                            // VELOCITY
            sw.WriteLine("VelH = " + form.skeetSlider9.Value);
            sw.WriteLine("VelY = " + form.skeetSlider8.Value);
            if (form.skeetCheckbox14.Checked == true)
            {
                sw.WriteLine("VelRandomizer = true");
            }
            else
            {
                sw.WriteLine("VelRandomizer = false");
            }
            if (form.skeetCheckbox13.Checked == true)
            {
                sw.WriteLine("antiCombo = true");
            }
            else
            {
                sw.WriteLine("antiCombo = false");
            }
            if (form.skeetCheckbox9.Checked == true)
            {
                sw.WriteLine("chance = true");
                sw.WriteLine("chance% = " + form.skeetSlider7.Value);
            }
            else
            {
                sw.WriteLine("chance = false");
            }

                            // antivoid
            if (form.skeetCheckbox7.Checked == true)
            {
                sw.WriteLine("antivoid = true");
                sw.WriteLine("antiVoidSnapBack = " + form.skeetSlider10.Value);
            }
            else
            {
                sw.WriteLine("antivoid = false");
            }


            if (form.skeetCheckbox41.Checked == true)
            {
                sw.WriteLine("comebackassist = true");
                sw.WriteLine("comebackHpThreshold = " + form.skeetSlider18.Value);
            }
            else
            {
                sw.WriteLine("comebackassist = false");
            }





            Console.WriteLine("Succesfully saved config + ");
            
        }

        public static void LoadConfig()
        {
                   
        }


    }
}
