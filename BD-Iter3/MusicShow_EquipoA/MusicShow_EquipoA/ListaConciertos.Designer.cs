namespace MusicShow_EquipoA
{
    partial class ListaConciertos
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
            this.volver = new MetroFramework.Controls.MetroLink();
            this.concBoton = new MetroFramework.Controls.MetroButton();
            this.concComboBox = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.concInterGrid = new System.Windows.Forms.DataGridView();
            this.concGrid = new System.Windows.Forms.DataGridView();
            this.filtroText = new MetroFramework.Controls.MetroTextBox();
            this.buscarBoton = new MetroFramework.Controls.MetroButton();
            this.quitarBoton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.concInterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(916, 22);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 51;
            this.volver.Text = "Volver";
            this.volver.UseSelectable = true;
            this.volver.Click += new System.EventHandler(this.volver_Click_1);
            // 
            // concBoton
            // 
            this.concBoton.Location = new System.Drawing.Point(189, 446);
            this.concBoton.Name = "concBoton";
            this.concBoton.Size = new System.Drawing.Size(102, 23);
            this.concBoton.TabIndex = 50;
            this.concBoton.Text = "Ver Concierto";
            this.concBoton.UseSelectable = true;
            this.concBoton.Click += new System.EventHandler(this.concBoton_Click_1);
            // 
            // concComboBox
            // 
            this.concComboBox.FormattingEnabled = true;
            this.concComboBox.Location = new System.Drawing.Point(23, 121);
            this.concComboBox.Name = "concComboBox";
            this.concComboBox.Size = new System.Drawing.Size(268, 21);
            this.concComboBox.TabIndex = 49;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Todos los conciertos";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.concInterGrid);
            this.groupBox1.Location = new System.Drawing.Point(660, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 318);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conciertos que me interesan";
            // 
            // concInterGrid
            // 
            this.concInterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.concInterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.concInterGrid.Location = new System.Drawing.Point(6, 19);
            this.concInterGrid.Name = "concInterGrid";
            this.concInterGrid.Size = new System.Drawing.Size(325, 299);
            this.concInterGrid.TabIndex = 0;
            // 
            // concGrid
            // 
            this.concGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.concGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.concGrid.Location = new System.Drawing.Point(39, 237);
            this.concGrid.Name = "concGrid";
            this.concGrid.Size = new System.Drawing.Size(513, 169);
            this.concGrid.TabIndex = 1;
            // 
            // filtroText
            // 
            // 
            // 
            // 
            this.filtroText.CustomButton.Image = null;
            this.filtroText.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.filtroText.CustomButton.Name = "";
            this.filtroText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.filtroText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filtroText.CustomButton.TabIndex = 1;
            this.filtroText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filtroText.CustomButton.UseSelectable = true;
            this.filtroText.CustomButton.Visible = false;
            this.filtroText.Lines = new string[0];
            this.filtroText.Location = new System.Drawing.Point(340, 119);
            this.filtroText.MaxLength = 30;
            this.filtroText.Name = "filtroText";
            this.filtroText.PasswordChar = '\0';
            this.filtroText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filtroText.SelectedText = "";
            this.filtroText.SelectionLength = 0;
            this.filtroText.SelectionStart = 0;
            this.filtroText.ShortcutsEnabled = true;
            this.filtroText.Size = new System.Drawing.Size(157, 23);
            this.filtroText.TabIndex = 52;
            this.filtroText.UseSelectable = true;
            this.filtroText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filtroText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buscarBoton
            // 
            this.buscarBoton.Location = new System.Drawing.Point(231, 179);
            this.buscarBoton.Name = "buscarBoton";
            this.buscarBoton.Size = new System.Drawing.Size(102, 23);
            this.buscarBoton.TabIndex = 53;
            this.buscarBoton.Text = "Buscar";
            this.buscarBoton.UseSelectable = true;
            this.buscarBoton.Click += new System.EventHandler(this.buscarBoton_Click_1);
            // 
            // quitarBoton
            // 
            this.quitarBoton.Location = new System.Drawing.Point(820, 417);
            this.quitarBoton.Name = "quitarBoton";
            this.quitarBoton.Size = new System.Drawing.Size(102, 23);
            this.quitarBoton.TabIndex = 54;
            this.quitarBoton.Text = "Quitar";
            this.quitarBoton.UseSelectable = true;
            this.quitarBoton.Click += new System.EventHandler(this.quitarBoton_Click_1);
            // 
            // ListaConciertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 492);
            this.Controls.Add(this.quitarBoton);
            this.Controls.Add(this.buscarBoton);
            this.Controls.Add(this.filtroText);
            this.Controls.Add(this.concGrid);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.concBoton);
            this.Controls.Add(this.concComboBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListaConciertos";
            this.Text = "Lista de Conciertos";
            this.Load += new System.EventHandler(this.ListaConciertos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.concInterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink volver;
        private MetroFramework.Controls.MetroButton concBoton;
        private System.Windows.Forms.ComboBox concComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView concInterGrid;
        private System.Windows.Forms.DataGridView concGrid;
        private MetroFramework.Controls.MetroTextBox filtroText;
        private MetroFramework.Controls.MetroButton buscarBoton;
        private MetroFramework.Controls.MetroButton quitarBoton;
    }
}