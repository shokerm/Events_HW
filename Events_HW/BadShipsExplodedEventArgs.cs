using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    public class BadShipsExplodedEventArgs : EventArgs
    {
       public int _numberOfBadShips;

        public BadShipsExplodedEventArgs(int numberOfBadShips)
        {
            _numberOfBadShips = numberOfBadShips;
        }
    }
}
