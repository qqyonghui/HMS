using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMS.Application.SystemModule;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Login(string loginName, string password, string tantent)
        {
            bool result = _sysUserService.Login( loginName, password, tantent);
            return Content(result.ToString());
        }
    }
}