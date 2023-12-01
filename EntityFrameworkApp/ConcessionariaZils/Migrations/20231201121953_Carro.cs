using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcessionariaZIls.Migrations
{
    /// <inheritdoc />
    public partial class Carro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Carros(Marca, Modelo, Cor, Ano, Preco, Placa, NumeroPassageiros, NumeroPortas) Values('Pegeout', '208 Griffe', 'Prata', '2015', '45000', 'AFE-56152', '4', '4')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
