namespace MusicShow_EquipoA
{
    partial class ModificarRepertorio
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
            this.Agregar = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.ReperAg = new MetroFramework.Controls.MetroComboBox();
            this.TablaCanciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Eliminar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ReperEl = new MetroFramework.Controls.MetroComboBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCanciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Agregar);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.ReperAg);
            this.groupBox2.Location = new System.Drawing.Point(23, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 164);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione la canción que desea agregar";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(319, 53);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(81, 29);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseSelectable = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
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
            // ReperAg
            // 
            this.ReperAg.FormattingEnabled = true;
            this.ReperAg.ItemHeight = 23;
            this.ReperAg.Location = new System.Drawing.Point(34, 53);
            this.ReperAg.Name = "ReperAg";
            this.ReperAg.Size = new System.Drawing.Size(156, 29);
            this.ReperAg.TabIndex = 0;
            this.ReperAg.UseSelectable = true;
            // 
            // TablaCanciones
            // 
            this.TablaCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCanciones.Location = new System.Drawing.Point(23, 278);
            this.TablaCanciones.Name = "TablaCanciones";
            this.TablaCanciones.Size = new System.Drawing.Size(877, 217);
            this.TablaCanciones.TabIndex = 3;
            this.TablaCanciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.ReperEl);
            this.groupBox1.Location = new System.Drawing.Point(481, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 164);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione canciones que desea eliminar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(315, 53);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(81, 29);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseSelectable = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Repertorio del concierto";
            // 
            // ReperEl
            // 
            this.ReperEl.FormattingEnabled = true;
            this.ReperEl.ItemHeight = 23;
            this.ReperEl.Location = new System.Drawing.Point(34, 53);
            this.ReperEl.Name = "ReperEl";
            this.ReperEl.Size = new System.Drawing.Size(156, 29);
            this.ReperEl.TabIndex = 0;
            this.ReperEl.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(825, 21);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 27;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // ModificarRepertorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 518);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.TablaCanciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ModificarRepertorio";
            this.Text = "Modificar repertorio";
            this.Load += new System.EventHandler(this.ModificarRepertorio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCanciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton Eliminar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ReperEl;
        private System.Windows.Forms.DataGridView TablaCanciones;
        private MetroFramework.Controls.MetroButton Agregar;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox ReperAg;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}