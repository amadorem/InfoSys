using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.Entities.ViewModels.District
{
    public class DistrictListViewModel
    {
        public int TotalCount { get; set; }

        public int Page { get; set; }

        public ICollection<DistrictItemViewModel> Items { get; set; }
    }
}
