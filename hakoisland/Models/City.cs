using System;

namespace hakoisland.Models
{
    public abstract class CityBase : Location
    {
        public int CityID { get; }

        /// <summary>
        /// 消耗電力
        /// </summary>
        /// <value></value>
        public virtual int LoadingPower { get; }

        public Island BelongingIsland { get; set; }

        /// <summary>
        /// 人口
        /// </summary>
        /// <value></value>
        public virtual uint Population { get; set; }

        /// <summary>
        /// 消耗預算
        /// </summary>
        /// <value></value>
        public virtual uint Budget { get; set; }

        
    }

    #region 一般城市
    public class City : CityBase
    {
        public override string GetInfomation()
        {
            string name = null;
            if (this.Population > 3999) {
                name = "町";
            } else if (this.Population > 9999) {
                name = "都市";
            } else {
                name = "村";
            }
            return new string(this.GetLocationInfo() + name + ", 人口：" + this.Population.ToString() + "人");
        }
    }
    #endregion

    #region 新都市系
    public class NewCity : CityBase
    {

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "新都市, 人口: " + this.Population.ToString() + "人, 職場: " + "人");
        }
    }

    public class ModernCity : CityBase
    {
        private CityFrame cityFrame;

        public CityFrame Frame { get => this.cityFrame; set => this.cityFrame = value; }

        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "現代都市, 人口: " + this.Population.ToString() + "人, 職場: " + "人, 農場: " + "人");
        }
    }

    public class CommercialCity : CityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "商業都市, 人口: " + this.Population.ToString() + "人, 職場: " + "人");
        }
    }

    public class GloriousCity : CityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "輝煌都市, 人口：" + this.Population.ToString() + "人");
        }
    }

    public class GoldenCity : CityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "黃金城, 人口：" + this.Population.ToString() + "人");
        }
    }
    #endregion

    #region 防災都市系
    public class DisasterPreventionCity : CityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "防災都市, 人口: " + this.Population.ToString() + "人, 防災等級: ");
        }
    }

    public class DisasterPreventionNewCity : CityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "防災新都市, 人口: " + this.Population.ToString() + "人, 防災等級: " + "職場: " + "人, 農場: " + "人");
        }
    }
    #endregion

    #region 港口系
    public class Port : CityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "港町, 人口: " + this.Population.ToString() + "人, 職場: " + "人");
        }
    }
    public class SeaCity : CityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "海上都市, 人口: " + this.Population.ToString() + "人");
        }
    }

    public class SeaNewCity : CityBase
    {
        public override string GetInfomation()
        {
            return new string(this.GetLocationInfo() + "海上新都市, 人口: " + this.Population.ToString() + "人, 職場: " + "人, 農場: " + "人");
        }
    }
    #endregion
}