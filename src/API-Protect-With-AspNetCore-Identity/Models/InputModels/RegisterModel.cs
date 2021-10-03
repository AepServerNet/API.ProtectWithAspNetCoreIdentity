using System.ComponentModel.DataAnnotations;

namespace API_Protect_With_AspNetCore_Identity.Models.InputModels
{
    public class RegisterModel  
    {  
        [Required(ErrorMessage = "User Name is required")]  
        public string Username { get; set; }  
  
        [EmailAddress]  
        [Required(ErrorMessage = "Email is required")]  
        public string Email { get; set; }  
  
        [Required(ErrorMessage = "Password is required")]  
        public string Password { get; set; }  
  
    }  
}