using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task.Models;
using task.ViewModels;

namespace task.Controllers
{
    public class SidesController : Controller
    {
        private readonly Model1 _sidecontext=new Model1();
        // GET: Sides
        public ActionResult Index()
        {
            IEnumerable<ReceivingSide> sides = _sidecontext.Sides;
            return View(sides);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("create")]
        public ActionResult ConCreate(AddSidesViewModel newside)
        {
            if (ModelState.IsValid)
            {
                ReceivingSide side = new ReceivingSide()

                {
                    name = newside.SideName
                };
                _sidecontext.Sides.Add(side);
                return RedirectToAction(nameof(Index));

            }
            else
            {
                return View(nameof(Create), newside);
            }

        }
    }
}