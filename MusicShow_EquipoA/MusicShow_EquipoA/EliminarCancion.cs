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
    public partial class EliminarCancion : MetroForm
    {
        MenuAnunciante menu;
        AccesoBaseDatos bd;
        string nombI, nombC;
        
        public EliminarCancion(MenuAnunciante m)
        {
            menu = m;
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }

        private void EliminarCancion_Load(object sender, EventArgs e)
        {
            LlenarCombobox(elCancionCombo);
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void elCancionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LlenarCombobox(ComboBox combobox)
        {
            SqlDataReader datos = bd.ObtenerTabla("SELECT c.Nombre, c.NombreInterprete  FROM  Repertorio r join Anunciante a ON r.NombreAn = a.NombreAn join Cancion c ON c.Nombre = r.NombreCancion Where a.NombreAn ='" + menu.nombreAn +"';");
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    nombC = datos.GetValue(0).ToString();
                    nombI = datos.GetValue(1).ToString();
                    combobox.Items.Add(datos.GetValue(0) + " - " + datos.GetValue(1));
                    //combobox.Items.Add(datos.GetValue(1));
                }
            }
            /* Si no hay tuplas en la base de datos se limpia el combobox y se
            carga unicamente el valor "Seleccione"*/
            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }
            // Se pone por defecto la primera entrada del combobox seleccionada
            combobox.SelectedIndex = 0;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = elCancionCombo.Text;
            string[] nIter = nombre.Split('-');
            // MessageBox.Show("nombreAn: "+ menu.nombreAn + " nombreC: " + nIter[0] + " nombre Int: " + nIter[1], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
             //bd.ActualizarDatos("exec eliminarCancion @nombreAn = '" + menu.nombreAn + "', @nombreC = '" + nombC + "' , @nombreI = '" + nombI + "';");
            bd.ActualizarDatos("Delete FROM Cancion WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nombC + "' and r.NombreInterprete = '" + nombI+ "');");
            elCancionCombo.Items.Clear();
            LlenarCombobox(elCancionCombo);
        }
    }
}
