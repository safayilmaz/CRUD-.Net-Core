using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Business.Abstract;
using Crud.Entities;
using Crud.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crud.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private INoteService _noteService;

        public HomeController(INoteService noteService)
        {
            _noteService = noteService;
        }
        public IActionResult Index()
        {
            return View(new NoteModel()
            {
                Notes = _noteService.getAll()
            });
        }

        [HttpGet]
        public IActionResult AddNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNote(NoteModel n)
        {
            var entity = new Notes()
            {
                Note = n.Note,
                EnrollDate = DateTime.Now.ToLocalTime()
            };

            _noteService.Add(entity);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            
            var entity = _noteService.GetById(id);



            var model = new NoteModel()
            {
                Note = entity.Note,
                EnrollDate = DateTime.Now.ToLocalTime()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(NoteModel model)
        {

            var entity = _noteService.GetById(model.ID);

            entity.Note = model.Note;
            entity.EnrollDate = DateTime.Now.ToLocalTime();


            _noteService.Update(entity);

            return RedirectToAction("Index");
        }

        public IActionResult GetNote(int id)
        {

            var entity = _noteService.GetById(id);
            return View("GetNote",entity);
        }

        public IActionResult Delete(int id)
        {
            var entity = _noteService.GetById(id);

            
            _noteService.Delete(entity);
            

            return RedirectToAction("Index");
        }

    }
}