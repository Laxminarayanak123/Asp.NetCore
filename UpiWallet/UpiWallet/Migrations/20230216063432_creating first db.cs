using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UpiWallet.Migrations
{
    public partial class creatingfirstdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Upi",
                columns: table => new
                {
                    UPI = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Mobile = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    JoinedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Upi", x => x.UPI);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Transaaction",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    UPI1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Transaaction", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_tbl_Transaaction_tbl_Upi_UPI1",
                        column: x => x.UPI1,
                        principalTable: "tbl_Upi",
                        principalColumn: "UPI",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Transaaction_UPI1",
                table: "tbl_Transaaction",
                column: "UPI1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Transaaction");

            migrationBuilder.DropTable(
                name: "tbl_Upi");
        }
    }
}
