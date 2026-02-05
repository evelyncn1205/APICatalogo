using APICatalogo.Context;

namespace APICatalogo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProdutoRepository ? _produtoRepo;
        private ICategoriaRepository ? _categoriaRepo;
        public AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context=context;
        }

        public IProdutoRepository ProdutoRepository
        {

            get
            {
                return _produtoRepo = _produtoRepo ?? new ProdutosRepository(_context);
            }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                return _categoriaRepo = _categoriaRepo ?? new CategoriaRepositpry(_context);
            }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
