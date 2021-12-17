using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WSOrdenesInfinity.Models;

namespace WSOrdenesInfinity
{
    partial class SWEnvioOrdenes : ServiceBase
    {
        int i_i_Tiempo;
        public SWEnvioOrdenes()
        {
            InitializeComponent();
            i_i_Tiempo = 1000 * 30; //30 Segundos
        }     

        private List<eOrden> ListOrdenesCab = null;
        private List<Examem> ListOrdenesDet = null;

        Thread Hilo1 = null;
        private bool RunH1 = true;
        //private int TimeOutH1 = 0;     

        

        public void ExecuteH1()
        {
          /*  string mensajes = "Navidad";
            string saludo = "Hola";*/

   /*         //NavHol
            string union = mensajes.Substring(0,3) + saludo.Substring(0,3);

            string folderName = @"c:\Top-Level Folder";
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");

            string pathString2 = @"c:\Top-Level Folder\SubFolder2";
            System.IO.Directory.CreateDirectory(pathString);

            string fileName = "MyNewFile.txt";

            pathString = System.IO.Path.Combine(pathString, fileName);


            using (StreamWriter outputFile = new StreamWriter(pathString))
            {
                outputFile.WriteLine(union);

            };*/



            string folderName = @"D:\Top-Level Folder";

            string pathString = System.IO.Path.Combine(folderName, "SubFolder");
            string pathString2 = @"D:\Top-Level Folder\SubFolder2";


            System.IO.Directory.CreateDirectory(pathString);


            string fileName = System.IO.Path.GetRandomFileName();

            while (RunH1)
            {
                DateTime dtActual = DateTime.Now;
                var formatoHL7 = new StringBuilder();

                //EJECUTA Y DUERME 1 MINUTO
                string mensaje = string.Empty;
                //int ok;
                eOrden Ordenes = new eOrden();
                try
                {

                    //ListOrdenesCab = BLOrden.Envio_Orden_EnterpriseCab("%");
                    ListOrdenesCab = new List<eOrden> { 
                        new eOrden { numeroOrden = "12102180",
                                     apelldios = "RAMIREZ SOTOMAYOR", 
                                     nombres = "JERSON"},
                        new eOrden
                        {
                            numeroOrden = "12102181",
                            apelldios = "RAMIREZ SOTOMAYOR",
                            nombres = "Arturo"
                        }
                    }
                    ;

                    if (ListOrdenesCab.Count() <= 0)
                    {
                        //Thread.Sleep(i_i_Tiempo);
                    }
                    else
                    {

                        foreach (var entidad in ListOrdenesCab)
                        {
                            formatoHL7 = new StringBuilder();
                            int i = 0;
                            //ListOrdenesDet = BLOrden.Envio_Orden_EnterpriseDet(entidad);
                            ListOrdenesDet = new List<Examem> {
                                new Examem {
                                            codigoServicio = "330410",
                                            nombreExamen = "Hemograma"
                                            },
                                new Examem {
                                            codigoServicio="330108",
                                            nombreExamen="Glucosa"
                                            }
                                            };
                            formatoHL7.AppendLine("H|" + entidad.numeroOrden + "||" + entidad.nombres + "||" + entidad.apelldios + "||" + "\r");
                            foreach (var examen in ListOrdenesDet)
                            {
                                i++;

                                formatoHL7.AppendLine("O" + "|" + i + "|" + examen.codigoServicio + "||" + examen.nombreExamen + "||" + "\r");

                            }

                            formatoHL7.AppendLine("L|1|N");

                            //guardar en un txt

                            Util.Util.GuardarArchivo(entidad.numeroOrden, formatoHL7.ToString());

                            //using (StreamWriter outputFile = new StreamWriter("C:\\documentosTxt\\Archivo.txt"))
                            //{
                            //    outputFile.WriteLine(formatoHL7);

                            using (StreamWriter outputFile = new StreamWriter(pathString))
                            {
                                outputFile.WriteLine(formatoHL7);
                                //};



                            }

                        }
                    }

                }
                catch (Exception ex)
                {
                    //LogExcepciones.LogOrdenesEnterpriseError(ex.Message);
                    ////Thread.Sleep(60000 * Properties.Settings.Default.TiempoMin);


                    //LogExcepciones.LogOrdenesEnterpriseError("Ocurrio un problema la Orden: " + Ordenes.yearOrden + "debido a" + ex.Message);
                }


            }

        }
        protected override void OnStart(string[] args)
        {
            // TODO: agregar código aquí para iniciar el servicio.
        }

        protected override void OnStop()
        {
            // TODO: agregar código aquí para realizar cualquier anulación necesaria para detener el servicio.
        }
    }
}
