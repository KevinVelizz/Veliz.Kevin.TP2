namespace Aplicacion02
{
    partial class FrmPrincipal
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
            btnGenerarSala = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            btnCrearJugadores = new Button();
            panel1 = new Panel();
            lblNombreUser = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnGenerarSala
            // 
            btnGenerarSala.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnGenerarSala.Location = new Point(3, 138);
            btnGenerarSala.Name = "btnGenerarSala";
            btnGenerarSala.Size = new Size(246, 49);
            btnGenerarSala.TabIndex = 0;
            btnGenerarSala.Text = "Generar sala";
            btnGenerarSala.UseVisualStyleBackColor = true;
            btnGenerarSala.Click += btnGenerarSala_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.generala;
            pictureBox1.Location = new Point(301, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(403, 76);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 2;
            label1.Text = "GENERALA";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(3, 214);
            button1.Name = "button1";
            button1.Size = new Size(246, 49);
            button1.TabIndex = 3;
            button1.Text = "Estadisticas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCrearJugadores
            // 
            btnCrearJugadores.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnCrearJugadores.Location = new Point(3, 289);
            btnCrearJugadores.Name = "btnCrearJugadores";
            btnCrearJugadores.Size = new Size(246, 49);
            btnCrearJugadores.TabIndex = 4;
            btnCrearJugadores.Text = "Crear jugadores";
            btnCrearJugadores.UseVisualStyleBackColor = true;
            btnCrearJugadores.Click += btnCrearJugadores_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(lblNombreUser);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnGenerarSala);
            panel1.Controls.Add(btnCrearJugadores);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 450);
            panel1.TabIndex = 5;
            // 
            // lblNombreUser
            // 
            lblNombreUser.AutoSize = true;
            lblNombreUser.Location = new Point(101, 86);
            lblNombreUser.Name = "lblNombreUser";
            lblNombreUser.Size = new Size(38, 15);
            lblNombreUser.TabIndex = 6;
            lblNombreUser.Text = "label2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario;
            pictureBox2.Location = new Point(72, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Name = "FrmPrincipal";
            Text = "FormSala";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarSala;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button btnCrearJugadores;
        private Panel panel1;
        private Label lblNombreUser;
        private PictureBox pictureBox2;
    }
}