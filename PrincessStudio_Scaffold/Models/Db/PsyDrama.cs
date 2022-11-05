using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PsyDrama
    {
        public long DramaId { get; set; }
        public long ConditionTotalEat { get; set; }
        public long ConditionCharaType { get; set; }
        public string ConditionTime { get; set; }
        public long ConditionPsyProduct1 { get; set; }
        public long ConditionPsyProduct2 { get; set; }
        public long ConditionPsyProduct3 { get; set; }
        public long ConditionPsyProduct4 { get; set; }
        public long ConditionPsyProduct5 { get; set; }
        public long ReleasePsyProductId1 { get; set; }
        public long ReleasePsyProductId2 { get; set; }
        public long ReleasePsyProductId3 { get; set; }
        public long ReleasePsyProductId4 { get; set; }
        public long ReleasePsyProductId5 { get; set; }
        public string Title { get; set; }
    }
}
