using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class GlossaryDetail
    {
        public long GlossaryId { get; set; }
        public long GlossaryCategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long UnlockStoryId { get; set; }
        public long CategoryType { get; set; }
        public long DispOrder { get; set; }
    }
}
