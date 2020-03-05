using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCarStore.Controllers
{
    public class ImoneController : Controller
    {
        public ImoneController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
