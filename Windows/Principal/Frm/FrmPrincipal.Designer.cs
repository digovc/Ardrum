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
            this.mxcChimbal = new Ardrum.Controle.MixerCanal();
            this.mxcTarol = new Ardrum.Controle.MixerCanal();
            this.mxcBumbo = new Ardrum.Controle.MixerCanal();
            this.mxcTomA = new Ardrum.Controle.MixerCanal();
            this.mxcTomB = new Ardrum.Controle.MixerCanal();
            this.mxcPratoConducao = new Ardrum.Controle.MixerCanal();
            this.mxcPratoAtaque = new Ardrum.Controle.MixerCanal();
            this.pnlMixer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMixer
            // 
            this.pnlMixer.Controls.Add(this.mxcChimbal);
            this.pnlMixer.Controls.Add(this.mxcTarol);
            this.pnlMixer.Controls.Add(this.mxcBumbo);
            this.pnlMixer.Controls.Add(this.mxcTomA);
            this.pnlMixer.Controls.Add(this.mxcTomB);
            this.pnlMixer.Controls.Add(this.mxcPratoConducao);
            this.pnlMixer.Controls.Add(this.mxcPratoAtaque);
            this.pnlMixer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMixer.Location = new System.Drawing.Point(10, 10);
            this.pnlMixer.Name = "pnlMixer";
            this.pnlMixer.Size = new System.Drawing.Size(564, 241);
            this.pnlMixer.TabIndex = 0;
            // 
            // mxcChimbal
            // 
            this.mxcChimbal.booLinhaDireita = false;
            this.mxcChimbal.Dock = System.Windows.Forms.DockStyle.Right;
            this.mxcChimbal.Location = new System.Drawing.Point(114, 0);
            this.mxcChimbal.Name = "mxcChimbal";
            this.mxcChimbal.strTitulo = "Pad 1";
            this.mxcChimbal.TabIndex = 6;
            // 
            // mxcTarol
            // 
            this.mxcTarol.booLinhaDireita = false;
            this.mxcTarol.Dock = System.Windows.Forms.DockStyle.Right;
            this.mxcTarol.Location = new System.Drawing.Point(189, 0);
            this.mxcTarol.Name = "mxcTarol";
            this.mxcTarol.strTitulo = "Pad 1";
            this.mxcTarol.TabIndex = 5;
            // 
            // mxcBumbo
            // 
            this.mxcBumbo.booLinhaDireita = false;
            this.mxcBumbo.Dock = System.Windows.Forms.DockStyle.Right;
            this.mxcBumbo.Location = new System.Drawing.Point(264, 0);
            this.mxcBumbo.Name = "mxcBumbo";
            this.mxcBumbo.strTitulo = "Pad 1";
            this.mxcBumbo.TabIndex = 4;
            // 
            // mxcTomA
            // 
            this.mxcTomA.booLinhaDireita = false;
            this.mxcTomA.Dock = System.Windows.Forms.DockStyle.Right;
            this.mxcTomA.Location = new System.Drawing.Point(339, 0);
            this.mxcTomA.Name = "mxcTomA";
            this.mxcTomA.strTitulo = "Pad 1";
            this.mxcTomA.TabIndex = 3;
            // 
            // mxcTomB
            // 
            this.mxcTomB.booLinhaDireita = false;
            this.mxcTomB.Dock = System.Windows.Forms.DockStyle.Right;
            this.mxcTomB.Location = new System.Drawing.Point(414, 0);
            this.mxcTomB.Name = "mxcTomB";
            this.mxcTomB.strTitulo = "Pad 1";
            this.mxcTomB.TabIndex = 2;
            // 
            // mxcPratoConducao
            // 
            this.mxcPratoConducao.booLinhaDireita = false;
            this.mxcPratoConducao.Dock = System.Windows.Forms.DockStyle.Right;
            this.mxcPratoConducao.Location = new System.Drawing.Point(489, 0);
            this.mxcPratoConducao.Name = "mxcPratoConducao";
            this.mxcPratoConducao.strTitulo = "Pad 1";
            this.mxcPratoConducao.TabIndex = 1;
            // 
            // mxcPratoAtaque
            // 
            this.mxcPratoAtaque.booLinhaDireita = true;
            this.mxcPratoAtaque.Dock = System.Windows.Forms.DockStyle.Left;
            this.mxcPratoAtaque.Location = new System.Drawing.Point(0, 0);
            this.mxcPratoAtaque.Name = "mxcPratoAtaque";
            this.mxcPratoAtaque.strTitulo = "Master";
            this.mxcPratoAtaque.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.pnlMixer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FrmPrincipal";
            this.pnlMixer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMixer;
        private Controle.MixerCanal mxcPratoAtaque;
        private Controle.MixerCanal mxcPratoConducao;
        private Controle.MixerCanal mxcChimbal;
        private Controle.MixerCanal mxcTarol;
        private Controle.MixerCanal mxcBumbo;
        private Controle.MixerCanal mxcTomA;
        private Controle.MixerCanal mxcTomB;
    }
}