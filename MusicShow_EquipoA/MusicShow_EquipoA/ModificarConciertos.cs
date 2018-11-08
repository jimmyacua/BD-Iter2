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
    public partial class ModificarConciertos : MetroForm
    {
        MenuAnunciante menu;
        AccesoBaseDatos bd;
        public string nombreConcierto;
        public string nombreAn;
        public ModificarConciertos(MenuAnunciante m)
        {
            menu = m;
            nombreAn = menu.nombreAn;
            bd = new AccesoBaseDatos();
            InitializeComponent();
        }

        private void ModificarConciertos_Load(object sender, EventArgs e)
        {
            LlenarCombobox(comboEliminar, "select NombreConcierto from Concierto where NombreAn = '"+menu.nombreAn+"'");
            LlenarCombobox(nombConc, "select c.NombreConcierto FROM Concierto c where c.NombreAn = '"+menu.nombreAn+"';");
            LlenarCombobox(comboLugar, "select NombreLugar from Lugar");
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            if(nombConc.Text != "Seleccione")
            {
                ModificarRepertorio m = new ModificarRepertorio(this);
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar un concierto!", "Modificar Repertorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LlenarCombobox(ComboBox combobox, string consulta)
        {
            SqlDataReader datos = bd.ObtenerTabla(consulta);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboEliminar.Text != "Seleccione")
            {
                bd.ActualizarDatos("delete from Concierto where NombreConcierto = '" + comboEliminar.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                MessageBox.Show("Se eliminó exitosamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEliminar.Items.Clear();
                LlenarCombobox(comboEliminar, "select NombreConcierto from Concierto where NombreAn = '" + menu.nombreAn + "'");
                nombConc.Items.Clear();
                LlenarCombobox(nombConc, "select c.NombreConcierto FROM Concierto c where c.NombreAn = '" + menu.nombreAn + "';");
            }
            else {
                MessageBox.Show("¡Debe seleccionar un concierto!", "Eliminar concierto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreConcierto = nombConc.Text;
            comboLugar.Items.Clear();
            LlenarCombobox(comboLugar, "select NombreLugar from  Lugar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nombConc.Text != "Seleccione") {
                if (nombre.Text != "" && cupo.Text == "" && descripcion.Text == "" && comboLugar.Text == "Seleccione") //caso 1
                {
                    bd.ActualizarDatos("update Concierto set NombreConcierto = '" + nombre.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text == "" && cupo.Text != "" && descripcion.Text == "" && comboLugar.Text == "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set Cupo = '" + cupo.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text == "" && cupo.Text == "" && descripcion.Text != "" && comboLugar.Text == "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set Descripcion = '" + descripcion.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text == "" && cupo.Text == "" && descripcion.Text == "" && comboLugar.Text != "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set NombreLugar = '" + comboLugar.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text != "" && cupo.Text != "" && descripcion.Text == "" && comboLugar.Text == "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set NombreConcierto = '" + nombre.Text + "', Cupo = '" + cupo.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text != "" && cupo.Text == "" && descripcion.Text != "" && comboLugar.Text == "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set NombreConcierto = '" + nombre.Text + "', Descripcion = '" + descripcion.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text != "" && cupo.Text == "" && descripcion.Text == "" && comboLugar.Text != "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set NombreConcierto = '" + nombre.Text + "', NombreLugar = '" + comboLugar.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text != "" && cupo.Text != "" && descripcion.Text != "" && comboLugar.Text != "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set NombreConcierto = '" + nombre.Text + "', NombreLugar = '" + comboLugar.Text + "', Cupo = '" + cupo.Text + "', Descripcion = '" + descripcion.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text == "" && cupo.Text != "" && descripcion.Text != "" && comboLugar.Text == "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set Cupo = '" + cupo.Text + "', Descripcion = '" + descripcion.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text == "" && cupo.Text != "" && descripcion.Text == "" && comboLugar.Text != "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set NombreLugar = '" + comboLugar.Text + "', Cupo = '" + cupo.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text == "" && cupo.Text == "" && descripcion.Text != "" && comboLugar.Text != "Seleccione")
                {
                    bd.ActualizarDatos("update Concierto set NombreLugar = '" + comboLugar.Text + "', Descripcion = '" + descripcion.Text + "' where NombreConcierto = '" + nombConc.Text + "' and NombreAn = '" + menu.nombreAn + "'");
                }
                else if (nombre.Text == "" && cupo.Text == "" && descripcion.Text == "" && comboLugar.Text == "Seleccione")
                {
                    MessageBox.Show("No se llenaron los campos, no se modificó", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                nombre.Clear(); cupo.Clear(); descripcion.Clear(); comboLugar.Items.Clear(); nombConc.Items.Clear(); comboEliminar.Items.Clear();
                MessageBox.Show("El concierto se modificó exitosamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCombobox(comboEliminar, "select NombreConcierto from Concierto where NombreAn = '" + menu.nombreAn + "'");
                LlenarCombobox(nombConc, "select c.NombreConcierto FROM Concierto c where c.NombreAn = '" + menu.nombreAn + "';");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un concierto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            AgregarLugar a = new AgregarLugar(this);
            a.Show();
            this.Hide();
            
        }

        public void recargar() {
            comboLugar.Items.Clear();
            LlenarCombobox(comboLugar, "select NombreLugar from  Lugar");
        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            if (nombConc.Text != "Seleccione")
            {
                FechasModConc f = new FechasModConc(this);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un concierto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
