using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SjrParameterEvaluation
    {
        public long ParameterType { get; set; }
        public double Border1 { get; set; }
        public double Border2 { get; set; }
        public double Border3 { get; set; }
    }
}
