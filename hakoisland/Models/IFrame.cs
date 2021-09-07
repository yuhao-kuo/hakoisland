using System;

namespace hakoisland.Models
{
    public interface IFrame
    {
        /// <summary>
        /// 生產食物
        /// </summary>
        /// <returns></returns>
        int ProductionFood();
        /// <summary>
        /// 賣出食物
        /// </summary>
        /// <returns></returns>
        int TradeOutFood();
    }

    public interface IFrameFactory
    {
        /// <summary>
        /// 出售食物加工品
        /// </summary>
        /// <returns></returns>
        int TradeProcessedFood();
    }
}