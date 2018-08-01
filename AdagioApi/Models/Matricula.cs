using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdagioApi.Models
{
    public class Matricula
    {
        public int AlumnoId { get; set; }
        public int ClaseId { get; set; }
        public Alumno Alumno { get; set; }
        public Clase Clase { get; set; }
    }
}
