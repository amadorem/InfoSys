using DepEd.InfoSys.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DepEd.InfoSys.Entities
{
    public class Region : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
