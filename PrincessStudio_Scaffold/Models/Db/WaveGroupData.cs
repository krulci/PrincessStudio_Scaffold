using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class WaveGroupData
    {
        public long Id { get; set; }
        public long WaveGroupId { get; set; }
        public long Odds { get; set; }
        public long EnemyId1 { get; set; }
        public long DropGold1 { get; set; }
        public long DropRewardId1 { get; set; }
        public long EnemyId2 { get; set; }
        public long DropGold2 { get; set; }
        public long DropRewardId2 { get; set; }
        public long EnemyId3 { get; set; }
        public long DropGold3 { get; set; }
        public long DropRewardId3 { get; set; }
        public long EnemyId4 { get; set; }
        public long DropGold4 { get; set; }
        public long DropRewardId4 { get; set; }
        public long EnemyId5 { get; set; }
        public long DropGold5 { get; set; }
        public long DropRewardId5 { get; set; }
        public long GuestEnemyId { get; set; }
        public long GuestLane { get; set; }
    }
}
