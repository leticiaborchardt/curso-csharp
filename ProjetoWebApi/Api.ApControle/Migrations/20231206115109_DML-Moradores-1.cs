using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.ApControle.Migrations
{
    /// <inheritdoc />
    public partial class DMLMoradores1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Moradores(Nome, Apartamento, TaxaCondominio, CondominioId) Values('Letícia Borchardt', 'Apto 502', '1500.00', '1')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
