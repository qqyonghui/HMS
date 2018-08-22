using AutoMapper;
using HMS.Domin.SystemModule.Dto;
using HMS.Domin.SystemModule.Input;
using HMS.Domin.SystemModule.Interface;
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
            return _dbContext.SysUser.Any(p => p.TenantId == input.TenantId && p.LoginName == p.LoginName && p.Password == input.Password);
        }
    }
}
