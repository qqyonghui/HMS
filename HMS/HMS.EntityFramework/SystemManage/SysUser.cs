using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HMS.EntityFramework
{
    public class SysUser:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        
        public Guid RoleId { get; set; }

        public Guid TenantId { get; set; }

        public int Gender { get; set; }

        public DateTime lastLoginTime { get; set; }

        public string PhoneNumber { get; set; }

    }
}
