using System.ComponentModel.DataAnnotations;

namespace ConfigArchBackEndNetCore.Models.Users
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatório!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória!")]
        public string PassWord { get; set; }
    }
}
