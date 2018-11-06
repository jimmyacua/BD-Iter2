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
            this.interpreteCancionBox = new MetroFramework.Controls.MetroTextBox();
            this.gridCanciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxIdioma = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxGenero = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
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
            this.metroLabel2.Location = new System.Drawing.Point(33, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Intérprete orignal";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 197);
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
            this.nombreCancionBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.nombreCancionBox.CustomButton.Name = "";
            this.nombreCancionBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nombreCancionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombreCancionBox.CustomButton.TabIndex = 1;
            this.nombreCancionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombreCancionBox.CustomButton.UseSelectable = true;
            this.nombreCancionBox.CustomButton.Visible = false;
            this.nombreCancionBox.Lines = new string[0];
            this.nombreCancionBox.Location = new System.Drawing.Point(189, 127);
            this.nombreCancionBox.MaxLength = 32767;
            this.nombreCancionBox.Name = "nombreCancionBox";
            this.nombreCancionBox.PasswordChar = '\0';
            this.nombreCancionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombreCancionBox.SelectedText = "";
            this.nombreCancionBox.SelectionLength = 0;
            this.nombreCancionBox.SelectionStart = 0;
            this.nombreCancionBox.ShortcutsEnabled = true;
            this.nombreCancionBox.Size = new System.Drawing.Size(75, 23);
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
            this.añoCancionBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.añoCancionBox.CustomButton.Name = "";
            this.añoCancionBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.añoCancionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.añoCancionBox.CustomButton.TabIndex = 1;
            this.añoCancionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.añoCancionBox.CustomButton.UseSelectable = true;
            this.añoCancionBox.CustomButton.Visible = false;
            this.añoCancionBox.Lines = new string[0];
            this.añoCancionBox.Location = new System.Drawing.Point(189, 197);
            this.añoCancionBox.MaxLength = 32767;
            this.añoCancionBox.Name = "añoCancionBox";
            this.añoCancionBox.PasswordChar = '\0';
            this.añoCancionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.añoCancionBox.SelectedText = "";
            this.añoCancionBox.SelectionLength = 0;
            this.añoCancionBox.SelectionStart = 0;
            this.añoCancionBox.ShortcutsEnabled = true;
            this.añoCancionBox.Size = new System.Drawing.Size(75, 23);
            this.añoCancionBox.TabIndex = 6;
            this.añoCancionBox.UseSelectable = true;
            this.añoCancionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.añoCancionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // interpreteCancionBox
            // 
            // 
            // 
            // 
            this.interpreteCancionBox.CustomButton.Image = null;
            this.interpreteCancionBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.interpreteCancionBox.CustomButton.Name = "";
            this.interpreteCancionBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.interpreteCancionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.interpreteCancionBox.CustomButton.TabIndex = 1;
            this.interpreteCancionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.interpreteCancionBox.CustomButton.UseSelectable = true;
            this.interpreteCancionBox.CustomButton.Visible = false;
            this.interpreteCancionBox.Lines = new string[0];
            this.interpreteCancionBox.Location = new System.Drawing.Point(189, 162);
            this.interpreteCancionBox.MaxLength = 32767;
            this.interpreteCancionBox.Name = "interpreteCancionBox";
            this.interpreteCancionBox.PasswordChar = '\0';
            this.interpreteCancionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.interpreteCancionBox.SelectedText = "";
            this.interpreteCancionBox.SelectionLength = 0;
            this.interpreteCancionBox.SelectionStart = 0;
            this.interpreteCancionBox.ShortcutsEnabled = true;
            this.interpreteCancionBox.Size = new System.Drawing.Size(75, 23);
            this.interpreteCancionBox.TabIndex = 7;
            this.interpreteCancionBox.UseSelectable = true;
            this.interpreteCancionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.interpreteCancionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gridCanciones
            // 
            this.gridCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCanciones.Location = new System.Drawing.Point(21, 25);
            this.gridCanciones.Name = "gridCanciones";
            this.gridCanciones.Size = new System.Drawing.Size(465, 298);
            this.gridCanciones.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridCanciones);
            this.groupBox1.Location = new System.Drawing.Point(365, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 323);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canciones actuales";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(98, 378);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 10;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(796, 23);
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
            this.metroLabel4.Location = new System.Drawing.Point(33, 243);
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
            this.comboBoxIdioma.Location = new System.Drawing.Point(189, 240);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(121, 29);
            this.comboBoxIdioma.TabIndex = 13;
            this.comboBoxIdioma.UseSelectable = true;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.ItemHeight = 23;
            this.comboBoxGenero.Location = new System.Drawing.Point(189, 285);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(121, 29);
            this.comboBoxGenero.TabIndex = 15;
            this.comboBoxGenero.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 288);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(52, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Género";
            // 
            // AgregarCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 473);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.interpreteCancionBox);
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
        private MetroFramework.Controls.MetroTextBox interpreteCancionBox;
        private System.Windows.Forms.DataGridView gridCanciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonAgregar;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox comboBoxIdioma;
        private MetroFramework.Controls.MetroComboBox comboBoxGenero;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}