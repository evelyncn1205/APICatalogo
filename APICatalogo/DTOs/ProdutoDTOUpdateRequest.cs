using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs
{
    public class ProdutoDTOUpdateRequest : IValidatableObject
    {
        [Range(1,999, ErrorMessage ="O estoque deve estar entre 1 e 9999.")]
        public float Estoque { get; set; }
        public DateTime DataRegisto { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
          if(DataRegisto.Date <= DateTime.Now)
            {
                yield return new ValidationResult("A data deve ser maior que a data atual ",
                    new[] { nameof(this.DataRegisto) });
                    
            }

        }
    }
}
