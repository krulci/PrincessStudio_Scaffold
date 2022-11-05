using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class RoomEffect
    {
        public long Id { get; set; }
        public long RewardGet { get; set; }
        public long Jukebox { get; set; }
        public long Nebbia { get; set; }
        public long Arcade { get; set; }
        public long Vegetable { get; set; }
        public long Poster { get; set; }
        public long Stock { get; set; }
    }
}
