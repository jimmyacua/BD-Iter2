using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Lab_Interfaces;
using System.Data.SqlClient;

namespace MusicShow_EquipoA
{
    public partial class AgregarCanciones : MetroForm
    {
        MenuAnunciante menu;
        string nombre;
        string interprete;
        string año;
        Usuario user;


        public AgregarCanciones(MenuAnunciante m)
        {
            menu = m;
            InitializeComponent();
            user = new Usuario();
        }


        private void LlenarCombobox(ComboBox combobox)
        {

            AccesoBaseDatos bd;
            bd = new AccesoBaseDatos();

            string consulta = "";

            SqlDataReader datos = bd.ObtenerTabla();
 
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                }
            }
            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }
            combobox.SelectedIndex = 0;
        }











        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = nombreCancionBox.Text;
            interprete = interpreteCancionBox.Text;
            año = añoCancionBox.Text;

            AccesoBaseDatos bd = new AccesoBaseDatos();

            bd.ActualizarDatos();

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
