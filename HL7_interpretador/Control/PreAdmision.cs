using HL7_interpretador.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Control
{
    class PreAdmision
    {
        public bool AgendarCita(ORM_O01 orm)
        {
            bool correcto = true;
            string[] aux_nombre_medico = orm.ORC[12].Split('^');
            string nombre_medico = aux_nombre_medico[2] + " " + aux_nombre_medico[3] + " " + aux_nombre_medico[1];
            int id_medico = Int32.Parse(aux_nombre_medico[0]);
            int id_paciente = Int32.Parse(orm.PID[3].Split('^')[0]);
            string estudio_requerido = orm.OBR[4].Split('^')[1];
            //string[] aux = orm.OBR[4].Split('^');
            /*for(int i = 0; i < orm.ORC.Length; i++)
            {
                Console.WriteLine(i + ": " + orm.ORC[i]);
            }*/
            Estudio estudio = new Estudio(id_paciente, nombre_medico, id_medico, estudio_requerido, DateTime.Now);
            Base_de_datos.Ejecutar("insert into medico (id, nombre) values (" + estudio.IdMedico + ",\"" + estudio.MedicoDeReferencia + "\")");
            string modalidad = "";
            if (estudio_requerido.Contains("X-RAY"))
            {
                modalidad = "X-RAY";
            } else if(estudio_requerido.Contains("ECOGRAPHY"))
            {
                modalidad = "ECOGRAPHY";
            }
            Base_de_datos.Ejecutar("insert into estudio (idpaciente,idmedico,modalidad,descripcion,fecha) values (" + estudio.Paciente + "," + estudio.IdMedico + ",\"" + modalidad + "\",\"" + estudio.EstudioRequerido + "\",\"" + estudio.FechaEstudio.ToLongDateString() + "\")");
            Console.WriteLine(estudio.ImprimirEstudio());
            return correcto;
        }
    }
}
