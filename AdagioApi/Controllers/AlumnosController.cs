using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adagio.Data.Data;
using Adagio.Data.Models;
using Adagio.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Adagio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private readonly AdagioContext _context;
        private AlumnoRepository AlumnoRepository;
        public AlumnosController(AdagioContext context)
        {
            _context = context;
            AlumnoRepository = new AlumnoRepository(_context);
        }

        /// <summary>
        /// Devuelve una lista con todos los Alumnos
        /// </summary>
        /// <returns>ActionResult<IEnumerable<Alumno>></returns>
        [HttpGet(Name = "GetAll")]
        public async Task<ActionResult<IEnumerable<Alumno>>> GetAllAsync(string orden = null)
        {
            var listaAlumnos = AlumnoRepository.GetAll();

            if (!String.IsNullOrWhiteSpace(orden))
            {
                switch (orden)
                {
                    case "nombre_asc":
                        listaAlumnos = listaAlumnos.OrderBy(o => o.Nombre).ToList();
                        break;
                    case "nombre_desc":
                        listaAlumnos = listaAlumnos.OrderByDescending(o => o.Nombre).ToList();
                        break;
                    default:
                        break;
                }
            }
            return listaAlumnos.ToList();
        }

        /// <summary>
        /// Devuelve una lista con todos los Alumnos mayores de la edad especificada
        /// </summary>
        /// <param name="edad"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Alumno>> GetAllMayores(int id)
        {
            return AlumnoRepository.Get(id) ?? null;
        }
    }
}