using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class QuestAreaData
    {
        public long AreaId { get; set; }
        public string AreaName { get; set; }
        public string AreaDisplayName { get; set; }
        public long MapType { get; set; }
        public string SheetId { get; set; }
        public string QueId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
