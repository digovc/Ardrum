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
            this.tcbPan = new System.Windows.Forms.TrackBar();
            this.tcbVolume = new System.Windows.Forms.TrackBar();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlComando = new System.Windows.Forms.Panel();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnSolo = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.ctrLinha = new DigoFramework.Controle.Diverso.Linha();
            ((System.ComponentModel.ISupportInitialize)(this.tcbPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbVolume)).BeginInit();
            this.pnlComando.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcbPan
            // 
            this.tcbPan.AutoSize = false;
            this.tcbPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcbPan.Location = new System.Drawing.Point(1, 20);
            this.tcbPan.Name = "tcbPan";
            this.tcbPan.Size = new System.Drawing.Size(74, 25);
            this.tcbPan.TabIndex = 0;
            this.tcbPan.Value = 5;
            // 
            // tcbVolume
            // 
            this.tcbVolume.AutoSize = false;
            this.tcbVolume.Dock = System.Windows.Forms.DockStyle.Right;
            this.tcbVolume.Location = new System.Drawing.Point(50, 45);
            this.tcbVolume.Name = "tcbVolume";
            this.tcbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tcbVolume.Size = new System.Drawing.Size(25, 205);
            this.tcbVolume.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Location = new System.Drawing.Point(1, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(74, 20);
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
            this.pnlComando.Location = new System.Drawing.Point(1, 45);
            this.pnlComando.Name = "pnlComando";
            this.pnlComando.Padding = new System.Windows.Forms.Padding(10);
            this.pnlComando.Size = new System.Drawing.Size(49, 205);
            this.pnlComando.TabIndex = 3;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.btnMute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(111)))), ((int)(((byte)(144)))));
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.Location = new System.Drawing.Point(10, 60);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(29, 25);
            this.btnMute.TabIndex = 2;
            this.btnMute.UseVisualStyleBackColor = false;
            // 
            // btnSolo
            // 
            this.btnSolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.btnSolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(111)))), ((int)(((byte)(144)))));
            this.btnSolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolo.Location = new System.Drawing.Point(10, 35);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Size = new System.Drawing.Size(29, 25);
            this.btnSolo.TabIndex = 1;
            this.btnSolo.UseVisualStyleBackColor = false;
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(85)))), ((int)(((byte)(114)))));
            this.btnAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAudio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(111)))), ((int)(((byte)(144)))));
            this.btnAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudio.Location = new System.Drawing.Point(10, 10);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(29, 25);
            this.btnAudio.TabIndex = 0;
            this.btnAudio.UseVisualStyleBackColor = false;
            // 
            // ctrLinha
            // 
            this.ctrLinha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(111)))), ((int)(((byte)(144)))));
            this.ctrLinha.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctrLinha.Name = "ctrLinha";
            this.ctrLinha.TabIndex = 4;
            // 
            // MixerCanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlComando);
            this.Controls.Add(this.tcbVolume);
            this.Controls.Add(this.tcbPan);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ctrLinha);
            this.Name = "MixerCanal";
            this.Size = new System.Drawing.Size(75, 250);
            ((System.ComponentModel.ISupportInitialize)(this.tcbPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbVolume)).EndInit();
            this.pnlComando.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tcbPan;
        private System.Windows.Forms.TrackBar tcbVolume;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlComando;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnSolo;
        private DigoFramework.Controle.Diverso.Linha ctrLinha;
    }
}
