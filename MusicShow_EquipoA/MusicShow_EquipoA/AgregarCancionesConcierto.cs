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
    public partial class AgregarCancionesConcierto : MetroForm
    {
        agregarFecha af;
        string nombre;
        int cupo;
        string descripcion;
        string lugar;
        string[] vectorFechas = new string[50];
        string[] vectorCanciones = new string[50];
        string[] vectorInterpretes = new string[50];
        string[] vectorEntradasCategorias = new string[50];
        string[] vectorEntradasPrecio = new string[50];
        string[] vectorBoleteria = new string[50];
        string nombreAnunciante;
        SqlDataReader datos;

        int contador = 0;//contador para iterar canciones
        int contadorEntradas = 0;

        // Variables - Entradas
        string tipoEntrada;
        string precioEntrada;
        string boleteria;

        public MenuAnunciante menuFinal;

        public AgregarCancionesConcierto(agregarFecha a)
        {
            af = a;

            menuFinal = af.menuNuevo;
            nombreAnunciante = af.nombreAnunciante;


            InitializeComponent();

            gridAgregarC.Columns.Add("Nombre", "nombre");
            gridAgregarC.Columns.Add("Interprete original", "Interprete original");


            gridEntradas.Columns.Add("Tipo", "Tipo");
            gridEntradas.Columns.Add("Precio", "Precio");
            gridEntradas.Columns.Add("Boleteria", "Boleteria");


        }

        private void AgregarCancionesConcierto_Load(object sender, EventArgs e)
        {
            LlenarCombobox(comboBoxReper, "select NombreCancion, NombreInterprete from Repertorio where NombreAn = '" + nombreAnunciante +"';");
            LlenarCombobox2(comboBoxBoleteria, "select * from Boleteria;");
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void LlenarCombobox(ComboBox combobox, string consulta)
        {

            AccesoBaseDatos bd;
            bd = new AccesoBaseDatos();
            datos = bd.ObtenerTabla(consulta);

            int cont = 0;

            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
                    vectorInterpretes[cont] = datos.GetValue(1).ToString();
                    cont++;
                }
            }
            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }
            combobox.SelectedIndex = 0;
        }

        private void LlenarCombobox2(ComboBox combobox, string consulta)
        {

            AccesoBaseDatos bd;
            bd = new AccesoBaseDatos();
            datos = bd.ObtenerTabla(consulta);

    

            if (datos != null)
            {
                combobox.Items.Add("Seleccione");
                while (datos.Read())
                {
                    combobox.Items.Add(datos.GetValue(0));
  

                }
            }
            else
            {
                combobox.Items.Clear();
                combobox.Items.Add("Seleccione");
            }
            combobox.SelectedIndex = 0;
        }




        public void actualizarCombo()
        {
            comboBoxBoleteria.Items.Clear();
            LlenarCombobox(comboBoxBoleteria, "select * from Boleteria;");
        }





        private void metroLink1_Click(object sender, EventArgs e)
        {
            af.Show();
            this.Hide();
        }

        public void setDatos(string n, string d, string l, int c, string[]v)
        {
            nombre = n;
            descripcion = d;
            lugar = l;
            cupo = c;
            vectorFechas = v;

            labelNombre.Text = nombre;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int index = comboBoxReper.SelectedIndex -1;//aqui
            string cancion = comboBoxReper.Text;


            int contadorT = 0;
            bool esta = false;

            while (!esta && contadorT < 50)
            {
                if (vectorCanciones[contadorT] == cancion)
                {
                    esta = true;
                }
                contadorT++;
            }

            if (!esta)
            {
                vectorCanciones[contador] = cancion;

                DataGridViewRow row2 = (DataGridViewRow)gridAgregarC.Rows[0].Clone();
                gridAgregarC.Rows.Add(row2);

                gridAgregarC.Rows[contador].Cells[0].Value = vectorCanciones[contador];
                gridAgregarC.Rows[contador].Cells[1].Value = vectorInterpretes[index];

                contador++;
            }
        }

        private void textBoxTipo_Click(object sender, EventArgs e)
        {

        }

        private void botonAgregarEntrada_Click(object sender, EventArgs e)
        {
            tipoEntrada = textBoxTipo.Text;
            precioEntrada = textBoxPrecio.Text;
            boleteria = comboBoxBoleteria.Text;



            int contadorT = 0;
            bool esta = false;

            while (!esta && contadorT < 50)
            {
                
               
                contadorT++;
            }

            if (!esta)
            {
                DataGridViewRow row = (DataGridViewRow)gridEntradas.Rows[0].Clone();
                gridEntradas.Rows.Add(row);

                gridEntradas.Rows[contadorEntradas].Cells[0].Value = tipoEntrada;
                gridEntradas.Rows[contadorEntradas].Cells[1].Value = precioEntrada;
                gridEntradas.Rows[contadorEntradas].Cells[2].Value = boleteria;

                vectorEntradasCategorias[contadorEntradas] = tipoEntrada;
                vectorEntradasPrecio[contadorEntradas] = precioEntrada;
                vectorBoleteria[contadorEntradas] = boleteria;            // Revisar

                contadorEntradas++;

                textBoxTipo.Text = "";
                textBoxPrecio.Text = "";
                comboBoxBoleteria.SelectedIndex = 0;
            }
            
        }

        private void botonEntrada_Click(object sender, EventArgs e)
        {
            AgregarBoleteria ab = new AgregarBoleteria(this);
            ab.Show();
            this.Hide();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            AccesoBaseDatos bd = new AccesoBaseDatos();


            bd.ActualizarDatos("exec agregarConcierto @nombre = '" + nombre + "', @nombreAn = '" + nombreAnunciante + "', @cupo = " + cupo + ", @descripcion = '" + descripcion + "', @lugar = '" + lugar +"';");

            int indiceFH = 0;

            while (vectorFechas[indiceFH] != null){


            bd.ActualizarDatos("insert into Fecha_Hora(NombreConcierto, NombreAn, Fecha_Hora) values('"+ nombre +"','"+ nombreAnunciante  +"','"+ vectorFechas[indiceFH] + "');");

                indiceFH++;

            }


            // Introduce a la DB los tipos de entrada conjunto a sus precios
            int indiceEntradas = 0;

            while (vectorEntradasCategorias[indiceEntradas] != null && vectorEntradasCategorias[indiceEntradas] != null)
            {


                bd.ActualizarDatos("insert into Entrada(Categoria, Precio, NombreConcierto, NombreAn) values('" + vectorEntradasCategorias[indiceEntradas] + "', " + vectorEntradasPrecio[indiceEntradas] + ", '" + nombre + "', '" + nombreAnunciante + "');");

                bd.ActualizarDatos("insert into Se_Consigue(NombreBoleteria, TipoEntrada, NombreConcierto, NombreAn) values('"+vectorBoleteria[indiceEntradas]+"', '"+vectorEntradasCategorias[indiceEntradas]+"', '"+ nombre +"', '"+nombreAnunciante +"');");

                indiceEntradas++;

            }

            
            int indiceCanciones = 0;

            while (vectorCanciones[indiceCanciones] != null)
            {

                bd.ActualizarDatos("insert into Se_Tocan values('"+ nombre +"', '"+ nombreAnunciante +"', '"+ vectorCanciones[indiceCanciones] +"', '"+vectorInterpretes[indiceCanciones]+"')");

                indiceCanciones++;


            }

            menuFinal.Show();
            this.Hide();
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
