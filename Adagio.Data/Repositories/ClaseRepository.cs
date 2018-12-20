using Adagio.Data.Data;
using Adagio.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adagio.Data.Repositories
{
    public class ClaseRepository : Repository<Clase>
    {
        public ClaseRepository(AdagioContext context) : base(context) { }

        public List<Clase> GetClasesConAlumnos()
        {
            return Context.Clases
                .Include(c => c.Matriculas)
                    .ThenInclude(m => m.Alumno)
                .ToList();
        }

        public async Task<List<Clase>> GetClasesConAlumnosAsync()
        {
            return await Context.Clases
                .Include(c => c.Matriculas)
                    .ThenInclude(m => m.Alumno)
                .ToListAsync();
        }
    }
}
