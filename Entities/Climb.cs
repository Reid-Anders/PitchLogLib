using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public abstract class Climb : EntityBase
    {
        public string Name { get; set; }

        public Grade Grade { get; set; }

        public int GradeID { get; set; }

        public Sector Sector { get; set; }

        public int SectorID { get; set; }
    }
}
