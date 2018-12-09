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
    public partial class ListaArtistas : MetroForm
    {
        MenuBuscador menu;
        private SqlDataReader datos;
        AccesoBaseDatos bd;

        public ListaArtistas(MenuBuscador m)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            menu = m;
        }

        private void LlenarCombobox(ComboBox combobox, string consulta)
        {

            Lab_Interfaces.AccesoBaseDatos bd;
            bd = new AccesoBaseDatos();
            datos = bd.ObtenerTabla(consulta);

            int cont = 0;

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



        public void actulizarGrid()
        {

            LlenarTabla(gridFav, "select NombreAn from Favoritos where NombreBusc = '" + menu.nombreBusc + "';");

        }

        private void ListaArtistas_Load(object sender, EventArgs e)
        {
            LlenarCombobox(comboArtistas, "select * from Anunciante;");

            LlenarTabla(gridFav, "select NombreAn from Favoritos where NombreBusc = '"+ menu.nombreBusc +"';");


        }

        private void LlenarTabla(DataGridView dataGridView, string consulta)
        {
            Usuario user = new Usuario();

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


        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string nombreArtista = comboArtistas.Text;

            PerfilAnunciante_VistaBuscador anuncianteBuscador = new PerfilAnunciante_VistaBuscador(nombreArtista, menu.nombreBusc, this);

            anuncianteBuscador.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string nombreBorrar = gridFav.Rows[gridFav.CurrentRow.Index].Cells[0].Value.ToString();

            //MessageBox.Show(nombreBorrar, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            bd.ActualizarDatos("delete from Favoritos where NombreAn = '"+ nombreBorrar +"' and NombreBusc = '"+ menu.nombreBusc +"'");


            LlenarTabla(gridFav, "select NombreAn from Favoritos where NombreBusc = '" + menu.nombreBusc + "';");
        }
    }
}
