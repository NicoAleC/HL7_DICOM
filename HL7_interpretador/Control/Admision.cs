using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7_interpretador.Control
{
    class Admision
    {
        public string nombrePaciente { get; set; }
        public string fechaNacimiento { get; set; }
        public string pid { get; set; }
        public string accNumber { get; set; }
        public string studyDate { get; set; }
        public string studyDesc { get; set; }
        public string medicoRef { get; set; }
        public string genero { get; set; }
        public string modalidad { get; set; }

        public Admision(string nombrePaciente, string fechaNacimiento, string pid, string accNumber, string studyDate, string studyDesc, string medicoRef, string genero, string modalidad)
        {
            this.nombrePaciente = nombrePaciente;
            this.fechaNacimiento = fechaNacimiento;
            this.pid = pid;
            this.accNumber = accNumber;
            this.studyDate = studyDate;
            this.studyDesc = studyDesc;
            this.medicoRef = medicoRef;
            this.genero = genero;
            this.modalidad = modalidad;
        }


        //Escribir en un archivo de texto

        public string EscribirArchivoTxt()
        {
            string docPath = "C:\\Users\\chinc\\source\\repos\\HL7-interpretador\\DMWLTXT\\";
            string fileName = "worklistF" + accNumber + ".dump";
            Random random = new Random();


            string[] nombreP = nombrePaciente.Split(' ');


            String nombre1 = nombrePaciente;

            char[] nombreXXX = nombre1.ToCharArray();

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {

                //Información acerca del formato del archivo

                outputFile.WriteLine("# Dicom-File-Format");
                outputFile.WriteLine("");
                outputFile.WriteLine("# Dicom-Meta-Information-Header");
                outputFile.WriteLine("# Used TransferSyntax: Little Endian Explicit");
                outputFile.WriteLine("(0002,0000) UL 202                                      #   4, 1 FileMetaInformationGroupLength");
                outputFile.WriteLine("(0002,0001) OB 00\\01                                    #   2, 1 FileMetaInformationVersion");
                outputFile.WriteLine("(0002,0002) UI [1.2.276.0.7230010.3.1.0.1]              #  26, 1 MediaStorageSOPClassUID");
                outputFile.WriteLine("(0002,0003) UI [1.2.276.0.7230010.3.1.4.2831176407.11158.1448031138.881460] #  58, 1 MediaStorageSOPInstanceUID");
                outputFile.WriteLine("(0002,0010) UI =LittleEndianExplicit                    #  20, 1 TransferSyntaxUID");
                outputFile.WriteLine("(0002,0012) UI [1.2.276.0.7230010.3.0.3.6.0]            #  28, 1 ImplementationClassUID");
                outputFile.WriteLine("(0002,0013) SH [OFFIS_DCMTK_360]                        #  16, 1 ImplementationVersionName");
                outputFile.WriteLine("");

                //Información del archivo en sí

                outputFile.WriteLine("# Dicom-Data-Set");
                outputFile.WriteLine("# Used TransferSyntax: Little Endian Explicit");
                outputFile.WriteLine("(0008,0005) CS [ISO_IR 100]                             #  10, 1 SpecificCharacterSet");
                outputFile.WriteLine("(0008,0050) SH [" + accNumber + "]                                  #   6, 1 AccessionNumber");


                outputFile.WriteLine("(0008,1030) LO [" + studyDesc + "]                                  #   100, 1 StudyDescription");

                outputFile.WriteLine("(0008,0020) DA [" + studyDate + "]                                  #   8, 1 StudyDate");

                outputFile.WriteLine("(0038,0010) LO [" + modalidad + "]                                  #   8, 1 AdmissionID");


                outputFile.WriteLine("(0010,0010) PN [" + nombreP[0] + "^" + nombreP[1] + "]                        #  16, 1 PatientName");
                outputFile.WriteLine("(0010,0020) LO [" + pid + "]                                #   8, 1 PatientID");
                outputFile.WriteLine("(0010,0030) DA [" + fechaNacimiento + "]                               #   8, 1 PatientBirthDate");
                outputFile.WriteLine("(0010,0040) CS [" + genero + "]                                      #   2, 1 PatientSex");
                outputFile.WriteLine("(0010,2000) LO []                             #  10, 1 MedicalAlerts");
                outputFile.WriteLine("(0010,2110) LO []                                 #   6, 1 Allergies");
                outputFile.WriteLine("(0020,000d) UI [1.2.276.0.7230010.3.2." + Convert.ToString(random.Next(100, 999)) + "]              #  26, 1 StudyInstanceUID");
                outputFile.WriteLine("(0032,1032) PN [" + medicoRef + "]                                  #   6, 1 RequestingPhysician\n");
                outputFile.WriteLine("(0032,1060) LO []                                  #   6, 1 RequestedProcedureDescription");
                outputFile.WriteLine("(0040,0100) SQ (Sequence with explicit length #=1)      # 176, 1 ScheduledProcedureStepSequence");
                outputFile.WriteLine("  (fffe,e000) na (Item with explicit length #=12)         # 168, 1 Item");
                outputFile.WriteLine("    (0008,0060) CS [" + modalidad + "]                                     #   2, 1 Modality");
                outputFile.WriteLine("    (0032,1070) LO []                           #  12, 1 RequestedContrastAgent");
                outputFile.WriteLine("    (0040,0001) AE [" + modalidad + "TITLE" + "]                              #  10, 2 ScheduledStationAETitle");
                outputFile.WriteLine("    (0040,0002) DA [" + studyDate + "]                               #   8, 1 ScheduledProcedureStepStartDate");
                outputFile.WriteLine("    (0040,0003) TM []                                 #   6, 1 ScheduledProcedureStepStartTime");
                outputFile.WriteLine("    (0040,0006) PN []                                #   8, 1 ScheduledPerformingPhysicianName");
                outputFile.WriteLine("    (0040,0007) LO []                                 #   6, 1 ScheduledProcedureStepDescription");
                outputFile.WriteLine("    (0040,0009) SH []                                #   8, 1 ScheduledProcedureStepID");
                outputFile.WriteLine("    (0040,0010) SH []                                 #   6, 1 ScheduledStationName");
                outputFile.WriteLine("    (0040,0011) SH []                                 #   6, 1 ScheduledProcedureStepLocation");
                outputFile.WriteLine("    (0040,0012) LO (no value available)                     #   0, 0 PreMedication");
                outputFile.WriteLine("    (0040,0400) LT (no value available)                     #   0, 0 CommentsOnTheScheduledProcedureStep");
                outputFile.WriteLine("  (fffe,e00d) na (ItemDelimitationItem for re-encoding)   #   0, 0 ItemDelimitationItem");
                outputFile.WriteLine("(fffe,e0dd) na (SequenceDelimitationItem for re-encod.) #   0, 0 SequenceDelimitationItem");
                outputFile.WriteLine("(0040,1001) SH [" + nombre1[0] + nombre1[1] + nombre1[2] + nombre1[3] + "]                              #  10, 1 RequestedProcedureID");
                outputFile.WriteLine("(0040,1003) SH []                                    #   4, 1 RequestedProcedurePriority");

            }

            return docPath + fileName;
        }


        public void cambiarFormato(string archivo)
        {

            string archivoTxt = archivo;


            // Use ProcessStartInfo class.
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = "C:\\Users\\chinc\\source\\repos\\HL7-interpretador\\DMWLTXT\\";
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "D:\\DiscoD\\Recupera\\Documents\\upb\\Bioinformatica\\dcmtk-3.6.4-win64-dynamic\\bin\\dump2dcm.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = archivoTxt + " " + "workListF" + accNumber + ".wl";

            Process proc = new Process();
            proc.StartInfo = startInfo;
            proc.Start();





        }

        public void guardarEnWL()
        {
            string archivoAGuardar = EscribirArchivoTxt();
            cambiarFormato(archivoAGuardar);
        }
    }
}
