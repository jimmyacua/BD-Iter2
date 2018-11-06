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
    public partial class ConsultaConciertos : MetroForm
    {
        MenuAnunciante menu;
        public ConsultaConciertos(MenuAnunciante m)
        {
            menu = m;
            InitializeComponent();
        }

        private void ConsultaCoonciertos_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }
    }
}
