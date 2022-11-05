using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TowerWaveGroupData
    {
        public long Id { get; set; }
        public long WaveGroupId { get; set; }
        public long Odds { get; set; }
        public long EnemyId1 { get; set; }
        public long EnemyId2 { get; set; }
        public long EnemyId3 { get; set; }
        public long EnemyId4 { get; set; }
        public long EnemyId5 { get; set; }
    }
}
