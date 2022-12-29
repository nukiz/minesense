using SkeetUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.minesense.feature.overlays;

namespace WindowsFormsApp1.minesense.feature.customization
{
    public class colorhandler
    {
        
        public static void RgbManager()             //rewrite........ will format configs in .json form using Newtonsoft.json
        {

            int r = 255, g = 0, b = 0;
            Form1 form = new Form1();
            arraylist arlst = new arraylist();

            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0)
            {
                g--;
                b++;
            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }

            form.panel3.BackColor = Color.FromArgb(r, g, b);
            form.rnbSpeed.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider1.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider2.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider3.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider4.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider5.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider6.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider7.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider8.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider9.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider10.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider11.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider12.SliderColor = Color.FromArgb(r, g, b);
            form.skeetSlider13.SliderColor = Color.FromArgb(r, g, b);
            form.skeetCheckbox1.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox2.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox3.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox4.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox5.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox6.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox7.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox8.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox9.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox10.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox11.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox12.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox13.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox14.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox15.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox16.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox17.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox18.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox19.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox20.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox21.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox22.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox23.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox24.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox25.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox26.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox27.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox28.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox29.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox30.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox31.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox32.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox33.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox34.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox35.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox36.ColorChecked = Color.FromArgb(r, g, b);
            form.skeetCheckbox37.ColorChecked = Color.FromArgb(r, g, b);
            form.ScriptTextBox.LineNumberColor = Color.FromArgb(r, g, b);
            arlst.AcArLst.ForeColor = Color.FromArgb(r, g, b);
            arlst.ReachArLst.ForeColor = Color.FromArgb(r, g, b);
            arlst.FakeLagArLst.ForeColor = Color.FromArgb(r, g, b);
            arlst.VeloArLst.ForeColor = Color.FromArgb(r, g, b);

        }

    }
}
