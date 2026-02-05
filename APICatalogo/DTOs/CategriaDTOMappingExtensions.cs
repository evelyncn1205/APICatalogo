using APICatalogo.Controllers;
using APICatalogo.Models;

namespace APICatalogo.DTOs
{
    public static class CategriaDTOMappingExtensions
    {
        public static CategoriaDTO? ToCategoriaDTO(this Categoria categoria)
        {
            return new CategoriaDTO
            {
                CategoriaID = categoria.CategoriaID,
                Nome = categoria.Nome,
                ImageUrl = categoria.ImageUrl,
            };
        }

        public static Categoria? ToCategoria(this CategoriaDTO categoriaDto)
        {
            return new Categoria
            {
                CategoriaID = categoriaDto.CategoriaID,
                Nome = categoriaDto.Nome,
                ImageUrl = categoriaDto.ImageUrl,
            };
        }

        public static IEnumerable<CategoriaDTO> ToCategoriaDTOList(this IEnumerable<Categoria>categorias)
        {
            if (categorias is null || !categorias.Any())
            {
                return new List<CategoriaDTO>();
            }

            return categorias.Select(categoria => new CategoriaDTO
            {
                CategoriaID = categoria.CategoriaID,
                Nome = categoria.Nome,
                ImageUrl = categoria.ImageUrl,
            });
        }
    }
}
