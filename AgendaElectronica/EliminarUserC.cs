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
    public partial class EliminarUserC : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection("server = DESKTOP-B7GBJ6U ;database= AgendaElectronica ; integrated security = true");
        string rowSelected;
        public EliminarUserC()
        {
            
            InitializeComponent();
            mostrarDatos();
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
            string nombre = textBuscarE.Text;
            string qwery = "select * from Contactos where Nombre = '" + nombre + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(qwery, sqlConnection);
            DataSet datos = new DataSet();
            adaptador.Fill(datos);
            if (datos.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Este registro no existe");
            }
            else
            {
                dataGridView1.DataSource = datos.Tables[0];
            }

            sqlConnection.Close();
        }

        private void textBuscarE_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBuscarE.Text))
            {
                mostrarDatos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string qwery = "delete from Contactos where Id = '" + rowSelected + "'";
            SqlCommand comando = new SqlCommand(qwery, sqlConnection);
            comando.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Registro Eliminado correctamente!!!");
            mostrarDatos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                rowSelected = dgvRow.Cells[0].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
