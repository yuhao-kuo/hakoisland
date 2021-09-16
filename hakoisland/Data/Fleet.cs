using System;
using System.Collections.Generic;

namespace hakoisland.Data
{
    public partial class Fleet
    {
        public uint FleetId { get; set; }
        public uint LocationId { get; set; }
        public uint IslandId { get; set; }
        public uint TargetLocationId { get; set; }
        public uint FleetNumber { get; set; }
    }
}
