namespace MusicShow_EquipoA
{
    partial class AgregarCanciones
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.nombreCancionBox = new MetroFramework.Controls.MetroTextBox();
            this.añoCancionBox = new MetroFramework.Controls.MetroTextBox();
            this.agregarInterpreteBox = new MetroFramework.Controls.MetroTextBox();
            this.gridCanciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxIdioma = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxGenero = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxInterprete = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.botonAgregarInterprete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nombre de la canción";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 227);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Intérprete orignal";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 172);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Año (canción original)";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // nombreCancionBox
            // 
            // 
            // 
            // 
            this.nombreCancionBox.CustomButton.Image = null;
            this.nombreCancionBox.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.nombreCancionBox.CustomButton.Name = "";
            this.nombreCancionBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nombreCancionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombreCancionBox.CustomButton.TabIndex = 1;
            this.nombreCancionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombreCancionBox.CustomButton.UseSelectable = true;
            this.nombreCancionBox.CustomButton.Visible = false;
            this.nombreCancionBox.Lines = new string[0];
            this.nombreCancionBox.Location = new System.Drawing.Point(189, 127);
            this.nombreCancionBox.MaxLength = 30;
            this.nombreCancionBox.Name = "nombreCancionBox";
            this.nombreCancionBox.PasswordChar = '\0';
            this.nombreCancionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombreCancionBox.SelectedText = "";
            this.nombreCancionBox.SelectionLength = 0;
            this.nombreCancionBox.SelectionStart = 0;
            this.nombreCancionBox.ShortcutsEnabled = true;
            this.nombreCancionBox.Size = new System.Drawing.Size(175, 23);
            this.nombreCancionBox.TabIndex = 5;
            this.nombreCancionBox.UseSelectable = true;
            this.nombreCancionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombreCancionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nombreCancionBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // añoCancionBox
            // 
            // 
            // 
            // 
            this.añoCancionBox.CustomButton.Image = null;
            this.añoCancionBox.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.añoCancionBox.CustomButton.Name = "";
            this.añoCancionBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.añoCancionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.añoCancionBox.CustomButton.TabIndex = 1;
            this.añoCancionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.añoCancionBox.CustomButton.UseSelectable = true;
            this.añoCancionBox.CustomButton.Visible = false;
            this.añoCancionBox.Lines = new string[0];
            this.añoCancionBox.Location = new System.Drawing.Point(189, 170);
            this.añoCancionBox.MaxLength = 4;
            this.añoCancionBox.Name = "añoCancionBox";
            this.añoCancionBox.PasswordChar = '\0';
            this.añoCancionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.añoCancionBox.SelectedText = "";
            this.añoCancionBox.SelectionLength = 0;
            this.añoCancionBox.SelectionStart = 0;
            this.añoCancionBox.ShortcutsEnabled = true;
            this.añoCancionBox.Size = new System.Drawing.Size(175, 23);
            this.añoCancionBox.TabIndex = 6;
            this.añoCancionBox.UseSelectable = true;
            this.añoCancionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.añoCancionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.añoCancionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.añoCancionBox_KeyPress);
            // 
            // agregarInterpreteBox
            // 
            // 
            // 
            // 
            this.agregarInterpreteBox.CustomButton.Image = null;
            this.agregarInterpreteBox.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.agregarInterpreteBox.CustomButton.Name = "";
            this.agregarInterpreteBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.agregarInterpreteBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.agregarInterpreteBox.CustomButton.TabIndex = 1;
            this.agregarInterpreteBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.agregarInterpreteBox.CustomButton.UseSelectable = true;
            this.agregarInterpreteBox.CustomButton.Visible = false;
            this.agregarInterpreteBox.Lines = new string[0];
            this.agregarInterpreteBox.Location = new System.Drawing.Point(189, 282);
            this.agregarInterpreteBox.MaxLength = 30;
            this.agregarInterpreteBox.Name = "agregarInterpreteBox";
            this.agregarInterpreteBox.PasswordChar = '\0';
            this.agregarInterpreteBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.agregarInterpreteBox.SelectedText = "";
            this.agregarInterpreteBox.SelectionLength = 0;
            this.agregarInterpreteBox.SelectionStart = 0;
            this.agregarInterpreteBox.ShortcutsEnabled = true;
            this.agregarInterpreteBox.Size = new System.Drawing.Size(175, 23);
            this.agregarInterpreteBox.TabIndex = 7;
            this.agregarInterpreteBox.UseSelectable = true;
            this.agregarInterpreteBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.agregarInterpreteBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.agregarInterpreteBox.Click += new System.EventHandler(this.interpreteCancionBox_Click);
            // 
            // gridCanciones
            // 
            this.gridCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCanciones.Location = new System.Drawing.Point(13, 23);
            this.gridCanciones.Name = "gridCanciones";
            this.gridCanciones.Size = new System.Drawing.Size(541, 281);
            this.gridCanciones.TabIndex = 8;
            this.gridCanciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCanciones_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridCanciones);
            this.groupBox1.Location = new System.Drawing.Point(476, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 323);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canciones actuales";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(95, 457);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 10;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(967, 24);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 11;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(33, 341);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Idioma";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.ItemHeight = 23;
            this.comboBoxIdioma.Location = new System.Drawing.Point(189, 334);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(175, 29);
            this.comboBoxIdioma.TabIndex = 13;
            this.comboBoxIdioma.UseSelectable = true;
            this.comboBoxIdioma.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdioma_SelectedIndexChanged);
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.ItemHeight = 23;
            this.comboBoxGenero.Location = new System.Drawing.Point(189, 379);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(175, 29);
            this.comboBoxGenero.TabIndex = 15;
            this.comboBoxGenero.UseSelectable = true;
            this.comboBoxGenero.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenero_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 384);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Género";
            // 
            // comboBoxInterprete
            // 
            this.comboBoxInterprete.FormattingEnabled = true;
            this.comboBoxInterprete.ItemHeight = 23;
            this.comboBoxInterprete.Location = new System.Drawing.Point(189, 227);
            this.comboBoxInterprete.Name = "comboBoxInterprete";
            this.comboBoxInterprete.Size = new System.Drawing.Size(175, 29);
            this.comboBoxInterprete.TabIndex = 16;
            this.comboBoxInterprete.UseSelectable = true;
            this.comboBoxInterprete.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterprete_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(189, 205);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Existente";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(33, 282);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(120, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "¿Nuevo intérprete?";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // botonAgregarInterprete
            // 
            this.botonAgregarInterprete.Location = new System.Drawing.Point(381, 278);
            this.botonAgregarInterprete.Name = "botonAgregarInterprete";
            this.botonAgregarInterprete.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarInterprete.TabIndex = 19;
            this.botonAgregarInterprete.Text = "Agregar interprete";
            this.botonAgregarInterprete.UseVisualStyleBackColor = true;
            this.botonAgregarInterprete.Click += new System.EventHandler(this.botonAgregarInterprete_Click);
            // 
            // AgregarCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 537);
            this.Controls.Add(this.botonAgregarInterprete);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.comboBoxInterprete);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.agregarInterpreteBox);
            this.Controls.Add(this.añoCancionBox);
            this.Controls.Add(this.nombreCancionBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AgregarCanciones";
            this.Text = "Agregar Canciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCanciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox nombreCancionBox;
        private MetroFramework.Controls.MetroTextBox añoCancionBox;
        private MetroFramework.Controls.MetroTextBox agregarInterpreteBox;
        private System.Windows.Forms.DataGridView gridCanciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonAgregar;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox comboBoxIdioma;
        private MetroFramework.Controls.MetroComboBox comboBoxGenero;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox comboBoxInterprete;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Button botonAgregarInterprete;
    }
}