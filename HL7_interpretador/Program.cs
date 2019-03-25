using HL7_interpretador.Control;
using HL7_interpretador.formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HL7_interpretador
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            Lector lector = new Lector();
            string nombre = "ORM-O01_1";
            lector.LeerMensaje(@"..\\..\\..\\HL7-ejemplos\\" + nombre + ".txt");
            Console.ReadKey();
            Base_de_datos.conexion.Close();
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Inicio());*/
            Console.ReadKey();
            Base_de_datos.conexion.Close();
        }
    }
}
