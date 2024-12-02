using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationMVC.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "G2_CATEGORIAS",
                columns: new[] { "ID_CATEGORIA", "NM_CATEGORIA", "DS_CATEGORIA" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "Roupas Masculinas", "Categoria de roupas masculinas, como camisas, calças, e acessórios." },
                    { Guid.NewGuid(), "Roupas Femininas", "Categoria de roupas femininas, como vestidos, saias, e blusas." },
                    { Guid.NewGuid(), "Roupas Infantis", "Categoria de roupas para crianças, incluindo roupas de bebê e roupas para crianças mais velhas." },
                    { Guid.NewGuid(), "Acessórios", "Categoria de acessórios de moda, como bolsas, chapéus e joias." },
                    { Guid.NewGuid(), "Calçados", "Categoria de calçados, incluindo tênis, botas e sandálias." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM G2_CATEGORIAS");
        }
    }
}
