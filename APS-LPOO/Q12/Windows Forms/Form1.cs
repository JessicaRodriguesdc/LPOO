using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {



            MessageBox.Show("Moto ligada !!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();


            MessageBox.Show("Moto desligada !!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Subiu de marcha");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reduziu a marcha");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Moto mt = new Moto();

            mt.setMarca(textBox1.Text);
            try
            {
                mt.setModelo(textBox3.Text);

                mt.setcor(textBox2.Text);
                string marca = mt.getMarca();
                string modelo = mt.getModelo();
                string cor = mt.getCor();
                string srtsaida = "Marca : " + marca.ToUpper() + "\n\n" + "Modelo :" + modelo.ToUpper() + "\n\n" + "Cor :" + cor.ToUpper();
                MessageBox.Show(srtsaida, "Dados :");
            }

            catch(Exception erro)
            {
                MessageBox.Show("Erro");
            }

             
            
        }
    }
}
