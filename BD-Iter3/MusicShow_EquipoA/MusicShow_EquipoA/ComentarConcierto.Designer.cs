namespace MusicShow_EquipoA
{
    partial class ComentarConcierto
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
            this.comentBox = new MetroFramework.Controls.MetroTextBox();
            this.elimBoton = new MetroFramework.Controls.MetroButton();
            this.agreComent = new MetroFramework.Controls.MetroButton();
            this.comLabel = new MetroFramework.Controls.MetroLabel();
            this.volver = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // comentBox
            // 
            // 
            // 
            // 
            this.comentBox.CustomButton.Image = null;
            this.comentBox.CustomButton.Location = new System.Drawing.Point(328, 2);
            this.comentBox.CustomButton.Name = "";
            this.comentBox.CustomButton.Size = new System.Drawing.Size(195, 195);
            this.comentBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.comentBox.CustomButton.TabIndex = 1;
            this.comentBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comentBox.CustomButton.UseSelectable = true;
            this.comentBox.CustomButton.Visible = false;
            this.comentBox.Lines = new string[0];
            this.comentBox.Location = new System.Drawing.Point(91, 100);
            this.comentBox.MaxLength = 50;
            this.comentBox.Name = "comentBox";
            this.comentBox.PasswordChar = '\0';
            this.comentBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.comentBox.SelectedText = "";
            this.comentBox.SelectionLength = 0;
            this.comentBox.SelectionStart = 0;
            this.comentBox.ShortcutsEnabled = true;
            this.comentBox.Size = new System.Drawing.Size(526, 100);
            this.comentBox.TabIndex = 0;
            this.comentBox.UseSelectable = true;
            this.comentBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.comentBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // elimBoton
            // 
            this.elimBoton.Location = new System.Drawing.Point(478, 252);
            this.elimBoton.Name = "elimBoton";
            this.elimBoton.Size = new System.Drawing.Size(119, 23);
            this.elimBoton.TabIndex = 55;
            this.elimBoton.Text = "Eliminar Comentario";
            this.elimBoton.UseSelectable = true;
            this.elimBoton.Click += new System.EventHandler(this.quitarBoton_Click);
            // 
            // agreComent
            // 
            this.agreComent.Location = new System.Drawing.Point(151, 252);
            this.agreComent.Name = "agreComent";
            this.agreComent.Size = new System.Drawing.Size(119, 23);
            this.agreComent.TabIndex = 56;
            this.agreComent.Text = "Agregar Comentario";
            this.agreComent.UseSelectable = true;
            this.agreComent.Click += new System.EventHandler(this.agreComent_Click);
            // 
            // comLabel
            // 
            this.comLabel.AutoSize = true;
            this.comLabel.Location = new System.Drawing.Point(91, 60);
            this.comLabel.Name = "comLabel";
            this.comLabel.Size = new System.Drawing.Size(192, 19);
            this.comLabel.TabIndex = 57;
            this.comLabel.Text = "Agregar o eliminar comentario";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(615, 30);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 58;
            this.volver.Text = "Volver";
            this.volver.UseSelectable = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // ComentarConcierto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 317);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.comLabel);
            this.Controls.Add(this.agreComent);
            this.Controls.Add(this.elimBoton);
            this.Controls.Add(this.comentBox);
            this.Name = "ComentarConcierto";
            this.Text = "Comentar Concierto";
            this.Load += new System.EventHandler(this.ComentarConcierto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox comentBox;
        private MetroFramework.Controls.MetroButton elimBoton;
        private MetroFramework.Controls.MetroButton agreComent;
        private MetroFramework.Controls.MetroLabel comLabel;
        private MetroFramework.Controls.MetroLink volver;
    }
}