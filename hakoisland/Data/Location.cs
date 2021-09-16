using System;
using System.Collections.Generic;

namespace hakoisland.Data
{
    public partial class Location
    {
        public uint LocationId { get; set; }
        public uint Uoid { get; set; }
        public uint X { get; set; }
        public uint Y { get; set; }
        public uint Pollution { get; set; }
    }
}
