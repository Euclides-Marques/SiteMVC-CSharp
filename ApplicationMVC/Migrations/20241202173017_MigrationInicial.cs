using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationMVC.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "G2_CATEGORIAS",
                columns: table => new
                {
                    ID_CATEGORIA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NM_CATEGORIA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DS_CATEGORIA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_G2_CATEGORIAS", x => x.ID_CATEGORIA);
                });

            migrationBuilder.CreateTable(
                name: "G2_ROUPAS",
                columns: table => new
                {
                    ID_ROUPA = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NM_ROUPA = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DS_ROUPA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    VL_ROUPA = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    FL_IMAGEM_ROUPA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FL_THUMBNAIL_ROUPA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FL_ESTOQUE = table.Column<bool>(type: "bit", nullable: false),
                    ID_CATEGORIA = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_G2_ROUPAS", x => x.ID_ROUPA);
                    table.ForeignKey(
                        name: "FK_G2_ROUPAS_G2_CATEGORIAS_ID_CATEGORIA",
                        column: x => x.ID_CATEGORIA,
                        principalTable: "G2_CATEGORIAS",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_G2_ROUPAS_ID_CATEGORIA",
                table: "G2_ROUPAS",
                column: "ID_CATEGORIA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "G2_ROUPAS");

            migrationBuilder.DropTable(
                name: "G2_CATEGORIAS");
        }
    }
}
