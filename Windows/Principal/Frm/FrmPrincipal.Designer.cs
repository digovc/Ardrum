namespace Ardrum.Frm
{
    partial class FrmPrincipal
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
            this.pnlMixer = new System.Windows.Forms.Panel();
            this.mxcMaster = new Ardrum.Controle.MixerCanal();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblArduinoStatus = new System.Windows.Forms.Label();
            this.pnlComando = new System.Windows.Forms.Panel();
            this.btnConectar = new Ardrum.Controle.BotaoArdrum();
            this.pnlMixer.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlComando.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMixer
            // 
            this.pnlMixer.Controls.Add(this.mxcMaster);
            this.pnlMixer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMixer.Location = new System.Drawing.Point(0, 30);
            this.pnlMixer.Name = "pnlMixer";
            this.pnlMixer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMixer.Size = new System.Drawing.Size(828, 244);
            this.pnlMixer.TabIndex = 0;
            // 
            // mxcMaster
            // 
            this.mxcMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.mxcMaster.booLinhaDireita = true;
            this.mxcMaster.Dock = System.Windows.Forms.DockStyle.Left;
            this.mxcMaster.ForeColor = System.Drawing.Color.White;
            this.mxcMaster.Location = new System.Drawing.Point(10, 10);
            this.mxcMaster.Margin = new System.Windows.Forms.Padding(4);
            this.mxcMaster.Name = "mxcMaster";
            this.mxcMaster.pad = null;
            this.mxcMaster.strTitulo = "Master";
            this.mxcMaster.TabIndex = 0;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblArduinoStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 274);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(828, 25);
            this.pnlStatus.TabIndex = 9;
            // 
            // lblArduinoStatus
            // 
            this.lblArduinoStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblArduinoStatus.Location = new System.Drawing.Point(0, 0);
            this.lblArduinoStatus.Name = "lblArduinoStatus";
            this.lblArduinoStatus.Size = new System.Drawing.Size(150, 25);
            this.lblArduinoStatus.TabIndex = 0;
            this.lblArduinoStatus.Text = "Desconectado";
            this.lblArduinoStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlComando
            // 
            this.pnlComando.Controls.Add(this.btnConectar);
            this.pnlComando.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComando.Location = new System.Drawing.Point(0, 0);
            this.pnlComando.Name = "pnlComando";
            this.pnlComando.Size = new System.Drawing.Size(828, 30);
            this.pnlComando.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.btnConectar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(0, 0);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(150, 30);
            this.btnConectar.strTitulo = "Conectar";
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(828, 299);
            this.Controls.Add(this.pnlMixer);
            this.Controls.Add(this.pnlComando);
            this.Controls.Add(this.pnlStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.pnlMixer.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlComando.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMixer;
        private Controle.MixerCanal mxcMaster;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblArduinoStatus;
        private System.Windows.Forms.Panel pnlComando;
        private Controle.BotaoArdrum btnConectar;
    }
}