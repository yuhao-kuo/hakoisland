using System;

namespace hakoisland.Models
{
    public interface IPollution
    {
        /// <summary>
        /// 清除污染
        /// </summary>
        void ClearPollution();

        /// <summary>
        /// 產生污染
        /// </summary>
        uint ProducePollutions();

        /// <summary>
        /// 污染擴散
        /// </summary>
        void DiffusionInjection(uint p);
    }
}