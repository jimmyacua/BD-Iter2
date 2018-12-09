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
    public partial class CrearPerfilDeBuscador : MetroForm
    {
        Usuario user;
        string nombreB = "";
        string provincia = "";
        string canton = "";
        string correo = "";
        string[] generos = new string[20];
        int contadorGenero = 0;
        string[] idiomas = new string[20];
        int contadorIdioma = 0;
        private SqlDataReader datos;

        public CrearPerfilDeBuscador()
        {
            user = new Usuario();
            InitializeComponent();
            gridIdiomas.Columns.Add("Nombre", "Nombre");
            gridGenero.Columns.Add("Nombre", "Nombre");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            LlenarCombobox(ComboIdioma, "select * from idioma;");
            LlenarCombobox(ComboGenero, "select * from genero");
            LlenarCombobox(ComboProvincia, "select * from provincia");

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

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


        private void botonGuardar_Click(object sender, EventArgs e)
        {
            AccesoBaseDatos bd = new AccesoBaseDatos();

            if (TX_Nombre.Text != "")
            {
                nombreB = TX_Nombre.Text;
                provincia = ComboProvincia.Text;
                canton = comboCanton.Text;
                correo = TX_Email.Text;

                int error = user.AgregarBuscador(nombreB, correo, provincia, canton);
                if (error != 0)
                {
                    MessageBox.Show("Ya existe un usuario asociado a este nombre en el sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
               
                    int indice1 = 0;

                    while (idiomas[indice1] != null)
                    {

                        bd.ActualizarDatos("insert into prefiere values('"+ nombreB +"', '"+ idiomas[indice1] +"');");

                        indice1++;

                    }

                    int indice2 = 0;

                    while (generos[indice2] != null)
                    {

                        bd.ActualizarDatos("insert into Gusta_De values('" + generos[indice2]  + "', '" + nombreB + "');");

                        indice2++;

                    }

                    MessageBox.Show("Usuario se creó extosamente", "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);










                    MenuBuscador m = new MenuBuscador(nombreB);
                    m.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Debe escribir un nombre válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void agregarGenero_Click(object sender, EventArgs e)
        {
            string generoSeleccionado = ComboGenero.Text;

            int contadorT = 0;
            bool esta = false;

            while (!esta && contadorT < 20)
            {
                if (generos[contadorT] == generoSeleccionado)
                {
                    esta = true;
                }
                contadorT++;
            }

            if (!esta)
            {
                generos[contadorGenero] = generoSeleccionado;

                DataGridViewRow row2 = (DataGridViewRow)gridGenero.Rows[0].Clone();
                gridGenero.Rows.Add(row2);

                gridGenero.Rows[contadorGenero].Cells[0].Value = generos[contadorGenero];

                contadorGenero++;
            }

        }

      
        private void agregarIdioma_Click(object sender, EventArgs e)
        {
            string idiomaSelecconado = ComboIdioma.Text;

            int contadorT = 0;
            bool esta = false;

            while (!esta && contadorT < 20)
            {
                if (idiomas[contadorT] == idiomaSelecconado)
                {
                    esta = true;
                }
                contadorT++;
            }

            if (!esta)
            {
                idiomas[contadorIdioma] = idiomaSelecconado;

                DataGridViewRow row2 = (DataGridViewRow)gridIdiomas.Rows[0].Clone();
                gridIdiomas.Rows.Add(row2);

                gridIdiomas.Rows[contadorIdioma].Cells[0].Value = idiomas[contadorIdioma];           

                contadorIdioma++;
            }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ComboLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = ComboProvincia.Text;

            comboCanton.Items.Clear();

            LlenarCombobox(comboCanton, "Select * from Canton where NombreProvincia = '" + opcion + "';");
        }

        private void link1_Click(object sender, EventArgs e)
        {
            PaginaInicio pag = new PaginaInicio();

            pag.Show();

            this.Hide();



        }

        private void gridIdiomas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

