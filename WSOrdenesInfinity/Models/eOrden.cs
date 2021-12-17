using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOrdenesInfinity.Models
{
    public class eOrden
    {
        public string numeroOrden { get; set; }
        public string nombres { get; set; }
        public string apelldios { get; set; }
    }

    public class Examem
    {
        public string codigoServicio { get; set; }
        public string nombreExamen { get; set; }
    }
}
