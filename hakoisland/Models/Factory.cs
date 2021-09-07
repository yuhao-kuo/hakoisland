using System;

namespace hakoisland.Models
{
    public abstract class FactoryBase : FacilityBase, IPollution
    {
        /// <summary>
        /// 生產量
        /// </summary>
        /// <value></value>
        public virtual uint Production { get; }

        /// <summary>
        /// 收益
        /// </summary>
        /// <value></value>
        public virtual uint Income { get; }
    }

    public abstract class AffiliatedFactoryBase : AffiliatedFacilityBase
    {
        /// <summary>
        /// 生產量
        /// </summary>
        /// <value></value>
        public virtual uint Production { get; }

        /// <summary>
        /// 收益
        /// </summary>
        /// <value></value>
        public virtual uint Income { get; }
    }

    /// <summary>
    /// 食品加工廠
    /// </summary>
    public class FoodProductsFactory : FactoryBase, IFrameFactory
    {

        public override uint ProducePollutions()
        {
            this.Pollution = this.Production * 100 / 7;
            return this.Pollution;
        }

        public override uint Production
        {
            get => this.Employees * 100;
        }

        public int TradeProcessedFood()
        {
            return 0;
        }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "食品加工廠, 從業人員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 工廠
    /// </summary>
    public class Factory : FactoryBase
    {
        public override uint ProducePollutions()
        {
            this.Pollution = (uint)(this.Level * 10 / 5);
            base.DiffusionPollutions();
            return this.Pollution;
        }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "工廠, 從業人員: " + this.Employees.ToString());
        }
    }

    /// <summary>
    /// 高科技工廠
    /// </summary>
    public class HighTechFactory : FactoryBase
    {
        public override uint ProducePollutions()
        {
            this.Pollution = (uint)(this.Level * 5 / 2);
            base.DiffusionPollutions();
            return this.Pollution;
        }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "高科技工廠, 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 高科技公司
    /// </summary>
    public class HighTechCompany : FactoryBase
    {
        public override uint ProducePollutions()
        {
            this.Pollution = (uint)(this.Employees * 10 / 9);
            base.DiffusionPollutions();
            return this.Pollution;
        }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "高科技公司, Lv." + this.Level.ToString() + " 職場數: " + this.Employees.ToString() + "人");
        }
    }
}