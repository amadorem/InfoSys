using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DepEd.InfoSys.Entities.ViewModels.Region
{
    public class RegionCreateViewModel
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
