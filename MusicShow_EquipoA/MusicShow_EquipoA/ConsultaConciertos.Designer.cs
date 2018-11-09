namespace MusicShow_EquipoA
{
    partial class ConsultaConciertos
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
            this.concCombobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.filtroGeneral = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // concCombobox
            // 
            this.concCombobox.FormattingEnabled = true;
            this.concCombobox.ItemHeight = 23;
            this.concCombobox.Location = new System.Drawing.Point(189, 124);
            this.concCombobox.Name = "concCombobox";
            this.concCombobox.Size = new System.Drawing.Size(176, 29);
            this.concCombobox.TabIndex = 0;
            this.concCombobox.UseSelectable = true;
            this.concCombobox.SelectedIndexChanged += new System.EventHandler(this.concCombobox_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 124);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(132, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Seleccione concierto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 283);
            this.dataGridView1.TabIndex = 2;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(670, 27);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.Text = "Volver";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // filtroGeneral
            // 
            // 
            // 
            // 
            this.filtroGeneral.CustomButton.Image = null;
            this.filtroGeneral.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.filtroGeneral.CustomButton.Name = "";
            this.filtroGeneral.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.filtroGeneral.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filtroGeneral.CustomButton.TabIndex = 1;
            this.filtroGeneral.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filtroGeneral.CustomButton.UseSelectable = true;
            this.filtroGeneral.CustomButton.Visible = false;
            this.filtroGeneral.Lines = new string[0];
            this.filtroGeneral.Location = new System.Drawing.Point(486, 124);
            this.filtroGeneral.MaxLength = 30;
            this.filtroGeneral.Name = "filtroGeneral";
            this.filtroGeneral.PasswordChar = '\0';
            this.filtroGeneral.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filtroGeneral.SelectedText = "";
            this.filtroGeneral.SelectionLength = 0;
            this.filtroGeneral.SelectionStart = 0;
            this.filtroGeneral.ShortcutsEnabled = true;
            this.filtroGeneral.Size = new System.Drawing.Size(167, 23);
            this.filtroGeneral.TabIndex = 3;
            this.filtroGeneral.UseSelectable = true;
            this.filtroGeneral.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filtroGeneral.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.filtroGeneral.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(670, 124);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Filtrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ConsultaConciertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 486);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.filtroGeneral);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.concCombobox);
            this.Name = "ConsultaConciertos";
            this.Text = "Consultar conciertos";
            this.Load += new System.EventHandler(this.ConsultaCoonciertos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox concCombobox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox filtroGeneral;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}