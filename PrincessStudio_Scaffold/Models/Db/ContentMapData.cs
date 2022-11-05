using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ContentMapData
    {
        public long ContentMapId { get; set; }
        public string Name { get; set; }
        public long MapType { get; set; }
        public long AreaId { get; set; }
        public long ConditionQuestId { get; set; }
        public long QuestPositionX { get; set; }
        public long QuestPositionY { get; set; }
        public long IconId { get; set; }
        public long SystemId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
