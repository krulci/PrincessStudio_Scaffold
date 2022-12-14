using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class HatsuneDiaryScript
    {
        public long Id { get; set; }
        public long DiaryId { get; set; }
        public long SeqNum { get; set; }
        public long Type { get; set; }
        public string DiaryText { get; set; }
        public long TextAnimationSpeed { get; set; }
        public string SheetName { get; set; }
        public string CueName { get; set; }
        public long Command { get; set; }
        public double CommandParam { get; set; }
    }
}
