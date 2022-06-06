using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    //Aqui é onde é interessante fazer as validações das variáveis de entrada
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}