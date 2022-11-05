using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class CggCompletionData
    {
        public long CompletionId { get; set; }
        public long CompletionEmblemId { get; set; }
        public long GachaType { get; set; }
        public long CompletionNum { get; set; }
        public long SecretGoodsId1 { get; set; }
        public long SecretGoodsId2 { get; set; }
        public long SecretGoodsId3 { get; set; }
        public string Description { get; set; }
        public string ReceiveDescription { get; set; }
    }
}
