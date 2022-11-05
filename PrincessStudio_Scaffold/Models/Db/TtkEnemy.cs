using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TtkEnemy
    {
        public long EnemyId { get; set; }
        public long Score { get; set; }
        public long Coin { get; set; }
        public long Max { get; set; }
    }
}
