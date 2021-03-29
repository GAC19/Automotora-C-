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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=GAC ; database=AUTOMOTORA ; integrated security= true");
            conexion.Open();
            string matricula = tx_matricula.Text;
            string marca = tx_marca.Text;
            string modelo = tx_modelo.Text;
            string marcachina = tx_Mchina.Text;
            string fechacompra = tx_date.Text;
            string preciodiario = tx_preciod.Text;
            string distribuidor = tx_dist.Text;
            string cadena = "insert into Vehiculo (Matricula,Marca,Modelo,MarcaChina,FechaCompra,PrecioDiario,Distribuidor) values ('" + matricula + "','" + marca + "','" + modelo + "','" + marcachina+ "','" + fechacompra+ "','" + preciodiario + "','" + distribuidor+"')";
            SqlCommand comando = new SqlCommand(cadena,conexion);
            MessageBox.Show("Los Datos fueron Guardado");
            comando.ExecuteNonQuery();
            this.Close();



        }

        private void tx_matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=GAC ; database= AUTOMOTORA ; integrated security= true");
            conexion.Open();
            string borrar = tx_matricula.Text;
            string cadena = "delete from Vehiculo where Matricula='" + borrar+"'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                MessageBox.Show("EL VEHICULO CON ESA MATRICULA NO EXISTE");
                this.Close();
            }
            else
            {
                MessageBox.Show("EL VEHICULO CON ESA MATRICULA FUE ELIMINADO EN LA BASE DE DATO");
                this.Close();

            }
            this.Close();
        }
    }
}
