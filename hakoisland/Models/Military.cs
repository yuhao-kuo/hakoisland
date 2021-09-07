using System;

namespace hakoisland.Models
{
    public abstract class MilitaryBase : FacilityBase
    {
        /// <summary>
        /// 飛彈庫存量
        /// </summary>
        /// <value></value>
        public virtual uint Stock { get; set; }

        /// <summary>
        /// 監視範圍
        /// </summary>
        /// <value></value>
        public virtual uint MointerRange { get => 0; }
    }

    /// <summary>
    /// 飛彈基地
    /// </summary>
    public class MissileBase : MilitaryBase
    {
        public override uint MointerRange => 8;
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "飛彈基地, Lv." + this.Level.ToString() + "飛彈庫存: " + this.Stock.ToString() + "顆, 監視範圍: " + this.MointerRange.ToString());
        }
    }

    /// <summary>
    /// 防衛基地
    /// </summary>
    public class DefenseBase : MilitaryBase
    {
        public override uint MointerRange => 13;

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "防衛基地, Lv." + this.Level.ToString() + "監視範圍: " + this.MointerRange.ToString());
        }
    }
}