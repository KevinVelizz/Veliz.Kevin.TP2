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
            Task task = new Task(GenerarFormulario);
            task.Start();
        }

        private void GenerarFormulario()
        {
            FrmSala formulario = new FrmSala();
            formulario.Text = "Nuevo Formulario";
            Application.Run(formulario);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
