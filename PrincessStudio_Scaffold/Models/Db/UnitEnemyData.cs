using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class UnitEnemyData
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; }
        public long PrefabId { get; set; }
        public long MotionType { get; set; }
        public long SeType { get; set; }
        public long MoveSpeed { get; set; }
        public long SearchAreaWidth { get; set; }
        public long AtkType { get; set; }
        public double NormalAtkCastTime { get; set; }
        public long Cutin { get; set; }
        public long CutinStar6 { get; set; }
        public long VisualChangeFlag { get; set; }
        public string Comment { get; set; }
    }
}
