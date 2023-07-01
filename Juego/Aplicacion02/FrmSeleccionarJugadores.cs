using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion02
{
    public partial class FrmSeleccionarJugadores : Form
    {
        private Jugador jugador1;
        private Jugador jugador2;

        public Jugador Jugador1 { get => jugador1;}
        public Jugador Jugador2 { get => jugador2; }

        public FrmSeleccionarJugadores()
        {
            InitializeComponent();
        }

        private void FrmSeleccionarJugadores_Load(object sender, EventArgs e)
        {
            this.cboJugadores01.DataSource = Soporte.ObtenerValoresJugadores();
            this.cboJugadores02.DataSource = Soporte.ObtenerValoresJugadores();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (((Jugador)this.cboJugadores01.SelectedItem).Nombre == ((Jugador)this.cboJugadores02.SelectedItem).Nombre)
                {
                    throw new Exception("Seleccione dos jugadores diferentes para cada uno.");
                }
                this.jugador1 = (Jugador)this.cboJugadores01.SelectedItem;
                this.jugador2 = (Jugador)this.cboJugadores02.SelectedItem;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.lblMensajeError.Visible = true;
                this.lblMensajeError.Text = ex.Message;
            }

        }
    }
}
