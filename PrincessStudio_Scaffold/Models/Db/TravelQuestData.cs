using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TravelQuestData
    {
        public long TravelQuestId { get; set; }
        public long TravelAreaId { get; set; }
        public string TravelQuestName { get; set; }
        public long LimitUnitNum { get; set; }
        public long NeedPower { get; set; }
        public long TravelTime { get; set; }
        public long TravelTimeDecreaseLimit { get; set; }
        public long TravelDecreaseFlag { get; set; }
        public long MainReward1 { get; set; }
        public long MainReward2 { get; set; }
        public long MainReward3 { get; set; }
        public long MainReward4 { get; set; }
        public long MainReward5 { get; set; }
        public long IconId { get; set; }
        public long IconX { get; set; }
        public long IconY { get; set; }
        public long SituationGroupId { get; set; }
    }
}
