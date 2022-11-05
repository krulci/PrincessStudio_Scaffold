using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class EquipmentDonation
    {
        public long TeamLevel { get; set; }
        public long DonationNumOnce { get; set; }
        public long DonationNumDaily { get; set; }
        public long RequestNumOnce { get; set; }
    }
}
