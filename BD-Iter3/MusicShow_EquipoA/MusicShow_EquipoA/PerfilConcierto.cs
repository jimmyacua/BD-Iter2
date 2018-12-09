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
    public partial class PerfilConcierto : MetroForm
    {
        AccesoBaseDatos bd;
        ListaConciertos lc;
        public string nombreConc;
        public string nombreAn;
        public string nombreBusc;

        public PerfilConcierto(ListaConciertos l, string nCon, string nAn)
        {
            lc = l;
            nombreBusc = lc.nomBusc;
            bd = new AccesoBaseDatos();
            nombreConc = nCon;
            nombreAn = nAn;
            InitializeComponent();
            promedio.Text = "0";
        }

        private void PerfilConcierto_Load(object sender, EventArgs e)
        {
            nombConc.Text = nombreConc;
            artistaML.Text = nombreAn;
            LlenarTabla();
            SqlDataReader sql = bd.EjecutarConsulta("select AVG(Cant_Estrellas) from Valoracion where NombreConc = '" + nombreConc + "' and NombreAn = '" + nombreAn + "'");

            int d = 0;
            while (sql.Read())
            {
                try
                {
                    d = sql.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.
                                         // Do somthing with this rows string, for example to put them in to a list
                }
                catch (Exception) {
                }
            }

            promedio.Text = d.ToString();
        }

        private void LlenarTabla()
        {
            DataTable tabla = bd.EjecutarConsultaTabla("select c.NombreConcierto, c.NombreLugar, c.Cupo, c.Descripcion from Concierto c where c.NombreAn = '" + nombreAn + "' and c.NombreConcierto = '" + nombreConc + "'");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tabla;
            cancionesGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            cancionesGrid.DataSource = bindingSource;
            // Ciclo para darle un ancho a cada columna del datagridview proporcionado
            for (int i = 0; i < cancionesGrid.ColumnCount; i++)
            {
                cancionesGrid.Columns[i].Width = 100;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(3);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(1);
        }

        public void modificarPromedioEstrellas(int es)
        {
            SqlDataReader sql = bd.EjecutarConsulta("select count(*) from Valoracion where NombreBusc = '" + lc.nomBusc + "' and NombreConc = '" + nombreConc + "' and NombreAn = '" + nombreAn + "'");
            int div = 0;
            while (sql.Read())
            {
                div = sql.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.
                                       // Do somthing with this rows string, for example to put them in to a list
            }

            if (div == 0)
            {
                bd.ActualizarDatos("insert into Valoracion values('" + lc.nomBusc + "', '" + nombConc + "', '" + nombreAn + "'," + es + ")");
            }
            else
            {
                bd.ActualizarDatos("update Valoracion set Cant_Estrellas = " + es + " where NombreBusc = '" + lc.nomBusc + "' and NombreConc = '" + nombreConc + "' and NombreAn = '" + nombreAn + "'");
            }



            sql = bd.EjecutarConsulta("select AVG(Cant_Estrellas) from Valoracion where NombreConc = '" + nombreConc + "' and NombreAn = '" + nombreAn + "'");

            int d = 0;
            while (sql.Read())
            {
                d = sql.GetInt32(0); //The 0 stands for "the 0'th column", so the first column of the result.
                                     // Do somthing with this rows string, for example to put them in to a list
            }

            promedio.Text = d.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(2);
        }

        private void volver_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(4);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(5);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            bd.EjecutarConsulta("insert into Se_Interesa values('" + lc.nomBusc + "', '" + nombreConc + "', '" + nombreAn + "');");
            MessageBox.Show("Se agregó a su lista de favoritos", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void volver_Click_1(object sender, EventArgs e)
        {
            lc.LlenarTablaFavs();
            lc.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(1);
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(2);
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(4);
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            modificarPromedioEstrellas(5);
        }

        private void comentBoton_Click(object sender, EventArgs e)
        {
            ComentarConcierto cc = new ComentarConcierto(this);
            cc.Show();
            this.Hide();
        }
    }
}
