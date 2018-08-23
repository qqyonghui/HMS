using HME.Model.SystemModel;
using HMS.Common.Ioc;

using HMS.Domin.SystemModule.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domin.SystemModule
{
    public interface ISysUserDomin: IDependency
    {
        List<SysUserDto> GetSysUserList(SysUserInput input);

        bool Login(SysUserInput input);
    }
}
