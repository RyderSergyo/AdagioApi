using Adagio.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adagio.Data.Models
{
    public class Matricula : EntityBase
    {
        public int AlumnoId { get; set; }
        public int ClaseId { get; set; }
        public Alumno Alumno { get; set; }
        public Clase Clase { get; set; }
    }
}
