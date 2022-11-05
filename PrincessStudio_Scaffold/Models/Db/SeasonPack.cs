using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SeasonPack
    {
        public long Id { get; set; }
        public long MissionId { get; set; }
        public long DispOrder { get; set; }
        public long CategoryIcon { get; set; }
        public string ReceiveText { get; set; }
        public string AfterText { get; set; }
        public long GiftMessageId { get; set; }
        public long Term { get; set; }
        public long RepurchaseDay { get; set; }
        public long GroupId { get; set; }
        public long SystemId1 { get; set; }
        public long AddNum1 { get; set; }
        public long ItemRecordId { get; set; }
        public long ConditionFlg { get; set; }
        public long RewardRate1 { get; set; }
    }
}
