using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AUTOMOTORA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 nuevo = new Form3();
            nuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 nuevo = new Form4();
            nuevo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 nuevo = new Form5();
            nuevo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 nuevo = new Form6();
            nuevo.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //P1 cerrar = new P1();
            //cerrar.Show();
            MessageBox.Show("PROGRAMA Y SECCION FINALIZADA");
            Application.Exit();
        }
    }
}
