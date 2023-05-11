using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Grade : EntityBase
    {
        public string Value { get; set; }

        public GradeType Type { get; set; }
    }
}
