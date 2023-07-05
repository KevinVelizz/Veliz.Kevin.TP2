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
            label3 = new Label();
            lblJugadorMasVictoria = new Label();
            label4 = new Label();
            lblJugadorMenorVictoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvSalas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // dtgvSalas
            // 
            dtgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSalas.Columns.AddRange(new DataGridViewColumn[] { Jugador1, Jugador2, PuntajeJugador1, PuntajeJugador2, Ganador, Turnos });
            dtgvSalas.Location = new Point(12, 33);
            dtgvSalas.MultiSelect = false;
            dtgvSalas.Name = "dtgvSalas";
            dtgvSalas.ReadOnly = true;
            dtgvSalas.RowTemplate.Height = 25;
            dtgvSalas.Size = new Size(240, 304);
            dtgvSalas.TabIndex = 1;
            // 
            // Jugador1
            // 
            Jugador1.HeaderText = "Jugador1";
            Jugador1.Name = "Jugador1";
            Jugador1.ReadOnly = true;
            // 
            // Jugador2
            // 
            Jugador2.HeaderText = "Jugado2";
            Jugador2.Name = "Jugador2";
            Jugador2.ReadOnly = true;
            // 
            // PuntajeJugador1
            // 
            PuntajeJugador1.HeaderText = "PuntajeJugador1";
            PuntajeJugador1.Name = "PuntajeJugador1";
            PuntajeJugador1.ReadOnly = true;
            // 
            // PuntajeJugador2
            // 
            PuntajeJugador2.HeaderText = "PuntajeJugador2";
            PuntajeJugador2.Name = "PuntajeJugador2";
            PuntajeJugador2.ReadOnly = true;
            // 
            // Ganador
            // 
            Ganador.HeaderText = "Ganador";
            Ganador.Name = "Ganador";
            Ganador.ReadOnly = true;
            // 
            // Turnos
            // 
            Turnos.HeaderText = "Turnos";
            Turnos.Name = "Turnos";
            Turnos.ReadOnly = true;
            // 
            // dtgvJugadores
            // 
            dtgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvJugadores.Location = new Point(258, 33);
            dtgvJugadores.MultiSelect = false;
            dtgvJugadores.Name = "dtgvJugadores";
            dtgvJugadores.ReadOnly = true;
            dtgvJugadores.RowTemplate.Height = 25;
            dtgvJugadores.Size = new Size(258, 304);
            dtgvJugadores.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(66, 10);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 3;
            label1.Text = "Partidas jugadas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(257, 10);
            label2.Name = "label2";
            label2.Size = new Size(259, 20);
            label2.TabIndex = 4;
            label2.Text = "Jugadores de mayor puntaje a menor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(537, 46);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 5;
            label3.Text = "Más victorias:";
            // 
            // lblJugadorMasVictoria
            // 
            lblJugadorMasVictoria.AutoSize = true;
            lblJugadorMasVictoria.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblJugadorMasVictoria.Location = new Point(631, 48);
            lblJugadorMasVictoria.Name = "lblJugadorMasVictoria";
            lblJugadorMasVictoria.Size = new Size(43, 17);
            lblJugadorMasVictoria.TabIndex = 6;
            lblJugadorMasVictoria.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(522, 84);
            label4.Name = "label4";
            label4.Size = new Size(103, 17);
            label4.TabIndex = 7;
            label4.Text = "Menos victorias:";
            // 
            // lblJugadorMenorVictoria
            // 
            lblJugadorMenorVictoria.AutoSize = true;
            lblJugadorMenorVictoria.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblJugadorMenorVictoria.Location = new Point(631, 86);
            lblJugadorMenorVictoria.Name = "lblJugadorMenorVictoria";
            lblJugadorMenorVictoria.Size = new Size(43, 17);
            lblJugadorMenorVictoria.TabIndex = 8;
            lblJugadorMenorVictoria.Text = "label5";
            // 
            // FrmEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 349);
            Controls.Add(lblJugadorMenorVictoria);
            Controls.Add(label4);
            Controls.Add(lblJugadorMasVictoria);
            Controls.Add(label3);
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
        private Label label3;
        private Label lblJugadorMasVictoria;
        private Label label4;
        private Label lblJugadorMenorVictoria;
    }
}