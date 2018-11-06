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
    public partial class MenuAnunciante : MetroForm
    {
        public String nombreAn;
        String tipo;
        public MenuAnunciante()
        {
            nombreAn = "";
            tipo = "";
            InitializeComponent();
        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        public void setInformacion(String name, String type) {
            nombreAn = name;
            tipo = type;
            ML_Nombre.Text = nombreAn;
            ML_TIPO.Text = tipo;
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
            ModificarRepertorio mr = new ModificarRepertorio(this);
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
    }
}
