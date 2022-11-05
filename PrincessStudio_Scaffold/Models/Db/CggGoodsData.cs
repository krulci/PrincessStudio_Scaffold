using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CggGoodsData
    {
        public long GoodsId { get; set; }
        public string Name { get; set; }
        public long Rarity { get; set; }
        public long ShelfPositionId { get; set; }
        public double DetailScaleX { get; set; }
        public double DetailScaleY { get; set; }
        public string Description { get; set; }
    }
}
