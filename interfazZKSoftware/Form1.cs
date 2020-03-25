using System;
using System.Xml;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// API
using ZKSoftwareAPI;
// Protocolo TCP/IP
using System.Net;
using System.Net.Sockets;
// Threads
using System.Threading;

namespace interfazZKSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // No se puede cambiar tamaño
            this.Text = "Interfaz Reloj"; // Titulo
            this.Width = 345;
            this.Height = 345;
            btn_ConnectTCPIP.Hide();
            btn_ObtAsis.Hide();
            lb_IPServer.Hide();
            lb_ServerPort.Hide();
            txtBox_IPServer.Hide();
            txtBox_ServerPort.Hide();
            ruta.Hide();
            filename.Hide();
            lb_Rute.Hide();
            lb_FileName.Hide();

            initList2 = ReadInit();
            tbox_IP.Text = initList2[0];
            tbox_IP_2.Text = initList2[1];
            tbox_IP_3.Text = initList2[2];
            tbox_IP_4.Text = initList2[3];
            tbox_IP_5.Text = initList2[4];
        }

        /* ----- Variables ----- */

        private System.Windows.Forms.Timer timer1;
        DateTime today = DateTime.UtcNow.Date;

        char[] test = { };

        string[] separators = { "|", " " };
        string[] separators2 = { "/", " " };
        string[] words = { };
        string[] date = { };

        string prob = "";
        string value = "";
        string normalDate = "";
        string userID = "";
        string dataBaseName = "DataBase.txt";
        string initialDate = "";
        string finalDate = "";

        static ZKSoftware device = new ZKSoftware(Modelo.X628C); // Crear objeto del dispositivo
        static ZKSoftware device_2 = new ZKSoftware(Modelo.X628C);
        static ZKSoftware device_3 = new ZKSoftware(Modelo.X628C);
        static ZKSoftware device_4 = new ZKSoftware(Modelo.X628C);
        static ZKSoftware device_5 = new ZKSoftware(Modelo.X628C);

        // Listas para leer configuracion inicial
        List<string> initList = new List<string>();
        List<string> initList2 = new List<string>();

        // Lista para guardar dispositivos
        List<Device> listDevices = new List<Device>();

        // Listas para guardar inforamcion de los dispositivos
        List<ZKSoftwareAPI.UsuarioInformacion> listUsers = new List<ZKSoftwareAPI.UsuarioInformacion>();
        List<ZKSoftwareAPI.UsuarioMarcaje> listAttendanceRecord = new List<ZKSoftwareAPI.UsuarioMarcaje>();
        List<ZKSoftwareAPI.UsuarioMarcaje> listOperationalRecord = new List<ZKSoftwareAPI.UsuarioMarcaje>();

        /* ----- Funciones ----- */

        public void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(btn_ObtAsis_Click);
            timer1.Interval = 300000; // in miliseconds, 0.001, 300000
            timer1.Start();
        }

        public List<string> ReadInit() {
            string IP1 = ConfigurationManager.AppSettings["IP1"];
            string IP2 = ConfigurationManager.AppSettings["IP2"];
            string IP3 = ConfigurationManager.AppSettings["IP3"];
            string IP4 = ConfigurationManager.AppSettings["IP4"];
            string IP5 = ConfigurationManager.AppSettings["IP5"];
            string doBepp = ConfigurationManager.AppSettings["doBeep"];
            string listMode = ConfigurationManager.AppSettings["listMode"];

            initList.Add(IP1);
            initList.Add(IP2);
            initList.Add(IP3);
            initList.Add(IP4);
            initList.Add(IP5);
            initList.Add(doBepp);
            initList.Add(listMode);

            return initList;
        }

        public void WriteInit(List<Device> Devices) {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in doc.DocumentElement) {
                if (element.Name.Equals("appSettings")) {
                    foreach (XmlNode node in element.ChildNodes) {
                        if (node.Attributes[0].Value.Equals("IP1")) {
                            node.Attributes[1].Value = Devices[0].originalIP;
                        } else if (node.Attributes[0].Value.Equals("IP2")) {
                            node.Attributes[1].Value = Devices[1].originalIP;
                        } else if (node.Attributes[0].Value.Equals("IP3")) {
                            node.Attributes[1].Value = Devices[2].originalIP;
                        } else if (node.Attributes[0].Value.Equals("IP4")) {
                            node.Attributes[1].Value = Devices[3].originalIP;
                        } else if (node.Attributes[0].Value.Equals("IP5")) {
                            node.Attributes[1].Value = Devices[4].originalIP;
                        }
                    }
                }
            }

            doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void Connect(){ // Conectar dispositivo
            Device device1 = new Device(device, tbox_IP.Text, 1, false);
            Device device2 = new Device(device_2, tbox_IP_2.Text, 2, false);
            Device device3 = new Device(device_3, tbox_IP_3.Text, 3, false);
            Device device4 = new Device(device_4, tbox_IP_4.Text, 4, false);
            Device device5 = new Device(device_5, tbox_IP_5.Text, 5, false);

            listDevices.Add(device1);
            listDevices.Add(device2);
            listDevices.Add(device3);
            listDevices.Add(device4);
            listDevices.Add(device5);

            foreach (Device devices in listDevices)
            {
                if (devices.originalIP.Length > 0)
                {
                    if (devices.originalDevice.DispositivoConectar(devices.originalIP, 0, cbox_Beep.Checked))
                    {
                        if (cbox_Beep.Checked)
                        { // Hacer ruido
                            btn_Connect.Text = "Desconectar";
                        }
                        else
                        {
                            MessageBox.Show("Dispositivo Conectado", "Interfaz");
                            btn_Connect.Text = "Desconectar";
                        }
                        devices.originalIsConnected = true;
                    }
                    else
                    {
                        // Si no se conectó
                        MessageBox.Show(devices.originalDevice.ERROR, "Error");
                    }
                }
                else
                {
                    devices.originalIsConnected = false;
                }
                
            }

            foreach (Device devices in listDevices)
            {
                if (devices.originalIsConnected == true)
                {
                    // Redimencionar ventana
                    this.Width = 555;
                    this.Height = 345;
                    cbox_Beep.Hide(); // Ocultar checkBox
                    // Deshabilitar el textBox de la IP
                    tbox_IP.Enabled = false;
                    tbox_IP_2.Enabled = false;
                    tbox_IP_3.Enabled = false;
                    tbox_IP_4.Enabled = false;
                    tbox_IP_5.Enabled = false;
                    dateTimePicker_InitialDate.Enabled = false;
                    dateTimePicker_FinalDate.Enabled = false;
                    btn_ConnectTCPIP.Show(); // Mostrar boton Conectar al Server
                    // btn_ObtAsis.Show(); // Mostrar boton Actualizar Base de Datos
                    lb_IPServer.Show();
                    lb_ServerPort.Show();
                    txtBox_IPServer.Show();
                    txtBox_ServerPort.Show();
                    ruta.Show();
                    filename.Show();
                    lb_Rute.Show();
                    lb_FileName.Show();
                }
            }

            InitTimer();
            WriteInit(listDevices);
        }

        private void Desconnect(){ // Desconectar dispositivo

            foreach (Device devices in listDevices)
            {
                devices.originalDevice.DispositivoDesconectar();
                devices.originalIsConnected = false;
                devices.originalIP = "";
                devices.originalID = 0;
            }

            foreach (Device devices in listDevices)
            {
                if (devices.originalIsConnected == false)
                {
                    // Redimencionar ventana
                    this.Width = 345;
                    this.Height = 345;
                    btn_Connect.Text = "Conectar"; // Cambiar nombre del boton
                    // Habilitar el textBox de la IP
                    tbox_IP.Enabled = true;
                    tbox_IP_2.Enabled = true;
                    tbox_IP_3.Enabled = true;
                    tbox_IP_4.Enabled = true;
                    tbox_IP_5.Enabled = true;
                    dateTimePicker_InitialDate.Enabled = true;
                    dateTimePicker_FinalDate.Enabled = true;
                    cbox_Beep.Show(); // Mostrar checkBox
                    btn_ConnectTCPIP.Hide(); // Esconder boton Conectar al Server
                    btn_ObtAsis.Hide(); // Esconder boton Actualizar Base de Datos
                    lb_IPServer.Hide();
                    lb_ServerPort.Hide();
                    txtBox_IPServer.Hide();
                    txtBox_ServerPort.Hide();
                    ruta.Hide();
                    filename.Hide();
                    lb_Rute.Hide();
                    lb_FileName.Hide();
                }
            }

            timer1.Stop();
        }

        private void GetUsers(){ // Obtener empleados
            foreach (Device devices in listDevices){

                if (devices.originalIsConnected == true)
                {
                    if (devices.originalDevice.UsuarioBuscarTodos(true))
                    { // Todos los empleados

                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\" + Environment.UserName + @"\Desktop\DataBase.txt", devices.originalDevice == device ? false : true))
                        {
                            try
                            {
                                foreach (ZKSoftwareAPI.UsuarioInformacion user in devices.originalDevice.ListaUsuarios)
                                {
                                    listUsers.Add(user);
                                }

                                if (devices.originalDevice == device)
                                {
                                    file.WriteLine("Empleados: \n");
                                }

                                foreach (ZKSoftwareAPI.UsuarioInformacion user in listUsers)
                                {
                                    file.WriteLine("D" + devices.originalID.ToString() + ": " + user);
                                }
                                listUsers.Clear();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Error");
                            }
                        }
                    }
                }
            }
        }

        private void GetAttendanceRecord(string initialDate, string finalDate){ // Obtener Registro de Asistencias
            foreach (Device devices in listDevices){
                if (devices.originalIsConnected == true)
                {
                    // Dividir las checadas de los dispositivos
                    if (devices.originalID == 1 || devices.originalID == 2) {
                        dataBaseName = "DataBase_D1y2.txt";
                    } else if (devices.originalID == 3) {
                        dataBaseName = "DataBase_D3.txt";
                    } else {
                        dataBaseName = "DataBase_Rest.txt";
                    }

                    finalDate = today.ToShortDateString();
                    initialDate = dateTimePicker_InitialDate.Value.Date.ToShortDateString();
                    // finalDate = dateTimePicker_FinalDate.Value.Date.ToShortDateString();

                    devices.originalDevice.DispositivoObtenerRegistrosAsistencias();

                    // Agregar el registro de asistencias a la lista
                    foreach (ZKSoftwareAPI.UsuarioMarcaje attendanceRecord in devices.originalDevice.ListaMarcajes)
                    {
                        value = attendanceRecord.ToString();
                        words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        normalDate = words[1];
                        // if (finalDate == normalDate) {
                            listAttendanceRecord.Add(attendanceRecord);
                        // }
                    }
                    // listAttendanceRecord.Reverse();
                    // devices.originalDevice == device ? false : true
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\" + Environment.UserName + @"\Desktop\" + dataBaseName, 
                        devices.originalDevice == device || devices.originalDevice == device_3 || devices.originalDevice == device_4 ? false : true/*true*/))
                    {
                        try
                        {
                            foreach (ZKSoftwareAPI.UsuarioMarcaje attendanceRecord in listAttendanceRecord)
                            {
                                prob = "";
                                value = attendanceRecord.ToString();
                                words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                                normalDate = words[1];
                                userID = words[0];
                                test = userID.ToCharArray();
                                date = normalDate.Split(separators2, StringSplitOptions.RemoveEmptyEntries);

                                for (int i = 1; i < test.Length; i++) {
                                    prob = prob + test[i];
                                }

                                userID = prob;

                                file.Write(userID + "=" + date[1] + "/" + date[0] + "/" + date[2] + " " + words[2] + "\r\n");
                            }

                            listAttendanceRecord.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error");
                        }
                    }
                }  
            }
        }

        private void GetOperationalRecord(){ // Obtener Registro de Operaciones
            foreach (Device devices in listDevices){
               
                if (devices.originalIsConnected == true)
                {
                    devices.originalDevice.DispositivoObtenerRegistrosOperativos();

                    // Agregar los registros operativos a la lista
                    foreach (ZKSoftwareAPI.UsuarioMarcaje operationalRecord in devices.originalDevice.ListaMarcajes)
                    {
                        listOperationalRecord.Add(operationalRecord);
                    }
                    listOperationalRecord.Reverse();

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\" + Environment.UserName + @"\Desktop\DataBase.txt", true))
                    {
                        try
                        {
                            if (devices.originalDevice == device)
                            {
                                file.WriteLine("\nRegistros Operativos: \n");
                            }

                            foreach (ZKSoftwareAPI.UsuarioMarcaje operationalRecord in listOperationalRecord)
                            {
                                file.WriteLine("D" + devices.originalID.ToString() + ": " + operationalRecord);
                            }

                            listOperationalRecord.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error");
                        }
                    }
                }
            }
        }

        private void conecctionTCPIP() {
            string serverIP = txtBox_IPServer.Text;
            int serverPort = int.Parse(txtBox_ServerPort.Text);
            txtBox_IPServer.Enabled = false;
            txtBox_ServerPort.Enabled = false;
            ruta.Enabled = false;
            filename.Enabled = false;
            try {
                /* --- Establecer Conexion --- */
                IPAddress direction = IPAddress.Parse(serverIP);
                IPEndPoint endPointServer = new IPEndPoint(direction, serverPort); // Conexion
                EndPoint senderRemote = (EndPoint)endPointServer;
                TcpClient newClient = new TcpClient(serverIP, serverPort);
                Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Socket
                tcpSocket.Connect(endPointServer);
                byte[] msg = new Byte[256];

                btn_ConnectTCPIP.Enabled = false;

                /* --- Enviar Cabecera y Archivo --- */
                const int numFunctProt = 15;
                
                string fileName = filename.Text;
                string filePath = @"" + ruta.Text;
                
                /*
                string fileName = "DataBase.txt";
                string filePath = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                */
                FileInfo file = new FileInfo(filePath + fileName);
                long longFile = file.Length;
                int intFile = unchecked((int)longFile);
                
                byte[] bytes_numFunctProt = BitConverter.GetBytes(numFunctProt); // Bytes de la funcion del protocolo
                byte[] bytes_longFile = BitConverter.GetBytes(intFile);
                byte[] bytes_cabecera = new byte[bytes_numFunctProt.Length + bytes_longFile.Length];

                byte[] bytes_fileName = Encoding.ASCII.GetBytes(fileName); // Bytes del nombre del archivo
                byte[] bytes_fileData = File.ReadAllBytes(filePath + fileName); // Bytes de la informacion del archivo
                byte[] bytes_clientData = new byte[4 + bytes_fileName.Length + bytes_fileData.Length];  // Bytes de la informacion del archivo
                byte[] bytes_fileNameLen = BitConverter.GetBytes(bytes_fileName.Length); // Bytes del tamaño del nombre del archivo

                bytes_fileNameLen.CopyTo(bytes_clientData, 0);
                bytes_fileName.CopyTo(bytes_clientData, 4);
                bytes_fileData.CopyTo(bytes_clientData, 4 + bytes_fileName.Length);

                tcpSocket.Send(bytes_cabecera);
                tcpSocket.Send(bytes_clientData);

                // System.Threading.Thread.Sleep(3000);
                String test = tcpSocket.ReceiveFrom(msg, 0, msg.Length, SocketFlags.None, ref senderRemote).ToString();
                MessageBox.Show("Test: " + test, "Cliente");
                
                /* --- Cerrar Conexion --- */
                tcpSocket.Shutdown(SocketShutdown.Send);
                tcpSocket.Close();
            }
            catch (SocketException sExp)
            {
                MessageBox.Show(sExp.ToString(), "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el archivo: " + ex.ToString(), "Error");
            }
            btn_ConnectTCPIP.Enabled = true;
            txtBox_IPServer.Enabled = true;
            txtBox_ServerPort.Enabled = true;
            ruta.Enabled = true;
            filename.Enabled = true;
        }

        /* ----- Eventos de Botón ----- */

        // Confirmacion para salir
        private void Form1_FormClosing(object sender, FormClosingEventArgs e){
            if (btn_Connect.Text == "Desconectar") {
                if (MessageBox.Show("¿Seguro que quieres salir?", "Confirmación de Salida", MessageBoxButtons.YesNo) == DialogResult.Yes){
                    e.Cancel = false;
                }else{
                    e.Cancel = true;
                }
            }
        }

        // Boton Conectar/Desconectar
        private void btn_Connect_Click(object sender, EventArgs e){
            if (btn_Connect.Text == "Desconectar")
            { // Desconectar dispositivo
                Desconnect();
            }
            else
            { // Conectar dispositivo
                Connect();
                GetAttendanceRecord(initialDate, finalDate);
            }
            // SQLConnection();
        }
        
        // Actualizar Base de Datos
        private void btn_ObtAsis_Click(object sender, EventArgs e){
            //GetUsers();
            GetAttendanceRecord(initialDate, finalDate);
            //GetOperationalRecord();
        }

        // Enviar Base de Datos al Servidor
        private void btn_ConnectTCPIP_Click(object sender, EventArgs e){
            conecctionTCPIP();
        }
    }
}
