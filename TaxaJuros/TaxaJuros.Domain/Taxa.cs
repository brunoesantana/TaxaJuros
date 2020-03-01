using System.ComponentModel.DataAnnotations;
using TaxaJuros.Domain.Base;

namespace TaxaJuros.Domain
{
    public class Taxa : EntityBase
    {
        [Required]
        public double Value { get; set; }
    }
}