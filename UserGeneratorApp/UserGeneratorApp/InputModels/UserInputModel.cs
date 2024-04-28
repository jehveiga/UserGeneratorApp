using System.ComponentModel.DataAnnotations;

namespace UserGeneratorApp.InputModels
{
    public class UserInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Valor nao permitido")]
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
