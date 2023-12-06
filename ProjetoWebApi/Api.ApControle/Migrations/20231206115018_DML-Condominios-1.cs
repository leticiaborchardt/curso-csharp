using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.ApControle.Migrations
{
    /// <inheritdoc />
    public partial class DMLCondominios1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Condominios(Nome, Cnpj) Values('Moradas do Norte', '43.813.226/0001-14')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
