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
    public partial class MenuBuscador : MetroForm
    {
        
        public string nombreBusc;
        public MenuBuscador(string nombreB)
        {
            nombreBusc = nombreB;
            InitializeComponent();
        }

        private void MenuBuscador_Load(object sender, EventArgs e)
        {
            ML_Nombre.Text = nombreBusc;
        }

        public void setInformacion(string nombre) {
            nombreBusc = nombre;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PaginaInicio pi = new PaginaInicio();
            pi.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void linkAgregarCanciones_Click(object sender, EventArgs e)
        {
            ListaArtistas lA = new ListaArtistas(this);
            lA.Show();
            this.Hide();

        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            ListaConciertos lC = new ListaConciertos(this);
            lC.Show();
            this.Hide();
        }



    }
}
