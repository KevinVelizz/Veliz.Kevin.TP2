namespace Aplicacion02
{
    partial class FrmEstadistica
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
            dtgvSalas = new DataGridView();
            Jugador1 = new DataGridViewTextBoxColumn();
            Jugador2 = new DataGridViewTextBoxColumn();
            PuntajeJugador1 = new DataGridViewTextBoxColumn();
            PuntajeJugador2 = new DataGridViewTextBoxColumn();
            Ganador = new DataGridViewTextBoxColumn();
            Turnos = new DataGridViewTextBoxColumn();
            dtgvJugadores = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvSalas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // dtgvSalas
            // 
            dtgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSalas.Columns.AddRange(new DataGridViewColumn[] { Jugador1, Jugador2, PuntajeJugador1, PuntajeJugador2, Ganador, Turnos });
            dtgvSalas.Location = new Point(12, 83);
            dtgvSalas.Name = "dtgvSalas";
            dtgvSalas.RowTemplate.Height = 25;
            dtgvSalas.Size = new Size(240, 150);
            dtgvSalas.TabIndex = 1;
            // 
            // Jugador1
            // 
            Jugador1.HeaderText = "Jugador1";
            Jugador1.Name = "Jugador1";
            // 
            // Jugador2
            // 
            Jugador2.HeaderText = "Jugado2";
            Jugador2.Name = "Jugador2";
            // 
            // PuntajeJugador1
            // 
            PuntajeJugador1.HeaderText = "PuntajeJugador1";
            PuntajeJugador1.Name = "PuntajeJugador1";
            // 
            // PuntajeJugador2
            // 
            PuntajeJugador2.HeaderText = "PuntajeJugador2";
            PuntajeJugador2.Name = "PuntajeJugador2";
            // 
            // Ganador
            // 
            Ganador.HeaderText = "Ganador";
            Ganador.Name = "Ganador";
            // 
            // Turnos
            // 
            Turnos.HeaderText = "Turnos";
            Turnos.Name = "Turnos";
            // 
            // dtgvJugadores
            // 
            dtgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvJugadores.Location = new Point(258, 83);
            dtgvJugadores.Name = "dtgvJugadores";
            dtgvJugadores.RowTemplate.Height = 25;
            dtgvJugadores.Size = new Size(240, 150);
            dtgvJugadores.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(66, 60);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 3;
            label1.Text = "Partidas jugadas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(333, 60);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Jugadores:";
            // 
            // FrmEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 318);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgvJugadores);
            Controls.Add(dtgvSalas);
            Name = "FrmEstadistica";
            Text = "FrmEstadistica";
            Load += FrmEstadistica_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSalas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgvSalas;
        private DataGridView dtgvJugadores;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Jugador1;
        private DataGridViewTextBoxColumn Jugador2;
        private DataGridViewTextBoxColumn PuntajeJugador1;
        private DataGridViewTextBoxColumn PuntajeJugador2;
        private DataGridViewTextBoxColumn Ganador;
        private DataGridViewTextBoxColumn Turnos;
    }
}