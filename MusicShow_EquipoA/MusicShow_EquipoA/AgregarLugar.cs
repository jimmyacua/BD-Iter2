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
    public partial class AgregarLugar : MetroForm
    {
        // Variables
        string nombreLugar;
        string provincia;
        string canton;
        string ubicacion;
        string tipoLugar;

        AnunciarConcierto ac;

        public AgregarLugar(AnunciarConcierto a)
        {
            ac = a;
            InitializeComponent();
        }

        private void LlenarCombobox(ComboBox combobox, string consulta)
        {

            AccesoBaseDatos bd;
            bd = new AccesoBaseDatos();

            SqlDataReader datos = bd.ObtenerTabla(consulta);

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



        private void AgregarLugar_Load(object sender, EventArgs e)
        {
            LlenarCombobox(comboBoxProvincia, "Select * from Provincia");
            LlenarCombobox(comboBoxTipoLugar, "Select * from TipoLugar;");
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

            ac.Show();
            this.Hide();

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = comboBoxProvincia.Text;

            comboBoxCanton.Items.Clear();

            LlenarCombobox(comboBoxCanton, "Select * from Canton where NombreProvincia = '" + opcion + "';");
        }

        private void comboBoxTipoLugar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            nombreLugar = textBoxNombreLugar.Text;
            provincia = comboBoxProvincia.Text;
            canton = comboBoxCanton.Text;
            ubicacion = textBoxUbicacionExacta.Text; ;
            tipoLugar = comboBoxTipoLugar.Text;

            AccesoBaseDatos bd = new AccesoBaseDatos();

            bd.ActualizarDatos("EXEC dbo.agregarLugar @nombre = '" + nombreLugar  + "', @tipoLugar = '" + tipoLugar + "', @ubicacion = '" + ubicacion + "', @canton = '" + canton + "', @provincia = '" + provincia + "';");

            textBoxNombreLugar.Text = "";
            comboBoxProvincia.SelectedIndex = 0;
            comboBoxCanton.SelectedIndex = 0;
            textBoxUbicacionExacta.Text = ""; ;
            comboBoxTipoLugar.SelectedIndex = 0;
        }
    }
}
