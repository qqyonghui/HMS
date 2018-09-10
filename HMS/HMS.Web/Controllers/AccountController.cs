using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HME.Model.SystemModel;
using HMS.Application.SystemModule;
using HMS.Common.Helper;
using HMS.Domin.SystemModule.Input;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HMS.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISysUserService _sysUserService;
        public AccountController(ISysUserService sysUserService)
        {
            _sysUserService = sysUserService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(SysUserInput input)
        {
            SysUserDto currentUser = _sysUserService.Login(input.LoginName, input.Password, input.TenantName);
            if (currentUser!=null)
            {
                HttpContext.Session.Set("CurrentUser", ByteConvertHelper.Object2Bytes(currentUser));
                return Content(true.ToString());
            }
            return Content(false.ToString());
        }
    }
}