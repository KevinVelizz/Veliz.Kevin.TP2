using Entidades;
namespace Aplicacion02
{
    public partial class FrmInciarSesion : Form
    {
        private Usuario usuario;
        public Usuario Usuario { get => usuario; private set => usuario = value; }

        public FrmInciarSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario? aux = Funcionalidades.Login(txtEmail.Text, txtContrasenia.Text);

            if (aux != null)
            {
                this.usuario = aux;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al ingresar. Verifique los datos.");
            }
        }

        private void FrmInciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.ShowDialog();
        }
    }
}
