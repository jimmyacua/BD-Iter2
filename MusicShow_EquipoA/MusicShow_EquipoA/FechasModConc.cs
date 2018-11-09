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
using System.Globalization;

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
            //LlenarTabla(gridFechas,"select f.Fecha_Hora from Concierto c join Fecha_Hora f on c.NombreConcierto = f.NombreConcierto where c.NombreAn = '"+menu.nombreAn+"' and c.NombreConcierto = '"+ modConc.nombreConcierto+"'");
            LlenarTabla(gridFechas, "select f.Fecha_Hora as Fecha_y_Hora, f.NombreConcierto as Nombre_Concierto, f.NombreAn as Nombre_Anunciante from Fecha_Hora f where f.NombreAn = '" + modConc.nombreAn+"' and f.NombreConcierto = '"+ modConc.nombreConcierto+ "'; ");
            LlenarCombobox(CB_Elim, "select f.Fecha_Hora, f.NombreConcierto from Fecha_Hora f where f.NombreAn = '" + modConc.nombreAn + "' and f.NombreConcierto = '" + modConc.nombreConcierto + "'; ");
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

        private void LlenarCombobox(ComboBox combobox, string consulta)
        {
            SqlDataReader datos = bd.ObtenerTabla(consulta);
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(1) + ": " + datos.GetValue(0));
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

        private void botonElm_Click_1(object sender, EventArgs e)
        {
            if (CB_Elim.Text != "Seleccione")
            {
                string[] fH = CB_Elim.Text.Split(' ');
                string fechYHor = fH[1] + " " + fH[2] + " " + fH[3];// + fH[4];
                string[] fecha = fH[1].Split('/');
                string f = fecha[2] + "-" + fecha[1] + "-" + fecha[0];
                string[] hora = fH[2].Split(':');
                if (fH[3] == "p.m.") {
                    int hr = int.Parse(hora[0]);
                    hr = (hr + 12) % 24;
                    hora[0] = "" + hr;
                }
                f = f + " "+ hora[0] +":"+ hora[1] + ":" + hora[2];
                DateTime dateTime = DateTime.Parse(f);
                //MessageBox.Show("f y h: " + f, "Modificar f y h", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bd.ActualizarDatos("delete from Fecha_Hora where NombreAn = '"+modConc.nombreAn+"' and NombreConcierto = '"+ modConc.nombreConcierto+ "' and Fecha_Hora = '"+ f + "';");
                LlenarTabla(gridFechas, "select f.Fecha_Hora as Fecha_y_Hora, f.NombreConcierto as Nombre_Concierto, f.NombreAn as Nombre_Anunciante from Fecha_Hora f where f.NombreAn = '" + modConc.nombreAn + "' and f.NombreConcierto = '" + modConc.nombreConcierto + "'; ");
                CB_Elim.Items.Clear();
                LlenarCombobox(CB_Elim, "select f.Fecha_Hora , f.NombreConcierto from Fecha_Hora f where f.NombreAn = '" + modConc.nombreAn + "' and f.NombreConcierto = '" + modConc.nombreConcierto + "'; ");
            }
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            modConc.Show();
            this.Hide();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string fH = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
            bd.ActualizarDatos("insert into Fecha_Hora(NombreConcierto, NombreAn, Fecha_Hora) values('" + modConc.nombreConcierto + "','" + modConc.nombreAn + "','" + fH + "');");
            LlenarTabla(gridFechas, "select f.Fecha_Hora as Fecha_y_Hora, f.NombreConcierto as Nombre_Concierto, f.NombreAn as Nombre_Anunciante from Fecha_Hora f where f.NombreAn = '" + modConc.nombreAn + "' and f.NombreConcierto = '" + modConc.nombreConcierto + "'; ");
            CB_Elim.Items.Clear();
            LlenarCombobox(CB_Elim, "select f.Fecha_Hora, f.NombreConcierto from Fecha_Hora f where f.NombreAn = '" + modConc.nombreAn + "' and f.NombreConcierto = '" + modConc.nombreConcierto + "'; ");
        }

        private void CB_Elim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
