using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ClanBattleTrainingData
    {
        public long Id { get; set; }
        public long TrainingId { get; set; }
        public long Mode { get; set; }
        public long Phase { get; set; }
        public long MapDataId { get; set; }
    }
}
