using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senatur.Tarde.Domains
{
    public class UsuarioDomain
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [EmailAddress]
        public string Email{ get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public string TipoUsuario{ get; set; }
    }
}
