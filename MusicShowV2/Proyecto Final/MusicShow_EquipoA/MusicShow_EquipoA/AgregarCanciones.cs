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
        Usuario user;


        public AgregarCanciones(MenuAnunciante m)
        {
            menu = m;
            InitializeComponent();
            user = new Usuario();
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

        private void LlenarTabla(DataGridView dataGridView, string filtro)
        {
            /* Obtiene un dataTable con todos los estudiantes que se encuentran
            en la base de datos (null, null) es para vengan todas las tuplas sin
            ningún filtro*/

            AccesoBaseDatos bd;
            bd = new AccesoBaseDatos();


            DataTable tabla;

            tabla = bd.FiltrarCancionesAnunciante(filtro);

            // Se inicializa el source para cargar el datagridview y se le asigna el dataTable obtenido
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;
            // Ciclo para darle un ancho a cada columna del datagridview proporcionado





            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarCombobox(comboBoxIdioma, "select * from Idioma");
            LlenarCombobox(comboBoxGenero, "select * from Genero");
            LlenarTabla(gridCanciones, menu.nombreAn);


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
            año = int.Parse(añoCancionBox.Text);
            idioma = comboBoxIdioma.Text;
            genero = comboBoxGenero.Text;

            AccesoBaseDatos bd = new AccesoBaseDatos();


            bd.ActualizarDatos("exec agregarInterprete @nombre = '" + interprete +"';");
            bd.ActualizarDatos("exec agregarCanciones @nombre = '" + nombre +"', @nombrein = '"+ interprete +"', @idioma = '" + idioma +"', @genero = '"+ genero +"', @anno = " + año+";");
            //bd.ActualizarDatos();


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

        private void gridCanciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
