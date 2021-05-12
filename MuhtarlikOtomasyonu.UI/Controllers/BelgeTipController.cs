using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MuhtarlikOtomasyonu.BusinessEngine.Contracts;

namespace MuhtarlikOtomasyonu.UI.Controllers
{
    public class BelgeTipController : Controller
    {
        private readonly IBelgeTipBusinessEngine _belgeTipBusinessEngine;

        public BelgeTipController(IBelgeTipBusinessEngine belgeTipBusinessEngine)
        {
            _belgeTipBusinessEngine = belgeTipBusinessEngine;
        }

        public IActionResult Index()
        {
            var data = _belgeTipBusinessEngine.GetAllBelgeTipleri();

            if (data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
                //return RedirectToAction("Create");
            }
            return View();


        }
    }
}
