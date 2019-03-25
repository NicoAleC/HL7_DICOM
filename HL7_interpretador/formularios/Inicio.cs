using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HL7_interpretador.Control;

namespace HL7_interpretador.formularios
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servidor s = new Servidor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lector lector = new Lector();
            lector.LeerMensaje(@"..\\..\\..\\HL7-ejemplos\\" + textBox1.Text + ".txt");            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            solicitudes_pendientes sp = new solicitudes_pendientes();
            sp.Show();
        }
    }
}
