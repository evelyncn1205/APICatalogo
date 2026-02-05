using APICatalogo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.DTOs
{
    public class ProdutoDTOUpdateResponse
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }     
        public decimal Preco { get; set; }       
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataRegisto { get; set; }
        public int CategoriaID { get; set; }

    }
}
