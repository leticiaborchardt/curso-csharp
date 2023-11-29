using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ap.Controle.Models;

[Table("Moradores")]
public class Morador
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome deve ser preenchido")]
    [MinLength(2, ErrorMessage = "O nome deve conter, no mínimo, 2 caracteres")]
    [MaxLength(32, ErrorMessage = "O nome deve conter, no máximo, 32 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O apartamento deve ser preenchido")]
    public string Apartamento { get; set; }

    [Required(ErrorMessage = "A taxa de condomínio deve ser preenchida")]
    [Column(TypeName = "decimal(10, 2)")]
    public decimal TaxaCondominio { get; set; }

    [Required(ErrorMessage = "O condomínio deve ser informado")]
    public int CondominioId { get; set; }

    [ForeignKey("CondominioId")]
    public virtual Condominio Condominio { get; set; }
}
