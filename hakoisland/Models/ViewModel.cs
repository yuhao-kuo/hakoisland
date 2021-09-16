using System;
using System.Collections.Generic;
using hakoisland.Domain;

namespace hakoisland.Models
{
    public abstract class ViewModelBase
    {
        
    }

    public class IndexViewModel : ViewModelBase
    {
        public List<LoginSelectListItem> LoginAccountViewModel { get; set; }
        public List<IslandInfo> IslandViewModel { get; set; }
        public List<History> WorldHistory { get; set; }
        
    }

    
}