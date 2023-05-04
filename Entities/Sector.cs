using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Sector : EntityBase
    {
        public string Name { get; set; }

        public int? Approach { get; set; }

        public Aspect Aspect { get; set; }

        public Area Area { get; set; }

        public IList<Route>? Routes { get; set; }

        public IList<BoulderProblem>? BoulderProblems { get; set; }
    }
}
