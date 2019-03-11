using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Entity
{
    class ORM_O01_v2_3 : ORM_O01
    {
        public string[] PV1 { get; set; }
        public string[] IN1 { get; set; }
        public string[] OBX { get; set; }

        public ORM_O01_v2_3()
        {
            MSH = new string[19];
            PID = new string[30];
            PV1 = new string[52];
            ORC = new string[19];
            OBX = new string[17];
        }
    }
}
