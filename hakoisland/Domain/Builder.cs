using System;
using System.Threading.Tasks;
using System.Linq;
using hakoisland.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using hakoisland.Data;

namespace hakoisland.Domain
{
    public interface IViewModelBuilder<T>
    {
        Task<T> BuildAsync();

    }


    public class IndexViewbuilder : IViewModelBuilder<IndexViewModel>
    {
        private HakoIslandDbContext _context;
        public IndexViewbuilder()
        {
            this._context = new HakoIslandDbContext();
        }

        private async Task<List<LoginSelectListItem>>  GetLoginSelectListItemsAsync()
        {
            List<LoginSelectListItem> items = new List<LoginSelectListItem>();
            var s = await this._context.Island.ToListAsync();
            foreach(var i in s)
            {
                items.Add(new LoginSelectListItem(i.Name, i.IslandId));
            }

            return items;
        }

        private async Task<List<IslandInfo>> GetIslandInfosAsync()
        {
            List<IslandInfo> items = new List<IslandInfo>();
            var s = await this._context.Island.ToListAsync();
            foreach(var i in s)
            {
                // select island data
                var island_data = this._context.Facility.Where(
                    id => (
                        id.IslandId == i.IslandId
                    )
                );

                // 積分
                uint exp = 1;

                // 面積
                uint area_cnt = (uint)island_data.Count() * 100;

                // 工業從業人員
                var factory = from tmp in island_data
                              where tmp.FacilityId > 90 && tmp.FacilityId <= 105
                              select tmp;
                uint factory_cnt = 0;
                foreach(var c in factory) {
                    factory_cnt += c.Employee;
                }

                // 發電量與發電廠工作人員計算
                var power = from tmp in island_data
                            where tmp.FacilityId > 60 && tmp.FacilityId <= 70
                            select tmp;
                foreach(var c in power) {
                    factory_cnt += c.Employee;
                }

                // 農業從業人員
                var frame = from tmp in island_data
                            where tmp.FacilityId > 70 && tmp.FacilityId <= 90
                            select tmp;
                
                uint frame_cnt = 0;
                foreach(var c in factory) {
                    frame_cnt += c.Employee;
                }

                // 商業從業人員
                var business = from tmp in island_data
                               where tmp.FacilityId > 1000
                               select tmp;
                uint business_cnt = 0;
                foreach (var c in business) {
                    business_cnt += c.Employee;
                }

                // 礦業從業人員
                var mining = from tmp in island_data
                             where tmp.FacilityId > 105 && tmp.FacilityId <= 110
                             select tmp;
                uint mining_cnt = 0;
                foreach (var c in mining) {
                    mining_cnt += c.Employee;
                }

                // 失業率
                uint jobs = factory_cnt + frame_cnt + business_cnt + mining_cnt;

                // 建立清單
                IslandInfo info = new IslandInfo(i);
                info.FrameEmployee = frame_cnt;
                info.IndustryEmployee = factory_cnt;
                info.MiningEmployee = mining_cnt;
                info.BusinessEmployee = business_cnt;
                info.TotalPower = 0;    // test
                info.Rank = 0;
                info.TotalArea = area_cnt;
                info.Integral = exp;
                info.AccumulatedTourists = 0;   // 累積遊客先設為 0
                info.UserInfomation = "";
                items.Add(info);
            }

            return items;
        }

        public async Task<IndexViewModel> BuildAsync()
        {
            IndexViewModel obj = new IndexViewModel();
            obj.IslandViewModel = await this.GetIslandInfosAsync();
            obj.LoginAccountViewModel = await this.GetLoginSelectListItemsAsync();
            obj.WorldHistory = null;
            return obj;
        }
    }
}