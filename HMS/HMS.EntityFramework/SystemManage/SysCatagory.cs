using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HMS.EntityFramework
{
    public class SysCatagory:BaseEntity
    {
        [StringLength(100)]
        public string Name { get; set; }

        public Guid TenantId { get; set; }

        public Guid ParentId { get; set; }

    }
}
