using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear un nuevo formulario en memoria que todavía no está visible
            Form1 form1 = new Form1();
            //Muestra el formulario en modo modal, es decir, bloquea el formulario
            //anterior (el que lo abrió) hasta que se cierre.
            form1.ShowDialog();
        }
    }
}
