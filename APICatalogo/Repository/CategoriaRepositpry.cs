using APICatalogo.Context;
using APICatalogo.Models;

namespace APICatalogo.Repository
{
    public class CategoriaRepositpry : Repository<Categoria>,ICategoriaRepository
    {
        public CategoriaRepositpry(AppDbContext context) : base(context)
        {

        }
       
    }
}
