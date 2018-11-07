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
    public partial class AgregarLugar : MetroForm
    {
        AnunciarConcierto ac;

        public AgregarLugar(AnunciarConcierto a)
        {
            ac = a;
            InitializeComponent();
        }

        private void AgregarLugar_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

            ac.Show();
            this.Hide();

        }
    }
}
