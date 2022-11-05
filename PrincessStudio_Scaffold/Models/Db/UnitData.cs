using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitData
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; }
        public string Kana { get; set; }
        public long PrefabId { get; set; }
        public long PrefabIdBattle { get; set; }
        public long IsLimited { get; set; }
        public long Rarity { get; set; }
        public long MotionType { get; set; }
        public long SeType { get; set; }
        public long MoveSpeed { get; set; }
        public long SearchAreaWidth { get; set; }
        public long AtkType { get; set; }
        public double NormalAtkCastTime { get; set; }
        public long Cutin1 { get; set; }
        public long Cutin2 { get; set; }
        public long Cutin1Star6 { get; set; }
        public long Cutin2Star6 { get; set; }
        public long GuildId { get; set; }
        public long ExskillDisplay { get; set; }
        public string Comment { get; set; }
        public long OnlyDispOwned { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long OriginalUnitId { get; set; }
    }
}
