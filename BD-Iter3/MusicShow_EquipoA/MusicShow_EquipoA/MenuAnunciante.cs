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
    public partial class MenuAnunciante : MetroForm
    {
        AccesoBaseDatos bd;
        public String nombreAn;
        String tipo;
        public MenuAnunciante()
        {
            nombreAn = "";
            tipo = "";
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }


        public void Menu_Load(object sender, EventArgs e)
        {
            string consultaG = "select distinct c.NombreGenero FROM Anunciante a join Repertorio r on a.NombreAn = r.NombreAn join Cancion c on r.NombreCancion = c.Nombre and r.NombreInterprete = c.NombreInterprete where a.NombreAn = '" + nombreAn + "'";
            LlenarTabla(generosGrid,consultaG);

            string consultaI = "select distinct c.NombreIdioma FROM Anunciante a join Repertorio r on a.NombreAn = r.NombreAn join Cancion c on r.NombreCancion = c.Nombre and r.NombreInterprete = c.NombreInterprete where a.NombreAn = '" + nombreAn + "'";
            LlenarTabla(idiomasGid, consultaI);
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

        public void setInformacion(String name, String type, String numLikes) {
            nombreAn = name;
            tipo = type;
            ML_Nombre.Text = nombreAn;
            ML_TIPO.Text = tipo;
            likesMetro.Text = numLikes;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PaginaInicio pi = new PaginaInicio();
            pi.Show();
            this.Hide();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            AgregarCanciones ac = new AgregarCanciones(this);
            ac.Show();
            this.Hide();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            EliminarCancion mr = new EliminarCancion(this);
            mr.Show();
            this.Hide();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            AnunciarConcierto ac = new AnunciarConcierto(this);
            ac.Show();
            this.Hide();
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            ModificarConciertos mc = new ModificarConciertos(this);
            mc.Show();
            this.Hide();
        }

        private void metroLink5_Click(object sender, EventArgs e)
        {
            ConsultaConciertos cc = new ConsultaConciertos(this);
            cc.Show();
            this.Hide();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
