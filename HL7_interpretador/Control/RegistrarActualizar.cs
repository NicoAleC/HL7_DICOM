using HL7_interpretador.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (adt.PID[2].Equals("") || adt.PID[5].Equals("") || adt.PID[7].Equals("") || adt.PID[8].Equals(""))
            {
                correcto = false;
                //Console.WriteLine(correcto);
                //Console.WriteLine(adt.PID[3].Split('^')[0] + "\n" + adt.PID[5] + "\n" + adt.PID[8] + "\n" + adt.PID[7]);
            }
            else
            {
                string fecha = adt.PID[7].Substring(6, 2) + "/" + adt.PID[7].Substring(4, 2) + "/" + adt.PID[7].Substring(0, 4);
                Paciente paciente = new Paciente(Int32.Parse(adt.PID[2]), adt.PID[5].Replace(' ', '^'), adt.PID[8], DateTime.Parse(fecha));
                //Console.WriteLine(adt.PID[2] + "\n" + adt.PID[5] + "\n" + adt.PID[8] + "\n" + fecha);
            }
            return correcto;
        }
    }
}
