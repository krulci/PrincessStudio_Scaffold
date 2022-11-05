using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EnemyMParts
    {
        public long EnemyId { get; set; }
        public string Name { get; set; }
        public long ChildEnemyParameter1 { get; set; }
        public long ChildEnemyParameter2 { get; set; }
        public long ChildEnemyParameter3 { get; set; }
        public long ChildEnemyParameter4 { get; set; }
        public long ChildEnemyParameter5 { get; set; }
    }
}
