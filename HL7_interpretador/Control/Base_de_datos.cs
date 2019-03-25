using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using HL7_interpretador.Entity;

namespace HL7_interpretador.Control
{
    class Base_de_datos
    {
        public static OleDbConnection conexion = null;
        public static OleDbConnection GetConexion()
        {
            if(conexion == null)
            {
                try
                {
                    OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
                    builder.Provider = "Microsoft.ACE.OLEDB.12.0";
                    //builder.Provider = "SQLOLEDB";
                    builder.DataSource = "..\\..\\..\\RIS.accdb";
                    conexion = new OleDbConnection(builder.ToString());
                    conexion.Open();
                }
                catch (OleDbException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return conexion;
        }

        public static OleDbDataReader Leer(string sql)
        {
            OleDbCommand command = new OleDbCommand();
            try
            {
                command = new OleDbCommand(sql, GetConexion());
                return command.ExecuteReader();
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void Ejecutar(string sql)
        {
            try
            {
                OleDbCommand command = new OleDbCommand(sql, GetConexion());
                command.ExecuteNonQuery();
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static Paciente LeerPaciente(int id)
        {
            OleDbDataReader bpaciente = Leer("select * from paciente where id = " + id);
            bpaciente.Read();
            Paciente paciente = new Paciente(bpaciente.GetInt32(0), bpaciente.GetString(1), bpaciente.GetString(2), bpaciente.GetDateTime(3));
            bpaciente.Close();
            return paciente;
        }

        public static OleDbDataReader LeerEstudios()
        {
            return Leer("select * from estudio, medico, modalidad where modalidad.nombre = estudio.modalidad and medico.id = estudio.idmedico");
        }
    }
}
