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
                MenuAnunciante menAn = new MenuAnunciante();
                menAn.Show();
                Hide();
            }
            else {
                MessageBox.Show("No existe el usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
