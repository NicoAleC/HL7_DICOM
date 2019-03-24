using HL7_interpretador.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace HL7_interpretador.Control
{
    class RegistrarActualizar
    {
        public bool RegistrarPaciente(ADT_A04 adt)
        {
            bool correcto = true;
            /*for(int i = 0; i < adt.PID.Length; i++)
            {
                Console.WriteLine(i + ":" + adt.PID[i]);
            }*/
            Paciente paciente = new Paciente();

            if (adt.PID[3].Equals("") || adt.PID[5].Equals("") || adt.PID[7].Equals("") || adt.PID[8].Equals(""))
            {
                Respuesta.Rechazo();
                correcto = false;
            }
            else
            {
                string fecha = adt.PID[7].Substring(6, 2) + "/" + adt.PID[7].Substring(4, 2) + "/" + adt.PID[7].Substring(0, 4);
                string[] aux = adt.PID[5].Split('^');
                string nombre = aux[1] + " " + aux[2] + " " + aux[0];
                Console.WriteLine("fecha de nacimiento: " + fecha);
                paciente = new Paciente(Int32.Parse(adt.PID[3].Split('^')[0]), nombre, adt.PID[8], DateTime.Parse(fecha));
            }

            if(paciente.Id > 0)
            {
                Console.WriteLine(paciente.ImprimirPaciente());
                Base_de_datos.Ejecutar("INSERT INTO PACIENTE (ID, NOMBRE, SEXO, FECHANACIMIENTO) VALUES (" + paciente.Id + ",\"" + paciente.Nombre + "\",\"" + paciente.Sexo + "\",\"" + paciente.Nacimiento.ToShortDateString() + "\")");
                OleDbDataReader leer = Base_de_datos.Leer("SELECT * FROM Paciente WHERE Id = " + paciente.Id + ";");
                leer.Read();
                Paciente aux = new Paciente(leer.GetInt32(0), leer.GetString(1), leer.GetString(2), leer.GetDateTime(3));
                leer.Close();
                Console.WriteLine(aux.ImprimirPaciente());
                Respuesta.Aceptado();
            }

            return correcto;
        }

        public bool ActualizarPaciente(ADT_A08 adt)
        {
            bool correcto = true;
            if (adt.PID[3].Equals("") || adt.PID[5].Equals("") || adt.PID[7].Equals("") || adt.PID[8].Equals(""))
            {
                Respuesta.Rechazo();
                correcto = false;
            }
            else
            {
                string fecha = adt.PID[7].Substring(6, 2) + "/" + adt.PID[7].Substring(4, 2) + "/" + adt.PID[7].Substring(0, 4);
                string[] aux = adt.PID[5].Split('^');
                string nombre = aux[1] + " " + aux[2] + " " + aux[0];
                Base_de_datos.Ejecutar("UPDATE PACIENTE SET NOMBRE = \"" + nombre + "\", SEXO = \"" + adt.PID[8] + "\", FECHANACIMIENTO = \"" + fecha + "\" WHERE ID = " + adt.PID[3].Split('^')[0]);
                OleDbDataReader leer = Base_de_datos.Leer("SELECT * FROM PACIENTE WHERE ID = " + adt.PID[3].Split('^')[0]);
                leer.Read();
                Paciente paciente = new Paciente(leer.GetInt32(0), leer.GetString(1), leer.GetString(2), leer.GetDateTime(3));
                leer.Close();
                Console.WriteLine(paciente.ImprimirPaciente());
                Respuesta.Aceptado();
            }
            return correcto;
        }
    }
}
