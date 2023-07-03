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
            dtgvSalas.Location = new Point(12, 83);
            dtgvSalas.Name = "dtgvSalas";
            dtgvSalas.RowTemplate.Height = 25;
            dtgvSalas.Size = new Size(240, 150);
            dtgvSalas.TabIndex = 1;
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
            ClientSize = new Size(543, 295);
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
    }
}