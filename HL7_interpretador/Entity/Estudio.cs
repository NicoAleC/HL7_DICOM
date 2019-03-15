using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Entity
{
    class Estudio
    {
        public Cliente Paciente { get; set; }
        public string MedicoDeReferencia { get; set; }
        public string EstudioRequerido { get; set; }

        public Estudio()
        {
            this.Paciente = new Cliente();
            this.MedicoDeReferencia = "";
            this.EstudioRequerido = "";
        }

        public Estudio(Cliente paciente, string medico, string estudio)
        {
            this.Paciente = paciente;
            this.MedicoDeReferencia = medico;
            this.EstudioRequerido = estudio;
        }
    }
}
