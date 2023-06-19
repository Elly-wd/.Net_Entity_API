using System.ComponentModel.DataAnnotations;

namespace ApiFilmesDois.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo nome é Obrigatório")]
        public string Nome { get; set; }
    }
}
