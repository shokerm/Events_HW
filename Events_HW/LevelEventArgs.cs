using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    public class LevelEventArgs: EventArgs
    {
        public int Level { get; set; }
        public LevelEventArgs()
        {
            Level = 1;
        }
    }
}
