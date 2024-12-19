using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseStorage.Migrations
{
    /// <inheritdoc />
    public partial class r : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alpha1 = table.Column<double>(type: "float", nullable: false),
                    Sigma = table.Column<double>(type: "float", nullable: false),
                    D1 = table.Column<double>(type: "float", nullable: false),
                    N = table.Column<double>(type: "float", nullable: false),
                    U = table.Column<double>(type: "float", nullable: false),
                    Dmin_Sigma = table.Column<double>(type: "float", nullable: false),
                    N_V = table.Column<double>(type: "float", nullable: false),
                    Beta = table.Column<double>(type: "float", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material_P = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "units",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    F = table.Column<double>(type: "float", nullable: false),
                    b = table.Column<double>(type: "float", nullable: false),
                    Sigma0 = table.Column<double>(type: "float", nullable: false),
                    SigmaF0 = table.Column<double>(type: "float", nullable: false),
                    SigmaF = table.Column<double>(type: "float", nullable: false),
                    C0 = table.Column<double>(type: "float", nullable: false),
                    C1 = table.Column<double>(type: "float", nullable: false),
                    C2 = table.Column<double>(type: "float", nullable: false),
                    C3 = table.Column<double>(type: "float", nullable: false),
                    W = table.Column<double>(type: "float", nullable: false),
                    MezOs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Natyazh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Character = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeofMachine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeofEngine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A = table.Column<double>(type: "float", nullable: false),
                    Crossectionalarea = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "resultEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    detailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    unitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sigma = table.Column<double>(type: "float", nullable: false),
                    F = table.Column<double>(type: "float", nullable: false),
                    Sigma0 = table.Column<double>(type: "float", nullable: false),
                    SigmaF = table.Column<double>(type: "float", nullable: false),
                    Crossectionalarea = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resultEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_resultEntities_details_detailId",
                        column: x => x.detailId,
                        principalTable: "details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_resultEntities_units_unitId",
                        column: x => x.unitId,
                        principalTable: "units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resultEntities_detailId",
                table: "resultEntities",
                column: "detailId");

            migrationBuilder.CreateIndex(
                name: "IX_resultEntities_unitId",
                table: "resultEntities",
                column: "unitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resultEntities");

            migrationBuilder.DropTable(
                name: "details");

            migrationBuilder.DropTable(
                name: "units");
        }
    }
}
