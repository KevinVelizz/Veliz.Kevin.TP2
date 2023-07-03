namespace Aplicacion02
{
    partial class FrmSeleccionarJugadores
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
            cboJugadores01 = new ComboBox();
            cboJugadores02 = new ComboBox();
            lblJugador01 = new Label();
            lblJugador02 = new Label();
            btnCrear = new Button();
            lblMensajeError = new Label();
            SuspendLayout();
            // 
            // cboJugadores01
            // 
            cboJugadores01.FormattingEnabled = true;
            cboJugadores01.Location = new Point(12, 38);
            cboJugadores01.Name = "cboJugadores01";
            cboJugadores01.Size = new Size(261, 23);
            cboJugadores01.TabIndex = 0;
            cboJugadores01.Text = "--Seleccione--";
            // 
            // cboJugadores02
            // 
            cboJugadores02.FormattingEnabled = true;
            cboJugadores02.Location = new Point(295, 38);
            cboJugadores02.Name = "cboJugadores02";
            cboJugadores02.Size = new Size(283, 23);
            cboJugadores02.TabIndex = 1;
            cboJugadores02.Text = "--Seleccione--";
            // 
            // lblJugador01
            // 
            lblJugador01.AutoSize = true;
            lblJugador01.Location = new Point(107, 20);
            lblJugador01.Name = "lblJugador01";
            lblJugador01.Size = new Size(61, 15);
            lblJugador01.TabIndex = 2;
            lblJugador01.Text = "Jugador01";
            // 
            // lblJugador02
            // 
            lblJugador02.AutoSize = true;
            lblJugador02.Location = new Point(413, 20);
            lblJugador02.Name = "lblJugador02";
            lblJugador02.Size = new Size(61, 15);
            lblJugador02.TabIndex = 3;
            lblJugador02.Text = "Jugador02";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(503, 156);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblMensajeError
            // 
            lblMensajeError.AutoSize = true;
            lblMensajeError.ForeColor = Color.Red;
            lblMensajeError.Location = new Point(17, 76);
            lblMensajeError.Name = "lblMensajeError";
            lblMensajeError.Size = new Size(38, 15);
            lblMensajeError.TabIndex = 5;
            lblMensajeError.Text = "label1";
            lblMensajeError.Visible = false;
            // 
            // FrmSeleccionarJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 237);
            Controls.Add(lblMensajeError);
            Controls.Add(btnCrear);
            Controls.Add(lblJugador02);
            Controls.Add(lblJugador01);
            Controls.Add(cboJugadores02);
            Controls.Add(cboJugadores01);
            Name = "FrmSeleccionarJugadores";
            Text = "FrmCrearJugadores";
            Load += FrmSeleccionarJugadores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboJugadores01;
        private ComboBox cboJugadores02;
        private Label lblJugador01;
        private Label lblJugador02;
        private Button btnCrear;
        private Label lblMensajeError;
    }
}