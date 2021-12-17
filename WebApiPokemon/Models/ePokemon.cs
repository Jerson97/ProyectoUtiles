using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPokemon.Models
{
    public class ePokemon
    {
        public IList<results> results { get; set; }
    }

    public class results
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
