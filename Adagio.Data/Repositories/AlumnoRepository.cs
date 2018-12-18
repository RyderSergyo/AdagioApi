using Adagio.Data.Data;
using Adagio.Data.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adagio.Data.Repositories
{
    public class AlumnoRepository : Repository<Alumno>
    {
        public AlumnoRepository(AdagioContext context) : base(context) { }

        public List<Alumno> GetAlumnosMayoresDe(int anyos)
        {
            int actualYear = DateTime.Now.Year;
            DateTime edad = new DateTime(actualYear - anyos, 0, 0);
            return GetAll().Where(o => o.FechaNacimiento - edad > DateTime.Now - edad).ToList();
        }
    }
}
