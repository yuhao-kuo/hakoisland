
using System;
using System.Collections.Generic;

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

    public class IslandInfo : Island
    {
        /// <summary>
        /// 排名
        /// </summary>
        /// <value></value>
        public uint Rank { get; set; }
        /// <summary>
        /// 積分
        /// </summary>
        /// <value></value>
        public uint Integral { get; set; }
        /// <summary>
        /// 總面積
        /// </summary>
        /// <value></value>
        public uint TotalArea { get; set; }
        /// <summary>
        /// 工業從業員人數
        /// </summary>
        /// <value></value>
        public uint IndustryEmployee { get; set; }
        /// <summary>
        /// 農業從業員人數
        /// </summary>
        /// <value></value>
        public uint FrameEmployee { get; set; }
        /// <summary>
        /// 礦業從業員人數
        /// </summary>
        /// <value></value>
        public uint MiningEmployee { get; set; }
        /// <summary>
        /// 發電量
        /// </summary>
        /// <value></value>
        public uint TotalPower { get; set; }
        /// <summary>
        /// 失業率
        /// </summary>
        /// <value></value>
        public double UnemploymentRate { get; set; }
        /// <summary>
        /// 島嶼訊息
        /// </summary>
        /// <value></value>
        public string UserInfomation { get; set; }
    }
}