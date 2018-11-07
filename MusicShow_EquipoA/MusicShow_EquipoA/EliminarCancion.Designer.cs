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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.elCancionCombo = new MetroFramework.Controls.MetroComboBox();
            this.TB_NOMB = new MetroFramework.Controls.MetroTextBox();
            this.TB_AÑO = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.modCancionCombo = new MetroFramework.Controls.MetroComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.INTER_Combo = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.elCancionCombo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(377, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 263);
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
            this.elCancionCombo.Location = new System.Drawing.Point(18, 73);
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
            this.TB_NOMB.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.TB_NOMB.CustomButton.Name = "";
            this.TB_NOMB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TB_NOMB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TB_NOMB.CustomButton.TabIndex = 1;
            this.TB_NOMB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TB_NOMB.CustomButton.UseSelectable = true;
            this.TB_NOMB.CustomButton.Visible = false;
            this.TB_NOMB.Lines = new string[0];
            this.TB_NOMB.Location = new System.Drawing.Point(194, 99);
            this.TB_NOMB.MaxLength = 32767;
            this.TB_NOMB.Name = "TB_NOMB";
            this.TB_NOMB.PasswordChar = '\0';
            this.TB_NOMB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TB_NOMB.SelectedText = "";
            this.TB_NOMB.SelectionLength = 0;
            this.TB_NOMB.SelectionStart = 0;
            this.TB_NOMB.ShortcutsEnabled = true;
            this.TB_NOMB.Size = new System.Drawing.Size(121, 23);
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
            this.TB_AÑO.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.TB_AÑO.CustomButton.Name = "";
            this.TB_AÑO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TB_AÑO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TB_AÑO.CustomButton.TabIndex = 1;
            this.TB_AÑO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TB_AÑO.CustomButton.UseSelectable = true;
            this.TB_AÑO.CustomButton.Visible = false;
            this.TB_AÑO.Lines = new string[0];
            this.TB_AÑO.Location = new System.Drawing.Point(194, 169);
            this.TB_AÑO.MaxLength = 32767;
            this.TB_AÑO.Name = "TB_AÑO";
            this.TB_AÑO.PasswordChar = '\0';
            this.TB_AÑO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TB_AÑO.SelectedText = "";
            this.TB_AÑO.SelectionLength = 0;
            this.TB_AÑO.SelectionStart = 0;
            this.TB_AÑO.ShortcutsEnabled = true;
            this.TB_AÑO.Size = new System.Drawing.Size(121, 23);
            this.TB_AÑO.TabIndex = 15;
            this.TB_AÑO.UseSelectable = true;
            this.TB_AÑO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TB_AÑO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 169);
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
            this.groupBox2.Controls.Add(this.INTER_Combo);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.modCancionCombo);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.TB_NOMB);
            this.groupBox2.Controls.Add(this.TB_AÑO);
            this.groupBox2.Location = new System.Drawing.Point(23, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 263);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
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
            this.modCancionCombo.Size = new System.Drawing.Size(121, 29);
            this.modCancionCombo.TabIndex = 19;
            this.modCancionCombo.UseSelectable = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Nombre de la canción";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(659, 26);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 19;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // INTER_Combo
            // 
            this.INTER_Combo.FormattingEnabled = true;
            this.INTER_Combo.ItemHeight = 23;
            this.INTER_Combo.Location = new System.Drawing.Point(194, 128);
            this.INTER_Combo.Name = "INTER_Combo";
            this.INTER_Combo.Size = new System.Drawing.Size(121, 29);
            this.INTER_Combo.TabIndex = 21;
            this.INTER_Combo.UseSelectable = true;
            // 
            // EliminarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 476);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox TB_NOMB;
        private MetroFramework.Controls.MetroTextBox TB_AÑO;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox modCancionCombo;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroComboBox elCancionCombo;
        private MetroFramework.Controls.MetroComboBox INTER_Combo;
    }
}