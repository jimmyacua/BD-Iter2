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
    public partial class AgregarBoleteria : MetroForm
    {
        AgregarCancionesConcierto acc;

        string nombre;
        string nombreLugar;

        public AgregarBoleteria(AgregarCancionesConcierto a)
        {
            acc = a;
            InitializeComponent();
        }

        private void AgregarBoleteria_Load(object sender, EventArgs e)
        {
            LlenarCombobox(comboBoxLugar,"select * from Lugar");

        }

        private void LlenarCombobox(ComboBox combobox, string consulta)
        {

            AccesoBaseDatos bd;
            bd = new AccesoBaseDatos();
            SqlDataReader datos;
            datos = bd.ObtenerTabla(consulta);

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

        private void textBoxPrecio_Click(object sender, EventArgs e)
        {

        }

        private void botonEntrada_Click(object sender, EventArgs e)
        {
            nombre = textBoxPrecio.Text;
            nombreLugar = comboBoxLugar.Text;
            AccesoBaseDatos bd = new AccesoBaseDatos();
            bd.ActualizarDatos("insert into Boleteria(Nombre_o_URL, NombreLugar) values('"+  nombre  +"', '"+ nombreLugar   +"');");

            acc.actualizarCombo();

            acc.Show();
            this.Hide();

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            acc.Show();
            this.Hide();
        }
    }
}
