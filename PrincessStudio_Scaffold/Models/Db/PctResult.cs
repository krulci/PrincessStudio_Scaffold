using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class PctResult
    {
        public long Id { get; set; }
        public long CharacterId { get; set; }
        public long ScoreFrom { get; set; }
        public long ScoreTo { get; set; }
        public long CommentId1 { get; set; }
        public long CommentId2 { get; set; }
        public long CommentId3 { get; set; }
        public long CommentId4 { get; set; }
        public long CommentId5 { get; set; }
    }
}
