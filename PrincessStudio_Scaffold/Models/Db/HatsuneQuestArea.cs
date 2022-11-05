using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneQuestArea
    {
        public long AreaId { get; set; }
        public long EventId { get; set; }
        public string AreaName { get; set; }
        public long MapType { get; set; }
        public string SheetId { get; set; }
        public string QueId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long AreaDisp { get; set; }
        public long MapId { get; set; }
        public long ScrollWidth { get; set; }
        public long ScrollHeight { get; set; }
        public long OpenTutorialId { get; set; }
        public string TutorialParam1 { get; set; }
        public string TutorialParam2 { get; set; }
        public long AdditionalEffect { get; set; }
    }
}
