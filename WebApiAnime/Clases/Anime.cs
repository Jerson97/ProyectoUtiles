using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using WebApiAnime.Interfaces;
using WebApiAnime.Models;

namespace WebApiAnime.Clases
{
    public class Anime : IAnime
    {
        public async Task<EAnime> ConsultaAnime(string parametro)
        {
            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.jikan.moe/v3/search/");

            var result =  client.GetAsync("anime?q=" + parametro).Result;

            if (!result.IsSuccessStatusCode)
                return null;

            EAnime eAnime = new EAnime();
            var response = result.Content.ReadAsStringAsync().Result;

             eAnime = JsonConvert.DeserializeObject<EAnime>(response);
            await Task.Delay(1);
            return eAnime;
        }
    }
}
