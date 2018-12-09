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
    public partial class ListaConciertos : MetroForm
    {
        public string nomBusc;
        MenuBuscador mb;
        AccesoBaseDatos bd;

        public ListaConciertos(MenuBuscador m)
        {
            mb = m;
            nomBusc = mb.nombreBusc;
            bd = new AccesoBaseDatos();
            InitializeComponent();
        }

        private void ListaConciertos_Load(object sender, EventArgs e)
        {
            LlenarTablaFavs();
            LlenarCombobox();
        }

        private void LlenarCombobox()
        {
            concComboBox.Items.Add("Seleccione");
            concComboBox.Items.Add("Tipo de lugar");
            concComboBox.Items.Add("Fecha");
            concComboBox.Items.Add("Género");
            concComboBox.Items.Add("Idioma");
            concComboBox.Items.Add("Anunciantes favoritos");
            concComboBox.SelectedIndex = 0;
        }

        public void LlenarTablaFavs()
        {
            DataTable tabla = bd.EjecutarConsultaTabla("select distinct s.NombreConc, s.NombreAn, c.NombreLugar from Se_Interesa s join Concierto c on s.NombreConc = c.NombreConcierto and s.NombreAn = c.NombreAn where s.NombreBusc = '" + mb.nombreBusc + "'");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            concInterGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            concInterGrid.DataSource = bindingSource;
            // Ciclo para darle un ancho a cada columna del datagridview proporcionado
            for (int i = 0; i < concInterGrid.ColumnCount; i++)
            {
                concInterGrid.Columns[i].Width = 100;
            }
        }

        private void LlenarTabla(DataGridView dataGridView, string combo, string filtro)
        {
            /* Obtiene un dataTable con todos los estudiantes que se encuentran
            en la base de datos (null, null) es para vengan todas las tuplas sin
            ningún filtro*/
            DataTable tabla = new DataTable();
            if (combo == "Tipo de lugar" && filtro != "")
            {
                tabla = bd.EjecutarConsultaTabla("select c.NombreConcierto , c.NombreAn , c.NombreLugar , f.Fecha_Hora from Concierto c join Fecha_Hora f on c.NombreAn = f.NombreAn and c.NombreConcierto = f.NombreConcierto where c.NombreLugar like '%" + filtro + "%' order by c.NombreAn");
            }
            else if (combo.Equals("Fecha") && filtro != "")
            {
                tabla = bd.EjecutarConsultaTabla("select c.NombreConcierto , c.NombreAn , c.NombreLugar  , f.Fecha_Hora from Concierto c join Fecha_Hora f on c.NombreAn = f.NombreAn and c.NombreConcierto = f.NombreConcierto where convert(varchar(30), f.Fecha_Hora, 126) like '%" + filtro + "%'");
            }
            else if (combo.Equals("Género") && filtro != "")
            {
                tabla = bd.EjecutarConsultaTabla("select c.NombreConcierto , c.NombreAn , c.NombreLugar , f.Fecha_Hora from Concierto c join Se_Tocan s on c.NombreAn = s.NombreAn and c.NombreConcierto = s.NombreConc join Cancion ca on s.NombreCancion = ca.Nombre and s.NombreInterprete = ca.NombreInterprete join Fecha_Hora f on c.NombreAn = f.NombreAn and c.NombreConcierto = f.NombreConcierto where ca.NombreGenero like '%" + filtro + "%'");
            }
            else if (combo.Equals("Idioma") && filtro != "")
            {
                tabla = bd.EjecutarConsultaTabla("select c.NombreConcierto, c.NombreAn , c.NombreLugar , f.Fecha_Hora from Concierto c join Se_Tocan s on c.NombreAn = s.NombreAn and c.NombreConcierto = s.NombreConc join Cancion ca on s.NombreCancion = ca.Nombre and s.NombreInterprete = ca.NombreInterprete join Fecha_Hora f on c.NombreAn = f.NombreAn and c.NombreConcierto = f.NombreConcierto where ca.NombreIdioma like '%" + filtro + "%'");
            }
            else if (combo.Equals("Anunciantes favoritos") && filtro != "") {
                tabla = bd.EjecutarConsultaTabla("select c.NombreConcierto , c.NombreAn , c.NombreLugar from Concierto c join Favoritos f on c.NombreAn = f.NombreAn where f.NombreBusc = '"+nomBusc+"' and f.NombreAn like '%"+filtro+"%' order by c.NombreAn");
            }
            else
            {
                tabla = bd.EjecutarConsultaTabla("select c.NombreConcierto, c.NombreAn , c.NombreLugar , f.Fecha_Hora  from Concierto c join Fecha_Hora f on c.NombreAn = f.NombreAn and c.NombreConcierto = f.NombreConcierto order by NombreAn, NombreConcierto");
            }

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

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
           
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
           

        }

        private void quitarBoton_Click(object sender, EventArgs e)
        {
            


        }

        private void concBoton_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarBoton_Click_1(object sender, EventArgs e)
        {
            if (concComboBox.Text != "Seleccione")
            {
                LlenarTabla(concGrid, concComboBox.Text, filtroText.Text);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un filtro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void quitarBoton_Click_1(object sender, EventArgs e)
        {
            string nombrAn = concInterGrid.Rows[concInterGrid.CurrentRow.Index].Cells[1].Value.ToString();
            bd.EjecutarConsulta("delete from Se_Interesa where NombreBusc = '" + mb.nombreBusc + "' and NombreAn = '" + nombrAn + "'");
            LlenarTablaFavs();
        }

        private void concBoton_Click_1(object sender, EventArgs e)
        {
            string nombreConc = concGrid.Rows[concGrid.CurrentRow.Index].Cells[0].Value.ToString();
            string nombreAn = concGrid.Rows[concGrid.CurrentRow.Index].Cells[1].Value.ToString();
            PerfilConcierto pc = new PerfilConcierto(this, nombreConc, nombreAn);
            pc.Show();
            this.Hide();
        }

        private void volver_Click_1(object sender, EventArgs e)
        {
            mb.Show();
            this.Hide();
        }
    }
}
