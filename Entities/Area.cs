using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Area : EntityBase
    {
        [MaxLength(256)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(256)]
        public string Municipality { get; set; } = string.Empty;

        [MaxLength(2)]
        public string Region { get; set; } = string.Empty;

        [MaxLength(2)]
        public string Country { get; set; } = string.Empty;

        public IList<Sector> Sectors { get; set; } = new List<Sector>();
    }
}
