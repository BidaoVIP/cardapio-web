using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao_Curta { get; set; }
        public string Descricao_Detalhada { get; set; }
        public decimal Preco { get; set; }
        public string Local_Tempo { get; set; }
        public bool Produto_Preferido { get; set; }
        public bool Em_Estoque { get; set; }

    }
}
