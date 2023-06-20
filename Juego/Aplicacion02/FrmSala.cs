using Entidades;

namespace Aplicacion02
{
    public partial class FrmSala : Form
    {

        private SalaJuego sala;
        private List<Jugador> jugador1;
        private List<Jugador> jugador2;
        private AccesoDatos acceso;
        public FrmSala()
        {
            InitializeComponent();
            this.jugador1 = new List<Jugador>();
            this.jugador2 = new List<Jugador>();
            this.acceso = new AccesoDatos();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarSalas_Click(object sender, EventArgs e)
        {
            FrmGenerarJugadores frmGenerarJugadores = new FrmGenerarJugadores();
            frmGenerarJugadores.ShowDialog();
            if (frmGenerarJugadores.DialogResult == DialogResult.OK)
            {
                this.sala = new SalaJuego(frmGenerarJugadores.Jugador1.Nombre, frmGenerarJugadores.Jugador2.Nombre);
                this.lblNombreJugador1.Text = this.sala.Jugador1.Nombre;
                this.lblNombreJugador2.Text = this.sala.Jugador2.Nombre;
                this.sala.SalaTerminada += SalaTerminadaEventHandler;
                this.sala.Jugador1.ActualizarDados += ActualizarDadosEventHandler;
                this.sala.Jugador2.ActualizarDados += ActualizarDadosEventHandler;
                this.btnJugar.Enabled = false;
                Task hiloSala = new Task(() => sala.Jugar());
                hiloSala.Start();

            }
        }

        public void ModificarDataGrid()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(this.ModificarDataGrid);
            }
            else
            {
                this.jugador1.Add(this.sala.Jugador1);
                this.jugador2.Add(this.sala.Jugador2);
                this.dtgvJugador1.DataSource = this.jugador1;
                this.dtgvJugador2.DataSource = this.jugador2;
            }
        }

        private void SalaTerminadaEventHandler(object sender, EventArgs e)
        {
            this.ModificarDataGrid();
            this.acceso.AgregarDato(this.sala.Jugador1);
            this.acceso.AgregarDato(this.sala.Jugador2);
            this.btnJugar.Enabled = true;
            MessageBox.Show("Sala de juego terminada: " + this.sala.Id);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.sala.Terminar();
        }

        private void ActualizarDadosEventHandler(List<int> dados)
        {
            this.picDado01.Image = this.DevolverImagen(dados[0]);

            this.picDado02.Image = this.DevolverImagen(dados[1]);

            this.picDado03.Image = this.DevolverImagen(dados[2]);

            this.picDado04.Image = this.DevolverImagen(dados[3]);

            this.picDado05.Image = this.DevolverImagen(dados[4]);
        }

        private Bitmap DevolverImagen(int indice)
        {
            switch (indice)
            {
                case 1:
                    return Properties.Resources.dado1;

                case 2:
                    return Properties.Resources.dado2;

                case 3:
                    return Properties.Resources.dado3;

                case 4:
                    return Properties.Resources.dado4;

                case 5:
                    return Properties.Resources.dado5;

                case 6:
                    return Properties.Resources.dado6;
                default:
                    throw new ArgumentOutOfRangeException(nameof(indice));
            }
        }

    }
}