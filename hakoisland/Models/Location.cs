using System;

namespace hakoisland.Models
{

    public class HakoislandMapDefine
    {
        public static int Width { get => 40; }
        public static int Height { get => 40; }
    }

    public abstract class Location : ILocation
    {
        public virtual int LocationID { get; set; }
        /// <summary>
        /// 世界座標X
        /// </summary>
        /// <value></value>
        public virtual int WorldX { get; set; }
        /// <summary>
        /// 世界座標Y
        /// </summary>
        /// <value></value>
		public virtual int WorldY { get; set; }
        /// <summary>
        /// 座標X
        /// </summary>
        /// <value></value>
		public virtual int X { get; set; }
        /// <summary>
        /// 座標Y
        /// </summary>
        /// <value></value>
		public virtual int Y { get; set; }

        /// <summary>
        /// 污染指數
        /// </summary>
        /// <value></value>
        public virtual uint Pollution { get; set; }

        /// <summary>
        /// 座標物件列舉
        /// </summary>
        /// <value></value>
        public virtual UnitType Type { get; }

        public static int CalcWorldID(int x, int y)
        {
            int ret = x * HakoislandMapDefine.Width + y;
            return ret;
        }

        public virtual string GetInfomation()
        {
            return this.GetLocationInfo();
        }

        protected string GetLocationInfo()
        {
            return new string("(" + this.X.ToString() + ", " + this.Y.ToString() + ")");
        }
    }
}