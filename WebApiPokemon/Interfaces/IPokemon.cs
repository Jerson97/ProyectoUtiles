using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPokemon.Models;

namespace WebApiPokemon.Interfaces
{
    public interface IPokemon
    {
        public Task<ePokemon> GetPokemon();
    }
}
