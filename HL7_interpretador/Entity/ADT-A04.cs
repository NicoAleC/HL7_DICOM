using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Entity
{
    class ADT_A04
    {
        public string version { get; set; }
        public string[] MSH { get; set; }
        public string[] EVN { get; set; }
        public string[] PID { get; set; }
        public string[] PV1 { get; set; }
        public string[] IN1 { get; set; }
        public string[] PR1 { get; set; }

        public ADT_A04()
        {
            this.version = "";
            this.MSH = new string[0];
            this.EVN = new string[0];
            this.PID = new string[0];
            this.PV1 = new string[0];
            this.PR1 = new string[0];
            this.IN1 = new string[0];

        }

        public void ADT_A04_v2_3()
        {
            this.version = "2.3";
            this.MSH = new string[19];
            this.EVN = new string[6];
            this.PID = new string[30];
            this.PV1 = new string[52];
            this.PR1 = new string[15];
            this.IN1 = new string[49];
        }

        public void ADT_A04_v2_2()
        {
            this.version = "2.2";
            this.MSH = new string[17];
            this.EVN = new string[5];
            this.PID = new string[27];
            this.PV1 = new string[50];
            this.PR1 = new string[0];
            this.IN1 = new string[46];
        }
    }
}
