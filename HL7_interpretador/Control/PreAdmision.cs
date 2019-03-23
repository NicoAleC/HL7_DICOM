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
            Console.WriteLine(orm.OBR[4].Contains("X-RAY"));
            return correcto;
        }
    }
}
