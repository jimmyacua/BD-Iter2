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
using Lab_Interfaces;
using System.Data.SqlClient;

namespace MusicShow_EquipoA
{
    public partial class ComentarConcierto : MetroForm
    {
        AccesoBaseDatos bd;
        PerfilConcierto perfConc;
        public ComentarConcierto(PerfilConcierto pc)
        {
            perfConc = pc;
            bd = new AccesoBaseDatos();
            InitializeComponent();
        }

        public void LlenarTabla()
        {
            string comentario = "";
            SqlDataReader reader = bd.EjecutarConsulta("select c.Comentario from Comenta c where c.NombreAn = '"+perfConc.nombreAn+"' and c.NombreBusc = '"+perfConc.nombreBusc+"' and c.NombreConc = '"+perfConc.nombreConc+"'");
            while (reader.Read())
            {
                comentario = reader.GetString(0); //The 0 stands for "the 0'th column", so the first column of the result.
                                              // Do somthing with this rows string, for example to put them in to a list
            }
            if (comentario.Equals(""))
            {
                comentBox.Text = "";
                comentBox.Enabled = true;
                elimBoton.Enabled = false;
                agreComent.Enabled = true;
            }
            else {
                comentBox.Text = comentario;
                comentBox.Enabled = false;
                agreComent.Enabled = false;
                elimBoton.Enabled = true;
            }
        }

        private void ComentarConcierto_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }

        private void quitarBoton_Click(object sender, EventArgs e)
        {
            bd.ActualizarDatos("delete from Comenta where NombreAn = '"+perfConc.nombreAn+"' and NombreBusc = '"+perfConc.nombreBusc+"' and NombreConc = '"+ perfConc.nombreConc+ "'");
            LlenarTabla();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            perfConc.Show();
            this.Hide();
        }

        private void agreComent_Click(object sender, EventArgs e)
        {
            if(comentBox.Text != "")
            {
                bd.ActualizarDatos("insert into Comenta  values('" + perfConc.nombreBusc + "', '" + perfConc.nombreConc + "', '" + perfConc.nombreAn + "', '"+ comentBox.Text+"'); ");
                MessageBox.Show("Se agregó su comentario", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*agreComent.Enabled = false;
                comentBox.Enabled = false;
                elimBoton.Enabled = true;*/
                LlenarTabla();
            }
            else
            {
                MessageBox.Show("Debe escribir un comentario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
