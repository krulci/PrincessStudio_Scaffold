using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SjrNameFormer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ConstrainGroup { get; set; }
        public long ConditionType1 { get; set; }
        public long ConditionType2 { get; set; }
        public long ConditionType3 { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long ConditionValue3 { get; set; }
    }
}
