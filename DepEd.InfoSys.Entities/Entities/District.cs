using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DepEd.InfoSys.Entities.Entities
{
    public class District : BaseEntity
    {
        public int Id { get; set; }

        [Required,
            MaxLength(50)]
        public string Name { get; set; }
    }
}
