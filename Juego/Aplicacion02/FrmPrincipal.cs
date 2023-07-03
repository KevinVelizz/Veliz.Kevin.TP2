using Entidades;

namespace Aplicacion02
{
    public partial class FrmPrincipal : Form
    {

        private Usuario usuario;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGenerarSala_Click_1(object sender, EventArgs e)
        {
            this.GenerarFormulario();
        }

        private void GenerarFormulario()
        {
            FrmSala formulario = new FrmSala();
            formulario.Text = "Nueva Sala";
            formulario.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmInciarSesion frmInciarSesion = new FrmInciarSesion();
            frmInciarSesion.ShowDialog();
            if (frmInciarSesion.DialogResult == DialogResult.OK)
            {
                this.usuario = frmInciarSesion.Usuario;
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEstadistica frmEstadistica = new FrmEstadistica();
            frmEstadistica.ShowDialog();

        }

        private void btnCrearJugadores_Click(object sender, EventArgs e)
        {
            FrmCrearJugadores frmCrearJugadores = new FrmCrearJugadores();
            frmCrearJugadores.ShowDialog();
            if (frmCrearJugadores.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
