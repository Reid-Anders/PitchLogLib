using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public string UserName { get; set; }
    }
}
