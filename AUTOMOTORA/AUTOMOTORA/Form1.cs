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
    public partial class P1 : Form
    {
        public P1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            string id, contraseña;
            id = tx_1.Text;
            contraseña = tx_2.Text;

            if (id=="adm" && contraseña == "adm") 
            {
                Form2 nuevo = new Form2();
                nuevo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
            Form formulario1 = new Form();
            formulario1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void P1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized; // FORMULARIO PANTALLA COMPLETA
            this.StartPosition = FormStartPosition.CenterScreen;

            //int lx, ly;
            //int sw, sh;

            /*public void P1_Load()
            {
                lx = this.Location.X;
                ly = this.Location.Y;
                sw = this.Size.Width;
                sh = this.Size.Height;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }*/
        }
    }
}
