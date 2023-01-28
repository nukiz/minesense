using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.minesense.feature.module
{
    public class velocity
    {
        // This is pretty straightforward.
        // You find knockback change memory address from somewhere (idk where, this is why this doesn't exist) and set it's value to only change X% depending on XZ/Y % specified in client.
        // For anticombo, we should see how many times and if the times exceed a number (lets say 5). If the player has been hit more than 5 times in like 6-8 secs, we should negate all knockback for a small while.
        // This way the player will land safely and take knockback again.
    }
}
