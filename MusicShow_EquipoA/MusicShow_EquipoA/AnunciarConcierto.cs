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
    public partial class AnunciarConcierto : MetroForm
    {
        // Variables
        string nombre;
        int cupo;
        string descripcion;
        string lugar;
        public string nombreAnunciante;

        public MenuAnunciante menu;
        public AnunciarConcierto(MenuAnunciante m)
        {
            menu = m;
            nombreAnunciante = m.nombreAn;
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

        private void AnunciarConcierto_Load(object sender, EventArgs e)
        {
            LlenarCombobox(ComboLugar, "select * from Lugar;");
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBoxNombreConcierto.Text;
            if (textBoxCupo.Text != "")
            {
                cupo = Int32.Parse(textBoxCupo.Text);
            }
            descripcion = textBoxDescripcion.Text;
            lugar = ComboLugar.Text;

            agregarFecha af1 = new agregarFecha(this);
            af1.setDatos(nombre, descripcion, lugar, cupo);
            af1.Show();
            this.Hide();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void BotonAgregarLugar_Click(object sender, EventArgs e)
        {
            AgregarLugar al = new AgregarLugar(this);

            al.Show();
            this.Hide();

        }

        public void recargar()
        {
            ComboLugar.Items.Clear();
            LlenarCombobox(ComboLugar, "select NombreLugar from  Lugar");
        }

        private void textBoxCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
