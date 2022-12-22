﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.minesense.feature.overlays;
using Timer = System.Windows.Forms.Timer;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class clicker
    {
        public static void Enable()
        {
            
            string module = "[MODULE] ";
            Form1 form = new Form1();
            arraylist arlst = new arraylist();

            if (form.skeetCheckbox1.Checked == true)
            {

                Console.WriteLine(module + "Autoclicker enabled.");
                form.autoclickTimer.Enabled = true;
            }
                                                                                               
        }

        public static void RandomizerEnable()
        {
            string module = "[MODULE] ";
            Form1 form = new Form1();
            arraylist arlst = new arraylist();

            if (form.skeetCheckbox2.Checked == true)
            {
                Console.WriteLine(module + "Autoclicker randomizer enabled.");
                form.randomizeCps.Start();
                if (form.skeetCheckbox1.Checked == true)
                {
                    form.autoclickTimer.Interval = 1000 / Convert.ToInt32(form.skeetSlider3.Value);
                }
            }            
        }

        public static void RandomizerDisable()
        {
            string module = "[MODULE] ";
            Form1 form = new Form1();
            arraylist arlst = new arraylist();

            if (form.skeetCheckbox2.Checked == false)
            {
                Console.WriteLine(module + "Autoclicker randomizer disabled.");
                form.randomizeCps.Stop();
                if (form.skeetCheckbox1.Checked == true)
                {
                    form.autoclickTimer.Interval = 1000 / Convert.ToInt32(form.skeetSlider3.Value);
                }
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
