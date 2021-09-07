using System;

namespace hakoisland.Models
{
    public abstract class PowerPlant : FacilityBase
    {

        /// <summary>
        /// 最大供電量
        /// </summary>
        /// <value>最大供電量，此欄位用於限制最大電量</value>
        public virtual uint MaxSupportPower { get; }

        /// <summary>
        /// 維持費
        /// </summary>
        /// <value></value>
        public virtual uint MaintenanceFee { get; set; }
        
    }

    /// <summary>
    /// 火力發電廠
    /// </summary>
    public class ThermalPowerPlant : PowerPlant
    {
        public override uint MaxSupportPower { get => base.MaxSupportPower; }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "火力發電廠, 發電量: " + this.SupportPower.ToString() + "萬瓦, 職員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 水力發電廠
    /// </summary>
    public class HydroelectricPowerPlant : PowerPlant
    {
        public override uint ProducePollutions()
        {
            this.Pollution = this.Pollution;
            base.DiffusionPollutions();
            return this.Pollution;
        }

        public override void DiffusionInjection(uint p)
        {
            this.Pollution += p;
        }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "水力發電廠, 發電量: " + this.SupportPower.ToString() + "萬瓦, 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 生質能發電廠
    /// </summary>
    public class BiomassPowerPlant : PowerPlant
    {
        private const uint maxSupportPower = 500;

        public override uint MaxSupportPower { get => BiomassPowerPlant.maxSupportPower; }
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "生質能發電廠, 發電量: " + this.SupportPower.ToString() + "萬瓦, 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 太陽能發電廠
    /// </summary>
    public class SolarPowerPlant : PowerPlant
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "太陽能發電廠, 發電量: " + this.SupportPower.ToString() + "萬瓦, 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 核能發電廠
    /// </summary>
    public class NuclearPowerPlant : PowerPlant
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "核能發電廠, 發電量: " + this.SupportPower.ToString() + "萬瓦, 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 風力發電廠
    /// </summary>
    public class WindPowerPlant : PowerPlant
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "風力發電廠, 發電量: " + this.SupportPower.ToString() + "萬瓦, 從業員: " + this.Employees.ToString() + "人");
        }
    }
}