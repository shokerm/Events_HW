using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    public class LocationEventAregs : EventArgs
    {
       public int x;
        public int y;

        public LocationEventAregs(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
