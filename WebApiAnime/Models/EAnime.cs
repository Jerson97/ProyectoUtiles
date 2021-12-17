using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAnime.Models
{
    public class EAnime
    {
        public string request_hash { get; set; }
        public IList<Resultados> results { get; set; }
    }

    public class Resultados
    {
        public int mal_id { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string title { get; set; }
    }
}
