using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchLogLib
{
    public class CONST
    {
    }

    public enum LengthUnits
    {
        Meters = 1,
        Feet = 2
    }

    public enum Aspect
    {
        North = 1,
        East = 2,
        South = 3,
        West = 4
    }

    public enum GradeType
    {
        YDS = 1,
        French = 2,
        BritishTrad = 3,
        VGrade = 4,
        Font = 5,
        Australian = 6,
        SouthAfrican = 7
    }

    public enum PitchType
    {
        Redpoint = 1,
        Work = 2,
        Climb = 3,
        Flash = 4,
        Onsight = 5,
        Toprope = 6
    }
}
