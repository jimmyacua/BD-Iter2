namespace MusicShow_EquipoA
{
    partial class AgregarBoleteria
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
            this.botonEntrada = new MetroFramework.Controls.MetroButton();
            this.comboBoxLugar = new MetroFramework.Controls.MetroComboBox();
            this.textBoxPrecio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // botonEntrada
            // 
            this.botonEntrada.Location = new System.Drawing.Point(20, 197);
            this.botonEntrada.Name = "botonEntrada";
            this.botonEntrada.Size = new System.Drawing.Size(112, 29);
            this.botonEntrada.TabIndex = 38;
            this.botonEntrada.Text = "Agregar boleteria";
            this.botonEntrada.UseSelectable = true;
            this.botonEntrada.Click += new System.EventHandler(this.botonEntrada_Click);
            // 
            // comboBoxLugar
            // 
            this.comboBoxLugar.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxLugar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxLugar.FormattingEnabled = true;
            this.comboBoxLugar.ItemHeight = 23;
            this.comboBoxLugar.Location = new System.Drawing.Point(186, 136);
            this.comboBoxLugar.Name = "comboBoxLugar";
            this.comboBoxLugar.Size = new System.Drawing.Size(134, 29);
            this.comboBoxLugar.TabIndex = 42;
            this.comboBoxLugar.UseSelectable = true;
            // 
            // textBoxPrecio
            // 
            // 
            // 
            // 
            this.textBoxPrecio.CustomButton.Image = null;
            this.textBoxPrecio.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.textBoxPrecio.CustomButton.Name = "";
            this.textBoxPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPrecio.CustomButton.TabIndex = 1;
            this.textBoxPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPrecio.CustomButton.UseSelectable = true;
            this.textBoxPrecio.CustomButton.Visible = false;
            this.textBoxPrecio.Lines = new string[0];
            this.textBoxPrecio.Location = new System.Drawing.Point(186, 96);
            this.textBoxPrecio.MaxLength = 32767;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.PasswordChar = '\0';
            this.textBoxPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPrecio.SelectedText = "";
            this.textBoxPrecio.SelectionLength = 0;
            this.textBoxPrecio.SelectionStart = 0;
            this.textBoxPrecio.ShortcutsEnabled = true;
            this.textBoxPrecio.Size = new System.Drawing.Size(134, 23);
            this.textBoxPrecio.TabIndex = 41;
            this.textBoxPrecio.UseSelectable = true;
            this.textBoxPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPrecio.Click += new System.EventHandler(this.textBoxPrecio_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "Nombre o URL";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(20, 136);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(42, 19);
            this.metroLabel10.TabIndex = 39;
            this.metroLabel10.Text = "Lugar";
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(245, 31);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 44;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // AgregarBoleteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 262);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.botonEntrada);
            this.Controls.Add(this.comboBoxLugar);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel10);
            this.Name = "AgregarBoleteria";
            this.Text = "Agregar boleteria";
            this.Load += new System.EventHandler(this.AgregarBoleteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton botonEntrada;
        private MetroFramework.Controls.MetroComboBox comboBoxLugar;
        private MetroFramework.Controls.MetroTextBox textBoxPrecio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}