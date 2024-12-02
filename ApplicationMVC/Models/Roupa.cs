using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationMVC.Models
{
    public class Roupa
    {
        [Column("ID_ROUPA")]
        public int RoupaId { get; set; }

        [Column("NM_ROUPA")]
        public string NomeRoupa { get; set; }

        [Column("DS_ROUPA")]
        public string DescricaoRoupa { get; set; }

        [Column("VL_ROUPA")]
        public double PrecoRoupa { get; set; }

        [Column("FL_IMAGEM_ROUPA")]
        public string ImagemUrl { get; set; }
        
        [Column("FL_THUMBNAIL_ROUPA")]
        public string ThumbnailUrl { get; set; }

        [Column("FL_ESTOQUE")]
        public bool EmEstoque { get; set; }

        [Column("ID_CATEGORIA")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
