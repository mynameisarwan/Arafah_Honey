using Microsoft.EntityFrameworkCore.Migrations;

namespace Arafah_Honey.Migrations
{
    public partial class AddingField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "QTY",
                table: "tbl_mst_neraca",
                type: "Decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QTY",
                table: "tbl_mst_neraca");
        }
    }
}
