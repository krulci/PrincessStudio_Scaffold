using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class VoteInfo
    {
        public long VoteId { get; set; }
        public long VoteHelpIndex { get; set; }
        public string VoteTitle { get; set; }
        public string VoteHelp { get; set; }
    }
}
