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
            btnTraerJugadores = new Button();
            dtgvSalas = new DataGridView();
            dtgvJugadores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgvSalas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // btnTraerJugadores
            // 
            btnTraerJugadores.Location = new Point(12, 226);
            btnTraerJugadores.Name = "btnTraerJugadores";
            btnTraerJugadores.Size = new Size(96, 49);
            btnTraerJugadores.TabIndex = 0;
            btnTraerJugadores.Text = "Update";
            btnTraerJugadores.UseVisualStyleBackColor = true;
            btnTraerJugadores.Click += btnTraerJugadores_Click;
            // 
            // dtgvSalas
            // 
            dtgvSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSalas.Location = new Point(12, 22);
            dtgvSalas.Name = "dtgvSalas";
            dtgvSalas.RowTemplate.Height = 25;
            dtgvSalas.Size = new Size(240, 150);
            dtgvSalas.TabIndex = 1;
            // 
            // dtgvJugadores
            // 
            dtgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvJugadores.Location = new Point(269, 22);
            dtgvJugadores.Name = "dtgvJugadores";
            dtgvJugadores.RowTemplate.Height = 25;
            dtgvJugadores.Size = new Size(240, 150);
            dtgvJugadores.TabIndex = 2;
            // 
            // FrmEstadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 295);
            Controls.Add(dtgvJugadores);
            Controls.Add(dtgvSalas);
            Controls.Add(btnTraerJugadores);
            Name = "FrmEstadistica";
            Text = "FrmEstadistica";
            Load += FrmEstadistica_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSalas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTraerJugadores;
        private DataGridView dtgvSalas;
        private DataGridView dtgvJugadores;
    }
}