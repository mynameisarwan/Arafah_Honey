using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Arafah_Honey.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_mst_neraca",
                columns: table => new
                {
                    neraca_id = table.Column<string>(type: "varchar(50)", nullable: false),
                    tanggal_neraca = table.Column<DateTime>(type: "datetime2", nullable: false),
                    keterangan = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    debitkredit = table.Column<string>(type: "varchar(1)", nullable: false),
                    nominal = table.Column<decimal>(type: "Decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_mst_neraca", x => x.neraca_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_mst_neraca");
        }
    }
}
