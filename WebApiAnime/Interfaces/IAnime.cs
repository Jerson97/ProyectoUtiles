using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiAnime.Models;

namespace WebApiAnime.Interfaces
{
    public interface IAnime
    {
        public Task<EAnime> ConsultaAnime(string parametro);
    }
}
