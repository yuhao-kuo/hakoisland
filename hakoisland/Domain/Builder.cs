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

        public async Task<List<LoginSelectListItem>>  GetLoginSelectListItemsAsync()
        {
            List<LoginSelectListItem> items = new List<LoginSelectListItem>();
            var s = await this._context.Island.ToListAsync();
            foreach(var i in s)
            {
                items.Add(new LoginSelectListItem(i.Name, i.IslandId));
            }

            return items;
        }

        public async Task<IndexViewModel> BuildAsync()
        {
            IndexViewModel obj = new IndexViewModel();
            obj.IslandViewModel = null;
            obj.LoginAccountViewModel = await this.GetLoginSelectListItemsAsync();
            obj.WorldHistory = null;
            return obj;
        }
    }
}