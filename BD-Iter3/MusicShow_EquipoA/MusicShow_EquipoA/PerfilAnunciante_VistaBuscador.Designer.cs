namespace MusicShow_EquipoA
{
    partial class PerfilAnunciante_VistaBuscador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridCanciones = new System.Windows.Forms.DataGridView();
            this.ML_Nombre = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelLikes = new MetroFramework.Controls.MetroLabel();
            this.labelTipo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.labelNombre = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridCanciones);
            this.groupBox1.Location = new System.Drawing.Point(23, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canciones";
            // 
            // gridCanciones
            // 
            this.gridCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCanciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridCanciones.Location = new System.Drawing.Point(6, 19);
            this.gridCanciones.Name = "gridCanciones";
            this.gridCanciones.Size = new System.Drawing.Size(565, 299);
            this.gridCanciones.TabIndex = 0;
            // 
            // ML_Nombre
            // 
            this.ML_Nombre.AutoSize = true;
            this.ML_Nombre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ML_Nombre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ML_Nombre.Location = new System.Drawing.Point(23, 71);
            this.ML_Nombre.Name = "ML_Nombre";
            this.ML_Nombre.Size = new System.Drawing.Size(63, 25);
            this.ML_Nombre.Style = MetroFramework.MetroColorStyle.Black;
            this.ML_Nombre.TabIndex = 28;
            this.ML_Nombre.Text = "Artista";
            this.ML_Nombre.UseMnemonic = false;
            this.ML_Nombre.UseStyleColors = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(540, 30);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 45;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 594);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 19);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Agregar a Favoritos";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelLikes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelLikes.Location = new System.Drawing.Point(540, 584);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(89, 25);
            this.labelLikes.Style = MetroFramework.MetroColorStyle.Black;
            this.labelLikes.TabIndex = 49;
            this.labelLikes.Text = "CAMBIAR";
            this.labelLikes.UseMnemonic = false;
            this.labelLikes.UseStyleColors = true;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelTipo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTipo.Location = new System.Drawing.Point(135, 114);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(63, 25);
            this.labelTipo.Style = MetroFramework.MetroColorStyle.Black;
            this.labelTipo.TabIndex = 50;
            this.labelTipo.Text = "Artista";
            this.labelTipo.UseMnemonic = false;
            this.labelTipo.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(23, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "Tipo";
            this.metroLabel4.UseMnemonic = false;
            this.metroLabel4.UseStyleColors = true;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelNombre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelNombre.Location = new System.Drawing.Point(135, 71);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(63, 25);
            this.labelNombre.Style = MetroFramework.MetroColorStyle.Black;
            this.labelNombre.TabIndex = 52;
            this.labelNombre.Text = "Artista";
            this.labelNombre.UseMnemonic = false;
            this.labelNombre.UseStyleColors = true;
            this.labelNombre.Click += new System.EventHandler(this.metroLabel5_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MusicShow_EquipoA.Properties.Resources.like1;
            this.pictureBox2.Location = new System.Drawing.Point(531, 541);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicShow_EquipoA.Properties.Resources.star1;
            this.pictureBox1.Location = new System.Drawing.Point(70, 541);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PerfilAnunciante_VistaBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 633);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ML_Nombre);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "PerfilAnunciante_VistaBuscador";
            this.Text = "Perfil de Artista";
            this.Load += new System.EventHandler(this.PerfilAnunciante_VistaBuscador_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridCanciones;
        private MetroFramework.Controls.MetroLabel ML_Nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel labelLikes;
        private MetroFramework.Controls.MetroLabel labelTipo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel labelNombre;
    }
}