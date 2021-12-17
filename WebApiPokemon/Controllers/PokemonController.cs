using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPokemon.Interfaces;
using WebApiPokemon.Models;

namespace WebApiPokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemon _pokemon;
        public PokemonController(IPokemon pokemon)
        {
            _pokemon = pokemon;
        }

        [HttpPost("ConsultaPokemon")]
        public async Task<ActionResult<ePokemon>> ConsultaPokemmo()
        {
            var result = await _pokemon.GetPokemon();

            return Ok(result);
        }
    }
}
