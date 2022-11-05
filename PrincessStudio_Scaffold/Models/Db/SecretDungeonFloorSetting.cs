using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SecretDungeonFloorSetting
    {
        public long Id { get; set; }
        public long QuestId { get; set; }
        public long EnemyIdentify { get; set; }
        public long Mode { get; set; }
        public long EnemyId { get; set; }
        public double FloorPositionX { get; set; }
        public double FloorPositionY { get; set; }
        public double FloorScale { get; set; }
        public long DispOrder { get; set; }
    }
}
