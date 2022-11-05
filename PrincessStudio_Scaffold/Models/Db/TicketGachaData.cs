using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TicketGachaData
    {
        public long GachaId { get; set; }
        public string GachaName { get; set; }
        public long GachaType { get; set; }
        public long TicketId { get; set; }
        public long GachaTimes { get; set; }
        public long GachaDetail { get; set; }
        public string GuaranteeRarity { get; set; }
        public string RarityOdds { get; set; }
        public string CharaOddsStar1 { get; set; }
        public string CharaOddsStar2 { get; set; }
        public string CharaOddsStar3 { get; set; }
        public long StagingType { get; set; }
    }
}
