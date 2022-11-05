using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ShopStaticPriceGroup
    {
        public long Id { get; set; }
        public long PriceGroupId { get; set; }
        public long BuyCountFrom { get; set; }
        public long BuyCountTo { get; set; }
        public long Count { get; set; }
    }
}
