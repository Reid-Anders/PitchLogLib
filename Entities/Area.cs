using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Area : EntityBase
    {
        public string Name { get; set; } = string.Empty;

        public string Municipality { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public IList<Sector> Sectors { get; set; } = new List<Sector>();
    }
}
