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
    public class ReceivedSamplesController : Controller
    {
        #region services
        private readonly SampleService _sampleService=new SampleService();  
        private readonly ClientServices _clientService=new ClientServices();  
        private readonly SideServices _sideServices=new SideServices();
        #endregion


        public async Task<ActionResult> Index()
        {
            
            return View(await _sampleService.GetAll());
        }
        #region create
        public async Task< ActionResult> create()
        {
            ViewBag.x = new SelectList(await _clientService.GetAllClients(), "id", "name");
            ViewBag.y=new SelectList(await _sideServices.GetAllClients(), "id", "name");
            return View(new AddSampleVM());

        }
      
        [HttpPost]
       
        public async Task< ActionResult> Create(AddSampleVM sample)
        {
            if (ModelState.IsValid)
            {

              await  _sampleService.Add(sample);
                return RedirectToAction(nameof(Index)); 
            }
            ViewBag.x = new SelectList(await _clientService.GetAllClients(), "id", "name");
            ViewBag.y = new SelectList(await _sideServices.GetAllClients(), "id", "name");
            return View(sample);
        }
        #endregion


        #region Delete
        public async Task<ActionResult> Delete(int id)
        {
                     
            await _sampleService.Delete(id);
            return RedirectToAction(nameof(Index), await _sampleService.GetAll());
        }
        #endregion


        #region edit
        public async Task<ActionResult> Edit(int id )
        {
            ViewBag.x = new SelectList(await _clientService.GetAllClients(), "id", "name");
            ViewBag.y = new SelectList(await _sideServices.GetAllClients(), "id", "name");
            return View(await _sampleService.GetById(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id ,AddSampleVM view)
        {
          await  _sampleService.edit(id, view);
            return RedirectToAction(nameof(Index), await _sampleService.GetAll());
        }
        #endregion
    }
}