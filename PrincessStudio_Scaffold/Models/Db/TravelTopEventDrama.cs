using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TravelTopEventDrama
    {
        public long CommandId { get; set; }
        public long DramaId { get; set; }
        public long CommandType { get; set; }
        public string Param01 { get; set; }
        public string Param02 { get; set; }
        public string Param03 { get; set; }
        public string Param04 { get; set; }
        public string Param05 { get; set; }
        public string Param06 { get; set; }
        public string Param07 { get; set; }
        public string Param08 { get; set; }
    }
}
