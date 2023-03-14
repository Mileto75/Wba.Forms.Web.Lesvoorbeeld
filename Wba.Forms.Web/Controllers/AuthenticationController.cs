using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wba.Forms.Web.Models;
using Wba.Forms.Web.ViewModels;

namespace Wba.Forms.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            //init country list
            AuthenticationRegisterViewModel authenticationRegisterViewModel
                = new AuthenticationRegisterViewModel();
            authenticationRegisterViewModel
                .Countries = new List<SelectListItem>
                {
                    new SelectListItem{Selected = true},
                    new SelectListItem{Value="1",Text="Italië"},
                    new SelectListItem{Value="2",Text="België"},
                    new SelectListItem{Value="3",Text="Nederland"},
                    new SelectListItem{Value="4",Text="Duitsland"},
                };
            //init preferences checkboxes
            authenticationRegisterViewModel
                .Preferences = new List<Models.CheckBoxModel>
                {
                    new CheckBoxModel{Value="1",Name="Promos"},
                    new CheckBoxModel{Value="2",Name="Newsletter"},
                    new CheckBoxModel{Value="3",Name="Acties op maat"},
                };
            return View(authenticationRegisterViewModel);
        }
        [HttpPost]
        public IActionResult Register(AuthenticationRegisterViewModel 
            authenticationRegisterViewModel)
        {
            if(!ModelState.IsValid)
                return View(authenticationRegisterViewModel);
            //process data
            return RedirectToAction("Registered");
        }
        [HttpGet]
        public IActionResult Registered() 
        {
            return View();
        }
    }
}
    
