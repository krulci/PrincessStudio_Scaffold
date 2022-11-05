using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneMap
    {
        public long CourseId { get; set; }
        public long EventId { get; set; }
        public string Name { get; set; }
        public long MapId { get; set; }
        public string SheetId { get; set; }
        public string QueId { get; set; }
        public long StartAreaId { get; set; }
        public long EndAreaId { get; set; }
    }
}
