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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=GAC ; database= AUTOMOTORA ; integrated security= true");
            conexion.Open();
            string borrar = tx_borrar.Text;
            string cadena = "delete from Cliente where rut=" + borrar;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            
            if (registro.Read())
            {
                MessageBox.Show("No existe ese Cliente");
                this.Close();
            }
            else
            {
                MessageBox.Show("El Cliente se  eliminado Correctamente");
                this.Close();

            }
            this.Close();


        }
    }
}
