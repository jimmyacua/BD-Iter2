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
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TX_USERNAME = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 248);
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
            this.metroLabel1.Location = new System.Drawing.Point(153, 189);
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
            this.TX_USERNAME.Location = new System.Drawing.Point(300, 189);
            this.TX_USERNAME.MaxLength = 32767;
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
            this.metroLink1.Location = new System.Drawing.Point(211, 306);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(155, 23);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.Text = "¿No tienes una cuenta?";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // PaginaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 428);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.TX_USERNAME);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button1);
            this.Name = "PaginaInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.PaginaInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TX_USERNAME;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}