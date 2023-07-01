using Entidades;

namespace Aplicacion02
{
    public partial class FrmCrearJugadores : Form
    {
        Jugador jugador1;
        Jugador jugador2;

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

        public Jugador Jugador2
        {
            get { return this.jugador2; }
            set { this.jugador2 = value; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.jugador1 = new Jugador(this.txtJugadorUno.Text);
                Soporte.SubirJugador(this.jugador1);
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
