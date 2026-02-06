using APICatalogo.Models;
using APICatalogo.Pagination;

namespace APICatalogo.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {      
        PageList<Categoria> GetCategoria(CategoriaParameters categoriaParameters);
        PageList<Categoria> GetCategoriasFiltroNome(CategoriaFiltroNome categoriasParams);
    }
}
