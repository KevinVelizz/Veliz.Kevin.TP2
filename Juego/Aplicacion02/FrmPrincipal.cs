namespace Aplicacion02
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnModificarDado01_Click(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\veliz\\Desktop\\dados\\dado2.png";
            this.picDado01.Image = Image.FromFile(rutaImagen);
        }
    }
}