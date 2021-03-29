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
    public partial class Form5 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=GAC ; database=AUTOMOTORA ; integrated security=true");
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string marca2 = tx_marca.Text;
            string cadena = "select * from Vehiculo where Marca='"+marca2+"'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                tx_listavehiculo.AppendText(registro["Matricula"].ToString());
                tx_listavehiculo.AppendText("Modelo: ");
                /*tx_listavehiculo.AppendText(registro["Marca"].ToString());
                tx_listavehiculo.AppendText(" - ");*/
                tx_listavehiculo.AppendText(registro["Modelo"].ToString());
                tx_listavehiculo.AppendText("Marca China: ");
                tx_listavehiculo.AppendText(registro["MarcaChina"].ToString());
                tx_listavehiculo.AppendText("Precio Diario: ");
                /*tx_listavehiculo.AppendText(registro["FechaCompra"].ToString());
                tx_listavehiculo.AppendText(" - ");*/
                tx_listavehiculo.AppendText(registro["PrecioDiario"].ToString());
                tx_listavehiculo.AppendText("  Dist.: ");
                tx_listavehiculo.AppendText(registro["Distribuidor"].ToString());
                tx_listavehiculo.AppendText("\n");
                tx_listavehiculo.AppendText(Environment.NewLine);
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlConnection conexion = new SqlConnection("server=GAC ; database=AUTOMOTORA ; integrated security=true");
            conexion.Open();
            string consulta = tx_consulta.Text;
            string cadena = "select Matricula from Alquiler where Matricula='" + consulta+"'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                string mensaje = "EL VEHICULO SE ENCUENTRA ALQUILADO";
                string titulo = "ADVERTENCIA";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, titulo, boton, MessageBoxIcon.Exclamation);
                //MessageBox.Show("EL VEHICULO SE ENCUENTRA ALQUILADO");
            }
            else
            {
                MessageBox.Show("EL VEHICULO NO ESTA ALQUILADO");
            }
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cons = tx_rut.Text;
            string cadena = "select * from Cliente where rut=" + cons;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                //MessageBox.Show("");
                tx_fono.AppendText(registro["telefono"].ToString());
                
            }
            else
            {
                //tx_fono.Text = registro["telefono"].ToString();
            }
            conexion.Close();
            /*

            string cadena = "select * from Alquiler where rut=" + cons;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                //conexion.Open();
                
                //conexion.Close();
            }    
            else
            {
                MessageBox.Show("el cliente no existe");
            }
            conexion.Close();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Matricula = tx_consulta.Text;
            string FechaSalida = dt_inicio.Text;
            string FechaEntrega = dt_final.Text;
            string rut = tx_rut.Text;
            string telefono = tx_fono.Text;
            string Observaciones = tx_obs.Text;

            string cadena ="insert into Alquiler (Matricula,FechaSalida,FechaEntrega,rut,telefono,Observaciones) values ('"+Matricula+ "','" + FechaSalida + "','" + FechaEntrega + "','" + rut + "','" + telefono + "','" + Observaciones + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            MessageBox.Show("LOS DATOS FUERON INGRESADO CORRECTAMENTE");
            comando.ExecuteNonQuery();
            this.Close();

        }

        private void tx_rut_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_eliminar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 nuevo = new Form7();
            nuevo.Show();
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            bt_limpiar.Enabled = true;
            tx_listavehiculo.Clear();
        }

        private void bt_consulta_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cons = tx_rut.Text;         
            string cadena = "select * from Alquiler where rut=" + cons;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                string mensaje = "EL CLIENTE REGISTRA CON UN ALQUILER";
                string titulo = "ADVERTENCIA";
                MessageBoxButtons boton = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, titulo, boton, MessageBoxIcon.Exclamation);
                
                
                //MessageBox.Show("EL CLIENTE REGISTRA CON UN ALQUILER");
            }    
            else
            {
                MessageBox.Show("EL CLIENTE NO REGISTRA CON UN ALGUILER");
            }
            conexion.Close();
        }
    }
}
