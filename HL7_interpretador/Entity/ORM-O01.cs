using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Entity
{
    class ORM_O01
    {
        public string version { get; set; }
        public string[] MSH { get; set; }
        public string[] PID { get; set; }
        public string[] ORC { get; set; }
        public string[] PV1 { get; set; }
        public string[] IN1 { get; set; }
        public string[] OBX { get; set; }
        public string[] OBR { get; set; }
        public string[] NTE { get; set; }

        public ORM_O01()
        {
            this.version = "";
            this.MSH = new string[0];
            this.PID = new string[0];
            this.ORC = new string[0];
            this.PV1 = new string[0];
            this.IN1 = new string[0];
            this.OBX = new string[0];
            this.OBR = new string[0];
            this.NTE = new string[0];
        }

        public void ORM_O01_v2_3()
        {
            this.version = "2.3";
            MSH = new string[19];
            PID = new string[30];
            PV1 = new string[52];
            ORC = new string[19];
            OBX = new string[17];
        }

        public void ORM_O01_v2_2()
        {
            this.version = "2.2";
            MSH = new string[17];
            PID = new string[27];
            ORC = new string[19];
            OBR = new string[36];
            NTE = new string[3];
        }
    }
}
