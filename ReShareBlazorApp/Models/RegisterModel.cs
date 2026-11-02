using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Podaj nazwę użytkownika!")]
        [MinLength(8, ErrorMessage = "Nazwa użytkownika musi mieć minimum 8 znaków!")]
        [MaxLength(24, ErrorMessage = "Nazwa użytkownika musi mieć maksymalnie 24 znaków!")]

        public string Username { get; set; } = "";
        [Required(ErrorMessage = "Podaj adres email!")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres email!")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Podaj hasło!")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć minimum 8 znaków!")]

        public string Password { get; set; } = "";
        [Required(ErrorMessage = "Potwierdź hasło.")]
        [Compare(nameof(Password),ErrorMessage = "Hasła nie są identyczne.")]
        public string ConfirmPassword { get; set; } = "";
        [Range(typeof(bool), "true", "true", ErrorMessage = "Musisz zaakceptować regulamin.")]
        public bool AcceptTerms { get; set; }
    }
}
