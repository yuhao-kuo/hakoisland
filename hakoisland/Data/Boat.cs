using System;
using System.Collections.Generic;

namespace hakoisland.Data
{
    public partial class Boat
    {
        public uint BoatId { get; set; }
        public uint LocationId { get; set; }
        public uint IslandId { get; set; }
        public uint FleetId { get; set; }
        public uint Type { get; set; }
        public uint Vector { get; set; }
        public uint Hp { get; set; }
        public uint MaxSpeed { get; set; }
        public uint BoatLoad { get; set; }
        public int Deep { get; set; }
    }
}
