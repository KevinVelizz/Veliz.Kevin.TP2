namespace Aplicacion02
{
    partial class FrmPrincipal
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
            btnModificarDado01 = new Button();
            button2 = new Button();
            picDado01 = new PictureBox();
            panel1 = new Panel();
            picDado05 = new PictureBox();
            picDado04 = new PictureBox();
            picDado03 = new PictureBox();
            picDado02 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDado01).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDado05).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDado04).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDado03).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDado02).BeginInit();
            SuspendLayout();
            // 
            // btnModificarDado01
            // 
            btnModificarDado01.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnModificarDado01.Location = new Point(37, 375);
            btnModificarDado01.Name = "btnModificarDado01";
            btnModificarDado01.Size = new Size(75, 33);
            btnModificarDado01.TabIndex = 0;
            btnModificarDado01.Text = "button1";
            btnModificarDado01.UseVisualStyleBackColor = true;
            btnModificarDado01.Click += btnModificarDado01_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(134, 375);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // picDado01
            // 
            picDado01.Image = Properties.Resources.dado11;
            picDado01.Location = new Point(64, 59);
            picDado01.Name = "picDado01";
            picDado01.Size = new Size(66, 67);
            picDado01.TabIndex = 2;
            picDado01.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(picDado05);
            panel1.Controls.Add(picDado04);
            panel1.Controls.Add(picDado03);
            panel1.Controls.Add(picDado02);
            panel1.Controls.Add(picDado01);
            panel1.Location = new Point(37, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 186);
            panel1.TabIndex = 3;
            // 
            // picDado05
            // 
            picDado05.Image = Properties.Resources.dado5;
            picDado05.Location = new Point(361, 59);
            picDado05.Name = "picDado05";
            picDado05.Size = new Size(69, 67);
            picDado05.TabIndex = 6;
            picDado05.TabStop = false;
            // 
            // picDado04
            // 
            picDado04.Image = Properties.Resources.dado4;
            picDado04.Location = new Point(286, 59);
            picDado04.Name = "picDado04";
            picDado04.Size = new Size(69, 67);
            picDado04.TabIndex = 5;
            picDado04.TabStop = false;
            // 
            // picDado03
            // 
            picDado03.Image = Properties.Resources.dado3;
            picDado03.Location = new Point(211, 59);
            picDado03.Name = "picDado03";
            picDado03.Size = new Size(69, 67);
            picDado03.TabIndex = 4;
            picDado03.TabStop = false;
            // 
            // picDado02
            // 
            picDado02.Image = Properties.Resources.dado2;
            picDado02.Location = new Point(136, 59);
            picDado02.Name = "picDado02";
            picDado02.Size = new Size(69, 67);
            picDado02.TabIndex = 3;
            picDado02.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 508);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(btnModificarDado01);
            Name = "FrmPrincipal";
            Text = "Salas";
            ((System.ComponentModel.ISupportInitialize)picDado01).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDado05).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDado04).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDado03).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDado02).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnModificarDado01;
        private Button button2;
        private PictureBox picDado01;
        private Panel panel1;
        private PictureBox picDado05;
        private PictureBox picDado04;
        private PictureBox picDado03;
        private PictureBox picDado02;
    }
}