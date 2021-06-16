using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace practicaa4.Controllers
{
    public class CuentaController : Controller
    {
        
        private readonly SignInManager<IdentityUser> _sim;
        private readonly UserManager<IdentityUser> _um;
        public CuentaController(SignInManager<IdentityUser> sim, UserManager<IdentityUser> um){

            _sim = sim;
            _um = um;
        }

        public IActionResult CrearCuenta(){
            return View();
        }

        [HttpPost]
        public IActionResult CrearCuenta(string email, string password){
            var usuario = new IdentityUser(email);   
            var resultado = _um.CreateAsync(usuario,password).Result;
            if(resultado.Succeeded){
                return RedirectToAction ("Index", "Home");
            }
            return View();
        }


        public IActionResult IniciarSesion(){
                return View();
        }
        

        [HttpPost]
        public IActionResult IniciarSesion(string usuario, string password){
            var result = _sim.PasswordSignInAsync(usuario, password, true, false ).Result;
            if(result.Succeeded){
                return RedirectToAction("Index", "Home");
            }else{

                ModelState.AddModelError("","Datos Incorrectos");
                return View();
            }
                
        }

        public async Task<IActionResult> CerrarSesion(){
           await _sim.SignOutAsync();
            return RedirectToAction("Index","Home");
                
        }
    }
}