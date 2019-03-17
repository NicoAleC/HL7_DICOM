using System.IO;
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
            string aux = File.ReadAllText(dir);
            string[] respuesta = new string[2];
            respuesta[0] = aux.Split('|')[11];
            respuesta[1] = aux.Split('|')[8];
            return respuesta;
        }

        public string GetMensaje(string dir)
        {
            return File.ReadAllText(dir); 
        }

        public bool LeerMensaje(string dir)
        {
            string mensaje = File.ReadAllText(dir);
            bool version = true;
            bool tipo = true;
            string[] condiciones = new string[2];
            condiciones[0] = mensaje.Split('|')[8];
            condiciones[1] = mensaje.Split('|')[11];
            Parser p = new Parser();

            switch (condiciones[1])
            {
                case "2.2":
                    switch (condiciones[0])
                    {
                        case "ADT^A04":
                            p.Parse_ADT_A04(mensaje, condiciones[1]);
                            break;
                        case "ADT^A08":
                            p.Parse_ADT_A08(mensaje, condiciones[1]);
                            break;
                        case "ORM^O01":
                            p.Parse_ORM_O01(mensaje, condiciones[1]);
                            break;
                        default:
                            tipo = false;
                            break;
                    }
                    break;
                case "2.3":
                    switch (condiciones[0])
                    {
                        case "ADT^A04":
                            p.Parse_ADT_A04(mensaje, condiciones[1]);
                            break;
                        case "ADT^A08":
                            p.Parse_ADT_A08(mensaje, condiciones[1]);
                            break;
                        case "ORM^O01":
                            p.Parse_ORM_O01(mensaje, condiciones[1]);
                            break;
                        default:
                            tipo = false;
                            break;
                    }
                    break;
                default:
                    version = false;
                    break;
            }

            return version && tipo;

        }
    }
}
