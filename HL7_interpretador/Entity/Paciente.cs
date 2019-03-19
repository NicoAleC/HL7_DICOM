using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Entity
{
    class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public DateTime Nacimiento { get; set; }

        public Paciente()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Sexo = "";
            this.Nacimiento = new DateTime();
        }

        public Paciente(int id, string nombre, string sexo, DateTime nacimiento)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.Nacimiento = nacimiento;
        }

        public string ImprimirPaciente()
        {
            return "Id: " + this.Id + "\nNombre: " + this.Nombre + "\nSexo: " + this.Sexo + "\nFecha de nacimiento: " + this.Nacimiento.ToShortDateString() + "\n";
        }
    }
}
