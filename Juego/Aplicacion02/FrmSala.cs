using Entidades;

namespace Aplicacion02
{
    public partial class FrmSala : Form
    {

        private SalaJuego sala;
        private CancellationTokenSource cancellationTokenSource;
        private static List<SalaJuego> salas;
        private Task hiloSala;
        public delegate void CallBack(DataGridView dtgvJugador, Jugador jugador);

        public FrmSala()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            salas = new List<SalaJuego>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            salas = Soporte.ArchivoJson.Deserealizar(Soporte.ArchivoJson.PathSalas);
        }

        private void btnGenerarSalas_Click(object sender, EventArgs e)
        {
            FrmSeleccionarJugadores frmSeleccionarJugadores = new FrmSeleccionarJugadores();
            frmSeleccionarJugadores.ShowDialog();
            if (frmSeleccionarJugadores.DialogResult == DialogResult.OK)
            {
                this.sala = new SalaJuego(frmSeleccionarJugadores.Jugador1, frmSeleccionarJugadores.Jugador2);
                this.lblNombreJugador1.Text = this.sala.Jugador1.Nombre;
                this.lblNombreJugador2.Text = this.sala.Jugador2.Nombre;

                this.sala.SalaTerminada += SalaTerminadaEventHandler;
                this.sala.Jugador1.ActualizarDados += ActualizarDadosEventHandler;
                this.sala.Jugador2.ActualizarDados += ActualizarDadosEventHandler;
                this.sala.ActualizarCategorias += ActualizarCategoriasEventHandler;

                this.cancellationTokenSource = new CancellationTokenSource();
                CancellationToken token = this.cancellationTokenSource.Token;

                this.btnJugar.Enabled = false;
                this.lblIdSala.Text = sala.Id.ToString();
                this.lblNumeroTurno.Visible = true;
                this.lblNumeroTurno.Text = sala.Turno.ToString();
                this.lblJugadorJugando.Visible = true;
                this.lblJugadorJugando.Text = sala.JugadorJugando;
                hiloSala = Task.Run(() => sala.Jugar(this.cancellationTokenSource), token);
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
                this.lblNumeroTurno.Text = this.sala.Turno.ToString();
                this.lblJugadorJugando.Text = sala.JugadorJugando;
                dtgvJugador.Rows.Clear();
                foreach (Dictionary<string, bool> dic in jugador.ListaCategorias)
                {
                    foreach (KeyValuePair<string, bool> kvp in dic)
                    {
                        int rows = dtgvJugador.Rows.Add();
                        dtgvJugador.Rows[rows].Cells[0].Value = kvp.Key;
                        dtgvJugador.Rows[rows].Cells[1].Value = kvp.Value;
                    }
                }
            }
        }

        private void ModificarLabelPuntosJugadores(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<Jugador, Jugador>(ModificarLabelPuntosJugadores), jugadorUno, jugadorDos);
            }
            else
            {
                this.lblPuntajeJugador1.Visible = true;
                this.lblPuntajeJugador2.Visible = true;
                this.lblPuntajeJugador1.Text = jugadorUno.Puntaje.ToString();
                this.lblPuntajeJugador2.Text = jugadorDos.Puntaje.ToString();
            }
        }

        private void SalaTerminadaEventHandler(object sender, EventArgs e)
        {
            SalaJuego salaJuego = (SalaJuego)sender;
            this.ModificarLabelPuntosJugadores(salaJuego.Jugador1, salaJuego.Jugador2);
            if (salaJuego.Jugador1.Puntaje > salaJuego.Jugador2.Puntaje)
            {
                MessageBox.Show($"El ganador es: {salaJuego.Jugador1.Nombre}");
            }
            else if (salaJuego.Jugador2.Puntaje > salaJuego.Jugador1.Puntaje)
            {
                MessageBox.Show($"El ganador es: {salaJuego.Jugador2.Nombre}");
            }
            else
            {
                MessageBox.Show("Empate.");
            }
            MessageBox.Show("Sala de juego terminada: " + this.sala.Id);
            salas.Add(salaJuego);
            Soporte.ArchivosXML.Serealizar(salas, Soporte.ArchivosXML.PathSalas);
            Soporte.ArchivoJson.Serealizar(salas, Soporte.ArchivoJson.PathSalas);
            salaJuego.Jugador1.Puntaje += sala.PuntosJugador1;
            salaJuego.Jugador2.Puntaje += sala.PuntosJugador2;
            Soporte.ModificarJugador(salaJuego.Jugador1);
            Soporte.ModificarJugador(salaJuego.Jugador2);
        }

        private async void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hiloSala != null && !hiloSala.IsCompleted)
            {
                cancellationTokenSource?.Cancel();
                MessageBox.Show("Se finalizará cuando termine el turno.");
                e.Cancel = true;
                await hiloSala;
                this.Close();
            }
        }


        /// <summary>
        /// El método actualiza las imagenes de los dados dependiendo los valores de la lista que recibe por parametros.
        /// </summary>
        /// <param name="dados"></param>

        private void ActualizarDadosEventHandler(List<int> dados)
        {
            this.picDado01.Image = this.DevolverImagen(dados[0]);

            this.picDado02.Image = this.DevolverImagen(dados[1]);

            this.picDado03.Image = this.DevolverImagen(dados[2]);

            this.picDado04.Image = this.DevolverImagen(dados[3]);

            this.picDado05.Image = this.DevolverImagen(dados[4]);
        }


        /// <summary>
        /// El método busca la imagen en la carpeta Resources y devuelve la imagen.
        /// </summary>
        /// <param name="indice"></param>
        /// <returns>un objeto Bitmap correspondiente a la imagen.</returns>
        private Bitmap DevolverImagen(int indice)
        {
            try
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
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Índice fuera de rango: " + ex.Message);
                return null;
            }
        }


        /// <summary>
        /// El método modifica los datos del DataGridView dependiendo el jugador ingresado.
        /// </summary>
        /// <param name="jugador"></param>
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


        /// <summary>
        /// El método cancela el hilo secundario producido anteriormente y finalizará cuando termine la ronda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.hiloSala != null)
            {
                this.cancellationTokenSource.Cancel();
                MessageBox.Show("Se finalizará cuando termine el turno.");
                this.btnCancelar.Enabled = false;
            }
        }
    }
}