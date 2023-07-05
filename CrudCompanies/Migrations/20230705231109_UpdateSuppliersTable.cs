using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudCompanies.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSuppliersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "tb_supplier",
                newName: "cep");

            migrationBuilder.AlterColumn<string>(
                name: "cep",
                table: "tb_supplier",
                type: "varchar(8)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cep",
                table: "tb_supplier",
                newName: "Cep");

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "tb_supplier",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8)");
        }
    }
}
