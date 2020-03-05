using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BigCarStore;

namespace WebCarStore.Controllers
{
    public class PrekesController : Controller
    {
        public IActionResult Index()
        {
            var prekes = PrekiuOperacijos.PrekiuKatalogas();



            return View(prekes);            
        }

        [HttpGet]
        public string Test(Preke preke){

            return preke.Pavadimas;
        }

    }
}