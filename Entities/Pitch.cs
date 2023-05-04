using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Pitch : ClimbInstance
    {
        public string? Partner { get; set; }

        public PitchType? Type { get; set; }
    }
}
