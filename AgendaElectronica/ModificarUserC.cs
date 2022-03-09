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
    public partial class ModificarUserC : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection("server = DESKTOP-B7GBJ6U ;database= AgendaElectronica ; integrated security = true");
        string rowSelected;
        string genero;
        string estadoCivil;
        public ModificarUserC()
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
                string nombre = textBuscarM.Text;
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

        private void textBuscarM_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBuscarM.Text))
            {
                mostrarDatos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string nombre = textBoxNombreM.Text;
            string apellido = textBoxApellidoM.Text;
            string fechaNacimiento = dateTimePickerM.Text;
            string direccion = textBoxDireccionM.Text;
            

            if (radiobtnMasculinoM.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Femenino";
            }
            

            if (radiobtnCasadoM.Checked)
            {
                estadoCivil = "Casado";
            }
            else if (radiobtnSolteroM.Checked)
            {
                estadoCivil = "Soltero";
            }
            else
            {
                estadoCivil = "Divorciado";
            }
            string movil = textBoxMovilM.Text;
            string telefono = textBoxTelefonoM.Text;
            string correo = textBoxCorreoM.Text;
            string qwery = "update Contactos set Nombre='" + nombre + "', Apellido= '" + apellido + "', Fecha_Nacimiento= '" + fechaNacimiento + "', Direccion= '" + direccion + "', Genero='" + genero + "', Estado_Civil= '" + estadoCivil + "', Movil= '" + movil + "', Telefono= '" + telefono + "', Correo= '" + correo + "' where Id = '" + rowSelected + "'";
            SqlCommand comando = new SqlCommand(qwery, sqlConnection);
            comando.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Registro modificado correctamente!!!");
            mostrarDatos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                rowSelected = dgvRow.Cells[0].Value.ToString();
                textBoxNombreM.Text = dgvRow.Cells[1].Value.ToString();
                textBoxApellidoM.Text = dgvRow.Cells[2].Value.ToString();
                dateTimePickerM.Text = dgvRow.Cells[3].Value.ToString();
                textBoxDireccionM.Text = dgvRow.Cells[4].Value.ToString();
                genero = dgvRow.Cells[5].Value.ToString();
                if (genero.Equals("Masculino"))
                {
                    radiobtnMasculinoM.Checked=true;

                }
                else
                {
                    radiobtnFemeninoM.Checked = true;
                }
                estadoCivil = dgvRow.Cells[6].Value.ToString();
                if (estadoCivil.Equals("Casado"))
                {
                    radiobtnCasadoM.Checked = true;
                }
                else if (estadoCivil.Equals("Divorciado"))
                {
                    radiobtnDivorciadoM.Checked = true;
                }
                else
                {
                    radiobtnSolteroM.Checked = true;
                }
                textBoxMovilM.Text = dgvRow.Cells[7].Value.ToString();
                textBoxTelefonoM.Text = dgvRow.Cells[8].Value.ToString();
                textBoxCorreoM.Text = dgvRow.Cells[9].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }
    }
}
