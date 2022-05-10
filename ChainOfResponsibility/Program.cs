using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manejador manejadorRojo = new ManejadorRojo();
            Manejador manejadorAzul = new ManejadorAzul();
            Manejador manejadorVerde = new ManejadorVerde();

            manejadorRojo.SetNextHandler(manejadorVerde);
            manejadorVerde.SetNextHandler(manejadorAzul);


            // Requests

            Peticion request = null;

            request = new Peticion("001", "Rojo");
            manejadorRojo.ProcessRequest(request);

            request = new Peticion("002", "Verde");
            manejadorRojo.ProcessRequest(request);

            request = new Peticion("003", "Azul");
            manejadorRojo.ProcessRequest(request);

            request = new Peticion("999", "Blanco");
            manejadorRojo.ProcessRequest(request);

            Console.ReadKey();
        }


    }
}
