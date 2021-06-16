using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using practicaa4.Models;

namespace practicaa4.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly FailContext _context;

        public ComentarioController(FailContext context) {
            _context = context;
        }
       
        public IActionResult Comenta() {
            ViewBag.Fotos = _context.Foto.ToList().Select(r => new SelectListItem(r.Foto, r.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Comenta(Comentario c){

         if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Index" ,"Home");
            }
            return View(c);
        }

    }
}