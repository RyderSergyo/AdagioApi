using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adagio.Data.Data;
using Adagio.Data.Models;
using Adagio.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Adagio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasesController : ControllerBase
    {
        private readonly AdagioContext _context;
        private ClaseRepository ClaseRepository;
        public ClasesController(AdagioContext context)
        {
            _context = context;
            ClaseRepository = new ClaseRepository(_context);
        }

        [HttpGet("GetAll", Name = "GetAllClases")]
        public List<Clase> GetAll(string order = "asc")
        {
            var listaClases = ClaseRepository.GetClasesConAlumnos();

            switch (order)
            {
                case "asc":
                    listaClases = listaClases.OrderBy(c => c.Nombre).ToList();
                    break;
                case "desc":
                    listaClases = listaClases.OrderBy(c => c.Nombre).ToList();
                    break;
                default:
                    break;
            }
            return listaClases;
        }

        [HttpGet("GetAllAsync", Name = "GetAllClasesAsync")]
        public async Task<List<Clase>> GetAllAsync(string order = "asc")
        {
            var listaClases = await ClaseRepository.GetClasesConAlumnosAsync();

            switch (order)
            {
                case "asc":
                    listaClases = listaClases.OrderBy(c => c.Nombre).ToList();
                    break;
                case "desc":
                    listaClases = listaClases.OrderBy(c => c.Nombre).ToList();
                    break;
                default:
                    break;
            }

            return listaClases;
        }

        [HttpGet("GetAsync", Name = "GetClaseById")]
        public async Task<Clase> GetById(int id)
        {
            return await ClaseRepository.GetAsync(id);
        }
    }
}