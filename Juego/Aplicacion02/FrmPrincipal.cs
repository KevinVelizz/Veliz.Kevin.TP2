namespace Aplicacion02
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGenerarSala_Click_1(object sender, EventArgs e)
        {
            Task task = new Task(GenerarFormulario);
            task.Start();
        }

        private void GenerarFormulario()
        {
            FrmSala formulario = new FrmSala();
            formulario.Text = "Nueva Sala";
            Application.Run(formulario);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEstadistica frmEstadistica = new FrmEstadistica();
            frmEstadistica.ShowDialog();

        }
    }
}
