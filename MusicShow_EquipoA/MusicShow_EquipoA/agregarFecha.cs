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
        public agregarFecha(AnunciarConcierto ac)
        {
            ac1 = ac;
            InitializeComponent();
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
            ac1.Show();
            this.Hide();

        }
    }
}
