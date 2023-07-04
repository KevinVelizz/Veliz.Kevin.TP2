namespace Aplicacion02
{
    partial class FrmSala
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picDado01 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            lblJugadorJugando = new Label();
            lblNumeroTurno = new Label();
            lblTurno = new Label();
            picDado05 = new PictureBox();
            picDado04 = new PictureBox();
            picDado03 = new PictureBox();
            picDado02 = new PictureBox();
            panelJugador2 = new Panel();
            lblPuntajeJugador2 = new Label();
            lblPuntajeText2 = new Label();
            lblNombreJugador2 = new Label();
            dtgvJugador2 = new DataGridView();
            Categoria1 = new DataGridViewTextBoxColumn();
            Realizado1 = new DataGridViewTextBoxColumn();
            panelJugador1 = new Panel();
            lblPuntajeJugador1 = new Label();
            lblPuntajeText1 = new Label();
            lblNombreJugador1 = new Label();
            dtgvJugador1 = new DataGridView();
            Categoria = new DataGridViewTextBoxColumn();
            Realizado = new DataGridViewTextBoxColumn();
            btnJugar = new Button();
            btnCancelar = new Button();
            lblIdSala = new Label();
            ((System.ComponentModel.ISupportInitialize)picDado01).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDado05).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDado04).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDado03).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDado02).BeginInit();
            panelJugador2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvJugador2).BeginInit();
            panelJugador1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvJugador1).BeginInit();
            SuspendLayout();
            // 
            // picDado01
            // 
            picDado01.Image = Properties.Resources.dado1;
            picDado01.Location = new Point(108, 64);
            picDado01.Name = "picDado01";
            picDado01.Size = new Size(66, 67);
            picDado01.SizeMode = PictureBoxSizeMode.Zoom;
            picDado01.TabIndex = 2;
            picDado01.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Green;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblJugadorJugando);
            panel1.Controls.Add(lblNumeroTurno);
            panel1.Controls.Add(lblTurno);
            panel1.Controls.Add(picDado05);
            panel1.Controls.Add(picDado04);
            panel1.Controls.Add(picDado03);
            panel1.Controls.Add(picDado02);
            panel1.Controls.Add(picDado01);
            panel1.Location = new Point(326, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 465);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(75, 13);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 10;
            label1.Text = "Jugando:";
            // 
            // lblJugadorJugando
            // 
            lblJugadorJugando.AutoSize = true;
            lblJugadorJugando.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblJugadorJugando.Location = new Point(149, 13);
            lblJugadorJugando.Name = "lblJugadorJugando";
            lblJugadorJugando.Size = new Size(17, 20);
            lblJugadorJugando.TabIndex = 9;
            lblJugadorJugando.Text = "1";
            lblJugadorJugando.Visible = false;
            // 
            // lblNumeroTurno
            // 
            lblNumeroTurno.AutoSize = true;
            lblNumeroTurno.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblNumeroTurno.Location = new Point(149, 433);
            lblNumeroTurno.Name = "lblNumeroTurno";
            lblNumeroTurno.Size = new Size(43, 17);
            lblNumeroTurno.TabIndex = 8;
            lblNumeroTurno.Text = "label1";
            lblNumeroTurno.Visible = false;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblTurno.Location = new Point(98, 433);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(45, 17);
            lblTurno.TabIndex = 7;
            lblTurno.Text = "Turno:";
            // 
            // picDado05
            // 
            picDado05.Image = Properties.Resources.dado5;
            picDado05.Location = new Point(108, 355);
            picDado05.Name = "picDado05";
            picDado05.Size = new Size(66, 66);
            picDado05.SizeMode = PictureBoxSizeMode.Zoom;
            picDado05.TabIndex = 6;
            picDado05.TabStop = false;
            // 
            // picDado04
            // 
            picDado04.Image = Properties.Resources.dado4;
            picDado04.Location = new Point(108, 282);
            picDado04.Name = "picDado04";
            picDado04.Size = new Size(66, 67);
            picDado04.SizeMode = PictureBoxSizeMode.Zoom;
            picDado04.TabIndex = 5;
            picDado04.TabStop = false;
            // 
            // picDado03
            // 
            picDado03.Image = Properties.Resources.dado3;
            picDado03.Location = new Point(108, 210);
            picDado03.Name = "picDado03";
            picDado03.Size = new Size(66, 66);
            picDado03.SizeMode = PictureBoxSizeMode.Zoom;
            picDado03.TabIndex = 4;
            picDado03.TabStop = false;
            // 
            // picDado02
            // 
            picDado02.Image = Properties.Resources.dado2;
            picDado02.Location = new Point(108, 137);
            picDado02.Name = "picDado02";
            picDado02.Size = new Size(66, 67);
            picDado02.SizeMode = PictureBoxSizeMode.Zoom;
            picDado02.TabIndex = 3;
            picDado02.TabStop = false;
            // 
            // panelJugador2
            // 
            panelJugador2.Anchor = AnchorStyles.None;
            panelJugador2.BackColor = Color.Green;
            panelJugador2.Controls.Add(lblPuntajeJugador2);
            panelJugador2.Controls.Add(lblPuntajeText2);
            panelJugador2.Controls.Add(lblNombreJugador2);
            panelJugador2.Controls.Add(dtgvJugador2);
            panelJugador2.Location = new Point(612, 42);
            panelJugador2.Name = "panelJugador2";
            panelJugador2.Size = new Size(261, 219);
            panelJugador2.TabIndex = 4;
            // 
            // lblPuntajeJugador2
            // 
            lblPuntajeJugador2.AutoSize = true;
            lblPuntajeJugador2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPuntajeJugador2.Location = new Point(136, 193);
            lblPuntajeJugador2.Name = "lblPuntajeJugador2";
            lblPuntajeJugador2.Size = new Size(43, 17);
            lblPuntajeJugador2.TabIndex = 3;
            lblPuntajeJugador2.Text = "label1";
            lblPuntajeJugador2.Visible = false;
            // 
            // lblPuntajeText2
            // 
            lblPuntajeText2.Anchor = AnchorStyles.None;
            lblPuntajeText2.AutoSize = true;
            lblPuntajeText2.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPuntajeText2.Location = new Point(80, 193);
            lblPuntajeText2.Name = "lblPuntajeText2";
            lblPuntajeText2.Size = new Size(53, 17);
            lblPuntajeText2.TabIndex = 2;
            lblPuntajeText2.Text = "Puntaje:";
            // 
            // lblNombreJugador2
            // 
            lblNombreJugador2.AutoSize = true;
            lblNombreJugador2.Location = new Point(106, 14);
            lblNombreJugador2.Name = "lblNombreJugador2";
            lblNombreJugador2.Size = new Size(58, 15);
            lblNombreJugador2.TabIndex = 1;
            lblNombreJugador2.Text = "Jugador 2";
            // 
            // dtgvJugador2
            // 
            dtgvJugador2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvJugador2.Columns.AddRange(new DataGridViewColumn[] { Categoria1, Realizado1 });
            dtgvJugador2.Location = new Point(15, 32);
            dtgvJugador2.Name = "dtgvJugador2";
            dtgvJugador2.RowTemplate.Height = 25;
            dtgvJugador2.Size = new Size(231, 150);
            dtgvJugador2.TabIndex = 0;
            // 
            // Categoria1
            // 
            Categoria1.HeaderText = "Categoria";
            Categoria1.Name = "Categoria1";
            // 
            // Realizado1
            // 
            Realizado1.HeaderText = "Realizado";
            Realizado1.Name = "Realizado1";
            // 
            // panelJugador1
            // 
            panelJugador1.Anchor = AnchorStyles.None;
            panelJugador1.BackColor = Color.DarkGreen;
            panelJugador1.Controls.Add(lblPuntajeJugador1);
            panelJugador1.Controls.Add(lblPuntajeText1);
            panelJugador1.Controls.Add(lblNombreJugador1);
            panelJugador1.Controls.Add(dtgvJugador1);
            panelJugador1.Location = new Point(63, 42);
            panelJugador1.Name = "panelJugador1";
            panelJugador1.Size = new Size(257, 219);
            panelJugador1.TabIndex = 5;
            // 
            // lblPuntajeJugador1
            // 
            lblPuntajeJugador1.AutoSize = true;
            lblPuntajeJugador1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPuntajeJugador1.Location = new Point(130, 193);
            lblPuntajeJugador1.Name = "lblPuntajeJugador1";
            lblPuntajeJugador1.Size = new Size(43, 17);
            lblPuntajeJugador1.TabIndex = 3;
            lblPuntajeJugador1.Text = "label1";
            lblPuntajeJugador1.Visible = false;
            // 
            // lblPuntajeText1
            // 
            lblPuntajeText1.Anchor = AnchorStyles.None;
            lblPuntajeText1.AutoSize = true;
            lblPuntajeText1.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPuntajeText1.Location = new Point(77, 193);
            lblPuntajeText1.Name = "lblPuntajeText1";
            lblPuntajeText1.Size = new Size(53, 17);
            lblPuntajeText1.TabIndex = 2;
            lblPuntajeText1.Text = "Puntaje:";
            // 
            // lblNombreJugador1
            // 
            lblNombreJugador1.AutoSize = true;
            lblNombreJugador1.Location = new Point(96, 14);
            lblNombreJugador1.Name = "lblNombreJugador1";
            lblNombreJugador1.Size = new Size(58, 15);
            lblNombreJugador1.TabIndex = 1;
            lblNombreJugador1.Text = "Jugador 1";
            // 
            // dtgvJugador1
            // 
            dtgvJugador1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvJugador1.Columns.AddRange(new DataGridViewColumn[] { Categoria, Realizado });
            dtgvJugador1.Location = new Point(13, 32);
            dtgvJugador1.Name = "dtgvJugador1";
            dtgvJugador1.RowTemplate.Height = 25;
            dtgvJugador1.Size = new Size(225, 150);
            dtgvJugador1.TabIndex = 0;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Realizado
            // 
            Realizado.HeaderText = "Realizado";
            Realizado.Name = "Realizado";
            // 
            // btnJugar
            // 
            btnJugar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnJugar.Location = new Point(12, 439);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(89, 43);
            btnJugar.TabIndex = 6;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnGenerarSalas_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCancelar.Location = new Point(107, 439);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 43);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblIdSala
            // 
            lblIdSala.AutoSize = true;
            lblIdSala.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdSala.ForeColor = SystemColors.ButtonFace;
            lblIdSala.Location = new Point(5, 42);
            lblIdSala.Name = "lblIdSala";
            lblIdSala.Size = new Size(52, 21);
            lblIdSala.TabIndex = 8;
            lblIdSala.Text = "label1";
            // 
            // FrmSala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(919, 545);
            Controls.Add(lblIdSala);
            Controls.Add(btnCancelar);
            Controls.Add(btnJugar);
            Controls.Add(panelJugador1);
            Controls.Add(panelJugador2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmSala";
            Text = "Salas";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)picDado01).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDado05).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDado04).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDado03).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDado02).EndInit();
            panelJugador2.ResumeLayout(false);
            panelJugador2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvJugador2).EndInit();
            panelJugador1.ResumeLayout(false);
            panelJugador1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvJugador1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picDado01;
        private Panel panel1;
        private PictureBox picDado05;
        private PictureBox picDado04;
        private PictureBox picDado03;
        private PictureBox picDado02;
        private Panel panelJugador2;
        private Label lblNombreJugador2;
        private DataGridView dtgvJugador2;
        private Panel panelJugador1;
        private Label lblNombreJugador1;
        private DataGridView dtgvJugador1;
        private Label lblPuntajeJugador2;
        private Label lblPuntajeText2;
        private Label lblPuntajeJugador1;
        private Label lblPuntajeText1;
        private Button btnJugar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Realizado;
        private DataGridViewTextBoxColumn Categoria1;
        private DataGridViewTextBoxColumn Realizado1;
        private Label lblIdSala;
        private Label lblNumeroTurno;
        private Label lblTurno;
        private Label lblJugadorJugando;
        private Label label1;
    }
}