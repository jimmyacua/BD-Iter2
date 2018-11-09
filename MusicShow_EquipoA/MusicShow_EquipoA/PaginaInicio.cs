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
    public partial class PaginaInicio : MetroForm
    {
        String username;
        Usuario user;
        public PaginaInicio()
        {
            user = new Usuario();
            InitializeComponent();
        }

        private void PaginaInicio_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            CrearPerfilDeUsuario crearPer = new CrearPerfilDeUsuario();
            crearPer.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        username = TX_USERNAME.Text;
            int valido = user.VerificarUsuario(username);
            if (valido == 1)
            {
                AccesoBaseDatos bd;
                bd = new AccesoBaseDatos();
                SqlDataReader read = bd.EjecutarConsulta("Select Tipo from Anunciante where NombreAn = '" + username +  "';");
                // string tp = read.GetString(1);
                var myString = "";

                while (read.Read())
                {
                    myString = read.GetString(0); //The 0 stands for "the 0'th column", so the first column of the result.
                                             // Do somthing with this rows string, for example to put them in to a list
                }

                MenuAnunciante menAn = new MenuAnunciante();
                menAn.setInformacion(username, myString);
                menAn.Show();
                Hide();
            }
            else {
                MessageBox.Show("No existe el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
