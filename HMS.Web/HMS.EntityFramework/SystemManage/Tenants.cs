using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HMS.EntityFramework
{
    public class Tenants:BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string LoginName { get; set; }
    }
}
