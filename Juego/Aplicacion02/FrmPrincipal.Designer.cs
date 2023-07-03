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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGenerarSala
            // 
            btnGenerarSala.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnGenerarSala.Location = new Point(12, 376);
            btnGenerarSala.Name = "btnGenerarSala";
            btnGenerarSala.Size = new Size(86, 49);
            btnGenerarSala.TabIndex = 0;
            btnGenerarSala.Text = "Generar sala";
            btnGenerarSala.UseVisualStyleBackColor = true;
            btnGenerarSala.Click += btnGenerarSala_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.generala;
            pictureBox1.Location = new Point(217, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(309, 59);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 2;
            label1.Text = "GENERALA";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(104, 376);
            button1.Name = "button1";
            button1.Size = new Size(93, 49);
            button1.TabIndex = 3;
            button1.Text = "Estadisticas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCrearJugadores
            // 
            btnCrearJugadores.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnCrearJugadores.Location = new Point(203, 376);
            btnCrearJugadores.Name = "btnCrearJugadores";
            btnCrearJugadores.Size = new Size(95, 49);
            btnCrearJugadores.TabIndex = 4;
            btnCrearJugadores.Text = "Crear jugadores";
            btnCrearJugadores.UseVisualStyleBackColor = true;
            btnCrearJugadores.Click += btnCrearJugadores_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearJugadores);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnGenerarSala);
            Name = "FrmPrincipal";
            Text = "FormSala";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarSala;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button btnCrearJugadores;
    }
}