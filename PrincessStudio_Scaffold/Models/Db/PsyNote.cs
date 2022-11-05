using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PsyNote
    {
        public long PsyProductId { get; set; }
        public long ConditionFlavor1 { get; set; }
        public long ConditionFlavor2 { get; set; }
        public string PsyProductName { get; set; }
        public string Flavor1 { get; set; }
        public string Flavor2 { get; set; }
        public string Flavor3 { get; set; }
        public long DispOrder { get; set; }
        public long InitFlg { get; set; }
    }
}
