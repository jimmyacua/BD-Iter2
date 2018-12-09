namespace MusicShow_EquipoA
{
    partial class CrearPerfilDeBuscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPerfilDeBuscador));
            this.botonGuardar = new MetroFramework.Controls.MetroButton();
            this.Nombre = new MetroFramework.Controls.MetroLabel();
            this.TX_Nombre = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TX_Email = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ComboGenero = new MetroFramework.Controls.MetroComboBox();
            this.ComboIdioma = new MetroFramework.Controls.MetroComboBox();
            this.agregarGenero = new MetroFramework.Controls.MetroButton();
            this.agregarIdioma = new MetroFramework.Controls.MetroButton();
            this.ComboProvincia = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridGenero = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridIdiomas = new System.Windows.Forms.DataGridView();
            this.comboCanton = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.link1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGenero)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIdiomas)).BeginInit();
            this.SuspendLayout();
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(299, 551);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 10;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseSelectable = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(23, 91);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(59, 19);
            this.Nombre.TabIndex = 8;
            this.Nombre.Text = "Nombre";
            // 
            // TX_Nombre
            // 
            // 
            // 
            // 
            this.TX_Nombre.CustomButton.Image = null;
            this.TX_Nombre.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.TX_Nombre.CustomButton.Name = "";
            this.TX_Nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TX_Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TX_Nombre.CustomButton.TabIndex = 1;
            this.TX_Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TX_Nombre.CustomButton.UseSelectable = true;
            this.TX_Nombre.CustomButton.Visible = false;
            this.TX_Nombre.Lines = new string[0];
            this.TX_Nombre.Location = new System.Drawing.Point(195, 91);
            this.TX_Nombre.MaxLength = 30;
            this.TX_Nombre.Name = "TX_Nombre";
            this.TX_Nombre.PasswordChar = '\0';
            this.TX_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TX_Nombre.SelectedText = "";
            this.TX_Nombre.SelectionLength = 0;
            this.TX_Nombre.SelectionStart = 0;
            this.TX_Nombre.ShortcutsEnabled = true;
            this.TX_Nombre.Size = new System.Drawing.Size(264, 23);
            this.TX_Nombre.TabIndex = 7;
            this.TX_Nombre.UseSelectable = true;
            this.TX_Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TX_Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 161);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(146, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Provincia de Residencia";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 241);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Email";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // TX_Email
            // 
            // 
            // 
            // 
            this.TX_Email.CustomButton.Image = null;
            this.TX_Email.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.TX_Email.CustomButton.Name = "";
            this.TX_Email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TX_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TX_Email.CustomButton.TabIndex = 1;
            this.TX_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TX_Email.CustomButton.UseSelectable = true;
            this.TX_Email.CustomButton.Visible = false;
            this.TX_Email.Lines = new string[0];
            this.TX_Email.Location = new System.Drawing.Point(195, 237);
            this.TX_Email.MaxLength = 30;
            this.TX_Email.Name = "TX_Email";
            this.TX_Email.PasswordChar = '\0';
            this.TX_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TX_Email.SelectedText = "";
            this.TX_Email.SelectionLength = 0;
            this.TX_Email.SelectionStart = 0;
            this.TX_Email.ShortcutsEnabled = true;
            this.TX_Email.Size = new System.Drawing.Size(264, 23);
            this.TX_Email.TabIndex = 14;
            this.TX_Email.UseSelectable = true;
            this.TX_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TX_Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(416, 289);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Géneros";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(37, 289);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Idiomas";
            // 
            // ComboGenero
            // 
            this.ComboGenero.FormattingEnabled = true;
            this.ComboGenero.ItemHeight = 23;
            this.ComboGenero.Location = new System.Drawing.Point(488, 283);
            this.ComboGenero.Name = "ComboGenero";
            this.ComboGenero.Size = new System.Drawing.Size(165, 29);
            this.ComboGenero.TabIndex = 17;
            this.ComboGenero.UseSelectable = true;
            // 
            // ComboIdioma
            // 
            this.ComboIdioma.FormattingEnabled = true;
            this.ComboIdioma.ItemHeight = 23;
            this.ComboIdioma.Location = new System.Drawing.Point(109, 283);
            this.ComboIdioma.Name = "ComboIdioma";
            this.ComboIdioma.Size = new System.Drawing.Size(165, 29);
            this.ComboIdioma.TabIndex = 18;
            this.ComboIdioma.UseSelectable = true;
            // 
            // agregarGenero
            // 
            this.agregarGenero.Location = new System.Drawing.Point(678, 285);
            this.agregarGenero.Name = "agregarGenero";
            this.agregarGenero.Size = new System.Drawing.Size(75, 23);
            this.agregarGenero.TabIndex = 19;
            this.agregarGenero.Text = "Agregar";
            this.agregarGenero.UseSelectable = true;
            this.agregarGenero.Click += new System.EventHandler(this.agregarGenero_Click);
            // 
            // agregarIdioma
            // 
            this.agregarIdioma.Location = new System.Drawing.Point(299, 285);
            this.agregarIdioma.Name = "agregarIdioma";
            this.agregarIdioma.Size = new System.Drawing.Size(75, 23);
            this.agregarIdioma.TabIndex = 20;
            this.agregarIdioma.Text = "Agregar";
            this.agregarIdioma.UseSelectable = true;
            this.agregarIdioma.Click += new System.EventHandler(this.agregarIdioma_Click);
            // 
            // ComboProvincia
            // 
            this.ComboProvincia.FormattingEnabled = true;
            this.ComboProvincia.ItemHeight = 23;
            this.ComboProvincia.Location = new System.Drawing.Point(195, 137);
            this.ComboProvincia.Name = "ComboProvincia";
            this.ComboProvincia.Size = new System.Drawing.Size(264, 29);
            this.ComboProvincia.TabIndex = 21;
            this.ComboProvincia.UseSelectable = true;
            this.ComboProvincia.SelectedIndexChanged += new System.EventHandler(this.ComboLugar_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridGenero);
            this.groupBox1.Location = new System.Drawing.Point(416, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 184);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Géneros de preferencia";
            // 
            // gridGenero
            // 
            this.gridGenero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGenero.BackgroundColor = System.Drawing.Color.White;
            this.gridGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGenero.Location = new System.Drawing.Point(6, 19);
            this.gridGenero.Name = "gridGenero";
            this.gridGenero.Size = new System.Drawing.Size(263, 159);
            this.gridGenero.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridIdiomas);
            this.groupBox2.Location = new System.Drawing.Point(37, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 184);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idiomas de preferencia";
            // 
            // gridIdiomas
            // 
            this.gridIdiomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIdiomas.BackgroundColor = System.Drawing.Color.White;
            this.gridIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIdiomas.Location = new System.Drawing.Point(6, 19);
            this.gridIdiomas.Name = "gridIdiomas";
            this.gridIdiomas.Size = new System.Drawing.Size(224, 159);
            this.gridIdiomas.TabIndex = 0;
            this.gridIdiomas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIdiomas_CellContentClick);
            // 
            // comboCanton
            // 
            this.comboCanton.FormattingEnabled = true;
            this.comboCanton.ItemHeight = 23;
            this.comboCanton.Location = new System.Drawing.Point(195, 188);
            this.comboCanton.Name = "comboCanton";
            this.comboCanton.Size = new System.Drawing.Size(264, 29);
            this.comboCanton.TabIndex = 25;
            this.comboCanton.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 191);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Cantón de Residencia";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // link1
            // 
            this.link1.Location = new System.Drawing.Point(598, 38);
            this.link1.Name = "link1";
            this.link1.Size = new System.Drawing.Size(155, 23);
            this.link1.TabIndex = 26;
            this.link1.Text = "Volver";
            this.link1.UseSelectable = true;
            this.link1.Click += new System.EventHandler(this.link1_Click);
            // 
            // CrearPerfilDeBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 614);
            this.Controls.Add(this.link1);
            this.Controls.Add(this.comboCanton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboProvincia);
            this.Controls.Add(this.agregarIdioma);
            this.Controls.Add(this.agregarGenero);
            this.Controls.Add(this.ComboIdioma);
            this.Controls.Add(this.ComboGenero);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TX_Email);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TX_Nombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CrearPerfilDeBuscador";
            this.Text = "Crear Perfil de Buscador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGenero)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIdiomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton botonGuardar;
        private MetroFramework.Controls.MetroLabel Nombre;
        private MetroFramework.Controls.MetroTextBox TX_Nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TX_Email;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox ComboGenero;
        private MetroFramework.Controls.MetroComboBox ComboIdioma;
        private MetroFramework.Controls.MetroButton agregarGenero;
        private MetroFramework.Controls.MetroButton agregarIdioma;
        private MetroFramework.Controls.MetroComboBox ComboProvincia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridGenero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridIdiomas;
        private MetroFramework.Controls.MetroComboBox comboCanton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink link1;
    }
}