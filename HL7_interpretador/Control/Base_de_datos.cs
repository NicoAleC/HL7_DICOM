using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

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

        public static OleDbDataReader Leer(String sql)
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

        public static void Ejecutar(String sql)
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
    }
}
