using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class OddsNameData
    {
        public long Id { get; set; }
        public string OddsFile { get; set; }
        public string Name { get; set; }
        public long IconType { get; set; }
        public string Description { get; set; }
    }
}
