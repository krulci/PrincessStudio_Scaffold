using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class TaqData
    {
        public long TaqNo { get; set; }
        public long Genre { get; set; }
        public long TaqType { get; set; }
        public long Difficulty { get; set; }
        public string Word { get; set; }
        public string Chunk { get; set; }
        public string Detail { get; set; }
        public string Detail2 { get; set; }
        public string AssistDetail { get; set; }
        public long ImageId { get; set; }
        public long CharNo1 { get; set; }
        public long CharNo2 { get; set; }
        public long CharNo3 { get; set; }
        public long CharNo4 { get; set; }
        public long CharNo5 { get; set; }
        public long InputType1 { get; set; }
        public long InputType2 { get; set; }
        public long InputType3 { get; set; }
        public long InputType4 { get; set; }
        public long InputType5 { get; set; }
    }
}
