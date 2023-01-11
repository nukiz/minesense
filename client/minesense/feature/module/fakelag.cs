using System;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using Memory;
using System.Diagnostics;
using WindowsFormsApp1.minesense.feature.Global;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class fakelag
    {       
        public static void Starter()
        {

            if (form.FakeLagStart.Checked == true)
            {               
            }
            else
            {
            }
       }

        
        public static void OnTick(object source, ElapsedEventArgs e)
        {
        }

        public static void LagSwitchHandler()
        {
            // we need to add a listener for a set keybind which i will do in the future
        }

        public static void FakeLagFluctuation()
        {


            if (form.FluctuateCheck.Checked == true)
            {
            }
            else
            {
            }
        }

        public static void FlucHandler(object source, ElapsedEventArgs e)
        {
            // code it yourself you monkey
        }

    }
}
