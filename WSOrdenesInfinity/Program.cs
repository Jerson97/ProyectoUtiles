using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WSOrdenesInfinity
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new SWEnvioOrdenes()
            //};
            //ServiceBase.Run(ServicesToRun);

            SWEnvioOrdenes sw = new SWEnvioOrdenes();
            sw.ExecuteH1();

        }
    }
}
