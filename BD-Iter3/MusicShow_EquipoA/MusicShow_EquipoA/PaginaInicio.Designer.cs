namespace MusicShow_EquipoA
{
    partial class PaginaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicio));
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TX_USERNAME = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAnunciante = new System.Windows.Forms.RadioButton();
            this.radioBuscador = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(152, 260);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nombre de usuario:";
            // 
            // TX_USERNAME
            // 
            // 
            // 
            // 
            this.TX_USERNAME.CustomButton.Image = null;
            this.TX_USERNAME.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.TX_USERNAME.CustomButton.Name = "";
            this.TX_USERNAME.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TX_USERNAME.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TX_USERNAME.CustomButton.TabIndex = 1;
            this.TX_USERNAME.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TX_USERNAME.CustomButton.UseSelectable = true;
            this.TX_USERNAME.CustomButton.Visible = false;
            this.TX_USERNAME.Lines = new string[0];
            this.TX_USERNAME.Location = new System.Drawing.Point(299, 261);
            this.TX_USERNAME.MaxLength = 30;
            this.TX_USERNAME.Name = "TX_USERNAME";
            this.TX_USERNAME.PasswordChar = '\0';
            this.TX_USERNAME.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TX_USERNAME.SelectedText = "";
            this.TX_USERNAME.SelectionLength = 0;
            this.TX_USERNAME.SelectionStart = 0;
            this.TX_USERNAME.ShortcutsEnabled = true;
            this.TX_USERNAME.Size = new System.Drawing.Size(106, 23);
            this.TX_USERNAME.TabIndex = 3;
            this.TX_USERNAME.UseSelectable = true;
            this.TX_USERNAME.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TX_USERNAME.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(25, 29);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(155, 23);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.Text = "Anunciante";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 150);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(25, 58);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(155, 23);
            this.metroLink2.TabIndex = 7;
            this.metroLink2.Text = "Buscador";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLink1);
            this.groupBox1.Controls.Add(this.metroLink2);
            this.groupBox1.Location = new System.Drawing.Point(188, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿No tienes cuenta?";
            // 
            // radioAnunciante
            // 
            this.radioAnunciante.AutoSize = true;
            this.radioAnunciante.Location = new System.Drawing.Point(299, 215);
            this.radioAnunciante.Name = "radioAnunciante";
            this.radioAnunciante.Size = new System.Drawing.Size(79, 17);
            this.radioAnunciante.TabIndex = 9;
            this.radioAnunciante.TabStop = true;
            this.radioAnunciante.Text = "Anunciante";
            this.radioAnunciante.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioAnunciante.UseVisualStyleBackColor = true;
            // 
            // radioBuscador
            // 
            this.radioBuscador.AutoSize = true;
            this.radioBuscador.Location = new System.Drawing.Point(299, 238);
            this.radioBuscador.Name = "radioBuscador";
            this.radioBuscador.Size = new System.Drawing.Size(70, 17);
            this.radioBuscador.TabIndex = 10;
            this.radioBuscador.TabStop = true;
            this.radioBuscador.Text = "Buscador";
            this.radioBuscador.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.radioBuscador.UseVisualStyleBackColor = true;
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 482);
            this.Controls.Add(this.radioBuscador);
            this.Controls.Add(this.radioAnunciante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TX_USERNAME);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button1);
            this.Name = "PaginaInicio";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.PaginaInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TX_USERNAME;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAnunciante;
        private System.Windows.Forms.RadioButton radioBuscador;
    }
}