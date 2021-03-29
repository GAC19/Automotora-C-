using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AUTOMOTORA
{
    public partial class Form3 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=GAC ; database= AUTOMOTORA ; integrated security= true");
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // INGRESA DATOS
        {
            //SqlConnection conexion = new SqlConnection("server=GAC ; database= AUTOMOTORA ; integrated security= true");
            //conexion.Open();
            string rut = tx_rut.Text;
            string dia = tx_dia.Text;
            string mes = tx_mes.Text;
            string año = tx_año.Text;
            string nombre = tx_nombre.Text;
            string apellido = tx_apellido.Text;
            string direccion = tx_direccion.Text;
            string nro = tx_nro.Text;
            string telefono = tx_telefono.Text;
            if ((año == "2003") || (año =="2004") || (año=="2005") || (año =="2006"))
            {
                MessageBox.Show("ES MENOR DE EDAD");
            }
            else
            {
                conexion.Open();
                string cadena = "insert into Cliente (rut,dia,mes,año,nombre,apellido,direccion,nro,telefono) values ('" + rut + "','" + dia + "','" + mes + "','" + año + "','" + nombre + "','" + apellido + "','" + direccion + "','" + nro + "','" + telefono + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("fueron ingresado con exito");
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 nuevo = new Form8();
            nuevo.Show();
            /*if (bt_eliminar.Visible == true)
            {
                tx_apellido = " ";
            }*/
        }

        private void button3_Click(object sender, EventArgs e) //MUESTRA DATOS
        {
            conexion.Open();
            string cons = tx_rut.Text;
            string cadena = "select nombre,apellido,dia,mes,año,direccion,nro,telefono from Cliente where rut=" + cons;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                tx_nombre.Text = registro["nombre"].ToString();
                tx_apellido.Text = registro["apellido"].ToString();
                tx_dia.Text = registro["dia"].ToString();
                tx_mes.Text = registro["mes"].ToString();
                tx_año.Text = registro["año"].ToString();
                tx_direccion.Text = registro["direccion"].ToString();
                tx_nro.Text = registro["nro"].ToString();
                tx_telefono.Text = registro["telefono"].ToString();
                button2.Enabled = true;

            }
            else
            {
                MessageBox.Show("el cliente no existe");
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e) //MODIFICA DATOS
        {
            
            conexion.Open();
            string rut = tx_rut.Text;
            string nombre = tx_nombre.Text;
            string apellido = tx_apellido.Text;
            string dia = tx_dia.Text;
            string mes = tx_mes.Text;
            string año = tx_año.Text;
            string direccion = tx_direccion.Text;
            string nro = tx_nro.Text;
            string telefono = tx_telefono.Text;
            string cadena = "update Cliente set dia=" + dia + ",mes=" + mes + ",año=" + año + ",nombre='" + nombre + "'," +
                "apellido='" + apellido + "',direccion='" + direccion + "',nro=" + nro + ",telefono=" + telefono + " where rut= "+ rut; 
            SqlCommand comando1 = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando1.ExecuteReader();

            MessageBox.Show("LOS DATOS DEL CLIENTE FUERON MODIFICADO CORRECTAMENTE");

            //comando1.ExecuteNonQuery();
            button2.Enabled = false;
            this.Close();
        }
    }
}
