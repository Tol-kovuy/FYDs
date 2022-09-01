using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYD_s.Controllers
{
    public class AnketaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
