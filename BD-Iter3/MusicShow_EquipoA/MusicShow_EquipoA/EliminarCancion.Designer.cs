namespace MusicShow_EquipoA
{
    partial class EliminarCancion
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
            this.btnElm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.elCancionCombo = new MetroFramework.Controls.MetroComboBox();
            this.TB_NOMB = new MetroFramework.Controls.MetroTextBox();
            this.TB_AÑO = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonAgregarInterprete = new System.Windows.Forms.Button();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.agregarInterpreteBox = new MetroFramework.Controls.MetroTextBox();
            this.INTER_Combo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.modCancionCombo = new MetroFramework.Controls.MetroComboBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnElm
            // 
            this.btnElm.Location = new System.Drawing.Point(256, 287);
            this.btnElm.Name = "btnElm";
            this.btnElm.Size = new System.Drawing.Size(75, 23);
            this.btnElm.TabIndex = 18;
            this.btnElm.Text = "Eliminar";
            this.btnElm.UseVisualStyleBackColor = true;
            this.btnElm.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.elCancionCombo);
            this.groupBox1.Controls.Add(this.btnElm);
            this.groupBox1.Location = new System.Drawing.Point(580, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 334);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 43);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(132, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Seleccione la canción";
            // 
            // elCancionCombo
            // 
            this.elCancionCombo.FormattingEnabled = true;
            this.elCancionCombo.ItemHeight = 23;
            this.elCancionCombo.Location = new System.Drawing.Point(18, 90);
            this.elCancionCombo.Name = "elCancionCombo";
            this.elCancionCombo.Size = new System.Drawing.Size(324, 29);
            this.elCancionCombo.TabIndex = 9;
            this.elCancionCombo.UseSelectable = true;
            this.elCancionCombo.SelectedIndexChanged += new System.EventHandler(this.elCancionCombo_SelectedIndexChanged);
            // 
            // TB_NOMB
            // 
            // 
            // 
            // 
            this.TB_NOMB.CustomButton.Image = null;
            this.TB_NOMB.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.TB_NOMB.CustomButton.Name = "";
            this.TB_NOMB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TB_NOMB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TB_NOMB.CustomButton.TabIndex = 1;
            this.TB_NOMB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TB_NOMB.CustomButton.UseSelectable = true;
            this.TB_NOMB.CustomButton.Visible = false;
            this.TB_NOMB.Lines = new string[0];
            this.TB_NOMB.Location = new System.Drawing.Point(194, 90);
            this.TB_NOMB.MaxLength = 30;
            this.TB_NOMB.Name = "TB_NOMB";
            this.TB_NOMB.PasswordChar = '\0';
            this.TB_NOMB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TB_NOMB.SelectedText = "";
            this.TB_NOMB.SelectionLength = 0;
            this.TB_NOMB.SelectionStart = 0;
            this.TB_NOMB.ShortcutsEnabled = true;
            this.TB_NOMB.Size = new System.Drawing.Size(295, 23);
            this.TB_NOMB.TabIndex = 14;
            this.TB_NOMB.UseSelectable = true;
            this.TB_NOMB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TB_NOMB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TB_AÑO
            // 
            // 
            // 
            // 
            this.TB_AÑO.CustomButton.Image = null;
            this.TB_AÑO.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.TB_AÑO.CustomButton.Name = "";
            this.TB_AÑO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TB_AÑO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TB_AÑO.CustomButton.TabIndex = 1;
            this.TB_AÑO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TB_AÑO.CustomButton.UseSelectable = true;
            this.TB_AÑO.CustomButton.Visible = false;
            this.TB_AÑO.Lines = new string[0];
            this.TB_AÑO.Location = new System.Drawing.Point(194, 228);
            this.TB_AÑO.MaxLength = 4;
            this.TB_AÑO.Name = "TB_AÑO";
            this.TB_AÑO.PasswordChar = '\0';
            this.TB_AÑO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TB_AÑO.SelectedText = "";
            this.TB_AÑO.SelectionLength = 0;
            this.TB_AÑO.SelectionStart = 0;
            this.TB_AÑO.ShortcutsEnabled = true;
            this.TB_AÑO.Size = new System.Drawing.Size(200, 23);
            this.TB_AÑO.TabIndex = 15;
            this.TB_AÑO.UseSelectable = true;
            this.TB_AÑO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TB_AÑO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TB_AÑO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_AÑO_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 228);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Año (canción original)";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 134);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Intérprete orignal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonAgregarInterprete);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.agregarInterpreteBox);
            this.groupBox2.Controls.Add(this.INTER_Combo);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.modCancionCombo);
            this.groupBox2.Controls.Add(this.btnMod);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.TB_NOMB);
            this.groupBox2.Controls.Add(this.TB_AÑO);
            this.groupBox2.Location = new System.Drawing.Point(23, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 334);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
            // 
            // botonAgregarInterprete
            // 
            this.botonAgregarInterprete.Location = new System.Drawing.Point(414, 182);
            this.botonAgregarInterprete.Name = "botonAgregarInterprete";
            this.botonAgregarInterprete.Size = new System.Drawing.Size(75, 23);
            this.botonAgregarInterprete.TabIndex = 24;
            this.botonAgregarInterprete.Text = "Agregar interprete";
            this.botonAgregarInterprete.UseVisualStyleBackColor = true;
            this.botonAgregarInterprete.Click += new System.EventHandler(this.botonAgregarInterprete_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(38, 182);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(120, 19);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "¿Nuevo intérprete?";
            // 
            // agregarInterpreteBox
            // 
            // 
            // 
            // 
            this.agregarInterpreteBox.CustomButton.Image = null;
            this.agregarInterpreteBox.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.agregarInterpreteBox.CustomButton.Name = "";
            this.agregarInterpreteBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.agregarInterpreteBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.agregarInterpreteBox.CustomButton.TabIndex = 1;
            this.agregarInterpreteBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.agregarInterpreteBox.CustomButton.UseSelectable = true;
            this.agregarInterpreteBox.CustomButton.Visible = false;
            this.agregarInterpreteBox.Lines = new string[0];
            this.agregarInterpreteBox.Location = new System.Drawing.Point(194, 182);
            this.agregarInterpreteBox.MaxLength = 30;
            this.agregarInterpreteBox.Name = "agregarInterpreteBox";
            this.agregarInterpreteBox.PasswordChar = '\0';
            this.agregarInterpreteBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.agregarInterpreteBox.SelectedText = "";
            this.agregarInterpreteBox.SelectionLength = 0;
            this.agregarInterpreteBox.SelectionStart = 0;
            this.agregarInterpreteBox.ShortcutsEnabled = true;
            this.agregarInterpreteBox.Size = new System.Drawing.Size(200, 23);
            this.agregarInterpreteBox.TabIndex = 22;
            this.agregarInterpreteBox.UseSelectable = true;
            this.agregarInterpreteBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.agregarInterpreteBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.agregarInterpreteBox.Click += new System.EventHandler(this.agregarInterpreteBox_Click);
            // 
            // INTER_Combo
            // 
            this.INTER_Combo.FormattingEnabled = true;
            this.INTER_Combo.ItemHeight = 23;
            this.INTER_Combo.Location = new System.Drawing.Point(194, 128);
            this.INTER_Combo.Name = "INTER_Combo";
            this.INTER_Combo.Size = new System.Drawing.Size(295, 29);
            this.INTER_Combo.TabIndex = 21;
            this.INTER_Combo.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(132, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Seleccione la canción";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // modCancionCombo
            // 
            this.modCancionCombo.FormattingEnabled = true;
            this.modCancionCombo.ItemHeight = 23;
            this.modCancionCombo.Location = new System.Drawing.Point(194, 43);
            this.modCancionCombo.Name = "modCancionCombo";
            this.modCancionCombo.Size = new System.Drawing.Size(295, 29);
            this.modCancionCombo.TabIndex = 19;
            this.modCancionCombo.UseSelectable = true;
            this.modCancionCombo.SelectedIndexChanged += new System.EventHandler(this.modCancionCombo_SelectedIndexChanged_1);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(227, 287);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 19;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Nombre de la canción";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(847, 26);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 19;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // EliminarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 446);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "EliminarCancion";
            this.Text = "Eliminar o Modificar Canción";
            this.Load += new System.EventHandler(this.EliminarCancion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElm;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TB_NOMB;
        private MetroFramework.Controls.MetroTextBox TB_AÑO;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox modCancionCombo;
        private System.Windows.Forms.Button btnMod;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroComboBox elCancionCombo;
        private MetroFramework.Controls.MetroComboBox INTER_Combo;
        private System.Windows.Forms.Button botonAgregarInterprete;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox agregarInterpreteBox;
    }
}