using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public abstract class ClimbInstance : OwnedEntity
    {
        public Climb Climb { get; set; }

        public DateTimeOffset Date { get; set; }
    }
}
