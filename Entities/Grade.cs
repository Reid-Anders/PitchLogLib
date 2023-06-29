using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib.Entities
{
    public class Grade : EntityBase
    {
        public static bool operator >(Grade lhs, Grade rhs)
        {
            if(lhs.Type != rhs.Type)
            {
                throw new InvalidOperationException($"Grade of type {lhs.Type} is not comparable to grade of type {rhs.Type}");
            }

            if(lhs.Type == GradeType.YDS)
            {
                int.TryParse(lhs.Value.Substring(2, lhs.Value.Length == 3 ? 1 : 2), out var lhsNumPart);
                int.TryParse(lhs.Value.Substring(2, rhs.Value.Length == 3 ? 1 : 2), out var rhsNumPart);

                if(lhsNumPart != rhsNumPart)
                {
                    return lhsNumPart > rhsNumPart;
                }

                char.TryParse(lhs.Value.Substring(4, 1), out var lhsLetterPart);
                char.TryParse(rhs.Value.Substring(4, 1), out var rhsLetterPart);

                return lhsLetterPart > rhsLetterPart;
            }

            return true;
        }

        public static bool operator <(Grade lhs, Grade rhs) => !(lhs > rhs);

        public string Value { get; set; }

        public GradeType Type { get; set; }
    }
}
