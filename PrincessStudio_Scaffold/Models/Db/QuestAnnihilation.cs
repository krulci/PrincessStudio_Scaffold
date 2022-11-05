using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class QuestAnnihilation
    {
        public long SystemId { get; set; }
        public long QuestId { get; set; }
        public long EffectType { get; set; }
        public long QuestEffectPosition { get; set; }
        public string SeCueName { get; set; }
    }
}
