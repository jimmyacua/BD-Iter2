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
    public partial class PerfilAnunciante_VistaBuscador : MetroForm
    {
        string nombreAn;
        string nombreBusc;
        AccesoBaseDatos bd;
        ListaArtistas lista;

        public PerfilAnunciante_VistaBuscador(string nombreAnunciante, string nombreBuscador, ListaArtistas listaNueva)
        {
            lista = listaNueva;
            InitializeComponent();
            bd = new AccesoBaseDatos();
            nombreAn = nombreAnunciante;
            nombreBusc = nombreBuscador;

            labelNombre.Text = nombreAn;

            SqlDataReader tipo = bd.EjecutarConsulta("select Tipo from Anunciante where NombreAn = '"+ nombreAn +"';");

         
                while (tipo.Read())
                {
                labelTipo.Text =  tipo.GetString(0); //The 0 stands for "the 0'th column", so the first column of the result.
                                                     // Do somthing with this rows string, for example to put them in to a list
                }   

        }

        private void PerfilAnunciante_VistaBuscador_Load(object sender, EventArgs e)
        {
            this.gridCanciones.DefaultCellStyle.ForeColor = Color.Black;//jajajajajajajajajajaja
            LlenarTabla(gridCanciones, "select c.Nombre, c.NombreInterprete, c.NombreGenero , c.NombreIdioma from Repertorio r join Cancion c on r.NombreCancion = c.Nombre and r.NombreInterprete = c.NombreInterprete where NombreAn = '" + nombreAn + "';");


            SqlDataReader data = bd.EjecutarConsulta("select count(*) from Me_Gustas where NombreAn = '" + nombreAn + "';");


            while (data.Read())
            {
                labelLikes.Text = data.GetInt32(0).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                                                    // Do somthing with this rows string, for example to put them in to a list
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bd.ActualizarDatos("insert into Favoritos values('"+ nombreBusc +"', '"+ nombreAn +"')");

            pictureBox1.Image = Properties.Resources.starMovil1;

            
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            lista.actulizarGrid();
            lista.Show();
            this.Hide();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

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

        private void gridCanciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bd.ActualizarDatos("insert into Me_Gustas values('"+ nombreBusc+"','"+nombreAn+"');");


            SqlDataReader data = bd.EjecutarConsulta("select count(*) from Me_Gustas where NombreAn = '" + nombreAn + "';");


            while (data.Read())
            {
                labelLikes.Text = data.GetInt32(0).ToString(); //The 0 stands for "the 0'th column", so the first column of the result.
                                                               // Do somthing with this rows string, for example to put them in to a list
            }

            pictureBox2.Image = Properties.Resources.likeMovil2;



        }
    }
}

