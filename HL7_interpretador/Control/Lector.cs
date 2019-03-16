using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Control
{
    class Lector
    {
        public string[] GetVersionTipo(string dir)
        {
            string aux = System.IO.File.ReadAllText(dir);
            string[] respuesta = new string[2];
            respuesta[0] = aux.Split('|')[11];
            respuesta[1] = aux.Split('|')[8];
            return respuesta;
        }

        public string GetMensaje(string dir)
        {
            return System.IO.File.ReadAllText(dir); 
        }
    }
}
