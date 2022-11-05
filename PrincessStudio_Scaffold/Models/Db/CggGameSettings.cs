using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CggGameSettings
    {
        public long CggId { get; set; }
        public long GoodsShelfId { get; set; }
        public long FirstGoodsShelfRewardNum { get; set; }
        public long CggGachaCurrencyId { get; set; }
        public long FirstCurrencyRewardNum { get; set; }
        public long ExchangeLuppiRate { get; set; }
        public long MaxGachaExchangeCount { get; set; }
        public long MaxGoodsCount { get; set; }
    }
}
