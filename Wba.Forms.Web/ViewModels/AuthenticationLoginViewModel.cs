using System.ComponentModel.DataAnnotations;

namespace Wba.Forms.Web.ViewModels
{
    public class AuthenticationLoginViewModel
    {
        [Display(Name = "Gebruikersnaam:")]
        [Required(ErrorMessage = "Username mag niet leeg zijn!")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Moet een emailadres zijn")]
        public string Username { get; set; }
        [Display(Name = "Wachtwoord:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Wachtwoord ontbreekt!")]
        public string Password { get; set; }
    }
}
