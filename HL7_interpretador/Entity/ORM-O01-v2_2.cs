using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Entity
{
    class ORM_O01_v2_2 : ORM_O01
    {
        public string[] OBR { get; set; }
        public string[] NTE { get; set; }

        public ORM_O01_v2_2()
        {
            MSH = new string[17];
            PID = new string[27];
            ORC = new string[19];
            OBR = new string[36];
            NTE = new string[3];
        }

    }
}
