using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HMS.EntityFramework
{
    public class Permissions : BaseEntity
    {
        public Guid TenantId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        public Guid RoleId { get; set; }

        public Guid UserId { get; set; }

        [StringLength(100)]
        public string Discriminator { get; set; }
    }
}
