using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Puerto_Serie_Arduino {
    public partial class Interfaz : Form {
        private SerialPort serialPort;
        public Interfaz() {
            this.InitializeComponent();
            this.serialPort = new SerialPort();
            this.ActualizarPuertos();
        }

        private void Bactualizar_Click(object sender, EventArgs e) {
            this.ActualizarPuertos();
        }

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

        private void Benviar_Click(object sender, EventArgs e) {
            EnviarDato();
        }

        private void TBdato_TextEnter(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (int)Keys.Enter) {
                EnviarDato();
                e.Handled = true;
            }
        }

        private void ActualizarPuertos() {
            this.CBpuertos.Items.Clear();
            this.CBpuertos.Items.AddRange(SerialPort.GetPortNames());
            this.CBpuertos.SelectedItem = SerialPort.GetPortNames()[0];
        }

        private void EnviarDato() {
            try {
                this.serialPort.Write(this.TBdato.Text);
                this.TBdato.Text = "";
                this.Lestado.Text = "Dato enviado correctamente.";
            } catch (Exception) {
                this.Lestado.Text = "No hay conexión establecida a través del puerto serial.";
            }
        }
    }
}