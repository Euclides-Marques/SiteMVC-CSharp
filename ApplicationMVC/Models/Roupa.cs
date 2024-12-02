using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationMVC.Models
{
    [Table("G2_ROUPAS")]
    public class Roupa
    {
        [Key]
        [Column("ID_ROUPA")]
        public Guid RoupaId { get; set; }

        [Required(ErrorMessage = "Informe o nome da roupa")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        [Display(Name = "Nome da Roupa")]
        [Column("NM_ROUPA")]
        public string NomeRoupa { get; set; }

        [Required(ErrorMessage = "Informe a descrição da roupa")]
        [MinLength(20, ErrorMessage = "Descrção deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrção deve ter no máximo {1} caracteres")]
        [Display(Name = "Nome da Roupa")]
        [Column("DS_ROUPA")]
        public string DescricaoRoupa { get; set; }

        [Required(ErrorMessage = "Informe o preço da roupa")]
        [Display(Name = "Preço")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre {1} e {2}")]
        [Column("VL_ROUPA", TypeName = "decimal(10,2)")]
        public double PrecoRoupa { get; set; }

        [Display(Name = "Caminho da Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        [Column("FL_IMAGEM_ROUPA")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        [Column("FL_THUMBNAIL_ROUPA")]
        public string ThumbnailUrl { get; set; }

        [Display(Name = "Estoque")]
        [Column("FL_ESTOQUE")]
        public bool EmEstoque { get; set; }

        [ForeignKey("G2_CATEGORIAS")]
        [Column("ID_CATEGORIA")]
        public Guid CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
