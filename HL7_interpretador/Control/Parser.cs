using HL7_interpretador.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Control
{
    class Parser
    {


        public bool Parse_ORM_O01(string mensaje, string version)
        {
            ORM_O01 orm_o01 = new ORM_O01();
            string[] aux = mensaje.Split('\n');
            bool correcto = true;
            orm_o01.version = version;

            switch (version)
            {
                case "2.2":
                    for (int i = 0; i < mensaje.Length; i++)
                    {
                        string[] seccion = aux[i].Split('|');
                        switch (seccion[0])
                        {
                            case "MSH":
                                orm_o01.MSH = new string[seccion.Length];
                                orm_o01.MSH = seccion;
                                break;
                            case "PID":
                                orm_o01.PID = new string[seccion.Length];
                                orm_o01.PID = seccion;
                                break;
                            case "ORC":
                                orm_o01.ORC = new string[seccion.Length];
                                orm_o01.ORC = seccion;
                                break;
                            case "OBR":
                                orm_o01.OBR = new string[seccion.Length];
                                orm_o01.OBR = seccion;
                                break;
                            case "NTE":
                                orm_o01.NTE = new string[seccion.Length];
                                orm_o01.NTE = seccion;
                                break;
                        }
                    }

                    if(orm_o01.MSH.Length <= 0 && orm_o01.PID.Length <= 0 && orm_o01.ORC.Length <= 0 && orm_o01.OBR.Length <= 0 && orm_o01.NTE.Length <= 0)
                    {
                        correcto = false;
                    }

                    break;
                case "2.3":
                    for (int i = 0; i < mensaje.Length; i++)
                    {
                        string[] seccion = aux[i].Split('|');
                        switch (seccion[0])
                        {
                            case "MSH":
                                orm_o01.MSH = seccion;
                                break;
                            case "PID":
                                orm_o01.PID = seccion;
                                break;
                            case "PV1":
                                orm_o01.PV1 = seccion;
                                break;
                            case "IN1":
                                orm_o01.IN1 = seccion;
                                break;
                            case "ORC":
                                orm_o01.ORC = seccion;
                                break;
                            case "OBX":
                                orm_o01.OBX = seccion;
                                break;
                        }
                    }

                    if (orm_o01.MSH.Length <= 0 && orm_o01.PID.Length <= 0 && orm_o01.PV1.Length <= 0 && orm_o01.IN1.Length <= 0 && orm_o01.ORC.Length <= 0 && orm_o01.OBX.Length <= 0)
                    {
                        correcto = false;
                    }

                    break;
            }
            if (correcto)
            {
                return correcto;
            }
            else
            {
                return correcto;
            }
            
        }

        public bool Parse_ADT_A08(string mensaje, string version)
        {
            ADT_A08 adt_a08 = new ADT_A08();
            string[] aux = mensaje.Split('\n');
            bool correcto = true;
            adt_a08.version = version;

            switch (version)
            {
                case "2.2":
                    for (int i = 0; i < aux.Length; i++)
                    {
                        string[] seccion = aux[i].Split('|');
                        switch (seccion[0])
                        {
                            case "MSH":
                                adt_a08.MSH = seccion;
                                break;
                            case "EVN":
                                adt_a08.EVN = seccion;
                                break;
                            case "PID":
                                adt_a08.PID = seccion;
                                break;
                            case "PV1":
                                adt_a08.PV1 = seccion;
                                break;
                            case "IN1":
                                adt_a08.IN1 = seccion;
                                break;
                        }
                    }

                    if(adt_a08.MSH.Length <= 0 && adt_a08.EVN.Length <= 0 && adt_a08.PID.Length <= 0 && adt_a08.PV1.Length <= 0 && adt_a08.IN1.Length <= 0)
                    {
                        correcto = false;
                    }

                    break;
                case "2.3":
                    for (int i = 0; i < aux.Length; i++)
                    {
                        string[] seccion = aux[i].Split('|');
                        switch (seccion[0])
                        {
                            case "MSH":
                                adt_a08.MSH = seccion;
                                break;
                            case "EVN":
                                adt_a08.EVN = seccion;
                                break;
                            case "PID":
                                adt_a08.PID = seccion;
                                break;
                            case "PV1":
                                adt_a08.PV1 = seccion;
                                break;
                            case "PR1":
                                adt_a08.PR1 = seccion;
                                break;
                            case "IN1":
                                adt_a08.IN1 = seccion;
                                break;
                        }
                    }

                    if (adt_a08.MSH.Length <= 0 && adt_a08.EVN.Length <= 0 && adt_a08.PID.Length <= 0 && adt_a08.PV1.Length <= 0 && adt_a08.PR1.Length <= 0 && adt_a08.IN1.Length <= 0)
                    {
                        correcto = false;
                    }

                    break;
            }

            if (correcto)
            {
                return correcto;
            }
            else
            {
                return correcto;
            }

        }

        public bool Parse_ADT_A04(string mensaje, string version)
        {
            ADT_A04 adt_a04 = new ADT_A04();
            string[] aux = mensaje.Split('\n');
            bool correcto = true;
            adt_a04.version = version;

            switch (version)
            {
                case "2.2":
                    for (int i = 0; i < aux.Length; i++)
                    {
                        string[] seccion = aux[i].Split('|');
                        switch (seccion[0])
                        {
                            case "MSH":
                                adt_a04.MSH = seccion;
                                break;
                            case "EVN":
                                adt_a04.EVN = seccion;
                                break;
                            case "PID":
                                adt_a04.PID = seccion;
                                break;
                            case "PV1":
                                adt_a04.PV1 = seccion;
                                break;
                            case "IN1":
                                adt_a04.IN1 = seccion;
                                break;
                        }
                    }

                    if(adt_a04.MSH.Length <= 0 && adt_a04.EVN.Length <= 0 && adt_a04.PID.Length <= 0 && adt_a04.PV1.Length <= 0 && adt_a04.IN1.Length <= 0)
                    {
                        correcto = false;
                    }

                    break;
                case "2.3":
                    for (int i = 0; i < aux.Length; i++)
                    {
                        string[] seccion = aux[i].Split('|');
                        switch (seccion[0])
                        {
                            case "MSH":
                                adt_a04.MSH = seccion;
                                break;
                            case "EVN":
                                adt_a04.EVN = seccion;
                                break;
                            case "PID":
                                adt_a04.PID = seccion;
                                break;
                            case "PV1":
                                adt_a04.PV1 = seccion;
                                break;
                            case "PR1":
                                adt_a04.PR1 = seccion;
                                break;
                            case "IN1":
                                adt_a04.IN1 = seccion;
                                break;
                        }
                    }

                    if (adt_a04.MSH.Length <= 0 && adt_a04.EVN.Length <= 0 && adt_a04.PID.Length <= 0 && adt_a04.PV1.Length <= 0 && adt_a04.PR1.Length <= 0 && adt_a04.IN1.Length <= 0)
                    {
                        correcto = false;
                    }

                    break;
            }

            if (correcto)
            {
                return correcto;
            }
            else
            {
                return correcto;
            }

        }
    }
}
