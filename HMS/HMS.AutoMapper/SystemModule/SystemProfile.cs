using AutoMapper;
using HME.Model.SystemModel;
using HMS.EntityFramework;
using System;

namespace HMS.AutoMapper.SystemModule
{
    public class SystemProfile
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<SysUser, SysUserDto>();
            });
        }
    }
}
