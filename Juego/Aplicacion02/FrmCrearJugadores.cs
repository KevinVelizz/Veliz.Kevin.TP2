using Entidades;

namespace Aplicacion02
{
    public partial class FrmCrearJugadores : Form
    {
        Jugador jugador1;

        public FrmCrearJugadores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Jugador Jugador1
        {
            get { return this.jugador1; }
            set { this.jugador1 = value; }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.jugador1 = new Jugador(this.txtJugadorUno.Text);
                if(Soporte.AgregarJugador(this.jugador1))
                {
                    MessageBox.Show("Se creó correctamente.");
                }
                else
                {
                    MessageBox.Show("No se creó correctamente.");
                }
            }
            catch (Exception ex)
            {
                this.lblAdvertencia.Visible = true;
                this.lblAdvertencia.Text = $"{ex.Message}";
            }
        }

        private void FrmGenerarJugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
