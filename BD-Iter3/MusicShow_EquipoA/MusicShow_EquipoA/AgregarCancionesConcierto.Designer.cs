namespace MusicShow_EquipoA
{
    partial class AgregarCancionesConcierto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridAgregarC = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxReper = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.botonEntrada = new MetroFramework.Controls.MetroButton();
            this.comboBoxBoleteria = new MetroFramework.Controls.MetroComboBox();
            this.gridEntradas = new System.Windows.Forms.DataGridView();
            this.botonAgregarEntrada = new MetroFramework.Controls.MetroButton();
            this.textBoxPrecio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.textBoxTipo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.labelNombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgregarC)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridAgregarC);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.comboBoxReper);
            this.groupBox2.Location = new System.Drawing.Point(23, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 333);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione canciones para su concierto";
            // 
            // gridAgregarC
            // 
            this.gridAgregarC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAgregarC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAgregarC.Location = new System.Drawing.Point(6, 110);
            this.gridAgregarC.Name = "gridAgregarC";
            this.gridAgregarC.Size = new System.Drawing.Size(369, 217);
            this.gridAgregarC.TabIndex = 3;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(211, 53);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 29);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Agregar canción";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(34, 28);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(73, 19);
            this.metroLabel11.TabIndex = 1;
            this.metroLabel11.Text = "Repertorio";
            // 
            // comboBoxReper
            // 
            this.comboBoxReper.FormattingEnabled = true;
            this.comboBoxReper.ItemHeight = 23;
            this.comboBoxReper.Location = new System.Drawing.Point(34, 53);
            this.comboBoxReper.Name = "comboBoxReper";
            this.comboBoxReper.Size = new System.Drawing.Size(156, 29);
            this.comboBoxReper.TabIndex = 0;
            this.comboBoxReper.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.botonEntrada);
            this.groupBox3.Controls.Add(this.comboBoxBoleteria);
            this.groupBox3.Controls.Add(this.gridEntradas);
            this.groupBox3.Controls.Add(this.botonAgregarEntrada);
            this.groupBox3.Controls.Add(this.textBoxPrecio);
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.textBoxTipo);
            this.groupBox3.Controls.Add(this.metroLabel12);
            this.groupBox3.Location = new System.Drawing.Point(420, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 393);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entradas";
            // 
            // botonEntrada
            // 
            this.botonEntrada.Location = new System.Drawing.Point(314, 119);
            this.botonEntrada.Name = "botonEntrada";
            this.botonEntrada.Size = new System.Drawing.Size(112, 29);
            this.botonEntrada.TabIndex = 4;
            this.botonEntrada.Text = "Agregar boleteria";
            this.botonEntrada.UseSelectable = true;
            this.botonEntrada.Click += new System.EventHandler(this.botonEntrada_Click);
            // 
            // comboBoxBoleteria
            // 
            this.comboBoxBoleteria.FormattingEnabled = true;
            this.comboBoxBoleteria.ItemHeight = 23;
            this.comboBoxBoleteria.Location = new System.Drawing.Point(162, 120);
            this.comboBoxBoleteria.Name = "comboBoxBoleteria";
            this.comboBoxBoleteria.Size = new System.Drawing.Size(121, 29);
            this.comboBoxBoleteria.TabIndex = 37;
            this.comboBoxBoleteria.UseSelectable = true;
            // 
            // gridEntradas
            // 
            this.gridEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEntradas.Location = new System.Drawing.Point(6, 160);
            this.gridEntradas.Name = "gridEntradas";
            this.gridEntradas.Size = new System.Drawing.Size(463, 173);
            this.gridEntradas.TabIndex = 4;
            // 
            // botonAgregarEntrada
            // 
            this.botonAgregarEntrada.Location = new System.Drawing.Point(186, 339);
            this.botonAgregarEntrada.Name = "botonAgregarEntrada";
            this.botonAgregarEntrada.Size = new System.Drawing.Size(110, 29);
            this.botonAgregarEntrada.TabIndex = 36;
            this.botonAgregarEntrada.Text = "Agregar entrada";
            this.botonAgregarEntrada.UseSelectable = true;
            this.botonAgregarEntrada.Click += new System.EventHandler(this.botonAgregarEntrada_Click);
            // 
            // textBoxPrecio
            // 
            // 
            // 
            // 
            this.textBoxPrecio.CustomButton.Image = null;
            this.textBoxPrecio.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.textBoxPrecio.CustomButton.Name = "";
            this.textBoxPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPrecio.CustomButton.TabIndex = 1;
            this.textBoxPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPrecio.CustomButton.UseSelectable = true;
            this.textBoxPrecio.CustomButton.Visible = false;
            this.textBoxPrecio.Lines = new string[0];
            this.textBoxPrecio.Location = new System.Drawing.Point(162, 79);
            this.textBoxPrecio.MaxLength = 10;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.PasswordChar = '\0';
            this.textBoxPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPrecio.SelectedText = "";
            this.textBoxPrecio.SelectionLength = 0;
            this.textBoxPrecio.SelectionStart = 0;
            this.textBoxPrecio.ShortcutsEnabled = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(212, 23);
            this.textBoxPrecio.TabIndex = 35;
            this.textBoxPrecio.UseSelectable = true;
            this.textBoxPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Precio";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(6, 119);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(61, 19);
            this.metroLabel10.TabIndex = 30;
            this.metroLabel10.Text = "Boletería";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // textBoxTipo
            // 
            // 
            // 
            // 
            this.textBoxTipo.CustomButton.Image = null;
            this.textBoxTipo.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.textBoxTipo.CustomButton.Name = "";
            this.textBoxTipo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxTipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxTipo.CustomButton.TabIndex = 1;
            this.textBoxTipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxTipo.CustomButton.UseSelectable = true;
            this.textBoxTipo.CustomButton.Visible = false;
            this.textBoxTipo.Lines = new string[0];
            this.textBoxTipo.Location = new System.Drawing.Point(162, 39);
            this.textBoxTipo.MaxLength = 30;
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.PasswordChar = '\0';
            this.textBoxTipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTipo.SelectedText = "";
            this.textBoxTipo.SelectionLength = 0;
            this.textBoxTipo.SelectionStart = 0;
            this.textBoxTipo.ShortcutsEnabled = true;
            this.textBoxTipo.Size = new System.Drawing.Size(212, 23);
            this.textBoxTipo.TabIndex = 33;
            this.textBoxTipo.UseSelectable = true;
            this.textBoxTipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxTipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTipo.Click += new System.EventHandler(this.textBoxTipo_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(6, 39);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(103, 19);
            this.metroLabel12.TabIndex = 32;
            this.metroLabel12.Text = "Tipo de entrada";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(23, 502);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 23;
            this.metroButton3.Text = "Finalizar";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(734, 27);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 33;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(194, 75);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 19);
            this.labelNombre.TabIndex = 38;
            this.labelNombre.Text = "nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Nombre del concierto";
            // 
            // AgregarCancionesConcierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 566);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "AgregarCancionesConcierto";
            this.Text = "Canciones y entradas del concierto";
            this.Load += new System.EventHandler(this.AgregarCancionesConcierto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgregarC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridAgregarC;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox comboBoxReper;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox textBoxPrecio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox textBoxTipo;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox comboBoxBoleteria;
        private System.Windows.Forms.DataGridView gridEntradas;
        private MetroFramework.Controls.MetroButton botonAgregarEntrada;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel labelNombre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton botonEntrada;
    }
}