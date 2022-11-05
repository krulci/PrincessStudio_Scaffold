using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class ThumbnailHideCondition
    {
        public long StoryGroupId { get; set; }
        public long HideStoryIdFrom { get; set; }
        public long HideStoryIdTo { get; set; }
        public long UnlockConditionStoryId { get; set; }
    }
}
