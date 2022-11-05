using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneMultiRouteParameter
    {
        public long Id { get; set; }
        public long QuestId { get; set; }
        public long Type { get; set; }
        public long Param1 { get; set; }
        public long Param2 { get; set; }
        public long Param3 { get; set; }
        public string Text1 { get; set; }
    }
}
