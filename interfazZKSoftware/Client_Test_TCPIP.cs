using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Protocolo TCP/IP
using System.Net;
using System.Net.Sockets;
//Threads
using System.Threading;

namespace interfazZKSoftware
{
    public partial class Client_Test_TCPIP : Form
    {
        public Client_Test_TCPIP()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // No se puede cambiar tamaño
            InitializeComponent();
            tBox_TCPIP.Hide();
            this.Width = 250;
            this.Height = 100;
        }

        //Varaible que escucha el puerto que se manda
        private TcpListener server = null;
        private Socket serverSocket = null;
        private Socket clientSocket = null;
        private BinaryWriter bWriter = null;

        //Inicio server
        public void startServer()
        {
            try
            {

                //Declaracion del puerto y la direccion IP
                Int32 port = 8100;
                IPAddress IP_Adress = IPAddress.Parse("192.168.137.1");

                //Creamos un nuevo servidor
                server = new TcpListener(IP_Adress, port);
                server.Start();

                while (true)
                {

                    MessageBox.Show("Esperando ...");
                    //tBox_TCPIP.Text = "Esperando ...";

                    TcpClient client = server.AcceptTcpClient();
                    //Espera a que se conecte un cliente
                    MessageBox.Show("Entró");
                    //tBox_TCPIP.Text = "Entró prro lko";

                    //Información que envía el cliente
                    NetworkStream chain = client.GetStream();

                    int i;
                    Byte[] bytes = new Byte[256];
                    string data = null;

                    while ((i = chain.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        MessageBox.Show("Info obtenida: " + data);
                        tBox_TCPIP.Text = "Información Obtenida: " + data;
                        //Convertir en mayusculas
                        data = data.ToUpper();
                        //Convertir a bytes
                        byte[] msj = System.Text.Encoding.ASCII.GetBytes(data);

                        chain.Write(msj, 0, msj.Length); //Escribe en bytes

                        MessageBox.Show("Info enviada: " + data);
                        //tBox_TCPIP.Text = "Información Enviada: " + data;

                    }

                    client.Close();
                }

            }   //Errores
            catch (SocketException Socket_ex)
            {
                MessageBox.Show("Error: " + Socket_ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        //TCP/IP utilizando IPv6
        public void startServerIPv6()
        {
            try{
                IPAddress dirIP = IPAddress.Parse("fe80::dd87:c2e3:2733:a182");
                IPEndPoint endPoint = new IPEndPoint(dirIP, 5577); // Poner un endpoint, IP y puerto
                serverSocket = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(100);
                MessageBox.Show("Servidor Iniciado.\nEscuchando en: " + endPoint.ToString(), "Servidor");
                
                clientSocket = serverSocket.Accept();
                clientSocket.ReceiveBufferSize = 16384;
                byte[] bytes_clientData = new byte[1024 * 50000];
                string receivedPath = @"C:\Users\Víctor\Desktop\";
                int receivedBytesLen = clientSocket.Receive(bytes_clientData, bytes_clientData.Length, 0);
                int fileNameLen = BitConverter.ToInt32(bytes_clientData, 0);
                string fileName = Encoding.ASCII.GetString(bytes_clientData, 4, fileNameLen);

                bWriter = new BinaryWriter(File.Open(receivedPath + fileName, FileMode.Create));
                bWriter.Write(bytes_clientData, 4 + fileNameLen, receivedBytesLen - 4 - fileNameLen);

                while (receivedBytesLen > 0)
                {
                    receivedBytesLen = clientSocket.Receive(bytes_clientData, bytes_clientData.Length, 0);
                    if(receivedBytesLen == 0)
                    {
                        bWriter.Close();
                    }
                    else
                    {
                        bWriter.Write(bytes_clientData, 0, receivedBytesLen);
                    }
                }

                MessageBox.Show("Cliente " + clientSocket.RemoteEndPoint.ToString() + " conectado y Archivo " + fileName.ToString() + " empezo a recibirse.", "Servidor");
                bWriter.Close();
                
                MessageBox.Show("Archivo: " + fileName.ToString() + " recibido y guardado en: " + receivedPath.ToString(), "Servidor");
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void btn_Connect_TCPIP_Click(object sender, EventArgs e)
        {
            // Creamos un hilo con el servidor
            Thread thdServer = new Thread(startServerIPv6);
            thdServer.Start();
        }

        private void Client_Test_TCPIP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverSocket != null)
            {
                serverSocket.Close();
            }
        }
    }
}
