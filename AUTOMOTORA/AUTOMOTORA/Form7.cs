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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=GAC ; database= AUTOMOTORA ; integrated security= true");
            conexion.Open();
            string Matricula = tx_borrar.Text;
            string cadena = "delete from Alquiler where Matricula='" + Matricula + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                MessageBox.Show("EL VEHICULO NO SE ENCUENTRA ALQUILADO");
                this.Close();
            }
            else
            {
                MessageBox.Show("EL VEHICULO FUE CANCELADO EXITOSAMENTE");
                this.Close();
            }
            this.Close();

        }
    }
}
