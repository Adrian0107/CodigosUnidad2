using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Departamento
{
    public partial class Form1 : Form
    {
        Departamento departamento;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            departamento = new Departamento();
            departamento.Numero = int.Parse(textBox1.Text);
            departamento.Nombre = textBox2.Text;
            departamento.Jefe = textBox3.Text;
            foreach (Control t in groupBox1.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = false;
                }
            }
            button1.Enabled = false;
            MessageBox.Show("Datos del departamento capturados" );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = textBox4.Text;
            empleado.Telefono = int.Parse(textBox5.Text);
            empleado.CorreoElectronico = textBox6.Text;
            departamento.insertar(empleado);
            mostrarEmpleado();
        }
        void mostrarEmpleado()
        {
            dataGridView1.Rows.Clear();
            foreach (Empleado empleado in departamento)
            {
                dataGridView1.Rows.Add(empleado.Nombre, empleado.Telefono, empleado.CorreoElectronico);
            }
            foreach (Control t in groupBox3.Controls)
            {
                if (t is TextBox)
                {
                    t.ResetText();
                }
            }
            textBox4.Focus();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
