using AutoMapper;
using HME.Model.SystemModel;
using HMS.Common.Helper;
using HMS.Domin.SystemModule.Input;
using HMS.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domin.SystemModule
{
    public class SysUserDomin : ISysUserDomin
    {
        private readonly HMSDbContext _dbContext;
        public SysUserDomin(HMSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SysUserDto> GetSysUserList(SysUserInput input)
        {
            List<SysUser> userList= _dbContext.SysUser.Where(p=>p.TenantId==input.TenantId).ToList();
            return Mapper.Map<List<SysUserDto>>(userList);
        }

        public bool Login(SysUserInput input)
        {
           return _dbContext.SysUser.Join(_dbContext.Tenants, user => user.TenantId, tenant => tenant.Id, (user, tenant) => new SysUserDto
            {
                LoginName=user.LoginName,
                Password=user.Password,
                TenantName=tenant.Name

            }).Any(p=>p.LoginName==input.LogName&&p.Password==MD5Helper.MD5Encrypt(input.Password)&&p.TenantName==input.TenantName);
            //return _dbContext.SysUser.Any(p => p.TenantId == input.TenantId && p.LoginName == p.LoginName && p.Password == input.Password);
        }
    }
}
