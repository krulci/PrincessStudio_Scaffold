using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CampaignLevelData
    {
        public long Id { get; set; }
        public long LevelId { get; set; }
        public long LvFrom { get; set; }
        public long LvTo { get; set; }
        public long Value { get; set; }
        public string LabelColor { get; set; }
        public string FrameColor { get; set; }
    }
}
