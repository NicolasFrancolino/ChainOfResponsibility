using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Manejador
    {
        protected Manejador ProximoManejador;

        public void SetNextHandler(Manejador proximoManejador)
        {
            ProximoManejador = proximoManejador;
        }

        public abstract void ProcessRequest(Peticion request);
    }
}
