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
        int año;
        string idioma;
        string genero;
     


        public AgregarCanciones(MenuAnunciante m)
        {
            menu = m;
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

        private void LlenarTabla(DataGridView dataGridView)
        {
            Usuario user = new Usuario();

            DataTable tabla = user.obtenerCanciones(menu.nombreAn);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarCombobox(comboBoxIdioma, "select * from Idioma");
            LlenarCombobox(comboBoxGenero, "select * from Genero");
            LlenarCombobox(comboBoxInterprete, "Select * from InterpreteOriginal");
            LlenarTabla(gridCanciones);

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
            interprete = comboBoxInterprete.Text;
            año = int.Parse(añoCancionBox.Text);
            idioma = comboBoxIdioma.Text;
            genero = comboBoxGenero.Text;

            nombreCancionBox.Text = "";
            añoCancionBox.Text = "";
            nombreCancionBox.Text = "";
            nombreCancionBox.Text = "";
            comboBoxIdioma.SelectedIndex = 0;
            comboBoxGenero.SelectedIndex = 0;
            comboBoxInterprete.SelectedIndex = 0;




            AccesoBaseDatos bd = new AccesoBaseDatos();

            bd.ActualizarDatos("exec agregarCanciones @nombre = '" + nombre +"', @nombrein = '"+ interprete +"', @idioma = '" + idioma +"', @genero = '"+ genero +"', @anno = " + año+ ", @nombreAnunciante = '" + menu.nombreAn + "';");

            LlenarTabla(gridCanciones);

            MessageBox.Show("La canción se agregó exitosamente", "AGREGAR CANCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void interpreteCancionBox_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxInterprete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonAgregarInterprete_Click(object sender, EventArgs e)
        {
            if(agregarInterpreteBox.Text != "")
            {
                string interpreteNuevo = agregarInterpreteBox.Text;

                agregarInterpreteBox.Text = "";

                AccesoBaseDatos bd = new AccesoBaseDatos();
                bd.ActualizarDatos("exec agregarInterprete @nombre = '" + interpreteNuevo + "';");


                agregarInterpreteBox.Text = "";
                comboBoxInterprete.Items.Clear();

                LlenarCombobox(comboBoxInterprete, "Select * from InterpreteOriginal");
            }
            else
            {
                MessageBox.Show("Debe escribir un nombre válido", "Agregar Intérprete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void añoCancionBox_KeyPress(object sender, KeyPressEventArgs e) //para que solo permita numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
