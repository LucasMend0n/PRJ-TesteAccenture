using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudCompanies.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_supplier_company",
                columns: table => new
                {
                    id_supplier = table.Column<int>(type: "int", nullable: false),
                    id_company = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_supplier_company", x => new { x.id_company, x.id_supplier });
                    table.ForeignKey(
                        name: "FK_tb_supplier_company_tb_company_id_company",
                        column: x => x.id_company,
                        principalTable: "tb_company",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_supplier_company_tb_supplier_id_supplier",
                        column: x => x.id_supplier,
                        principalTable: "tb_supplier",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_supplier_company_id_supplier",
                table: "tb_supplier_company",
                column: "id_supplier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_supplier_company");
        }
    }
}
