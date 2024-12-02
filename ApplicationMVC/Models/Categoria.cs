using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationMVC.Models
{
    public class Categoria
    {
        [Column("ID_CATEGORIA")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria")]
        [StringLength(100, ErrorMessage = "O tamanho máximo é {1} caracteres")]
        [Display(Name = "Nome da Categoria")]
        [Column("NM_CATEGORIA")]
        public string NomeCategoria { get; set; }

        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [StringLength(200, ErrorMessage = "O tamanho máximo é {1} caracteres")]
        [Display(Name = "Descrição da Categoria")]
        [Column("DS_CATEGORIA")]
        public string DescricaoCategoria { get; set; }

        public List<Roupa> Roupas { get; set; }
    }
}
