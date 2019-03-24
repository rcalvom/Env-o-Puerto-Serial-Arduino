using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Puerto_Serie_Arduino {
    public partial class Interfaz : Form {
        /// <summary>
        /// Variable para referencial el puerto serial.
        /// </summary>
        private SerialPort serialPort;
        /// <summary>
        /// Constructor: inicializa la interfaz, inicializa el objeto SerialPort y Actualiza el ComboBox con los puertos disponibles.
        /// </summary>
        public Interfaz() {
            this.InitializeComponent();
            this.serialPort = new SerialPort();
            this.ActualizarPuertos();
        }

        /// <summary>
        /// Evento al presionar el Botón de Actualizar.
        /// </summary>
        private void Bactualizar_Click(object sender, EventArgs e) {
            this.ActualizarPuertos();
        } 

        /// <summary>
        /// Evento al presionar el Botón de Conectar.
        /// </summary>
        private void Bconectar_Click(object sender, EventArgs e) {
            if (!serialPort.IsOpen) {
                try {
                    this.serialPort.BaudRate = 9600;
                    this.serialPort.PortName = CBpuertos.SelectedItem.ToString();
                    this.serialPort.Open();
                    this.Bconectar.Text = "Desconectar";
                    this.CBpuertos.Enabled = false;
                    this.Lestado.Text = "Conexión establecida.";
                } catch (Exception) {
                    this.Lestado.Text = "Error al conectarse con el puerto serie " + CBpuertos.SelectedItem.ToString() + ".";
                }
            } else {
                this.serialPort.Close();
                this.Bconectar.Text = "Conectar";
                this.CBpuertos.Enabled = true;
                this.Lestado.Text = "Conexión Interrumpida";
            }
        }

        /// <summary>
        /// Evento al presionar el Botón de Enviar.
        /// </summary>
        private void Benviar_Click(object sender, EventArgs e) {
            EnviarDato();
        }

        /// <summary>
        /// Evento al presionar una tecla mientras se está haciendo focus en el TextBox.
        /// </summary>
        private void TBdato_TextEnter(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (int)Keys.Enter) {
                EnviarDato();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Método que actualiza el ComboBox con la lista de puertos serial disponibles.
        /// </summary>
        private void ActualizarPuertos() {
            this.CBpuertos.Items.Clear();
            this.CBpuertos.Items.AddRange(SerialPort.GetPortNames());
            this.CBpuertos.SelectedItem = SerialPort.GetPortNames()[0];
        }

        /// <summary>
        /// Método que envía un dato de tipo String por el puerto serial ya establecido.
        /// </summary>
        private void EnviarDato() {
            try {
                this.serialPort.Write(this.TBdato.Text);
                this.TBdato.Text = "";
                this.Lestado.Text = "Dato enviado correctamente.";
            } catch (Exception) {
                this.Lestado.Text = "No hay conexión establecida.";
            }
        }
    }
}