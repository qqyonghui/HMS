using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Domin.SystemModule.Input
{
    public class SysUserInput
    {
        public Guid Id { get; set; }

        public string LogName { get; set; }

        public string Password { get; set; }

        public Guid TenantId { get; set; }
        
        public string TenantName { get; set; }
    }
}
