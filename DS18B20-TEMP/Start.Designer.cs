namespace GUI_MODERNISTA
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.ICON = new System.Windows.Forms.Label();
            this.icon_ = new System.Windows.Forms.PictureBox();
            this.btnMinimizar_1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar_1 = new System.Windows.Forms.PictureBox();
            this.Bienvenidatxt = new System.Windows.Forms.Label();
            this.available_ports = new System.Windows.Forms.ComboBox();
            this.port_txt = new System.Windows.Forms.Label();
            this.baudrate_txt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.conexion_correctanoti = new System.Windows.Forms.NotifyIcon(this.components);
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar_1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.BarraTitulo.Controls.Add(this.ICON);
            this.BarraTitulo.Controls.Add(this.icon_);
            this.BarraTitulo.Controls.Add(this.btnMinimizar_1);
            this.BarraTitulo.Controls.Add(this.btnCerrar_1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(713, 48);
            this.BarraTitulo.TabIndex = 1;
            // 
            // ICON
            // 
            this.ICON.AutoSize = true;
            this.ICON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ICON.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICON.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ICON.Location = new System.Drawing.Point(47, 1);
            this.ICON.Name = "ICON";
            this.ICON.Size = new System.Drawing.Size(263, 41);
            this.ICON.TabIndex = 5;
            this.ICON.Text = "TERMO PHYSICS II";
            // 
            // icon_
            // 
            this.icon_.Image = ((System.Drawing.Image)(resources.GetObject("icon_.Image")));
            this.icon_.Location = new System.Drawing.Point(5, 6);
            this.icon_.Name = "icon_";
            this.icon_.Size = new System.Drawing.Size(48, 35);
            this.icon_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_.TabIndex = 4;
            this.icon_.TabStop = false;
            // 
            // btnMinimizar_1
            // 
            this.btnMinimizar_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar_1.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar_1.Image")));
            this.btnMinimizar_1.Location = new System.Drawing.Point(624, 8);
            this.btnMinimizar_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar_1.Name = "btnMinimizar_1";
            this.btnMinimizar_1.Size = new System.Drawing.Size(33, 31);
            this.btnMinimizar_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar_1.TabIndex = 2;
            this.btnMinimizar_1.TabStop = false;
            this.btnMinimizar_1.Click += new System.EventHandler(this.BtnMinimizar_1_Click);
            // 
            // btnCerrar_1
            // 
            this.btnCerrar_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar_1.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar_1.Image")));
            this.btnCerrar_1.Location = new System.Drawing.Point(663, 7);
            this.btnCerrar_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar_1.Name = "btnCerrar_1";
            this.btnCerrar_1.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar_1.TabIndex = 0;
            this.btnCerrar_1.TabStop = false;
            this.btnCerrar_1.Click += new System.EventHandler(this.BtnCerrar_1_Click);
            // 
            // Bienvenidatxt
            // 
            this.Bienvenidatxt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidatxt.Location = new System.Drawing.Point(68, 56);
            this.Bienvenidatxt.Name = "Bienvenidatxt";
            this.Bienvenidatxt.Size = new System.Drawing.Size(568, 48);
            this.Bienvenidatxt.TabIndex = 3;
            this.Bienvenidatxt.Text = "First select all parameters connection";
            this.Bienvenidatxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // available_ports
            // 
            this.available_ports.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_ports.FormattingEnabled = true;
            this.available_ports.Location = new System.Drawing.Point(176, 121);
            this.available_ports.Name = "available_ports";
            this.available_ports.Size = new System.Drawing.Size(429, 39);
            this.available_ports.TabIndex = 4;
            this.available_ports.Text = "Select between the available ports";
            // 
            // port_txt
            // 
            this.port_txt.AutoSize = true;
            this.port_txt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_txt.Location = new System.Drawing.Point(105, 121);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(62, 32);
            this.port_txt.TabIndex = 5;
            this.port_txt.Text = "Port:";
            // 
            // baudrate_txt
            // 
            this.baudrate_txt.AutoSize = true;
            this.baudrate_txt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrate_txt.Location = new System.Drawing.Point(105, 169);
            this.baudrate_txt.Name = "baudrate_txt";
            this.baudrate_txt.Size = new System.Drawing.Size(121, 32);
            this.baudrate_txt.TabIndex = 6;
            this.baudrate_txt.Text = "BaudRate:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(234, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 38);
            this.textBox1.TabIndex = 7;
            // 
            // Connect_btn
            // 
            this.Connect_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_btn.Location = new System.Drawing.Point(112, 217);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(496, 39);
            this.Connect_btn.TabIndex = 8;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // conexion_correctanoti
            // 
            this.conexion_correctanoti.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.conexion_correctanoti.BalloonTipText = "Connection to arduino already stabilished";
            this.conexion_correctanoti.BalloonTipTitle = "SUCCESSFUL CONNECTION ";
            this.conexion_correctanoti.Icon = ((System.Drawing.Icon)(resources.GetObject("conexion_correctanoti.Icon")));
            this.conexion_correctanoti.Tag = ".";
            this.conexion_correctanoti.Text = "Connection to arduino already stabilished";
            this.conexion_correctanoti.Visible = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(713, 298);
            this.Controls.Add(this.Connect_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.baudrate_txt);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.available_ports);
            this.Controls.Add(this.Bienvenidatxt);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Start_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label ICON;
        private System.Windows.Forms.PictureBox btnMinimizar_1;
        private System.Windows.Forms.PictureBox btnCerrar_1;
        private System.Windows.Forms.Label Bienvenidatxt;
        private System.Windows.Forms.ComboBox available_ports;
        private System.Windows.Forms.Label port_txt;
        private System.Windows.Forms.Label baudrate_txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.NotifyIcon conexion_correctanoti;
        private System.Windows.Forms.PictureBox icon_;
    }
}