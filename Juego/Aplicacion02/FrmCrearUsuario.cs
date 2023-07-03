using Entidades;
namespace Aplicacion02
{
    public partial class FrmCrearUsuario : Form
    {
        private List<Usuario> usuarios;

        public FrmCrearUsuario()
        {
            InitializeComponent();
            this.usuarios = new List<Usuario>();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text != "" && this.txtClave.Text != "" && this.txtEmail.Text != "")
                {
                    Usuario usuario = new Usuario(this.txtNombre.Text, this.txtEmail.Text, this.txtClave.Text);
                    this.usuarios.Add(usuario);
                    MessageBox.Show("Se creó correctamente");
                    Soporte.UsuariosJson.Serealizar(this.usuarios, Soporte.UsuariosJson.PathUsuarios);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.lblMensajeError.Visible = true;
                    this.lblMensajeError.Text = "Complete todos los campos";
                }
            }
            catch (Exception ex)
            {
                this.lblMensajeError.Visible = true;
                this.lblMensajeError.Text = ex.Message;
            }
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            this.usuarios = Soporte.UsuariosJson.Deserealizar(Soporte.UsuariosJson.PathUsuarios);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
        }
    }
}
