using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HMS.EntityFramework
{
    public class SysRoles:BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 租户ID
        /// </summary>
        public Guid TenantId { get; set; }

    }
}
