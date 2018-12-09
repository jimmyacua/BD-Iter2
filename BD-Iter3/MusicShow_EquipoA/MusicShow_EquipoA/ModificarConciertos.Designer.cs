namespace MusicShow_EquipoA
{
    partial class ModificarConciertos
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
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.comboEliminar = new MetroFramework.Controls.MetroComboBox();
            this.BT_Elm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLink4 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.comboLugar = new MetroFramework.Controls.MetroComboBox();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.descripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.nombConc = new MetroFramework.Controls.MetroComboBox();
            this.BTN_MOD = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nombre = new MetroFramework.Controls.MetroTextBox();
            this.cupo = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(834, 23);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 22;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.comboEliminar);
            this.groupBox1.Controls.Add(this.BT_Elm);
            this.groupBox1.Location = new System.Drawing.Point(541, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 448);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 43);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(143, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Seleccione el concierto";
            // 
            // comboEliminar
            // 
            this.comboEliminar.FormattingEnabled = true;
            this.comboEliminar.ItemHeight = 23;
            this.comboEliminar.Location = new System.Drawing.Point(18, 73);
            this.comboEliminar.Name = "comboEliminar";
            this.comboEliminar.Size = new System.Drawing.Size(324, 29);
            this.comboEliminar.TabIndex = 9;
            this.comboEliminar.UseSelectable = true;
            this.comboEliminar.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // BT_Elm
            // 
            this.BT_Elm.Location = new System.Drawing.Point(267, 394);
            this.BT_Elm.Name = "BT_Elm";
            this.BT_Elm.Size = new System.Drawing.Size(75, 23);
            this.BT_Elm.TabIndex = 18;
            this.BT_Elm.Text = "Eliminar";
            this.BT_Elm.UseVisualStyleBackColor = true;
            this.BT_Elm.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLink4);
            this.groupBox2.Controls.Add(this.metroLink3);
            this.groupBox2.Controls.Add(this.comboLugar);
            this.groupBox2.Controls.Add(this.metroLink2);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.descripcion);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.nombConc);
            this.groupBox2.Controls.Add(this.BTN_MOD);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.nombre);
            this.groupBox2.Controls.Add(this.cupo);
            this.groupBox2.Location = new System.Drawing.Point(54, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 448);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
            // 
            // metroLink4
            // 
            this.metroLink4.Location = new System.Drawing.Point(323, 392);
            this.metroLink4.Name = "metroLink4";
            this.metroLink4.Size = new System.Drawing.Size(108, 50);
            this.metroLink4.TabIndex = 29;
            this.metroLink4.Text = "Agregar o\r\nEliminar Fechas";
            this.metroLink4.UseSelectable = true;
            this.metroLink4.Click += new System.EventHandler(this.metroLink4_Click);
            // 
            // metroLink3
            // 
            this.metroLink3.Location = new System.Drawing.Point(15, 405);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(166, 23);
            this.metroLink3.TabIndex = 28;
            this.metroLink3.Text = "Hacer Cambios al Repertorio";
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // comboLugar
            // 
            this.comboLugar.FormattingEnabled = true;
            this.comboLugar.ItemHeight = 23;
            this.comboLugar.Location = new System.Drawing.Point(194, 224);
            this.comboLugar.Name = "comboLugar";
            this.comboLugar.Size = new System.Drawing.Size(210, 29);
            this.comboLugar.TabIndex = 27;
            this.comboLugar.UseSelectable = true;
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(15, 265);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(121, 23);
            this.metroLink2.TabIndex = 26;
            this.metroLink2.Text = "¿Nuevo lugar?";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(38, 231);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(42, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Lugar";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(38, 182);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Descripción";
            // 
            // descripcion
            // 
            // 
            // 
            // 
            this.descripcion.CustomButton.Image = null;
            this.descripcion.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.descripcion.CustomButton.Name = "";
            this.descripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descripcion.CustomButton.TabIndex = 1;
            this.descripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descripcion.CustomButton.UseSelectable = true;
            this.descripcion.CustomButton.Visible = false;
            this.descripcion.Lines = new string[0];
            this.descripcion.Location = new System.Drawing.Point(194, 175);
            this.descripcion.MaxLength = 50;
            this.descripcion.Name = "descripcion";
            this.descripcion.PasswordChar = '\0';
            this.descripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descripcion.SelectedText = "";
            this.descripcion.SelectionLength = 0;
            this.descripcion.SelectionStart = 0;
            this.descripcion.ShortcutsEnabled = true;
            this.descripcion.Size = new System.Drawing.Size(210, 23);
            this.descripcion.TabIndex = 23;
            this.descripcion.UseSelectable = true;
            this.descripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(143, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Seleccione el concierto";
            // 
            // nombConc
            // 
            this.nombConc.FormattingEnabled = true;
            this.nombConc.ItemHeight = 23;
            this.nombConc.Location = new System.Drawing.Point(194, 43);
            this.nombConc.Name = "nombConc";
            this.nombConc.Size = new System.Drawing.Size(210, 29);
            this.nombConc.TabIndex = 19;
            this.nombConc.UseSelectable = true;
            this.nombConc.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // BTN_MOD
            // 
            this.BTN_MOD.Location = new System.Drawing.Point(259, 277);
            this.BTN_MOD.Name = "BTN_MOD";
            this.BTN_MOD.Size = new System.Drawing.Size(75, 23);
            this.BTN_MOD.TabIndex = 19;
            this.BTN_MOD.Text = "Modificar";
            this.BTN_MOD.UseVisualStyleBackColor = true;
            this.BTN_MOD.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Nombre del concierto";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Cupo";
            // 
            // nombre
            // 
            // 
            // 
            // 
            this.nombre.CustomButton.Image = null;
            this.nombre.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.nombre.CustomButton.Name = "";
            this.nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nombre.CustomButton.TabIndex = 1;
            this.nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nombre.CustomButton.UseSelectable = true;
            this.nombre.CustomButton.Visible = false;
            this.nombre.Lines = new string[0];
            this.nombre.Location = new System.Drawing.Point(194, 95);
            this.nombre.MaxLength = 30;
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nombre.SelectedText = "";
            this.nombre.SelectionLength = 0;
            this.nombre.SelectionStart = 0;
            this.nombre.ShortcutsEnabled = true;
            this.nombre.Size = new System.Drawing.Size(210, 23);
            this.nombre.TabIndex = 14;
            this.nombre.UseSelectable = true;
            this.nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cupo
            // 
            // 
            // 
            // 
            this.cupo.CustomButton.Image = null;
            this.cupo.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.cupo.CustomButton.Name = "";
            this.cupo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.cupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cupo.CustomButton.TabIndex = 1;
            this.cupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cupo.CustomButton.UseSelectable = true;
            this.cupo.CustomButton.Visible = false;
            this.cupo.Lines = new string[0];
            this.cupo.Location = new System.Drawing.Point(194, 134);
            this.cupo.MaxLength = 7;
            this.cupo.Name = "cupo";
            this.cupo.PasswordChar = '\0';
            this.cupo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cupo.SelectedText = "";
            this.cupo.SelectionLength = 0;
            this.cupo.SelectionStart = 0;
            this.cupo.ShortcutsEnabled = true;
            this.cupo.Size = new System.Drawing.Size(210, 23);
            this.cupo.TabIndex = 16;
            this.cupo.UseSelectable = true;
            this.cupo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cupo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.cupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cupo_KeyPress);
            // 
            // ModificarConciertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 702);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ModificarConciertos";
            this.Text = "Modificar o eliminar concierto";
            this.Load += new System.EventHandler(this.ModificarConciertos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox comboEliminar;
        private System.Windows.Forms.Button BT_Elm;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox nombConc;
        private System.Windows.Forms.Button BTN_MOD;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox nombre;
        private MetroFramework.Controls.MetroTextBox cupo;
        private MetroFramework.Controls.MetroComboBox comboLugar;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox descripcion;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink4;
    }
}