using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Wba.Forms.Web.Models;

namespace Wba.Forms.Web.ViewModels
{
    public class AuthenticationRegisterViewModel
    {
        [Required(ErrorMessage = "Voornaam missing!")]
        [Display(Name = "Voornaam:")]
        public string Firstname { get; set; }
        [Display(Name = "Naam:")]
        [Required(ErrorMessage = "Naam missing!")]
        public string Lastname { get; set; }
        [Display(Name = "Emailadres:")]
        [EmailAddress(ErrorMessage = "Moet een emailadres zijn!")]
        [Required(ErrorMessage = "Email missing!")]
        public string Email { get; set; }

        
        public List<SelectListItem> Countries { get; set; }
        [Display(Name = "Nationaliteit:")]
        public int CountryId { get; set; }
        [Display(Name = "Wachtwoord:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Paswoord missing!")]
        [Compare("CheckPassword", ErrorMessage = "Paswoorden moeten gelijk zijn!")]
        public string Password { get; set; }
        [Display(Name = "Herhaal wachtwoord:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Check paswoord missing!")]
        public string CheckPassword { get; set; }
        public List<CheckBoxModel> Preferences { get; set; }
    }
}
