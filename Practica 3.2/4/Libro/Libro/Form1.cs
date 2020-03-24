using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libro
{
    public partial class Form1 : Form
    {
        Libro libro;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            libro = new Libro();
            libro.Titulo = textBox1.Text;
            libro.Autor = textBox2.Text;
            libro.Editorial = textBox3.Text;
            libro.ISBN = textBox4.Text;
            foreach (Control t in groupBox1.Controls)
            {
                if (t is TextBox)
                {
                    t.Enabled = false;
                }
            }
            button1.Enabled = false;
            MessageBox.Show("Datos del libro capturados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Capitulo capitulo = new Capitulo();
            capitulo.Titulo = textBox5.Text;
            capitulo.CantidadPaginas = int.Parse(textBox6.Text);
            libro.InsertarCapitulo(capitulo);
            mostrarCapitulo();
        }
        void mostrarCapitulo()
        {
            dataGridView1.Rows.Clear();
            foreach (Capitulo capitulo in libro)
            {
                dataGridView1.Rows.Add(capitulo.Titulo, capitulo.CantidadPaginas);
                foreach (Control t in groupBox2.Controls)
                {
                    if (t is TextBox)
                    {
                        t.ResetText();
                    }
                }
                textBox5.Focus();

            }

        }
    }
}

