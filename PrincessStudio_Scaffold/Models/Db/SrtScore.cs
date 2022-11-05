using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SrtScore
    {
        public long DifficultyLevel { get; set; }
        public long CoefficientReadType1 { get; set; }
        public long CoefficientReadType2 { get; set; }
        public long CoefficientReadType3 { get; set; }
        public long CoefficientCountPriconnePanel { get; set; }
        public long CoefficientFever { get; set; }
        public long ConstantTurnBonus { get; set; }
        public long CoefficientTurnBonus { get; set; }
        public long CoefficientAvgAnswerTime { get; set; }
        public long ConstantWrongNum { get; set; }
        public long CoefficientWrongNum { get; set; }
    }
}
