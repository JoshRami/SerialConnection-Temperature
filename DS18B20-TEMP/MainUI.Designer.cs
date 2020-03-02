namespace GUI_MODERNISTA
{
    partial class MainUI
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.ICON = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.icon_ = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.JOSU = new System.Windows.Forms.Label();
            this.KELV = new System.Windows.Forms.Label();
            this.FAHR = new System.Windows.Forms.Label();
            this.CENT = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.BarraTitulo.Controls.Add(this.ICON);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.icon_);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1142, 47);
            this.BarraTitulo.TabIndex = 0;
            // 
            // ICON
            // 
            this.ICON.AutoSize = true;
            this.ICON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ICON.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICON.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ICON.Location = new System.Drawing.Point(56, 0);
            this.ICON.Name = "ICON";
            this.ICON.Size = new System.Drawing.Size(376, 41);
            this.ICON.TabIndex = 5;
            this.ICON.Text = "DIGITAL TERMO PHYSICS II";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1055, 7);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1095, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // icon_
            // 
            this.icon_.Image = ((System.Drawing.Image)(resources.GetObject("icon_.Image")));
            this.icon_.Location = new System.Drawing.Point(9, 2);
            this.icon_.Name = "icon_";
            this.icon_.Size = new System.Drawing.Size(45, 40);
            this.icon_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_.TabIndex = 4;
            this.icon_.TabStop = false;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(100)))));
            this.MenuVertical.Controls.Add(this.JOSU);
            this.MenuVertical.Controls.Add(this.KELV);
            this.MenuVertical.Controls.Add(this.FAHR);
            this.MenuVertical.Controls.Add(this.CENT);
            this.MenuVertical.Controls.Add(this.Timer);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MenuVertical.Location = new System.Drawing.Point(0, 47);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(1144, 465);
            this.MenuVertical.TabIndex = 1;
            // 
            // JOSU
            // 
            this.JOSU.AutoSize = true;
            this.JOSU.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold);
            this.JOSU.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.JOSU.Location = new System.Drawing.Point(664, 296);
            this.JOSU.Name = "JOSU";
            this.JOSU.Size = new System.Drawing.Size(208, 93);
            this.JOSU.TabIndex = 4;
            this.JOSU.Text = "JOSU";
            // 
            // KELV
            // 
            this.KELV.AutoSize = true;
            this.KELV.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold);
            this.KELV.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.KELV.Location = new System.Drawing.Point(160, 294);
            this.KELV.Name = "KELV";
            this.KELV.Size = new System.Drawing.Size(194, 93);
            this.KELV.TabIndex = 3;
            this.KELV.Text = "KELV";
            // 
            // FAHR
            // 
            this.FAHR.AutoSize = true;
            this.FAHR.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold);
            this.FAHR.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FAHR.Location = new System.Drawing.Point(664, 152);
            this.FAHR.Name = "FAHR";
            this.FAHR.Size = new System.Drawing.Size(213, 93);
            this.FAHR.TabIndex = 2;
            this.FAHR.Text = "FAHR";
            // 
            // CENT
            // 
            this.CENT.AutoSize = true;
            this.CENT.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold);
            this.CENT.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CENT.Location = new System.Drawing.Point(152, 152);
            this.CENT.Name = "CENT";
            this.CENT.Size = new System.Drawing.Size(212, 93);
            this.CENT.TabIndex = 1;
            this.CENT.Text = "CENT";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold);
            this.Timer.Location = new System.Drawing.Point(344, 14);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(196, 93);
            this.Timer.TabIndex = 0;
            this.Timer.Text = "Hora";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 512);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TERMOMETRO DIGITAL";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox icon_;
        private System.Windows.Forms.Label ICON;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label CENT;
        private System.Windows.Forms.Label KELV;
        private System.Windows.Forms.Label FAHR;
        private System.Windows.Forms.Label JOSU;
    }
}

