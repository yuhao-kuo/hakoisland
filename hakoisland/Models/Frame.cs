using System;

namespace hakoisland.Models
{
    public abstract class FrameBase : FacilityBase
    {
        /// <summary>
        /// 生產量
        /// </summary>
        /// <value></value>
        public virtual uint Production { get; set; }

        /// <summary>
        /// 庫存量
        /// </summary>
        /// <value></value>
        public virtual uint Stock { get; set; }

        /// <summary>
        /// 生產食物
        /// </summary>
        /// <returns></returns>
        public virtual int ProductionFood()
        {
            return 0;
        }

        /// <summary>
        /// 出售食物
        /// </summary>
        /// <returns></returns>
        public virtual int TradeOutFood()
        {
            return 0;
        }
    }

    public abstract class AffiliatedFrameBase : AffiliatedFacilityBase
    {
        /// <summary>
        /// 生產量
        /// </summary>
        /// <value></value>
        public virtual uint Production { get; set; }

        /// <summary>
        /// 庫存量
        /// </summary>
        /// <value></value>
        public virtual uint Stock { get; set; }

        /// <summary>
        /// 生產食物
        /// </summary>
        /// <returns></returns>
        public virtual int ProductionFood()
        {
            return 0;
        }

        /// <summary>
        /// 出售食物
        /// </summary>
        /// <returns></returns>
        public virtual int TradeOutFood()
        {
            return 0;
        }
    }

    /// <summary>
    /// 大型農場
    /// </summary>
    public class BigFrame : FrameBase
    {
        /// <summary>
        /// 生產食物
        /// </summary>
        /// <returns></returns>
        public override int ProductionFood()
        {
            // TODO: 農業技術相關
            return base.ProductionFood();
        }

        /// <summary>
        /// 賣出食物
        /// </summary>
        /// <returns></returns>
        public override int TradeOutFood()
        {
            // TODO: 賣出
            return base.TradeOutFood();
        }

        /// <summary>
        /// 產生污染
        /// </summary>
        public override uint ProducePollutions()
        {
            this.Pollution = (uint)(this.Ext * this.Level * 7 / 3);
            base.DiffusionPollutions();
            return this.Pollution;
        }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "大型農場, 從業員: " + this.Employees.ToString() + "生產量: " + this.Production.ToString());
        }
    }

    /// <summary>
    /// 食物研究所
    /// </summary>
    public class FrameResearchInstitute : FrameBase
    {
        public override int TradeOutFood()
        {
            return 0;
        }

        public override uint ProducePollutions()
        {
            this.Pollution = (uint)(this.Ext * this.Level * 10 / 3);
            base.DiffusionPollutions();
            return this.Pollution;
        }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "食物研究所, Lv." + this.Level.ToString() + " 從業人員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 牧場
    /// </summary>
    public class Pasture : FrameBase
    {
        public override uint ProducePollutions()
        {
            this.Pollution = (uint)(this.Ext * this.Level * 10 / 3);
            base.DiffusionPollutions();
            return this.Pollution;
        }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "牧場, Lv." + this.Level.ToString() + ", 從業員: " + this.Employees.ToString() + "人, 牛 " + this.Stock.ToString() + "頭");
        }
    }

    public class CityFrame : AffiliatedFrameBase
    {
        public override string ToString()
        {
            return new string("農場, Lv." + this.Level.ToString() + " 從業員: " + this.Employees.ToString());
        }
    }
}