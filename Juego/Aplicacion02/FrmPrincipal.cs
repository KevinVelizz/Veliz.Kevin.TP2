namespace Aplicacion02
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGenerarSala_Click_1(object sender, EventArgs e)
        {
            Thread thread = new Thread(GenerarFormulario);
            thread.Start();
        }

        private void GenerarFormulario()
        {
            // Crear un nuevo formulario de partida
            FrmSala formulario = new FrmSala();
            formulario.Text = "Nuevo Formulario";

            // Mostrar el formulario en un hilo de interfaz de usuario separado
            Application.Run(formulario);
        }


    }
}
