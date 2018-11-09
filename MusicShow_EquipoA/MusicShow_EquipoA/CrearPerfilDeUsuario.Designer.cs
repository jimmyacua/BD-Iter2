namespace MusicShow_EquipoA
{
    partial class CrearPerfilDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPerfilDeUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RB_Agrupcion = new MetroFramework.Controls.MetroRadioButton();
            this.TX_Nombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_solista = new MetroFramework.Controls.MetroRadioButton();
            this.botonGuardar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 161);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RB_Agrupcion
            // 
            this.RB_Agrupcion.AutoSize = true;
            this.RB_Agrupcion.Location = new System.Drawing.Point(31, 33);
            this.RB_Agrupcion.Name = "RB_Agrupcion";
            this.RB_Agrupcion.Size = new System.Drawing.Size(85, 15);
            this.RB_Agrupcion.TabIndex = 1;
            this.RB_Agrupcion.Text = "Agrupación";
            this.RB_Agrupcion.UseSelectable = true;
            this.RB_Agrupcion.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // TX_Nombre
            // 
            // 
            // 
            // 
            this.TX_Nombre.CustomButton.Image = null;
            this.TX_Nombre.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.TX_Nombre.CustomButton.Name = "";
            this.TX_Nombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TX_Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TX_Nombre.CustomButton.TabIndex = 1;
            this.TX_Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TX_Nombre.CustomButton.UseSelectable = true;
            this.TX_Nombre.CustomButton.Visible = false;
            this.TX_Nombre.Lines = new string[0];
            this.TX_Nombre.Location = new System.Drawing.Point(263, 299);
            this.TX_Nombre.MaxLength = 30;
            this.TX_Nombre.Name = "TX_Nombre";
            this.TX_Nombre.PasswordChar = '\0';
            this.TX_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TX_Nombre.SelectedText = "";
            this.TX_Nombre.SelectionLength = 0;
            this.TX_Nombre.SelectionStart = 0;
            this.TX_Nombre.ShortcutsEnabled = true;
            this.TX_Nombre.Size = new System.Drawing.Size(126, 23);
            this.TX_Nombre.TabIndex = 2;
            this.TX_Nombre.UseSelectable = true;
            this.TX_Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TX_Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TX_Nombre.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(167, 299);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nombre";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_solista);
            this.groupBox1.Controls.Add(this.RB_Agrupcion);
            this.groupBox1.Location = new System.Drawing.Point(172, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de músico";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RB_solista
            // 
            this.RB_solista.AutoSize = true;
            this.RB_solista.Location = new System.Drawing.Point(31, 55);
            this.RB_solista.Name = "RB_solista";
            this.RB_solista.Size = new System.Drawing.Size(57, 15);
            this.RB_solista.TabIndex = 2;
            this.RB_solista.Text = "Solista";
            this.RB_solista.UseSelectable = true;
            this.RB_solista.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(231, 512);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 5;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseSelectable = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // CrearPerfilDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 582);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TX_Nombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CrearPerfilDeUsuario";
            this.Text = "Crear Perfil de Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroRadioButton RB_Agrupcion;
        private MetroFramework.Controls.MetroTextBox TX_Nombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton RB_solista;
        private MetroFramework.Controls.MetroButton botonGuardar;
    }
}

