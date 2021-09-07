
using System;

namespace hakoisland.Models
{
    public class Island
    {
        /// <summary>
        /// 島嶼名稱
        /// </summary>
        /// <value></value>
        public string Name { get; set; }

        /// <summary>
        /// 玩家名稱
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }

        /// <summary>
        /// 資金(億)
        /// </summary>
        /// <value></value>
        public uint Funds { get; set; }

        /// <summary>
        /// 食料數量(萬噸)
        /// </summary>
        /// <value></value>
        public uint Foods { get; set; }

        /// <summary>
        /// 累積觀光客(萬人)
        /// </summary>
        /// <value></value>
        public uint AccumulatedTourists { get; set; }
    }
}