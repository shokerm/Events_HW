using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    public class PointEventArgs: EventArgs
    {
       public int _goodSpaceShipHitPoints;

        public PointEventArgs(int goodSpaceShipHitPoints)
        {
            _goodSpaceShipHitPoints = goodSpaceShipHitPoints;
        }
    }
}
