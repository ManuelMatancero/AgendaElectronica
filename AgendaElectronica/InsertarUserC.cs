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
    public partial class InsertarUserC : UserControl
    {
        public InsertarUserC()
        {
            InitializeComponent();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection("server = DESKTOP-B7GBJ6U ;database= AgendaElectronica ; integrated security = true");
            sqlConnection.Open();
            string nombre = textBoxNombreI.Text;
            string apellido = textBoxApellidoI.Text;
            string fechaNacimiento = dateTimePickerI.Text;
            string direccion = textBoxDireccionI.Text;
            string genero;
          
            if (radiobtnMasculinoI.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Femenino";
            }
            string estadoCivil;
           
            if (radiobtnCasadoI.Checked)
            {
                estadoCivil = "Casado";
            }
            else if (radiobtnSolteroI.Checked)
            {
                estadoCivil = "Soltero";
            }
            else
            {
                estadoCivil = "Divorciado";
            }
            string movil = textBoxMovilI.Text;
            string telefono = textBoxTelefonoI.Text;
            string correo = textBoxCorreoI.Text;
            if (String.IsNullOrEmpty(textBoxNombreI.Text))
            {
                textBoxNombreI.Focus();
                MessageBox.Show("El campo nombre no puede estar vacio");
            }
            else if (String.IsNullOrEmpty(textBoxApellidoI.Text))
            {
                textBoxApellidoI.Focus();
                MessageBox.Show("El campo apellido no puede estar vacio");
            }
            else if (String.IsNullOrEmpty(textBoxDireccionI.Text))
            {
                textBoxDireccionI.Focus();
                MessageBox.Show("El campo direccion no puede estar vacio");
            }
            else if (String.IsNullOrEmpty(textBoxMovilI.Text))
            {
                textBoxMovilI.Focus();
                MessageBox.Show("El campo movil no puede estar vacio");
            }
            else if (String.IsNullOrEmpty(textBoxTelefonoI.Text))
            {
                textBoxTelefonoI.Focus();
                MessageBox.Show("El Telefono telefono no puede estar vacio");
            }
            else if (String.IsNullOrEmpty(textBoxCorreoI.Text))
            {
                textBoxCorreoI.Focus();
                MessageBox.Show("El campo correo no puede estar vacio");
            }
            else
            {
                string qwery = "insert into Contactos values ('" + nombre + "', '" + apellido + "', '" + fechaNacimiento + "', '" + direccion + "','" + genero + "', '" + estadoCivil + "', '" + movil + "', '" + telefono + "', '" + correo + "')";
                SqlCommand comando = new SqlCommand(qwery, sqlConnection);
                comando.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Registro guardado correctamente!!!");
                textBoxNombreI.Text = "";
                textBoxApellidoI.Text = "";
                textBoxDireccionI.Text = "";
                textBoxMovilI.Text = "";
                textBoxTelefonoI.Text = "";
                textBoxCorreoI.Text = "";
            }         
        }

       
    }
}
