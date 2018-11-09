namespace MusicShow_EquipoA
{
    partial class FechasModConc
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
            this.finalizar = new MetroFramework.Controls.MetroButton();
            this.botonAgregar = new MetroFramework.Controls.MetroButton();
            this.gridFechas = new System.Windows.Forms.DataGridView();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.botonElm = new MetroFramework.Controls.MetroButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CB_Elim = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(382, 463);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(75, 23);
            this.finalizar.TabIndex = 38;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseSelectable = true;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(338, 117);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 36;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseSelectable = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // gridFechas
            // 
            this.gridFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFechas.Location = new System.Drawing.Point(23, 226);
            this.gridFechas.Name = "gridFechas";
            this.gridFechas.Size = new System.Drawing.Size(423, 205);
            this.gridFechas.TabIndex = 35;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(34, 86);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(199, 19);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Seleccione una fecha y una hora:";
            // 
            // botonElm
            // 
            this.botonElm.Location = new System.Drawing.Point(338, 170);
            this.botonElm.Name = "botonElm";
            this.botonElm.Size = new System.Drawing.Size(75, 23);
            this.botonElm.TabIndex = 40;
            this.botonElm.Text = "Eliminar";
            this.botonElm.UseSelectable = true;
            this.botonElm.Click += new System.EventHandler(this.botonElm_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 20);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CB_Elim
            // 
            this.CB_Elim.FormattingEnabled = true;
            this.CB_Elim.ItemHeight = 23;
            this.CB_Elim.Location = new System.Drawing.Point(34, 164);
            this.CB_Elim.Name = "CB_Elim";
            this.CB_Elim.Size = new System.Drawing.Size(249, 29);
            this.CB_Elim.TabIndex = 41;
            this.CB_Elim.UseSelectable = true;
            this.CB_Elim.SelectedIndexChanged += new System.EventHandler(this.CB_Elim_SelectedIndexChanged);
            // 
            // FechasModConc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 509);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CB_Elim);
            this.Controls.Add(this.botonElm);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.gridFechas);
            this.Controls.Add(this.metroLabel5);
            this.Name = "FechasModConc";
            this.Text = "Modificar Fechas";
            this.Load += new System.EventHandler(this.FechasModConc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFechas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton finalizar;
        private MetroFramework.Controls.MetroButton botonAgregar;
        private System.Windows.Forms.DataGridView gridFechas;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton botonElm;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroComboBox CB_Elim;
    }
}