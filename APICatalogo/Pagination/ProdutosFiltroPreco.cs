namespace APICatalogo.Pagination
{
    public class ProdutosFiltroPreco : QueryStringPatameters
    {
        public decimal? Preco {  get; set; }

        public string? PrecoCriterio { get; set; } //maior, menos ou igual 
    }
}
