using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcessionariaZils.Models;

[Table("Carros")]
public class Carro : Veiculo
{
    public byte? NumeroPassageiros { get; set; }

    public byte? NumeroPortas { get; set; }
}
