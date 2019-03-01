using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senatur.Tarde.Domains
{
    [Table("Pacotes")]
    public class PacoteDomain
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PacoteId { get; set; }

        [Required]
        public string NomePacote { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataIda { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataVolta{ get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public Decimal Valor { get; set; }

        [Required]
        public string Ativo { get; set; }

        [Required]
        public string NomeCidade{ get; set; }
    }
}
