using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ManejadorAzul : Manejador
    {
        public override void ProcessRequest(Peticion request)
        {
            if (request.Color == "Azul")
                Console.WriteLine($"{this.GetType().Name} solicitud aprobada {request.Codigo} como {request.Color}");
            else Console.WriteLine($"{this.GetType().Name} denegado {request.Codigo} como {request.Color}");
        }
    }
}
