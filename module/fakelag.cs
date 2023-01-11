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
            Random rnd = new Random();
            Form1 form = new Form1();
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTick);

            int minDelay = Convert.ToInt32(form.minFakeLagDelay.Value);
            int maxDelay = Convert.ToInt32(form.maxFakeLagDelay.Value); //warning to end user has to be added - this WILL mess with discord and other network connections.

            int resultedDelay = rnd.Next(minDelay, maxDelay);
            var cmdProcess = Process.Start(GlobalVarHandler.cmdStartInfo);

            if (form.FakeLagStart.Checked == true)
            {               
                aTimer.Enabled = true;
                aTimer.Start(); 
                aTimer.Interval = resultedDelay;
            }
            else
            {
                aTimer.Stop();
                aTimer.Enabled = false;
                cmdProcess.Kill();
            }
       }

        
        public static void OnTick(object source, ElapsedEventArgs e)
        {
            string black = "ipconfig /release";
            string nigger = "ipconfig /renew";
            Random rnd = new Random();
            Form1 form = new Form1();
            int minDelay = Convert.ToInt32(form.minFakeLagDelay.Value);
            int maxDelay = Convert.ToInt32(form.maxFakeLagDelay.Value);
            int resultedDelay = rnd.Next(minDelay, maxDelay);
            var cmdProcess = Process.Start(GlobalVarHandler.cmdStartInfo);

            Console.WriteLine(GlobalVarHandler.fakelag + "Resulted delay complete.");
            Console.WriteLine(GlobalVarHandler.fakelag + "Delay amount approximately " + resultedDelay + "ms.");

            cmdProcess.StandardInput.WriteLine(black); // we release internet connection           
            Thread.Sleep(resultedDelay);
            cmdProcess.StandardInput.WriteLine(nigger); // we renew the internet connection (restart) ik its a bad way to do this but idc
        }

        public static void LagSwitchHandler()
        {
            // we need to add a listener for a set keybind which i will do in the future
            string black = "ipconfig /release";
            string nigger = "ipconfig /renew";

            Form1 form = new Form1();
            var cmdProcess = Process.Start(GlobalVarHandler.cmdStartInfo);
            int time = Convert.ToInt32(form.LagSwitchTime.Value * 1000);

            cmdProcess.StandardInput.WriteLine(black);
            Thread.Sleep(time);
            cmdProcess.StandardInput.WriteLine(nigger);
        }

        public static void FakeLagFluctuation()
        {
            Form1 form = new Form1();
            Random rnd = new Random();
            int minDelay = Convert.ToInt32(form.minFakeLagDelay.Value);
            int maxDelay = Convert.ToInt32(form.maxFakeLagDelay.Value); 
            int resultedDelay = rnd.Next(minDelay, maxDelay);
            System.Timers.Timer FlucCalculator = new System.Timers.Timer();
            FlucCalculator.Elapsed += new ElapsedEventHandler(FlucHandler);
            FlucCalculator.Interval = resultedDelay;

            if (form.FluctuateCheck.Checked == true)
            {
                FlucCalculator.Enabled = true;
                FlucCalculator.Start();
            }
            else
            {
                FlucCalculator.Enabled = false;
                FlucCalculator.Stop();
            }
        }

        public static void FlucHandler(object source, ElapsedEventArgs e)
        {
            System.Timers.Timer FlucCalculator = new System.Timers.Timer();
            FlucCalculator.Elapsed += new ElapsedEventHandler(FlucHandler);
            Mem m = new Mem();
            Form1 form = new Form1();
            Random rnd = new Random();
            int minDelay = Convert.ToInt32(form.minFakeLagDelay.Value);
            int maxDelay = Convert.ToInt32(form.maxFakeLagDelay.Value);
            int FlucResultBefore = Convert.ToInt32(form.FlucAmountVal.Value);
            int resultedDelay = rnd.Next(minDelay, maxDelay);

            FlucCalculator.Interval = resultedDelay;

            

            int FlucResulted = resultedDelay * FlucResultBefore;
            Console.WriteLine(GlobalVarHandler.fakelag + "Fluctuation applied.");
            
            if(form.ReachFluc.Checked == true)
            {
                if (m.ReadFloat("base+3FAE0D0") > 5)
                {
                    resultedDelay = FlucResulted;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

        }

    }
}
