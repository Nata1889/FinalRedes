using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace FinalRedes
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            // Cargar los puertos COM disponibles
            cboPorts.Items.AddRange(SerialPort.GetPortNames());
            btnDesconectar.Enabled = false;
            btnOn.Enabled = false;
            btnOff.Enabled = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (cboPorts.SelectedItem != null)
            {
                try
                {
                    // Configurar el puerto serial
                    serialPort = new SerialPort(cboPorts.SelectedItem.ToString(), 9600);
                    serialPort.Open();

                    btnConectar.Enabled = false;
                    btnDesconectar.Enabled = true;
                    btnOn.Enabled = true;
                    btnOff.Enabled = true;
                    LogMessage("Conectado al puerto " + cboPorts.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    LogMessage("Error al conectar: " + ex.Message);
                }
            }
            else
            {
                LogMessage("Seleccione un puerto COM.");
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                btnConectar.Enabled = true;
                btnDesconectar.Enabled = false;
                btnOn.Enabled = false;
                btnOff.Enabled = false;
                LogMessage("Conexión cerrada.");
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            SendCommand("ON");
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            SendCommand("OFF");
        }

        private void SendCommand(string v)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine(v); // Enviar el comando
                    LogMessage("Comando enviado: " + v);
                }
                else
                {
                    LogMessage("Conexión no establecida.");
                }
            }
            catch (Exception ex)
            {
                LogMessage("Error al enviar comando: " + ex.Message);
            }
        }

        private void LogMessage(string message)
        {
            txtLog.AppendText(message + Environment.NewLine);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar el puerto serial si está abierto
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
