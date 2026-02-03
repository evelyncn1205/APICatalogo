using APICatalogo.Context;
using APICatalogo.Models;

namespace APICatalogo.Repository
{
    public class ProdutosRepository : Repository<Produto>,IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutosRepository(AppDbContext context) : base(context)
        {
            
        }

        public IEnumerable<Produto> GetProdutosPorCategoria(int id)
        {
          return GetAll().Where(c=> c.CategoriaID == id);
        }
    }
}
