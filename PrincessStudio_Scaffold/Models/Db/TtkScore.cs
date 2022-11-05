using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TtkScore
    {
        public long DifficultyLevel { get; set; }
        public long CoefficientDifficulty { get; set; }
        public long CoefficientCoinScore { get; set; }
        public long Life { get; set; }
        public long CoefficientWrongNum { get; set; }
    }
}
