using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inva.LawMax.Migrations
{
    /// <inheritdoc />
    public partial class AddEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    LitigationDegree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalVerdict = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lawyer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hearing",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Decision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hearing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hearing_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaseLawyer",
                columns: table => new
                {
                    CasesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LawyersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseLawyer", x => new { x.CasesId, x.LawyersId });
                    table.ForeignKey(
                        name: "FK_CaseLawyer_Case_CasesId",
                        column: x => x.CasesId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseLawyer_Lawyer_LawyersId",
                        column: x => x.LawyersId,
                        principalTable: "Lawyer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseLawyer_LawyersId",
                table: "CaseLawyer",
                column: "LawyersId");

            migrationBuilder.CreateIndex(
                name: "IX_Hearing_CaseId",
                table: "Hearing",
                column: "CaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseLawyer");

            migrationBuilder.DropTable(
                name: "Hearing");

            migrationBuilder.DropTable(
                name: "Lawyer");

            migrationBuilder.DropTable(
                name: "Case");
        }
    }
}
