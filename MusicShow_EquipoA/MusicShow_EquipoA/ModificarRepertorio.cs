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
    public partial class ModificarRepertorio : MetroForm
    {
        ModificarConciertos mc;
        public ModificarRepertorio(ModificarConciertos m)
        {
            mc = m;
            InitializeComponent();
        }

        private void ModificarRepertorio_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            mc.Show();
            this.Hide();
           
        }
    }
}
