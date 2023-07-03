namespace Aplicacion02
{
    partial class FrmInciarSesion
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
            txtEmail = new TextBox();
            txtContrasenia = new TextBox();
            lblEmail = new Label();
            lblContrasenia = new Label();
            btnIngresar = new Button();
            btnCrearUsuario = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(100, 129);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(291, 23);
            txtContrasenia.TabIndex = 1;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(55, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(24, 137);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(70, 15);
            lblContrasenia.TabIndex = 3;
            lblContrasenia.Text = "Contraseña:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(316, 203);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(100, 203);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(90, 23);
            btnCrearUsuario.TabIndex = 5;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // FrmInciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 285);
            Controls.Add(btnCrearUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(lblContrasenia);
            Controls.Add(lblEmail);
            Controls.Add(txtContrasenia);
            Controls.Add(txtEmail);
            Name = "FrmInciarSesion";
            Text = "FrmInciarSesion";
            Load += FrmInciarSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtContrasenia;
        private Label lblEmail;
        private Label lblContrasenia;
        private Button btnIngresar;
        private Button btnCrearUsuario;
    }
}