using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SjrUbData
    {
        public long UbId { get; set; }
        public string TopDescription { get; set; }
        public string InGameDescription { get; set; }
        public long UbType { get; set; }
        public long UbValue1 { get; set; }
        public long UbValue2 { get; set; }
        public long UbValue3 { get; set; }
        public long UbValue4 { get; set; }
    }
}
