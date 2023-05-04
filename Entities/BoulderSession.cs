using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class BoulderSession : ClimbInstance
    {
        public int SessionLength { get; set; }

        public bool Send { get; set; }
    }
}
