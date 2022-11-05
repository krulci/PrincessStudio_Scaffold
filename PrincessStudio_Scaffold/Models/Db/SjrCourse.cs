using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class SjrCourse
    {
        public long CourseId { get; set; }
        public long Type { get; set; }
        public long DifficultyLevel { get; set; }
        public long Feature { get; set; }
        public long Length { get; set; }
        public long PeekPos { get; set; }
        public double Time { get; set; }
        public long Rail1 { get; set; }
        public long Rail2 { get; set; }
        public long Rail3 { get; set; }
    }
}
