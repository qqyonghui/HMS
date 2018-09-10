using HME.Model.SystemModel;
using HMS.Domin.SystemModule;
using HMS.Domin.SystemModule.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Application.SystemModule
{
    public class SysUserService : ISysUserService
    {
        private ISysUserDomin _sysUserDomin;
        public SysUserService(ISysUserDomin sysUserDomin)
        {
            _sysUserDomin = sysUserDomin;
        }
        public SysUserDto Login(string loginName,string pwd, string tantentName)
        {
            SysUserInput input = new SysUserInput();
            input.LoginName = loginName;
            input.Password = pwd;
            if(!string.IsNullOrEmpty(tantentName))
            {
                input.TenantName = tantentName;
            }
            return _sysUserDomin.Login(input);
        }
    }
}
