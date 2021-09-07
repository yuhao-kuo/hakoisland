using System;

namespace hakoisland.Models
{
    /// <summary>
    /// 一般設施
    /// </summary>
    public abstract class FacilityBase : Location, IPollution
    {
        /// <summary>
        /// 等級
        /// </summary>
        /// <value></value>
        public virtual int Level { get; set; }
        /// <summary>
        /// 經驗值
        /// </summary>
        /// <value></value>
        public virtual int Ext { get; set; }
        /// <summary>
        /// 職員數量
        /// </summary>
        /// <value></value>
        public virtual uint Employees { get; set; }

        /// <summary>
        /// 消耗電力
        /// </summary>
        /// <value></value>
        public virtual uint LoadingPower { get; set; }

        /// <summary>
        /// 支援電力
        /// </summary>
        /// <value>提供島嶼電網的電力，無法提供電力的設施此欄位為0</value>
        public virtual uint SupportPower { get; set; }

        /// <summary>
        /// 清除污染
        /// </summary>
        public virtual void ClearPollution()
        {
            this.Pollution = 0;
        }

        /// <summary>
        /// 產生污染
        /// </summary>
        public virtual uint ProducePollutions()
        {
            this.Pollution++;
            // TODO: 把污染擴散給隔壁格
            return this.Pollution;
        }

        protected virtual void DiffusionPollutions()
        {
            
        }

        /// <summary>
        /// 污染擴散
        /// </summary>
        public virtual void DiffusionInjection(uint p)
        {
            this.Pollution += p;
        }
    }

    /// <summary>
    /// 附屬設施
    /// </summary>
    public abstract class AffiliatedFacilityBase : IPollution
    {
        /// <summary>
        /// 物件列舉
        /// </summary>
        /// <value></value>
        public UnitType Type { get; set; }
        /// <summary>
        /// 等級
        /// </summary>
        /// <value></value>
        public virtual int Level { get; set; }
        /// <summary>
        /// 經驗值
        /// </summary>
        /// <value></value>
        public virtual int Ext { get; set; }
        /// <summary>
        /// 職員數量
        /// </summary>
        /// <value></value>
        public virtual uint Employees { get; set; }

        /// <summary>
        /// 消耗電力
        /// </summary>
        /// <value></value>
        public virtual uint LoadingPower { get; set; }

        /// <summary>
        /// 支援電力
        /// </summary>
        /// <value>提供島嶼電網的電力，無法提供電力的設施此欄位為0</value>
        public virtual uint SupportPower { get; set; }

        /// <summary>
        /// 主體
        /// </summary>
        /// <value></value>
        public virtual FacilityBase Facility { get; set; }

        /// <summary>
        /// 清除污染
        /// </summary>
        public void ClearPollution()
        {
            // 清除污染為主體的工作
        }

        /// <summary>
        /// 擴散污染
        /// </summary>
        protected virtual void DiffusionPollutions()
        {
            
        }

        /// <summary>
        /// 產生污染
        /// </summary>
        public uint ProducePollutions()
        {
            return 0;
        }

        /// <summary>
        /// 注入污染擴散
        /// </summary>
        public void DiffusionInjection(uint p)
        {
            // 應注入主體
        }
    }
}