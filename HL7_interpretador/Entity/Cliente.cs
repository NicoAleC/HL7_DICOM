using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Entity
{
    class Cliente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public double Peso { get; set; }
        public string Nacimiento { get; set; }

        public Cliente()
        {
            this.Id = "";
            this.Nombre = "";
            this.Sexo = "";
            this.Peso = 0;
            this.Nacimiento = "";
        }

        public Cliente(string id, string nombre, string sexo, double peso, string medico, string nacimiento)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Sexo = sexo;
            this.Peso = peso;
            this.Nacimiento = nacimiento;
        }
    }
}
