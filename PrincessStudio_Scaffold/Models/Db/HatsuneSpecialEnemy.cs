using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneSpecialEnemy
    {
        public long EnemyId { get; set; }
        public long EventId { get; set; }
        public long Mode { get; set; }
        public long EnemyPoint { get; set; }
        public long InitialPosition { get; set; }
        public long Order { get; set; }
    }
}
