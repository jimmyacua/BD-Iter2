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

namespace MusicShow_EquipoA
{
    public partial class FechasModConc : MetroForm
    {
        MenuAnunciante menu;
        AccesoBaseDatos bd;
        ModificarConciertos modConc;
        public FechasModConc(ModificarConciertos mc)
        {
            modConc = mc;
            bd = new AccesoBaseDatos();
            menu = new MenuAnunciante();
            InitializeComponent();
        }

        private void FechasModConc_Load(object sender, EventArgs e)
        {
            LlenarTabla(gridFechas,"select f.Fecha_Hora from Concierto c join Fecha_Hora f on c.NombreConcierto = f.NombreConcierto where c.NombreAn = '"+menu.nombreAn+"' and c.NombreConcierto = '"+ modConc.nombreConcierto+"'");
        }

        private void LlenarTabla(DataGridView dataGridView, string consulta)
        {

            DataTable tabla = bd.EjecutarConsultaTabla(consulta);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource;

            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                dataGridView.Columns[i].Width = 100;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
