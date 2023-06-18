using Entidades;
namespace Aplicacion02
{
    public partial class FrmSala : Form
    {

        private List<SalaJuego> salas;
        private SalaJuego sala;
        private List<Jugador> jugador1;
        private List<Jugador> jugador2;
        private AccesoDatos acceso;
        public FrmSala()
        {
            InitializeComponent();
            this.salas = new List<SalaJuego>();
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
                Thread hiloSala = new Thread(() => sala.Jugar());
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
            SalaJuego salaTerminada = (SalaJuego)sender;
            this.salas.Remove(salaTerminada);
            this.ModificarDataGrid();
            this.acceso.AgregarDato(jugador1[0]);
            this.acceso.AgregarDato(jugador2[0]);
            MessageBox.Show("Sala de juego terminada: " + salaTerminada.Id);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (SalaJuego sala1 in this.salas)
            {
                sala1.Terminar();
            }
        }

        private void ActualizarDadosEventHandler(List<int> dados)
        {
            // Actualizar las imágenes de los dados en el subproceso principal de la interfaz de usuario
            Invoke(new Action(() =>
            {
                string rutaImagen = $"C:\\Users\\veliz\\Desktop\\dados\\dado{dados[0]}.png";
                this.picDado01.Image = Image.FromFile(rutaImagen);

                rutaImagen = $"C:\\Users\\veliz\\Desktop\\dados\\dado{dados[1]}.png";
                this.picDado02.Image = Image.FromFile(rutaImagen);

                rutaImagen = $"C:\\Users\\veliz\\Desktop\\dados\\dado{dados[2]}.png";
                this.picDado03.Image = Image.FromFile(rutaImagen);

                rutaImagen = $"C:\\Users\\veliz\\Desktop\\dados\\dado{dados[3]}.png";
                this.picDado04.Image = Image.FromFile(rutaImagen);

                rutaImagen = $"C:\\Users\\veliz\\Desktop\\dados\\dado{dados[4]}.png";
                this.picDado05.Image = Image.FromFile(rutaImagen);
            }));
        }


    }
}