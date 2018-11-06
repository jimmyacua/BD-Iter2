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

namespace MusicShow_EquipoA
{
    public partial class ConsultaConciertos : MetroForm
    {
        Usuario usuario;
        MenuAnunciante menu;
        public ConsultaConciertos(MenuAnunciante m)
        {
            menu = m;
            InitializeComponent();
            usuario = new Usuario();
        }

        private void ConsultaCoonciertos_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }


        private void LlenarTabla(DataGridView dataGridView, string fltroNombre, string filtro)
        {
            /* Obtiene un dataTable con todos los estudiantes que se encuentran
            en la base de datos (null, null) es para vengan todas las tuplas sin
            ningún filtro*/
            DataTable tabla = usuario.obtenerConcierto(fltroNombre, filtro);
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

    }
}
