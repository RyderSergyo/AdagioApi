using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Adagio.Data.Models
{
    public class Clase
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}
