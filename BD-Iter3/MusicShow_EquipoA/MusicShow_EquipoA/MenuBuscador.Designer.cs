namespace MusicShow_EquipoA
{
    partial class MenuBuscador
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.linkAgregarCanciones = new MetroFramework.Controls.MetroLink();
            this.ML_Nombre = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(454, 30);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 29;
            this.metroButton1.Text = "Cerrar sesión";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLink3);
            this.groupBox1.Controls.Add(this.linkAgregarCanciones);
            this.groupBox1.Location = new System.Drawing.Point(118, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 219);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Qué desea hacer?";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLink3
            // 
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink3.Location = new System.Drawing.Point(74, 142);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(179, 23);
            this.metroLink3.TabIndex = 19;
            this.metroLink3.Text = "Ir a la lista de Conciertos";
            this.metroLink3.UseSelectable = true;
            this.metroLink3.Click += new System.EventHandler(this.metroLink3_Click);
            // 
            // linkAgregarCanciones
            // 
            this.linkAgregarCanciones.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.linkAgregarCanciones.Location = new System.Drawing.Point(74, 89);
            this.linkAgregarCanciones.Name = "linkAgregarCanciones";
            this.linkAgregarCanciones.Size = new System.Drawing.Size(182, 23);
            this.linkAgregarCanciones.TabIndex = 16;
            this.linkAgregarCanciones.Text = "Ir a la lista de Artistas";
            this.linkAgregarCanciones.UseSelectable = true;
            this.linkAgregarCanciones.Click += new System.EventHandler(this.linkAgregarCanciones_Click);
            // 
            // ML_Nombre
            // 
            this.ML_Nombre.AutoSize = true;
            this.ML_Nombre.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ML_Nombre.Location = new System.Drawing.Point(106, 86);
            this.ML_Nombre.Name = "ML_Nombre";
            this.ML_Nombre.Size = new System.Drawing.Size(84, 19);
            this.ML_Nombre.TabIndex = 24;
            this.ML_Nombre.Text = "MODIFICAR";
            this.ML_Nombre.UseMnemonic = false;
            this.ML_Nombre.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Nombre";
            // 
            // MenuBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 485);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ML_Nombre);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MenuBuscador";
            this.Text = "Menu Buscador";
            this.Load += new System.EventHandler(this.MenuBuscador_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLink linkAgregarCanciones;
        private MetroFramework.Controls.MetroLabel ML_Nombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink3;
    }
}