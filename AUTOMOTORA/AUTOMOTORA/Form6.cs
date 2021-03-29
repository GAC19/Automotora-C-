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
    public partial class Form6 : Form
    {
        private SqlConnection conexion = new SqlConnection("server=GAC ; database=AUTOMOTORA ; integrated security=true");
        public Form6()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void bt_rut_Click(object sender, EventArgs e)
        {

            /*conexion.Open();
            string cadena = "select* from Cliente";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                tx_listarut.AppendText("Nombre: ");
                tx_listarut.AppendText(registro["nombre"].ToString());
                tx_listarut.AppendText(" ");
                tx_listarut.AppendText(registro["apellido"].ToString());
                tx_listarut.AppendText("  F/Nac.: ");
                tx_listarut.AppendText(registro["dia"].ToString());
                tx_listarut.AppendText("/");
                tx_listarut.AppendText(registro["mes"].ToString());
                tx_listarut.AppendText("/");
                tx_listarut.AppendText(registro["año"].ToString());
                tx_listarut.AppendText("  Direccion: ");
                tx_listarut.AppendText(registro["direccion"].ToString());
                tx_listarut.AppendText(" Nro. ");
                tx_listarut.AppendText(registro["nro"].ToString());
                tx_listarut.AppendText("  Telefono: ");
                tx_listarut.AppendText(registro["telefono"].ToString());
            }*/
            
        }

        private void bt_vehiculo_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=GAC ; database=AUTOMOTORA ; integrated security=true");
            conexion.Open();
            string cadena = "select * from Vehiculo";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                tx_listavehiculo.AppendText(registro["Matricula"].ToString());
                tx_listavehiculo.AppendText(" - ");
                tx_listavehiculo.AppendText(registro["Marca"].ToString());
                tx_listavehiculo.AppendText(" - ");
                tx_listavehiculo.AppendText(registro["Modelo"].ToString());
                tx_listavehiculo.AppendText(" - ");
                tx_listavehiculo.AppendText(registro["MarcaChina"].ToString());
                tx_listavehiculo.AppendText(" - ");
                tx_listavehiculo.AppendText(registro["FechaCompra"].ToString());
                tx_listavehiculo.AppendText(" - ");
                tx_listavehiculo.AppendText(registro["PrecioDiario"].ToString());
                tx_listavehiculo.AppendText(" - ");
                tx_listavehiculo.AppendText(registro["Distribuidor"].ToString());
                tx_listavehiculo.AppendText("\n");
                tx_listavehiculo.AppendText(Environment.NewLine);
            }
            conexion.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "select* from Cliente";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                tx_listarut.AppendText("Nombre: ");
                tx_listarut.AppendText(registro["nombre"].ToString());
                tx_listarut.AppendText(" ");
                tx_listarut.AppendText(registro["apellido"].ToString());
                tx_listarut.AppendText("  F/Nac.: ");
                tx_listarut.AppendText(registro["dia"].ToString());
                tx_listarut.AppendText("/");
                tx_listarut.AppendText(registro["mes"].ToString());
                tx_listarut.AppendText("/");
                tx_listarut.AppendText(registro["año"].ToString());
                tx_listarut.AppendText("  Direccion: ");
                tx_listarut.AppendText(registro["direccion"].ToString());
                tx_listarut.AppendText(" Nro. ");
                tx_listarut.AppendText(registro["nro"].ToString());
                tx_listarut.AppendText("  Telefono: ");
                tx_listarut.AppendText(registro["telefono"].ToString());
                tx_listarut.AppendText("\n");
                tx_listarut.AppendText(Environment.NewLine);
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena = "select* from Alquiler";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                tx_listaalquiler.AppendText(registro["Numero"].ToString());
                tx_listaalquiler.AppendText(") Matricula: ");
                tx_listaalquiler.AppendText(registro["Matricula"].ToString());
                tx_listaalquiler.AppendText(" F/S: ");
                tx_listaalquiler.AppendText(registro["FechaSalida"].ToString());
                tx_listaalquiler.AppendText(" F/R: ");
                tx_listaalquiler.AppendText(registro["FechaEntrega"].ToString());
                tx_listaalquiler.AppendText(" Rut: ");
                tx_listaalquiler.AppendText(registro["rut"].ToString());
                tx_listaalquiler.AppendText(" Telefono: ");
                tx_listaalquiler.AppendText(registro["telefono"].ToString());
                tx_listaalquiler.AppendText(" Obs: ");
                tx_listaalquiler.AppendText(registro["Observaciones"].ToString());
                tx_listaalquiler.AppendText("\n");
                //tx_listaalquiler.AppendText("\n");
                tx_listaalquiler.AppendText(Environment.NewLine);
            }
            conexion.Close();
        }
    }
}
