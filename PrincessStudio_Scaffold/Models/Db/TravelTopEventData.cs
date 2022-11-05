using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TravelTopEventData
    {
        public long TopEventId { get; set; }
        public long DramaType { get; set; }
        public long Pattern { get; set; }
        public long ZoomOffsetX { get; set; }
        public long ZoomOffsetY { get; set; }
        public long PreDramaId { get; set; }
        public long MainDramaId { get; set; }
        public long BranchId1 { get; set; }
        public long BranchId2 { get; set; }
        public long BranchId3 { get; set; }
        public long BranchId4 { get; set; }
        public long BranchId5 { get; set; }
        public long ChestId { get; set; }
    }
}
