using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NotelyApp.Models;
using NotelyApp.Services;
using Microsoft.Extensions.Logging;
using NotelyApp.Repositories;
namespace NotelyApp.Controllers
{
    public class HomeController : Controller
    {        
        private ProductServices productServices = new ProductServices();
        private NumberServices numberServices = new NumberServices();
        private NumberSelectServices numberSelectServices = new NumberSelectServices();
        
        private readonly INoteRepository _noteRepository;
        public HomeController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;

        }

        public IActionResult Index()
        {
            var notes = _noteRepository.GetAllNotes().Where(n => n.IsDeleted == false);

            return View(notes);
        }

        public IActionResult Product()
        {
            Product product = productServices.getProductDetail();

            return View(product);
        }
        public IActionResult NoteDetail(Guid id)
        {
            var note = _noteRepository.FindNoteById(id);

            return View(note);
        }

        
        [HttpGet]
        public IActionResult NoteEditor(Guid id = default)
        {
            if (id != Guid.Empty)
            {
                var note = _noteRepository.FindNoteById(id);

                return View(note);
            }

            return View();

        }

        [HttpPost]
        public IActionResult NoteEditor(NoteModel noteModel)
        {
            if (ModelState.IsValid)
            {               
                if (noteModel != null && noteModel.Id == Guid.Empty)
                {
                    noteModel.Id = Guid.NewGuid();


                    _noteRepository.SaveNote(noteModel);
                }
                else
                {
                    var note = _noteRepository.FindNoteById(noteModel.Id);
                    
                    note.Subject = noteModel.Subject;
                    note.Detail = noteModel.Detail;
                }

                return RedirectToAction("Index"); 
            }
            else
            {
                return View();
            }
        }

        public IActionResult DeleteNote(Guid id)
        {
            var note = _noteRepository.FindNoteById(id);

            note.IsDeleted = true;

            return RedirectToAction("Index");
        }
        public IActionResult FindNote(string subject)
        {
            var note = _noteRepository.FindNoteBySubject(subject);

            return View(note);
        }
        public IActionResult Number(String inputNumber = null)
        {
            if (String.IsNullOrEmpty(inputNumber))
            {
                inputNumber = "0";
            }
            Number number = numberServices.createNumber(inputNumber);
            return View(number);
        }

        public IActionResult NumberSelect(String inputNumber = null)
        {
            if (String.IsNullOrEmpty(inputNumber))
            {
                inputNumber = "0";
            }
            
            NumberSelect numberSelect = numberSelectServices.ChooseProduct(inputNumber);
            return View(numberSelect);
        }







        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
