using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;

namespace APICatalogo.Repository
{
    public class CategoriaRepositpry : Repository<Categoria>,ICategoriaRepository
    {
        public CategoriaRepositpry(AppDbContext context) : base(context)
        {
        }

        public PageList<Categoria> GetCategoria(CategoriaParameters categoriaParameters)
        {
            var categoria = GetAll().OrderBy(p => p.CategoriaID).AsQueryable();
            var categriaOrdenados = PageList<Categoria>.ToPageList(categoria, categoriaParameters.PageNumber, categoriaParameters.PageSize);
            return categriaOrdenados;
        }

        public PageList<Categoria> GetCategoriasFiltroNome(CategoriaFiltroNome categoriasParams)
        {
            var categorias = GetAll().AsQueryable();

            if (!string.IsNullOrEmpty(categoriasParams.Nome))
            {
                categorias = categorias.Where(c => c.Nome.Contains(categoriasParams.Nome));
            }

            var categoriasFiltradas = PageList<Categoria>.ToPageList(categorias,
                                       categoriasParams.PageNumber, categoriasParams.PageSize);

            return categoriasFiltradas;
        }
    }
}
