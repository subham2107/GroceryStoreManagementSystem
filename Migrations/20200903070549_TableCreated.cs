using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStoreMgmt.Migrations
{
    public partial class TableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "grocitems",
                columns: table => new
                {
                    GrocId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrocName = table.Column<string>(nullable: true),
                    GrocPrice = table.Column<double>(nullable: false),
                    GrocQuantity = table.Column<int>(nullable: false),
                    GrocTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grocitems", x => x.GrocId);
                });

            migrationBuilder.CreateTable(
                name: "grocsells",
                columns: table => new
                {
                    SellId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrocId = table.Column<int>(nullable: false),
                    CustName = table.Column<string>(nullable: true),
                    GrocQuantity = table.Column<int>(nullable: false),
                    GrocBuyTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grocsells", x => x.SellId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "grocitems");

            migrationBuilder.DropTable(
                name: "grocsells");
        }
    }
}
