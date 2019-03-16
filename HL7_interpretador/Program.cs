using HL7_interpretador.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector lector = new Lector();
            string nombre = "ADT-A01";
            string[] prueba = lector.GetVersionTipo(@"..\\..\\..\\HL7-ejemplos\\" + nombre + ".txt");
            string mensaje = lector.GetMensaje(@"..\\..\\..\\HL7-ejemplos\\" + nombre + ".txt");
            foreach(string c in prueba)
            {
                Console.WriteLine(c);
            }
            Console.Write(mensaje);
            Console.ReadKey();
        }
    }
}
