using Entidades;

namespace Aplicacion02
{
    public partial class FrmGenerarJugadores : Form
    {
        Jugador jugador1;
        Jugador jugador2;

        public FrmGenerarJugadores()
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
            if (this.txtJugadorDos.Text != "" && this.txtJugadorUno.Text != "")
            {
                this.jugador1 = new Jugador(this.txtJugadorUno.Text);
                this.jugador2 = new Jugador(this.txtJugadorDos.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ingrese los datos correspondientes.");
            }
        }

        private void FrmGenerarJugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
