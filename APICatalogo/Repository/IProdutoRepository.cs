using APICatalogo.Models;
using APICatalogo.Pagination;

namespace APICatalogo.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {        
        IEnumerable<Produto> GetProdutosPorCategoria( int id);
        //IEnumerable<Produto> GetProdutos(ProdutosParameters produtosParameters);
        PageList<Produto> GetProdutos(ProdutosParameters produtosParameters);
    }
}
