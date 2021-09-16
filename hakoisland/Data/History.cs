using System;
using System.Collections.Generic;

namespace hakoisland.Data
{
    public partial class History
    {
        public int HistoryId { get; set; }
        public int Uid { get; set; }
        public int Time { get; set; }
        public string Infomation { get; set; }
    }
}
