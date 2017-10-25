using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.Entities.ViewModels.Division
{
    public class DivisionListViewModel
    {
        public int TotalCount { get; set; }

        public int Page { get; set; }

        public ICollection<DivisionItemViewModel> Items { get; set; }
    }
}
