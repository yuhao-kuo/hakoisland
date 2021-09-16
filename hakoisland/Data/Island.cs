using System;
using System.Collections.Generic;

namespace hakoisland.Data
{
    public partial class Island
    {
        public int IslandId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int Funds { get; set; }
        public uint Foods { get; set; }
        public uint AccumulatedTourists { get; set; }
    }
}
