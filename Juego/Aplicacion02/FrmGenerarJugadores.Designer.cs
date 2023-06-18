namespace Aplicacion02
{
    partial class FrmGenerarJugadores
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
            lblNameJugadorUno = new Label();
            lblNameJugadorDos = new Label();
            txtJugadorUno = new TextBox();
            txtJugadorDos = new TextBox();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // lblNameJugadorUno
            // 
            lblNameJugadorUno.AutoSize = true;
            lblNameJugadorUno.Location = new Point(36, 53);
            lblNameJugadorUno.Name = "lblNameJugadorUno";
            lblNameJugadorUno.Size = new Size(38, 15);
            lblNameJugadorUno.TabIndex = 0;
            lblNameJugadorUno.Text = "label1";
            // 
            // lblNameJugadorDos
            // 
            lblNameJugadorDos.AutoSize = true;
            lblNameJugadorDos.Location = new Point(36, 91);
            lblNameJugadorDos.Name = "lblNameJugadorDos";
            lblNameJugadorDos.Size = new Size(38, 15);
            lblNameJugadorDos.TabIndex = 1;
            lblNameJugadorDos.Text = "label2";
            // 
            // txtJugadorUno
            // 
            txtJugadorUno.Location = new Point(80, 45);
            txtJugadorUno.Name = "txtJugadorUno";
            txtJugadorUno.Size = new Size(100, 23);
            txtJugadorUno.TabIndex = 2;
            // 
            // txtJugadorDos
            // 
            txtJugadorDos.Location = new Point(80, 83);
            txtJugadorDos.Name = "txtJugadorDos";
            txtJugadorDos.Size = new Size(100, 23);
            txtJugadorDos.TabIndex = 3;
            txtJugadorDos.TextChanged += textBox2_TextChanged;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(80, 145);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FrmGenerarJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 208);
            Controls.Add(btnCrear);
            Controls.Add(txtJugadorDos);
            Controls.Add(txtJugadorUno);
            Controls.Add(lblNameJugadorDos);
            Controls.Add(lblNameJugadorUno);
            Name = "FrmGenerarJugadores";
            Text = "FrmGenerarJugadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameJugadorUno;
        private Label lblNameJugadorDos;
        private TextBox txtJugadorUno;
        private TextBox txtJugadorDos;
        private Button btnCrear;
    }
}