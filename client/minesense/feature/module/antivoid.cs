using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class antivoid
    {
        //TODO: implement this aswell
        // How it should be done (i think) 
        // For one, we should use Memory.dll to read data from player XYZ coordinates addresses.
        // We should then use this data to see, if we have fallen over the value specified in client block amount to snapback threshold.
        // If this value is exceeded, we should return to original XYZ coordinates. XZ coordinates should only be mentioned in the method that will calculate Y coordinate change.
        // You can find XYZ in LocalPlayer vtable in cheat engine. I can give a cheat table for anyone that is interested.
    }
}
