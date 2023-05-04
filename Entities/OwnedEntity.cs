using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public abstract class OwnedEntity : EntityBase
    {
        public User User { get; set; }
    }
}
