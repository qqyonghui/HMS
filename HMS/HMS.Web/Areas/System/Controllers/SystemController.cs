using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMS.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HMS.Web.Areas.System.Controllers
{
    [Area("System")]
    public class SystemController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserManager()
        {
            return View();
        }
    }
}