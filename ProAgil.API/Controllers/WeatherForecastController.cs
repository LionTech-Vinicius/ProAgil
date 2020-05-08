using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProAgil.Repositorio;

namespace ProAgil.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IProAgilRepositorio _context { get; }

        public WeatherForecastController(IProAgilRepositorio context)
        {
            _context = context;

        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.GetAllEventosAsync(false);

                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou!");
            }
        }


        // [HttpGet("{id}")]
        // public async Task<IActionResult> Get(int id)
        // {
        //     try
        //     {
        //         var results = await _context.Eventos.FirstOrDefaultAsync(x => x.Id == id);
        //         return Ok(results);
        //     }
        //     catch (System.Exception)
        //     {

        //         throw;
        //     }
        // }
    }
}
