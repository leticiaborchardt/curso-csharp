namespace IsackNewton.Data
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public string Turno { get; set; }
        public decimal Salario { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nCargo: {Cargo}\nTurno: {Turno}\nSalário: {Salario}";
        }
    }
}
