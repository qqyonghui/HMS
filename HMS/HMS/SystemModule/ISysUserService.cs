using HMS.Common.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Application.SystemModule
{
    public interface ISysUserService:IDependency
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        bool Login(string loginName,string pwd,string tantentId);
    }
}
