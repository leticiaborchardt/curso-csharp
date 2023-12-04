using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.ApControle.Models;

[Table("Condominios")]
public class Condominio
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome deve ser preenchido")]
    [MinLength(2, ErrorMessage = "O nome deve conter, no mínimo, 2 caracteres")]
    [MaxLength(64, ErrorMessage = "O nome deve conter, no máximo, 64 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O CNPJ deve ser preenchido")]
    [MinLength(18, ErrorMessage = "O CNPJ deve conter, no mínimo, 18 caracteres")]
    [MaxLength(18, ErrorMessage = "O CNPJ deve conter, no máximo, 18 caracteres")]
    public string Cnpj { get; set; }

    public List<Morador> Moradores {get; set;}
}
