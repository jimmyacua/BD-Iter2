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
    public partial class EliminarCancion : MetroForm
    {
        MenuAnunciante menu;
        public EliminarCancion(MenuAnunciante m)
        {
            menu = m;
            InitializeComponent();
        }

        private void EliminarCancion_Load(object sender, EventArgs e)
        {
            LlenarCombobox(elCancionCombo);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void elCancionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LlenarCombobox(ComboBox combobox)
        {
            AccesoBaseDatos bd;
            bd = new AccesoBaseDatos();
            SqlDataReader datos = bd.ObtenerTabla("SELECT Nombre FROM Cancion");
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                }
            }
            /* Si no hay tuplas en la base de datos se limpia el combobox y se
            carga unicamente el valor "Seleccione"*/
            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }
            // Se pone por defecto la primera entrada del combobox seleccionada
            combobox.SelectedIndex = 0;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
