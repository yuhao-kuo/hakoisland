using System;
using System.Collections.Generic;

namespace hakoisland.Data
{
    public partial class Facility
    {
        public uint FacilityId { get; set; }
        public uint LocationId { get; set; }
        public uint IslandId { get; set; }
        public uint Employee { get; set; }
        public uint Level { get; set; }
        public uint Exp { get; set; }
        public uint Type { get; set; }
        public uint Stock { get; set; }
        public int SupportPower { get; set; }
        public int LoadingPower { get; set; }
    }
}
