using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vanado.Models;

namespace vanado.Controllers
{
    public class KvarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Kvar kvar)
        {
           if (ModelState.IsValid)
            {
                
            }

            return View(kvar);
        }

        [HttpGet]
        public IActionResult Update(int kvarid)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(int kvarid, Kvar kvar)
        {
            if (kvarid != kvar.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                
            }

            return View(kvar);
        }

        [HttpPost]
        public IActionResult Delete(int kvarid)
        {


            return RedirectToAction(nameof(Index));
        }




    
    }

    


    
}
