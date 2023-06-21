using Entidades;

namespace Aplicacion02
{
    public partial class FrmSala : Form
    {

        private SalaJuego sala;
        private AccesoDatos acceso;
        private CancellationTokenSource cancellationTokenSource;
        private static List<SalaJuego> salas;

        public delegate void CallBack(DataGridView dtgvJugador, Jugador jugador);

        public FrmSala()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.acceso = new AccesoDatos();
            salas = new List<SalaJuego>();
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
                this.sala.ActualizarCategorias += ActualizarCategoriasEventHandler;

                this.cancellationTokenSource = new CancellationTokenSource();
                CancellationToken token = this.cancellationTokenSource.Token;

                this.btnJugar.Enabled = false;
                Task hiloSala = new Task(() => sala.Jugar(this.cancellationTokenSource), token);
                hiloSala.Start();
            }
        }

        private void ModificarDataGrid(DataGridView dtgvJugador, Jugador jugador)
        {
            if (this.InvokeRequired)
            {
                CallBack callBack = new CallBack(this.ModificarDataGrid);
                Object[] argumentos = { dtgvJugador, jugador };
                this.BeginInvoke(callBack, argumentos);
            }
            else
            {
                foreach (Dictionary<string, bool> dic in jugador.ListaCategorias)
                {
                    foreach (KeyValuePair<string, bool> kvp in dic)
                    {
                        int rows = dtgvJugador.Rows.Add();
                        dtgvJugador.Rows[rows].Cells[0].Value = kvp.Key;
                        dtgvJugador.Rows[rows].Cells[1].Value = kvp.Value;
                    }
                }
                this.btnJugar.Enabled = true;
            }
        }

        private void ModificarLabelPuntosJugadores(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<Jugador, Jugador>(ModificarLabelPuntosJugadores), jugadorUno, jugadorDos);
            }
            else
            {
                this.lblPuntajeJugador1.Text = jugadorUno.Puntaje.ToString();
                this.lblPuntajeJugador2.Text = jugadorDos.Puntaje.ToString();
            }
        }

        private void SalaTerminadaEventHandler(object sender, EventArgs e)
        {
            SalaJuego salaJuego = (SalaJuego)sender;
            this.acceso.AgregarDatoJugador(this.sala.Jugador1);
            this.acceso.AgregarDatoJugador(this.sala.Jugador2);
            salas.Add(salaJuego);
            Archivos.SerealizarSalas(salas);

            this.ModificarLabelPuntosJugadores(salaJuego.Jugador1, salaJuego.Jugador2);

            if (salaJuego.Jugador1.Puntaje > salaJuego.Jugador2.Puntaje)
            {
                MessageBox.Show($"El ganador es: {salaJuego.Jugador1.Nombre}");
            }
            else
            {
                MessageBox.Show($"El ganador es: {salaJuego.Jugador2.Nombre}");
            }
            MessageBox.Show("Sala de juego terminada: " + this.sala.Id);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.sala is not null)
                {
                    this.sala.Terminar();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"{ex.Message} - {ex.StackTrace}");
            }
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

        private void ActualizarCategoriasEventHandler(Jugador jugador)
        {
            if (this.lblNombreJugador1.Text == jugador.Nombre)
            {
                this.ModificarDataGrid(this.dtgvJugador1, jugador);
            }
            else
            {
                this.ModificarDataGrid(this.dtgvJugador2, jugador);
            }
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.cancellationTokenSource.Cancel();
        }
    }
}