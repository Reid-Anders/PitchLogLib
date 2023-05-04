using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Area : EntityBase
    {
        public string Name { get; set; }

        public string NearestTown { get; set; }

        public IList<Sector> Sectors { get; set; } = new List<Sector>();
    }
}
