using System;

namespace hakoisland.Models
{
    public class History
    {
        /// <summary>
        /// 回合
        /// </summary>
        /// <value></value>
        public uint Round { get; set; }
        /// <summary>
        /// 事件內容
        /// </summary>
        /// <value></value>
        public string Infomation { get; set; }
        /// <summary>
        /// 曆法
        /// </summary>
        /// <value></value>
        public string Calendar { get; set; }
    }
}