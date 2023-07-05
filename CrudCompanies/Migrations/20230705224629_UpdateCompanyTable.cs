using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudCompanies.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompanyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "tb_company");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_company",
                table: "tb_company",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_company",
                table: "tb_company");

            migrationBuilder.RenameTable(
                name: "tb_company",
                newName: "Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "id");
        }
    }
}
