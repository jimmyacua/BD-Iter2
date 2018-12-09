namespace MusicShow_EquipoA
{
    partial class AgregarLugar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCanton = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxProvincia = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxTipoLugar = new MetroFramework.Controls.MetroComboBox();
            this.botonAgregar = new MetroFramework.Controls.MetroButton();
            this.textBoxUbicacionExacta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.textBoxNombreLugar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCanton);
            this.groupBox1.Controls.Add(this.comboBoxProvincia);
            this.groupBox1.Controls.Add(this.comboBoxTipoLugar);
            this.groupBox1.Controls.Add(this.botonAgregar);
            this.groupBox1.Controls.Add(this.textBoxUbicacionExacta);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.textBoxNombreLugar);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Location = new System.Drawing.Point(23, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 307);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lugar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxCanton
            // 
            this.comboBoxCanton.FormattingEnabled = true;
            this.comboBoxCanton.ItemHeight = 23;
            this.comboBoxCanton.Location = new System.Drawing.Point(170, 113);
            this.comboBoxCanton.Name = "comboBoxCanton";
            this.comboBoxCanton.Size = new System.Drawing.Size(119, 29);
            this.comboBoxCanton.TabIndex = 33;
            this.comboBoxCanton.UseSelectable = true;
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.ItemHeight = 23;
            this.comboBoxProvincia.Location = new System.Drawing.Point(170, 68);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(119, 29);
            this.comboBoxProvincia.TabIndex = 32;
            this.comboBoxProvincia.UseSelectable = true;
            this.comboBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincia_SelectedIndexChanged);
            // 
            // comboBoxTipoLugar
            // 
            this.comboBoxTipoLugar.FormattingEnabled = true;
            this.comboBoxTipoLugar.ItemHeight = 23;
            this.comboBoxTipoLugar.Location = new System.Drawing.Point(170, 196);
            this.comboBoxTipoLugar.Name = "comboBoxTipoLugar";
            this.comboBoxTipoLugar.Size = new System.Drawing.Size(119, 29);
            this.comboBoxTipoLugar.TabIndex = 31;
            this.comboBoxTipoLugar.UseSelectable = true;
            this.comboBoxTipoLugar.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoLugar_SelectedIndexChanged);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(214, 264);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 30;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseSelectable = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // textBoxUbicacionExacta
            // 
            // 
            // 
            // 
            this.textBoxUbicacionExacta.CustomButton.Image = null;
            this.textBoxUbicacionExacta.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.textBoxUbicacionExacta.CustomButton.Name = "";
            this.textBoxUbicacionExacta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxUbicacionExacta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxUbicacionExacta.CustomButton.TabIndex = 1;
            this.textBoxUbicacionExacta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxUbicacionExacta.CustomButton.UseSelectable = true;
            this.textBoxUbicacionExacta.CustomButton.Visible = false;
            this.textBoxUbicacionExacta.Lines = new string[0];
            this.textBoxUbicacionExacta.Location = new System.Drawing.Point(170, 158);
            this.textBoxUbicacionExacta.MaxLength = 32767;
            this.textBoxUbicacionExacta.Name = "textBoxUbicacionExacta";
            this.textBoxUbicacionExacta.PasswordChar = '\0';
            this.textBoxUbicacionExacta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUbicacionExacta.SelectedText = "";
            this.textBoxUbicacionExacta.SelectionLength = 0;
            this.textBoxUbicacionExacta.SelectionStart = 0;
            this.textBoxUbicacionExacta.ShortcutsEnabled = true;
            this.textBoxUbicacionExacta.Size = new System.Drawing.Size(119, 23);
            this.textBoxUbicacionExacta.TabIndex = 29;
            this.textBoxUbicacionExacta.UseSelectable = true;
            this.textBoxUbicacionExacta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxUbicacionExacta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(12, 158);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(107, 19);
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Ubicación exacta";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 113);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 26;
            this.metroLabel8.Text = "Cantón";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(12, 68);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Provincia";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(12, 196);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(88, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Tipo de lugar";
            // 
            // textBoxNombreLugar
            // 
            // 
            // 
            // 
            this.textBoxNombreLugar.CustomButton.Image = null;
            this.textBoxNombreLugar.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.textBoxNombreLugar.CustomButton.Name = "";
            this.textBoxNombreLugar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxNombreLugar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxNombreLugar.CustomButton.TabIndex = 1;
            this.textBoxNombreLugar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxNombreLugar.CustomButton.UseSelectable = true;
            this.textBoxNombreLugar.CustomButton.Visible = false;
            this.textBoxNombreLugar.Lines = new string[0];
            this.textBoxNombreLugar.Location = new System.Drawing.Point(170, 29);
            this.textBoxNombreLugar.MaxLength = 32767;
            this.textBoxNombreLugar.Name = "textBoxNombreLugar";
            this.textBoxNombreLugar.PasswordChar = '\0';
            this.textBoxNombreLugar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxNombreLugar.SelectedText = "";
            this.textBoxNombreLugar.SelectionLength = 0;
            this.textBoxNombreLugar.SelectionStart = 0;
            this.textBoxNombreLugar.ShortcutsEnabled = true;
            this.textBoxNombreLugar.Size = new System.Drawing.Size(119, 23);
            this.textBoxNombreLugar.TabIndex = 21;
            this.textBoxNombreLugar.UseSelectable = true;
            this.textBoxNombreLugar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxNombreLugar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 29);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(115, 19);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Nombre del lugar";
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(276, 21);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 27;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // AgregarLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 413);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarLugar";
            this.Text = "AgregarLugar";
            this.Load += new System.EventHandler(this.AgregarLugar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox textBoxUbicacionExacta;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox textBoxNombreLugar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton botonAgregar;
        private MetroFramework.Controls.MetroComboBox comboBoxTipoLugar;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroComboBox comboBoxCanton;
        private MetroFramework.Controls.MetroComboBox comboBoxProvincia;
    }
}