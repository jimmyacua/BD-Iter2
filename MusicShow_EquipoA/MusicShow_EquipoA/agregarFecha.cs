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
    public partial class agregarFecha : MetroForm
    {
        AnunciarConcierto ac1;

        string nombre;
        int cupo;
        string descripcion;
        string lugar;
          public string nombreAnunciante;

        string[] vectorFechas = new string[50];
        int contador = 0;
        public MenuAnunciante menuNuevo;




        public agregarFecha(AnunciarConcierto ac)
        {
            ac1 = ac;
            nombreAnunciante = ac1.nombreAnunciante;

             menuNuevo = ac1.menu;

            InitializeComponent();

            gridFechas.Columns.Add("Fecha","Fecha");

        }

        public void setDatos(string n, string d, string l, int c)
        {
            nombre = n;
            descripcion = d;
            lugar = l;
            cupo = c;

            labelNombre.Text = nombre;
        }

        private void agregarFecha_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            ac1.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AgregarCancionesConcierto ac1 = new AgregarCancionesConcierto(this);
            ac1.setDatos(nombre, descripcion, lugar, cupo, vectorFechas);
            ac1.Show();
            this.Hide();

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string fecha = timePicker.Value.ToString("yyyy-MM-dd HH:mm");


            int contadorT = 0;
            bool esta = false;

            while (!esta && contadorT < 50)
            {
                if (vectorFechas[contadorT] == fecha)
                {
                    esta = true;
                }
                contadorT++;
            }

            if (!esta)
            {
                vectorFechas[contador] = fecha;

                DataGridViewRow row = (DataGridViewRow)gridFechas.Rows[0].Clone();
                gridFechas.Rows.Add(row);


                gridFechas.Rows[contador].Cells[0].Value = vectorFechas[contador];

                contador++;

            }
                         

     

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
