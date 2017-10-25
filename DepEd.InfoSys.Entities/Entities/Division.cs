using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DepEd.InfoSys.Entities.Entities
{
    public class Division : BaseEntity
    {
        public int Id { get; set; }

        [Required, 
            MaxLength(50)]
        public string Name { get; set; }
    }
}
