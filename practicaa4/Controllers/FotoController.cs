using Microsoft.AspNetCore.Mvc;
using practicaa4.Models;

namespace practicaa4.Controllers
{
    public class FotoController : Controller
    {
        
        private readonly FailContext _context;

        public FotoController(FailContext context) {
            _context = context;
        }
        public IActionResult Foto(){

            return View();
        }

        [HttpPost]
         public IActionResult Foto(Fotos f){

            if(ModelState.IsValid){
                _context.Add(f);
                _context.SaveChanges();
                return RedirectToAction("Index" ,"Home");
            }
            return View(f);
        }
        

    }
}