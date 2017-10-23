using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.Entities.ViewModels.Region
{
    public class RegionListViewModel
    {
        public int TotalCount { get; set; }

        public int Page { get; set; }

        public ICollection<RegionItemViewModel> Items { get; set; }
    }
}
