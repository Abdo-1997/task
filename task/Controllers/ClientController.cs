using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task.Models;
using task.ViewModels;
using task.Services;
using System.Threading.Tasks;

namespace task.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientServices _clientServices = new ClientServices();
        // GET: Client
        public async Task< ActionResult> Index()
        {
         ;
            return View(await _clientServices.GetAllClients());
        } 
        public ActionResult Create()
        {
        

            return View();
        } 
        [HttpPost]
        [ValidateAntiForgeryToken]
     
        public async Task<ActionResult> Create(AddCustomerViewModel newcustomer)
        {
            if (ModelState.IsValid)
            {
                await _clientServices.Add(newcustomer);
                return RedirectToAction(nameof(Index));
            }
            else
                return View(nameof(Create), newcustomer);
        }
    }
}