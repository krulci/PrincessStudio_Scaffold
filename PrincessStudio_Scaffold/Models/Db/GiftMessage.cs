using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class GiftMessage
    {
        public long Id { get; set; }
        public string Discription { get; set; }
        public long Type1 { get; set; }
        public long Type2 { get; set; }
        public long Type3 { get; set; }
        public long Type4 { get; set; }
    }
}
