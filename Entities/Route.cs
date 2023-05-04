using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Route : Climb
    {
        public Length? Length { get; set; }
    }
}
