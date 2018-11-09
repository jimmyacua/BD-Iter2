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
    public partial class ConsultaConciertos : MetroForm
    {
        Usuario usuario;
        MenuAnunciante menu;
        AccesoBaseDatos bd;
        public ConsultaConciertos(MenuAnunciante m)
        {
            bd = new AccesoBaseDatos();
            menu = m;
            InitializeComponent();
            usuario = new Usuario();
        }

        private void ConsultaCoonciertos_Load(object sender, EventArgs e)
        {
            this.LlenarCombobox(concCombobox);
            this.LlenarTablaInicio(dataGridView1, null, null);
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void LlenarCombobox(ComboBox combobox) {
            
            
            SqlDataReader datos = bd.ObtenerTabla("EXEC consultarConciertos @nomAn = '"+menu.nombreAn+"'");
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


        private void LlenarTablaInicio(DataGridView dataGridView, string fltroNombre, string filtro)
        {
            /* Obtiene un dataTable con todos los estudiantes que se encuentran
            en la base de datos (null, null) es para vengan todas las tuplas sin
            ningún filtro*/
            DataTable tabla = bd.EjecutarConsultaTabla("EXEC consultarConciertos @nomAn = '" + menu.nombreAn + "'");
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

        private void LlenarTabla(DataGridView dataGridView, string fltroNombre, string filtro)
        {
            /* Obtiene un dataTable con todos los estudiantes que se encuentran
            en la base de datos (null, null) es para vengan todas las tuplas sin
            ningún filtro*/
            DataTable tabla = usuario.obtenerConcierto(fltroNombre, filtro, menu.nombreAn);
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

        private void concCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (concCombobox.SelectedIndex == 0)
            {
                LlenarTabla(dataGridView1, null, null);
            }
            else
            {
                LlenarTabla(dataGridView1, concCombobox.Text, null);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            LlenarTabla(dataGridView1, null, filtroGeneral.Text);
        }
    }
}
