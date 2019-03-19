using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Entity
{
    class Estudio
    {
        public Paciente Paciente { get; set; }
        public string MedicoDeReferencia { get; set; }
        public string IdMedico { get; set; }
        public string EstudioRequerido { get; set; }
        public DateTime FechaEstudio { get; set; }

        public Estudio()
        {
            this.Paciente = new Paciente();
            this.MedicoDeReferencia = "";
            this.EstudioRequerido = "";
            this.FechaEstudio = new DateTime();
        }

        public Estudio(Paciente paciente, string medico, string estudio, DateTime fechaEstudio)
        {
            this.Paciente = paciente;
            this.MedicoDeReferencia = medico;
            this.EstudioRequerido = estudio;
            this.FechaEstudio = fechaEstudio;
        }
    }
}
