using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationMVC.Models
{
    public class Categoria
    {
        [Column("ID_CATEGORIA")]
        public int CategoriaId { get; set; }

        [Column("NM_CATEGORIA")]
        public string NomeCategoria { get; set; }

        [Column("DS_CATEGORIA")]
        public string DescricaoCategoria { get; set; }

        public List<Roupa> Roupas { get; set; }
    }
}
