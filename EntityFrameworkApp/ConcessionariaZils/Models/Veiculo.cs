using System.ComponentModel.DataAnnotations;

namespace ConcessionariaZils.Models;

public class Veiculo
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "A Marca deve ser preenchida")]
    public string Marca { get; set; }

    [Required(ErrorMessage = "O Modelo deve ser preenchido")]
    public string Modelo { get; set; }

    [Required(ErrorMessage = "A Cor deve ser preenchida")]
    public string Cor { get; set; }

    [Required(ErrorMessage = "O Ano deve ser preenchida")]
    public int Ano { get; set; }

    [Required(ErrorMessage = "O Preço deve ser preenchido")]
    public int Preco { get; set; }

    [Required(ErrorMessage = "A placa deve ser preenchida")]
    public string Placa { get; set; }
}
