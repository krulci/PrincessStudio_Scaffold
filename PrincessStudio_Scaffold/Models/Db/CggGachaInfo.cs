using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CggGachaInfo
    {
        public long GachaType { get; set; }
        public long CggId { get; set; }
        public string GachaName { get; set; }
        public string GachaDescription { get; set; }
        public long CostCurrencyNum { get; set; }
        public string GachaIntro { get; set; }
    }
}
