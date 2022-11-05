using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class MusicList
    {
        public long MusicId { get; set; }
        public string ListName { get; set; }
        public double FontSize { get; set; }
        public string PreShopStart { get; set; }
        public string ShopStart { get; set; }
        public string ShopEnd { get; set; }
        public long StoryId { get; set; }
        public long CostItemNum { get; set; }
        public long Sort { get; set; }
        public string Kana { get; set; }
        public string IosUrl { get; set; }
        public string AndroidUrl { get; set; }
        public string DmmUrl { get; set; }
    }
}
