using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiPokemon.Interfaces;
using WebApiPokemon.Models;

namespace WebApiPokemon.Clases
{
    public class Pokemon : IPokemon
    {
       

        public async Task<ePokemon> GetPokemon()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");

            var result = client.GetAsync("pokemon").Result;

            if (!result.IsSuccessStatusCode)
                return null;

            ePokemon epokemon = new ePokemon();
            var response = result.Content.ReadAsStringAsync().Result;

            epokemon = JsonConvert.DeserializeObject<ePokemon>(response);
            await Task.Delay(1);
            return epokemon;
        }
    }
}
