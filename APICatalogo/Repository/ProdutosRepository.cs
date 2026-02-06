using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;

namespace APICatalogo.Repository
{
    public class ProdutosRepository : Repository<Produto>,IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutosRepository(AppDbContext context) : base(context)
        {
            
        }      

        //public IEnumerable<Produto> GetProdutos(ProdutosParameters produtosParameters)
        //{
        //    return GetAll().OrderBy(p=>p.Nome).
        //        Skip((produtosParameters.PageNumber-1)* produtosParameters.PageSize)
        //        .Take(produtosParameters.PageSize).ToList();
        //}
        public PageList<Produto> GetProdutos(ProdutosParameters produtosParameters)
        {
            var produtos = GetAll().OrderBy(p=> p.ProdutoId).AsQueryable();
            var produtorOrdenados = PageList<Produto>.ToPageList(produtos, produtosParameters.PageNumber,produtosParameters.PageSize);
            return produtorOrdenados;
        }
        public IEnumerable<Produto> GetProdutosPorCategoria(int id)
        {
          return GetAll().Where(c=> c.CategoriaID == id);
        }

        public PageList<Produto> GetProdutoFiltroPreco(ProdutosFiltroPreco produtosFiltroParams)
        {
            var produtos = GetAll().AsQueryable();

            if (produtosFiltroParams.Preco.HasValue && !string.IsNullOrEmpty(produtosFiltroParams.PrecoCriterio))
            {
                if (produtosFiltroParams.PrecoCriterio.Equals("maior", StringComparison.OrdinalIgnoreCase))
                {
                    produtos = produtos.Where(p => p.Preco > produtosFiltroParams.Preco.Value).OrderBy(p => p.Preco);
                }
                else if (produtosFiltroParams.PrecoCriterio.Equals("menor", StringComparison.OrdinalIgnoreCase))
                {
                    produtos = produtos.Where(p => p.Preco < produtosFiltroParams.Preco.Value).OrderBy(p => p.Preco);
                }
                else if (produtosFiltroParams.PrecoCriterio.Equals("igual", StringComparison.OrdinalIgnoreCase))
                {
                    produtos = produtos.Where(p => p.Preco == produtosFiltroParams.Preco.Value).OrderBy(p => p.Preco);
                }
            }
            var produtosFiltrados = PageList<Produto>.ToPageList(produtos, produtosFiltroParams.PageNumber,
                                                                                                  produtosFiltroParams.PageSize);
            return produtosFiltrados;

        }
    }
}
