using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSOrdenesInfinity.Util
{
    public class Util
    {
        public static string GuardarArchivo(string nombreTxt, string texto)
        {
            

            string folderName = @"c:\Ordenes";
            string pathString = System.IO.Path.Combine(folderName, "Escritura");

            
            System.IO.Directory.CreateDirectory(pathString);

            string fileName = nombreTxt;

            pathString = System.IO.Path.Combine(pathString, fileName);


            using (StreamWriter outputFile = new StreamWriter(pathString))
            {
                outputFile.WriteLine(texto);

            };

            return "ok";
        }
    }
}
