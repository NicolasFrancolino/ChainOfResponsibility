using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ManejadorRojo : Manejador
    {
        public override void ProcessRequest(Peticion request)
        {
            if (request.Color == "Rojo")
                Console.WriteLine($"{this.GetType().Name} solicitud aprobada {request.Codigo} como {request.Color}");
            else if (ProximoManejador != null)
                ProximoManejador.ProcessRequest(request);
        }
    }
}
