namespace Aplicacion02
{
    partial class FrmCrearJugadores
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
            txtJugadorUno = new TextBox();
            btnCrear = new Button();
            lblAdvertencia = new Label();
            SuspendLayout();
            // 
            // lblNameJugadorUno
            // 
            lblNameJugadorUno.AutoSize = true;
            lblNameJugadorUno.Location = new Point(12, 58);
            lblNameJugadorUno.Name = "lblNameJugadorUno";
            lblNameJugadorUno.Size = new Size(54, 15);
            lblNameJugadorUno.TabIndex = 0;
            lblNameJugadorUno.Text = "Nombre:";
            // 
            // txtJugadorUno
            // 
            txtJugadorUno.Location = new Point(82, 50);
            txtJugadorUno.Name = "txtJugadorUno";
            txtJugadorUno.Size = new Size(166, 23);
            txtJugadorUno.TabIndex = 2;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(233, 173);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblAdvertencia
            // 
            lblAdvertencia.AutoSize = true;
            lblAdvertencia.ForeColor = Color.Red;
            lblAdvertencia.Location = new Point(82, 86);
            lblAdvertencia.Name = "lblAdvertencia";
            lblAdvertencia.Size = new Size(38, 15);
            lblAdvertencia.TabIndex = 5;
            lblAdvertencia.Text = "label1";
            lblAdvertencia.Visible = false;
            // 
            // FrmCrearJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 208);
            Controls.Add(lblAdvertencia);
            Controls.Add(btnCrear);
            Controls.Add(txtJugadorUno);
            Controls.Add(lblNameJugadorUno);
            Name = "FrmCrearJugadores";
            Text = "FrmGenerarJugadores";
            Load += FrmGenerarJugadores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameJugadorUno;
        private TextBox txtJugadorUno;
        private Button btnCrear;
        private Label lblAdvertencia;
    }
}