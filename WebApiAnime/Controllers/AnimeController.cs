using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAnime.Interfaces;
using WebApiAnime.Models;

namespace WebApiAnime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IAnime _anime;
        public AnimeController(IAnime anime)
        {
            _anime = anime;
        }

        [HttpPost("ConsultaAnime")]
        public async Task<ActionResult<EAnime>> ConsultaAnime (string parametro)
        {
            var result = await _anime.ConsultaAnime(parametro);

            return Ok(result);
        }
    }
}
