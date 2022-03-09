using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaElectronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            eliminarUserC1.Hide();
            buscarUserC1.Hide();
            modificarUserC1.Hide();
            insertarUserC1.Show();
            insertarUserC1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminarUserC1.Hide();
            buscarUserC1.Hide();
            insertarUserC1.Hide();
            modificarUserC1.BringToFront();
            modificarUserC1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminarUserC1.Hide();
            modificarUserC1.Hide();
            insertarUserC1.Hide();
            buscarUserC1.Show();
            buscarUserC1.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buscarUserC1.Hide();
            modificarUserC1.Hide();
            insertarUserC1.Hide();
            eliminarUserC1.Show();
            eliminarUserC1.BringToFront();
        }

        private void insertarUserC1_Load(object sender, EventArgs e)
        {

        }

        private void buscarUserC1_Load(object sender, EventArgs e)
        {

        }
    }
}
