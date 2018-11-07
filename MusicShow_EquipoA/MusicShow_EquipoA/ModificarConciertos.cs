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
    public partial class ModificarConciertos : MetroForm
    {
        MenuAnunciante menu;
        public ModificarConciertos(MenuAnunciante m)
        {
            menu = m;
            InitializeComponent();
        }

        private void ModificarConciertos_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            ModificarRepertorio m = new ModificarRepertorio(this);
            m.Show();
            this.Hide();
        }
    }
}
