using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Control
{
    class Respuesta
    {
        public static void Rechazo()
        {
            Console.WriteLine("NACK de rechazo enviado");
        }

        public static void Aceptado()
        {
            Console.WriteLine("ACK de aceptaciónn enviado");
        }
    }
}
