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
            LlenarCombobox(modCancionCombo);
            LlenarComboboxInterpretes(INTER_Combo);
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
            SqlDataReader datos = bd.ObtenerTabla("SELECT c.Nombre, c.NombreInterprete  FROM  Repertorio r join Anunciante a ON r.NombreAn = a.NombreAn join Cancion c ON c.Nombre = r.NombreCancion Where a.NombreAn ='" + menu.nombreAn + "';");
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

        private void LlenarComboboxInterpretes(ComboBox combobox)
        {
            SqlDataReader datos = bd.ObtenerTabla("select Nombre from InterpreteOriginal");
            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
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

        private void modCancionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void botonModificar_Click(object sender, EventArgs e)
        {
            if (modCancionCombo.Text != "Seleccione" && TB_NOMB.Text != null && INTER_Combo.Text != "Seleccione" && TB_AÑO.Text != null)
            {
                int nAño = int.Parse(TB_AÑO.Text);
                string[] nomb = modCancionCombo.Text.Split(' ');
                bd.ActualizarDatos("Update Cancion set Nombre = '" + TB_NOMB.Text + "' , Año = " + nAño + ", NombreInterprete = '" + INTER_Combo.Text + "' " +
                    "WHERE Nombre in " +
                "(Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' " +
                "and r.NombreCancion = '" + TB_NOMB.Text + "' and r.NombreInterprete = '" + nomb[0] + "');");

            }
            else
            {
                MessageBox.Show("Debe completar todos los espacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            if (modCancionCombo.Text != "Seleccione"){
                string[] nomb = modCancionCombo.Text.Split(' ');
                if (TB_NOMB.Text != "" && TB_AÑO.Text == "" && INTER_Combo.Text == "Seleccione") //caso 1
                {
                    // MessageBox.Show("nombreAn: "+ menu.nombreAn + "/ nmC: "+ nomb[0]+ "/ nomI: " + nomb[2], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bd.ActualizarDatos("Update Cancion set Nombre = '" + TB_NOMB.Text + "'WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nomb[0] + "'  and r.NombreInterprete = '" + nomb[2] + "'); ");
                }
                else if (TB_NOMB.Text == "" && TB_AÑO.Text != "" && INTER_Combo.Text == "Seleccione") //caso 2
                {
                    int nAño = int.Parse(TB_AÑO.Text);
                    bd.ActualizarDatos("Update Cancion set Año = '" + nAño + "'WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nomb[0] + "'  and r.NombreInterprete = '" + nomb[2] + "'); ");
                }
                else if (TB_NOMB.Text == "" && TB_AÑO.Text == "" && INTER_Combo.Text != "Seleccione") { //caso 3
                    bd.ActualizarDatos("Update Cancion set NombreInterprete = '" + INTER_Combo.Text + "'WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nomb[0] + "'  and r.NombreInterprete = '" + nomb[2] + "'); ");

                } else if (TB_NOMB.Text != "" && TB_AÑO.Text != "" && INTER_Combo.Text != "Seleccione") { //caso 4
                    int nAño = int.Parse(TB_AÑO.Text);
                    bd.ActualizarDatos("Update Cancion set NombreInterprete = '" + INTER_Combo.Text + "', Año = '" + nAño + "', Nombre = '" + TB_NOMB.Text + "' WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nomb[0] + "'  and r.NombreInterprete = '" + nomb[2] + "'); ");
                } else if (TB_NOMB.Text != "" && TB_AÑO.Text == "" && INTER_Combo.Text != "Seleccione") { //caso 5
                    bd.ActualizarDatos("Update Cancion set NombreInterprete = '" + INTER_Combo.Text + "', Nombre = '" + TB_NOMB.Text + "' WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nomb[0] + "'  and r.NombreInterprete = '" + nomb[2] + "'); ");
                } else if (TB_NOMB.Text == "" && TB_AÑO.Text != "" && INTER_Combo.Text != "Seleccione") { //caso 6
                    int nAño = int.Parse(TB_AÑO.Text);
                    bd.ActualizarDatos("Update Cancion set NombreInterprete = '" + INTER_Combo.Text + "', Año = '" + nAño + "' WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nomb[0] + "'  and r.NombreInterprete = '" + nomb[2] + "'); ");
                } else if (TB_NOMB.Text != "" && TB_AÑO.Text != "" && INTER_Combo.Text == "Seleccione") { //caso 7
                    int nAño = int.Parse(TB_AÑO.Text);
                    bd.ActualizarDatos("Update Cancion set Nombre = '" + TB_NOMB.Text + "', Año = '" + nAño + "' WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nomb[0] + "'  and r.NombreInterprete = '" + nomb[2] + "'); ");
                }
                else if (TB_NOMB.Text == "" && TB_AÑO.Text == "" && INTER_Combo.Text == "Seleccione") { //caso 8
                    //nada
                }
                TB_NOMB.Clear(); INTER_Combo.Items.Clear(); TB_AÑO.Clear(); modCancionCombo.Items.Clear(); elCancionCombo.Items.Clear();
                MessageBox.Show("Se modificó exitosamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarComboboxInterpretes(INTER_Combo); LlenarCombobox(modCancionCombo); LlenarCombobox(elCancionCombo);

            }
            else
            {
                MessageBox.Show("Debe seleccionar una canción", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonAgregarInterprete_Click(object sender, EventArgs e)
        {
            string interpreteNuevo = agregarInterpreteBox.Text;

            agregarInterpreteBox.Text = "";

            AccesoBaseDatos bd = new AccesoBaseDatos();
            bd.ActualizarDatos("exec agregarInterprete @nombre = '" + interpreteNuevo + "';");


            agregarInterpreteBox.Text = "";
            INTER_Combo.Items.Clear();

            LlenarComboboxInterpretes(INTER_Combo);
        }

        private void agregarInterpreteBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = elCancionCombo.Text;
            string[] nIter = nombre.Split(' ');
            // MessageBox.Show("nombreAn: "+ menu.nombreAn + " nombreC: " + nIter[0] + " nombre Int: " + nIter[1], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //bd.ActualizarDatos("exec eliminarCancion @nombreAn = '" + menu.nombreAn + "', @nombreC = '" + nombC + "' , @nombreI = '" + nombI + "';");
            bd.ActualizarDatos("Delete FROM Cancion WHERE Nombre in (Select r.NombreCancion from Repertorio r where r.NombreAn = '" + menu.nombreAn + "' and r.NombreCancion = '" + nIter[0] + "' and r.NombreInterprete = '" + nIter[2] + "');");
            MessageBox.Show("Se eliminó exitosamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            elCancionCombo.Items.Clear();
            modCancionCombo.Items.Clear();
            LlenarCombobox(elCancionCombo); LlenarCombobox(modCancionCombo);
        }
    }
}