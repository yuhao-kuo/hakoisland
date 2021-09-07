using System;

namespace hakoisland.Models
{
    public abstract class UniversityBase : FacilityBase
    {
        /// <summary>
        /// 維持費
        /// </summary>
        /// <value></value>
        public virtual uint MainteanceFee { get => 0; }

        /// <summary>
        /// 收益
        /// </summary>
        /// <value></value>
        public virtual uint Income { get => 0; }
    }

    /// <summary>
    /// 農業大學
    /// </summary>
    public class AgriculturalUniversity : UniversityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "農業大學, Lv." + this.Level.ToString() + ", 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 理工大學
    /// </summary>
    public class PolytechnicUniversity : UniversityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "理工大學, Lv." + this.Level.ToString() + ", 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 氣象大學
    /// </summary>
    public class MeteorologicalUniversity : UniversityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "氣象大學, Lv." + this.Level.ToString() + ", 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 軍事大學
    /// </summary>
    public class MilitaryUniversity : UniversityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "軍事大學, Lv." + this.Level.ToString() + ", 從業員: " + this.Employees.ToString() + "人");
        }
    }

    /// <summary>
    /// 經濟大學
    /// </summary>
    public class EconomicsUniversity : UniversityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "經濟大學, Lv." + this.Level.ToString() + ", 從業員: " + this.Employees.ToString() + "人");
        }
    }
}