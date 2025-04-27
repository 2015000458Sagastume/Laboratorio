using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Laboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Botón agregar
        private void button1_Click(object sender, EventArgs e)
        {
            //toma lo que el usuario escribió en el cuadro de texto y lo guarda en una variable
            //para poder trabajar con ese dato después
            string nombre = textBox1.Text;
            string grado = textBox2.Text;
            string seccion = textBox3.Text;
            string telefono = textBox4.Text;
            string matricula = textBox5.Text;
            string ciclo = textBox6.Text;
            string padre = textBox7.Text;
            string madre = textBox8.Text;
            string direccion = textBox9.Text;
            string correo = textBox10.Text;
            string telefono_casa = textBox11.Text;

            //Arreglo tipo string llamado "fila" con valores que se llenan con variables que contienen texto
            string[] fila = { nombre, grado, seccion, telefono, matricula,
            ciclo, padre, madre, direccion, correo, telefono_casa};

            //Añade una nueva fila en el DataGridView, y cada dato del arreglo "fila" se pone en una celda
            //distinta de esa nueva fila.
            dataGridView1.Rows.Add(fila);

            //Luego de agregada la nueva fila al DataGridView, se limpian las celas para ingresar un nuevo
            //registro
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //  Este evento se ejecuta cuando el usuario hace clic en cualquier celda del DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se asegura que el clic fue en una fila válida (no en el encabezado de columna, por ejemplo. -1=encabezado).
            if (e.RowIndex >= 0) 
            {
                //Crea una variable fila que representa toda la fila donde se hizo clic.
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                //Toma el valor de la celda de esa fila (Cells[x]), convierte el valor a texto(ToString())
                //y lo muestra en el TextBox respectivo.
                textBox1.Text = fila.Cells[0].Value.ToString();
                textBox2.Text = fila.Cells[1].Value.ToString();
                textBox3.Text = fila.Cells[2].Value.ToString();
                textBox4.Text = fila.Cells[3].Value.ToString();
                textBox5.Text = fila.Cells[4].Value.ToString();
                textBox6.Text = fila.Cells[5].Value.ToString();
                textBox7.Text = fila.Cells[6].Value.ToString();
                textBox8.Text = fila.Cells[7].Value.ToString();
                textBox9.Text = fila.Cells[8].Value.ToString();
                textBox10.Text = fila.Cells[9].Value.ToString();
                textBox11.Text = fila.Cells[10].Value.ToString();
            }
        }
        //Botón Editar
        private void button2_Click(object sender, EventArgs e)
        {
            //Verifica que haya una fila seleccionada en el DataGridView.
            if (dataGridView1.CurrentRow != null) 
            {
                //Cambia el contenido de la  celda (columna x) de la fila seleccionada al texto que está en textBox1.
                dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
                dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
                dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
                dataGridView1.CurrentRow.Cells[6].Value = textBox7.Text;
                dataGridView1.CurrentRow.Cells[7].Value = textBox8.Text;
                dataGridView1.CurrentRow.Cells[8].Value = textBox9.Text;
                dataGridView1.CurrentRow.Cells[9].Value = textBox10.Text;
                dataGridView1.CurrentRow.Cells[10].Value = textBox11.Text;
                //Después de actualizar la fila, se limpian las celas para ingresar un nuevo registro
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
            }
        }
        //evento que se activa cuando el usuario hace clic en un elemento del menú llamado "Créditos"
        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crear un nuevo formulario en memoria que todavía no está visible
            Form3 form3 = new Form3();
            //Muestra el formulario en modo modal, es decir, bloquea el formulario
            //anterior (el que lo abrió) hasta que se cierre.
            form3.ShowDialog();
        }

        //Botón eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            //Verifica que haya una fila seleccionada en el DataGridView.
            if (dataGridView1.CurrentRow != null)
            {
                //elimina la fila que el usuario tiene seleccionada en el DataGridView.
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                //Después de eliminar la fila, se limpian las celas para ingresar un nuevo registro.
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
            }
            else
            {
                // se ejecuta si no hay ninguna fila seleccionada y muestra un mensaje de advertencia
                // al usuario usando un MessageBox.
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
    }
}
