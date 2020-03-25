namespace interfazZKSoftware
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tbox_IP = new System.Windows.Forms.TextBox();
            this.cbox_Beep = new System.Windows.Forms.CheckBox();
            this.lb_IP = new System.Windows.Forms.Label();
            this.btn_ObtAsis = new System.Windows.Forms.Button();
            this.btn_ConnectTCPIP = new System.Windows.Forms.Button();
            this.tbox_IP_2 = new System.Windows.Forms.TextBox();
            this.tbox_IP_3 = new System.Windows.Forms.TextBox();
            this.tbox_IP_4 = new System.Windows.Forms.TextBox();
            this.tbox_IP_5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_IPServer = new System.Windows.Forms.TextBox();
            this.txtBox_ServerPort = new System.Windows.Forms.TextBox();
            this.lb_IPServer = new System.Windows.Forms.Label();
            this.lb_ServerPort = new System.Windows.Forms.Label();
            this.ruta = new System.Windows.Forms.TextBox();
            this.filename = new System.Windows.Forms.TextBox();
            this.lb_Rute = new System.Windows.Forms.Label();
            this.lb_FileName = new System.Windows.Forms.Label();
            this.lb_InitialDate = new System.Windows.Forms.Label();
            this.lb_FinalDate = new System.Windows.Forms.Label();
            this.lb_DateTitle = new System.Windows.Forms.Label();
            this.dateTimePicker_InitialDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_FinalDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(12, 168);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(134, 28);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Conectar";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tbox_IP
            // 
            this.tbox_IP.Location = new System.Drawing.Point(12, 28);
            this.tbox_IP.Name = "tbox_IP";
            this.tbox_IP.Size = new System.Drawing.Size(134, 22);
            this.tbox_IP.TabIndex = 1;
            this.tbox_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbox_Beep
            // 
            this.cbox_Beep.AutoSize = true;
            this.cbox_Beep.Location = new System.Drawing.Point(152, 173);
            this.cbox_Beep.Name = "cbox_Beep";
            this.cbox_Beep.Size = new System.Drawing.Size(100, 20);
            this.cbox_Beep.TabIndex = 3;
            this.cbox_Beep.Text = "Hacer Beep";
            this.cbox_Beep.UseVisualStyleBackColor = true;
            // 
            // lb_IP
            // 
            this.lb_IP.AutoSize = true;
            this.lb_IP.Location = new System.Drawing.Point(30, 9);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(95, 16);
            this.lb_IP.TabIndex = 4;
            this.lb_IP.Text = "Direcciones IP";
            // 
            // btn_ObtAsis
            // 
            this.btn_ObtAsis.Location = new System.Drawing.Point(351, 261);
            this.btn_ObtAsis.Name = "btn_ObtAsis";
            this.btn_ObtAsis.Size = new System.Drawing.Size(176, 33);
            this.btn_ObtAsis.TabIndex = 0;
            this.btn_ObtAsis.Text = "Actualizar Base de Datos";
            this.btn_ObtAsis.UseVisualStyleBackColor = true;
            this.btn_ObtAsis.Visible = false;
            this.btn_ObtAsis.Click += new System.EventHandler(this.btn_ObtAsis_Click);
            // 
            // btn_ConnectTCPIP
            // 
            this.btn_ConnectTCPIP.Location = new System.Drawing.Point(351, 121);
            this.btn_ConnectTCPIP.Name = "btn_ConnectTCPIP";
            this.btn_ConnectTCPIP.Size = new System.Drawing.Size(176, 33);
            this.btn_ConnectTCPIP.TabIndex = 7;
            this.btn_ConnectTCPIP.Text = "Enviar al Servidor";
            this.btn_ConnectTCPIP.UseVisualStyleBackColor = true;
            this.btn_ConnectTCPIP.Click += new System.EventHandler(this.btn_ConnectTCPIP_Click);
            // 
            // tbox_IP_2
            // 
            this.tbox_IP_2.Location = new System.Drawing.Point(12, 56);
            this.tbox_IP_2.Name = "tbox_IP_2";
            this.tbox_IP_2.Size = new System.Drawing.Size(134, 22);
            this.tbox_IP_2.TabIndex = 8;
            this.tbox_IP_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_IP_3
            // 
            this.tbox_IP_3.Location = new System.Drawing.Point(12, 84);
            this.tbox_IP_3.Name = "tbox_IP_3";
            this.tbox_IP_3.Size = new System.Drawing.Size(134, 22);
            this.tbox_IP_3.TabIndex = 9;
            this.tbox_IP_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_IP_4
            // 
            this.tbox_IP_4.Location = new System.Drawing.Point(12, 112);
            this.tbox_IP_4.Name = "tbox_IP_4";
            this.tbox_IP_4.Size = new System.Drawing.Size(134, 22);
            this.tbox_IP_4.TabIndex = 10;
            this.tbox_IP_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_IP_5
            // 
            this.tbox_IP_5.Location = new System.Drawing.Point(12, 140);
            this.tbox_IP_5.Name = "tbox_IP_5";
            this.tbox_IP_5.Size = new System.Drawing.Size(134, 22);
            this.tbox_IP_5.TabIndex = 11;
            this.tbox_IP_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dispositivo °1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dispositivo °2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dispositivo °3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dispositivo °4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dispositivo °5";
            // 
            // txtBox_IPServer
            // 
            this.txtBox_IPServer.Location = new System.Drawing.Point(421, 65);
            this.txtBox_IPServer.Name = "txtBox_IPServer";
            this.txtBox_IPServer.Size = new System.Drawing.Size(106, 22);
            this.txtBox_IPServer.TabIndex = 17;
            this.txtBox_IPServer.Text = "192.168.32.34";
            this.txtBox_IPServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_ServerPort
            // 
            this.txtBox_ServerPort.Location = new System.Drawing.Point(421, 93);
            this.txtBox_ServerPort.Name = "txtBox_ServerPort";
            this.txtBox_ServerPort.Size = new System.Drawing.Size(106, 22);
            this.txtBox_ServerPort.TabIndex = 18;
            this.txtBox_ServerPort.Text = "1235";
            this.txtBox_ServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_IPServer
            // 
            this.lb_IPServer.AutoSize = true;
            this.lb_IPServer.Location = new System.Drawing.Point(341, 68);
            this.lb_IPServer.Name = "lb_IPServer";
            this.lb_IPServer.Size = new System.Drawing.Size(74, 16);
            this.lb_IPServer.TabIndex = 19;
            this.lb_IPServer.Text = "IP Servidor";
            // 
            // lb_ServerPort
            // 
            this.lb_ServerPort.AutoSize = true;
            this.lb_ServerPort.Location = new System.Drawing.Point(368, 96);
            this.lb_ServerPort.Name = "lb_ServerPort";
            this.lb_ServerPort.Size = new System.Drawing.Size(47, 16);
            this.lb_ServerPort.TabIndex = 20;
            this.lb_ServerPort.Text = "Puerto";
            // 
            // ruta
            // 
            this.ruta.Location = new System.Drawing.Point(393, 12);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(134, 22);
            this.ruta.TabIndex = 21;
            this.ruta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(393, 37);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(134, 22);
            this.filename.TabIndex = 22;
            this.filename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Rute
            // 
            this.lb_Rute.AutoSize = true;
            this.lb_Rute.Location = new System.Drawing.Point(263, 15);
            this.lb_Rute.Name = "lb_Rute";
            this.lb_Rute.Size = new System.Drawing.Size(36, 16);
            this.lb_Rute.TabIndex = 23;
            this.lb_Rute.Text = "Ruta";
            // 
            // lb_FileName
            // 
            this.lb_FileName.AutoSize = true;
            this.lb_FileName.Location = new System.Drawing.Point(263, 40);
            this.lb_FileName.Name = "lb_FileName";
            this.lb_FileName.Size = new System.Drawing.Size(124, 16);
            this.lb_FileName.TabIndex = 24;
            this.lb_FileName.Text = "Nombre de Archivo";
            // 
            // lb_InitialDate
            // 
            this.lb_InitialDate.AutoSize = true;
            this.lb_InitialDate.Location = new System.Drawing.Point(9, 253);
            this.lb_InitialDate.Name = "lb_InitialDate";
            this.lb_InitialDate.Size = new System.Drawing.Size(49, 16);
            this.lb_InitialDate.TabIndex = 27;
            this.lb_InitialDate.Text = "Desde";
            // 
            // lb_FinalDate
            // 
            this.lb_FinalDate.AutoSize = true;
            this.lb_FinalDate.Location = new System.Drawing.Point(9, 281);
            this.lb_FinalDate.Name = "lb_FinalDate";
            this.lb_FinalDate.Size = new System.Drawing.Size(44, 16);
            this.lb_FinalDate.TabIndex = 28;
            this.lb_FinalDate.Text = "Hasta";
            // 
            // lb_DateTitle
            // 
            this.lb_DateTitle.AutoSize = true;
            this.lb_DateTitle.Location = new System.Drawing.Point(9, 222);
            this.lb_DateTitle.Name = "lb_DateTitle";
            this.lb_DateTitle.Size = new System.Drawing.Size(221, 16);
            this.lb_DateTitle.TabIndex = 29;
            this.lb_DateTitle.Text = "Rango de Fechas de las Checadas";
            // 
            // dateTimePicker_InitialDate
            // 
            this.dateTimePicker_InitialDate.Location = new System.Drawing.Point(61, 248);
            this.dateTimePicker_InitialDate.Name = "dateTimePicker_InitialDate";
            this.dateTimePicker_InitialDate.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker_InitialDate.TabIndex = 30;
            // 
            // dateTimePicker_FinalDate
            // 
            this.dateTimePicker_FinalDate.Location = new System.Drawing.Point(61, 276);
            this.dateTimePicker_FinalDate.Name = "dateTimePicker_FinalDate";
            this.dateTimePicker_FinalDate.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker_FinalDate.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 306);
            this.Controls.Add(this.dateTimePicker_FinalDate);
            this.Controls.Add(this.dateTimePicker_InitialDate);
            this.Controls.Add(this.lb_DateTitle);
            this.Controls.Add(this.lb_FinalDate);
            this.Controls.Add(this.lb_InitialDate);
            this.Controls.Add(this.lb_FileName);
            this.Controls.Add(this.lb_Rute);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.lb_ServerPort);
            this.Controls.Add(this.lb_IPServer);
            this.Controls.Add(this.txtBox_ServerPort);
            this.Controls.Add(this.txtBox_IPServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_IP_5);
            this.Controls.Add(this.tbox_IP_4);
            this.Controls.Add(this.tbox_IP_3);
            this.Controls.Add(this.tbox_IP_2);
            this.Controls.Add(this.btn_ObtAsis);
            this.Controls.Add(this.btn_ConnectTCPIP);
            this.Controls.Add(this.lb_IP);
            this.Controls.Add(this.cbox_Beep);
            this.Controls.Add(this.tbox_IP);
            this.Controls.Add(this.btn_Connect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox tbox_IP;
        private System.Windows.Forms.CheckBox cbox_Beep;
        private System.Windows.Forms.Label lb_IP;
        private System.Windows.Forms.Button btn_ObtAsis;
        private System.Windows.Forms.Button btn_ConnectTCPIP;
        private System.Windows.Forms.TextBox tbox_IP_2;
        private System.Windows.Forms.TextBox tbox_IP_3;
        private System.Windows.Forms.TextBox tbox_IP_4;
        private System.Windows.Forms.TextBox tbox_IP_5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_IPServer;
        private System.Windows.Forms.TextBox txtBox_ServerPort;
        private System.Windows.Forms.Label lb_IPServer;
        private System.Windows.Forms.Label lb_ServerPort;
        private System.Windows.Forms.TextBox ruta;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label lb_Rute;
        private System.Windows.Forms.Label lb_FileName;
        private System.Windows.Forms.Label lb_InitialDate;
        private System.Windows.Forms.Label lb_FinalDate;
        private System.Windows.Forms.Label lb_DateTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker_InitialDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FinalDate;
    }
}

