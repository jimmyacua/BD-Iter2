namespace MusicShow_EquipoA
{
    partial class agregarFecha
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
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.gridCanciones = new System.Windows.Forms.DataGridView();
            this.botonAgregar = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(34, 89);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(199, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Seleccione una fecha y una hora:";
            // 
            // gridCanciones
            // 
            this.gridCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCanciones.Location = new System.Drawing.Point(63, 177);
            this.gridCanciones.Name = "gridCanciones";
            this.gridCanciones.Size = new System.Drawing.Size(282, 205);
            this.gridCanciones.TabIndex = 23;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(34, 127);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 31;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(308, 31);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 32;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(308, 403);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "Siguiente";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // agregarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 449);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.gridCanciones);
            this.Controls.Add(this.metroLabel5);
            this.Name = "agregarFecha";
            this.Text = "Agregar fecha y hora";
            this.Load += new System.EventHandler(this.agregarFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridView gridCanciones;
        private MetroFramework.Controls.MetroButton botonAgregar;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}