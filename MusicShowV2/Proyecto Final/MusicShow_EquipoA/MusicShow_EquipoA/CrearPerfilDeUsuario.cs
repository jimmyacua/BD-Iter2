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
    public partial class CrearPerfilDeUsuario : MetroForm
    {
        public Usuario user;
        public String name;
        public String tipoAn;
        public CrearPerfilDeUsuario()
        {
            tipoAn = "Agrupación";
            name = "";
            user = new Usuario();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (RB_Agrupcion.Checked)
            {
                tipoAn = "Agrupación";
            }
            else {
                tipoAn = "Solista";
            }

            name = TX_Nombre.Text;
            user.AgregarAnunciante(name, tipoAn);
        }
    }
}
