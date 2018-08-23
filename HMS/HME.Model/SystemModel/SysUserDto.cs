using System;
using System.Collections.Generic;
using System.Text;

namespace HME.Model.SystemModel
{
    public class SysUserDto
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public Guid RoleId { get; set; }

        public Guid TenantId { get; set; }

        public int Gender { get; set; }

        public DateTime lastLoginTime { get; set; }

        public string PhoneNumber { get; set; }
    }
}
