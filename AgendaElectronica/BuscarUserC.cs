using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaElectronica
{
    public partial class BuscarUserC : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection("server = DESKTOP-B7GBJ6U ;database= AgendaElectronica ; integrated security = true");
        public BuscarUserC()
        {
            InitializeComponent();
            mostrarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void mostrarDatos()
        {
            
            sqlConnection.Open();
            string qwery = "select * from Contactos";
            SqlDataAdapter adaptador = new SqlDataAdapter(qwery, sqlConnection);
            DataSet datos = new DataSet();
            adaptador.Fill(datos);
            dataGridView1.DataSource = datos.Tables[0];
            sqlConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string nombre = textBuscarB.Text;
            string qwery = "select * from Contactos where Nombre = '"+nombre+"'";
            SqlDataAdapter adaptador = new SqlDataAdapter(qwery, sqlConnection);
            DataSet datos = new DataSet();
            adaptador.Fill(datos);
            if (datos.Tables[0].Rows.Count==0)
            {
                MessageBox.Show("Este registro no existe");
            }
            else
            {
                dataGridView1.DataSource = datos.Tables[0];
            }
            
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
