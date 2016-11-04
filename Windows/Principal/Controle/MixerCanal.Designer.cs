namespace Ardrum.Controle
{
    partial class MixerCanal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcbBalanco = new System.Windows.Forms.TrackBar();
            this.tcbVolume = new System.Windows.Forms.TrackBar();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlComando = new System.Windows.Forms.Panel();
            this.btnMute = new Ardrum.Controle.BotaoArdrum();
            this.btnSolo = new Ardrum.Controle.BotaoArdrum();
            this.btnAudio = new Ardrum.Controle.BotaoArdrum();
            this.ctrLinha = new DigoFramework.Controle.Diverso.Linha();
            this.ofdDirAudio = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tcbBalanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbVolume)).BeginInit();
            this.pnlComando.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcbBalanco
            // 
            this.tcbBalanco.AutoSize = false;
            this.tcbBalanco.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcbBalanco.Location = new System.Drawing.Point(1, 16);
            this.tcbBalanco.Margin = new System.Windows.Forms.Padding(2);
            this.tcbBalanco.Name = "tcbBalanco";
            this.tcbBalanco.Size = new System.Drawing.Size(59, 20);
            this.tcbBalanco.TabIndex = 0;
            this.tcbBalanco.Value = 5;
            this.tcbBalanco.Scroll += new System.EventHandler(this.tcbBalanco_Scroll);
            // 
            // tcbVolume
            // 
            this.tcbVolume.AutoSize = false;
            this.tcbVolume.Dock = System.Windows.Forms.DockStyle.Right;
            this.tcbVolume.Location = new System.Drawing.Point(41, 36);
            this.tcbVolume.Margin = new System.Windows.Forms.Padding(2);
            this.tcbVolume.Name = "tcbVolume";
            this.tcbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tcbVolume.Size = new System.Drawing.Size(19, 164);
            this.tcbVolume.TabIndex = 1;
            this.tcbVolume.Value = 8;
            this.tcbVolume.Scroll += new System.EventHandler(this.tcbVolume_Scroll);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Location = new System.Drawing.Point(1, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(59, 16);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Canal ???";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlComando
            // 
            this.pnlComando.Controls.Add(this.btnMute);
            this.pnlComando.Controls.Add(this.btnSolo);
            this.pnlComando.Controls.Add(this.btnAudio);
            this.pnlComando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComando.Location = new System.Drawing.Point(1, 36);
            this.pnlComando.Margin = new System.Windows.Forms.Padding(2);
            this.pnlComando.Name = "pnlComando";
            this.pnlComando.Padding = new System.Windows.Forms.Padding(8);
            this.pnlComando.Size = new System.Drawing.Size(40, 164);
            this.pnlComando.TabIndex = 3;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.btnMute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMute.Location = new System.Drawing.Point(8, 58);
            this.btnMute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(24, 25);
            this.btnMute.strTitulo = "M";
            this.btnMute.TabIndex = 5;
            // 
            // btnSolo
            // 
            this.btnSolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.btnSolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSolo.Location = new System.Drawing.Point(8, 33);
            this.btnSolo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Size = new System.Drawing.Size(24, 25);
            this.btnSolo.strTitulo = "S";
            this.btnSolo.TabIndex = 4;
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.btnAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAudio.Location = new System.Drawing.Point(8, 8);
            this.btnAudio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(24, 25);
            this.btnAudio.strTitulo = "A";
            this.btnAudio.TabIndex = 3;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // ctrLinha
            // 
            this.ctrLinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(111)))), ((int)(((byte)(144)))));
            this.ctrLinha.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctrLinha.Name = "ctrLinha";
            this.ctrLinha.TabIndex = 4;
            // 
            // ofdDirAudio
            // 
            this.ofdDirAudio.FileName = "openFileDialog1";
            // 
            // MixerCanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlComando);
            this.Controls.Add(this.tcbVolume);
            this.Controls.Add(this.tcbBalanco);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ctrLinha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MixerCanal";
            this.Size = new System.Drawing.Size(60, 200);
            ((System.ComponentModel.ISupportInitialize)(this.tcbBalanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbVolume)).EndInit();
            this.pnlComando.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tcbBalanco;
        private System.Windows.Forms.TrackBar tcbVolume;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlComando;
        private DigoFramework.Controle.Diverso.Linha ctrLinha;
        private BotaoArdrum btnAudio;
        private BotaoArdrum btnMute;
        private BotaoArdrum btnSolo;
        private System.Windows.Forms.OpenFileDialog ofdDirAudio;
    }
}
