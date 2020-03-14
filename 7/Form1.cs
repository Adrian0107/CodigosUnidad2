using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beisbol
{
    public partial class Form1 : Form
    {
        Pitcher pitcher = new Pitcher();
        Posicion posicion = new Posicion();
        Designado designado = new Designado();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pitcher.NumUniforme = int.Parse(textBox1.Text);
                pitcher.Nombre = textBox2.Text;
                pitcher.Ponches= int.Parse(textBox3.Text);
                pitcher.Errores = int.Parse(textBox5.Text);
          
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
            }
            if (radioButton2.Checked == true)
            {
                posicion.NumUniforme = int.Parse(textBox1.Text);
                posicion.Nombre = textBox2.Text;
                posicion.Hits = int.Parse(textBox4.Text);
                posicion.Errores = int.Parse(textBox5.Text);
               
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            if (radioButton3.Checked == true)
            {
                designado.NumUniforme = int.Parse(textBox1.Text);
                designado.Nombre = textBox2.Text;
                designado.Hits = int.Parse(textBox4.Text);
               
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
               
            }
            
        }
    

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            textBox3.Enabled = true;
            textBox5.Enabled = true;

              
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox3.Enabled = false;
            textBox5.Enabled = true;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            textBox3.Enabled = false;
            textBox5.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show(pitcher.ToString());
            }
            if (radioButton2.Checked == true)
            {
                MessageBox.Show(posicion.ToString());
            }
            if (radioButton3.Checked == true)
            {
                MessageBox.Show(designado.ToString());
            }
         
        }
    }
}
