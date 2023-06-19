using System.ComponentModel.DataAnnotations;

namespace ApiFilmesDois.Data.Dtos;

public class ReadEnderecoDto
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo logradouro é obrigatório")]
    public string Logradouro { get; set; }

    [Required]
    public int Numero { get; set; }
}
