using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace ApplicationMVC.Migrations
{
    public partial class PopularRoupas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "G2_ROUPAS",
                columns: new[] { "ID_ROUPA", "NM_ROUPA", "DS_ROUPA", "VL_ROUPA", "FL_IMAGEM_ROUPA", "FL_THUMBNAIL_ROUPA", "FL_ESTOQUE", "ID_CATEGORIA" },
                values: new object[,]
                {
                    { Guid.NewGuid(), "Camisa Polo Masculina", "Camisa polo masculina de algodão, ideal para o dia a dia.", 79.99, "/imagens/camisa_polo_masculina.jpg", "/imagens/thumb_camisa_polo_masculina.jpg", true, Guid.Parse("9468FB0F-B409-490A-995D-462FA4D02615") },
                    { Guid.NewGuid(), "Vestido Feminino Floral", "Vestido feminino com estampa floral, ideal para eventos casuais.", 99.90, "/imagens/vestido_feminino_floral.jpg", "/imagens/thumb_vestido_feminino_floral.jpg", true, Guid.Parse("F0A07410-48B6-40D0-B9A7-5D8E0942545C") },
                    { Guid.NewGuid(), "Macacão Infantil", "Macacão infantil de algodão, confortável para o dia a dia.", 59.90, "/imagens/macacao_infantil.jpg", "/imagens/thumb_macacao_infantil.jpg", true, Guid.Parse("21814CA8-A02F-4DDF-B910-5FAEAE2FE475") },
                    { Guid.NewGuid(), "Bota Feminina de Couro", "Bota feminina de couro legítimo, ideal para o inverno.", 199.99, "/imagens/bota_feminina_couro.jpg", "/imagens/thumb_bota_feminina_couro.jpg", true, Guid.Parse("08E971B8-72E1-40F8-BF2F-B66D40436E86") },
                    { Guid.NewGuid(), "Tênis Casual Masculino", "Tênis masculino casual, confortável e moderno.", 129.90, "/imagens/tenis_casual_masculino.jpg", "/imagens/thumb_tenis_casual_masculino.jpg", true, Guid.Parse("2118F335-AD48-468F-ADE7-DEE7092EE25E") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM G2_ROUPAS");
        }
    }
}
