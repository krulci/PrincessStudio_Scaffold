using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TrialBattleCategory
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public long IconId { get; set; }
        public long LabelType1 { get; set; }
        public long LabelType2 { get; set; }
        public long LabelType3 { get; set; }
        public string Description { get; set; }
        public string DescriptionDetail { get; set; }
    }
}
