using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Sector : EntityBase
    {
        [MaxLength(256)]
        public string Name { get; set; }

        [Range(0,1024)]
        public int? Approach { get; set; }

        public Aspect Aspect { get; set; }

        public Area Area { get; set; }

        public int AreaID { get; set; }

        public IList<Route>? Routes { get; set; }

        public IList<BoulderProblem>? BoulderProblems { get; set; }
    }
}
