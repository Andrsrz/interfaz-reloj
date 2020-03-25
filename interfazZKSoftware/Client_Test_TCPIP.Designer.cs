namespace interfazZKSoftware
{
    partial class Client_Test_TCPIP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Connect_TCPIP = new System.Windows.Forms.Button();
            this.tBox_TCPIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Connect_TCPIP
            // 
            this.btn_Connect_TCPIP.Location = new System.Drawing.Point(53, 12);
            this.btn_Connect_TCPIP.Name = "btn_Connect_TCPIP";
            this.btn_Connect_TCPIP.Size = new System.Drawing.Size(124, 47);
            this.btn_Connect_TCPIP.TabIndex = 0;
            this.btn_Connect_TCPIP.Text = "Encender Servidor";
            this.btn_Connect_TCPIP.UseVisualStyleBackColor = true;
            this.btn_Connect_TCPIP.Click += new System.EventHandler(this.btn_Connect_TCPIP_Click);
            // 
            // tBox_TCPIP
            // 
            this.tBox_TCPIP.Location = new System.Drawing.Point(40, 116);
            this.tBox_TCPIP.Multiline = true;
            this.tBox_TCPIP.Name = "tBox_TCPIP";
            this.tBox_TCPIP.Size = new System.Drawing.Size(438, 234);
            this.tBox_TCPIP.TabIndex = 1;
            // 
            // Client_Test_TCPIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 413);
            this.Controls.Add(this.tBox_TCPIP);
            this.Controls.Add(this.btn_Connect_TCPIP);
            this.Name = "Client_Test_TCPIP";
            this.Text = "Servidor TCP/IP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_Test_TCPIP_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Connect_TCPIP;
        private System.Windows.Forms.TextBox tBox_TCPIP;
    }
}