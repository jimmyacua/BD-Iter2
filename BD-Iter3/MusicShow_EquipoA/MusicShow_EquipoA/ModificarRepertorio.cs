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
using System.Data.SqlClient;
using Lab_Interfaces;

namespace MusicShow_EquipoA
{
    public partial class ModificarRepertorio : MetroForm
    {
        ModificarConciertos mc;
        AccesoBaseDatos bd;
        Usuario usuario;
        public ModificarRepertorio(ModificarConciertos m)
        {
            usuario = new Usuario();
            mc = m;
            bd = new AccesoBaseDatos();
            InitializeComponent();
        }

        private void LlenarCombobox(ComboBox combobox, string consulta)
        {
            SqlDataReader datos = bd.ObtenerTabla(consulta);
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    datos.GetValue(0).ToString();
                    datos.GetValue(1).ToString();
                    combobox.Items.Add(datos.GetValue(0) + "-" + datos.GetValue(1));
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


        private void ModificarRepertorio_Load(object sender, EventArgs e)
        {
            LlenarCombobox(ReperAg, "select r.NombreCancion, r.NombreInterprete from Anunciante a join Repertorio r on a.NombreAn = r.NombreAn where a.NombreAn = '" + mc.nombreAn+"'");
            LlenarCombobox(ReperEl, "select NombreCancion, NombreInterprete from Se_Tocan where NombreConc = '"+mc.nombreConcierto+"' and NombreAn = '"+mc.nombreAn+"' ");
            LlenarTabla(TablaCanciones);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            mc.Show();
            this.Hide();
           
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if(ReperAg.Text!= "Seleccione")
            {
                string[] nomb = ReperAg.Text.Split('-');
                bd.ActualizarDatos("insert into Se_Tocan values('"+mc.nombreConcierto+"', '"+mc.nombreAn+"', '"+ nomb[0]+ "','"+ nomb[1] + "');");
                LlenarTabla(TablaCanciones);
                ReperEl.Items.Clear();
                LlenarCombobox(ReperEl, "select NombreCancion, NombreInterprete from Se_Tocan where NombreConc = '" + mc.nombreConcierto + "' and NombreAn = '" + mc.nombreAn + "' "); 
            }
        }

        private void LlenarTabla(DataGridView dataGridView)
        {
            /* Obtiene un dataTable con todos los estudiantes que se encuentran
            en la base de datos (null, null) es para vengan todas las tuplas sin
            ningún filtro*/
            DataTable tabla = bd.EjecutarConsultaTabla("Select NombreCancion as Canción, nombreConc as Concierto, NombreAn as Anunciante, NombreInterprete as Intérprete_Original from Se_Tocan where NombreAn = '" + mc.nombreAn+"'and nombreConc = '"+mc.nombreConcierto+"';");
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string[] nomb = ReperEl.Text.Split('-');
            bd.ActualizarDatos("delete from Se_Tocan where NombreConc = '" + mc.nombreConcierto + "' and NombreAn = '" + mc.nombreAn + "' and NombreCancion = '" + nomb[0] + "' and NombreInterprete = '" + nomb[1] + "'");
            ReperAg.Items.Clear();
            ReperEl.Items.Clear();
            LlenarCombobox(ReperAg, "select r.NombreCancion, r.NombreInterprete from Anunciante a join Repertorio r on a.NombreAn = r.NombreAn where a.NombreAn = '" + mc.nombreAn + "'");
            LlenarCombobox(ReperEl, "select NombreCancion, NombreInterprete from Se_Tocan where NombreConc = '" + mc.nombreConcierto + "' and NombreAn = '" + mc.nombreAn + "' ");
            LlenarTabla(TablaCanciones);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
