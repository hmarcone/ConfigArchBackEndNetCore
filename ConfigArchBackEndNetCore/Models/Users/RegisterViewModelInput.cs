using System.ComponentModel.DataAnnotations;

namespace ConfigArchBackEndNetCore.Models.Users
{
    public class RegisterViewModelInput
    {
        [Required(ErrorMessage = "O login é obrigatório!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatório!")]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "O e-mail é obrigatório!")]
        public string Email { get; set; }
    }
}
