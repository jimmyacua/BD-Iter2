﻿using System;
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
    public partial class AgregarCancionesConcierto : MetroForm
    {
        agregarFecha af;

        public AgregarCancionesConcierto(agregarFecha a)
        {
            af = a;
            InitializeComponent();
        }

        private void AgregarCancionesConcierto_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            af.Show();
            this.Hide();
        }
    }
}
