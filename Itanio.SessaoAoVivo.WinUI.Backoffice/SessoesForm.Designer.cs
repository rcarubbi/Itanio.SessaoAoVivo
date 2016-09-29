namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    partial class SessoesForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeSessao = new System.Windows.Forms.TextBox();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.lblNomeSessao = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblLogotipo = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.btnSelecionarLogotipo = new System.Windows.Forms.Button();
            this.selecionarLogotipoDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlCor = new System.Windows.Forms.Panel();
            this.corDialog = new System.Windows.Forms.ColorDialog();
            this.pbLogotipo = new System.Windows.Forms.PictureBox();
            this.lblDataHoraInicio = new System.Windows.Forms.Label();
            this.dtpDataHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblCodigoVideo = new System.Windows.Forms.Label();
            this.txtCodigoVideo = new System.Windows.Forms.TextBox();
            this.lblRodape = new System.Windows.Forms.Label();
            this.txtRodape = new System.Windows.Forms.TextBox();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.lblCaminhoValor = new System.Windows.Forms.Label();
            this.lblLogotipoValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // picVoltar
            // 
            this.picVoltar.Location = new System.Drawing.Point(834, 25);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(17, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gerenciar Sessões";
            // 
            // txtNomeSessao
            // 
            this.txtNomeSessao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeSessao.Location = new System.Drawing.Point(164, 105);
            this.txtNomeSessao.Name = "txtNomeSessao";
            this.txtNomeSessao.Size = new System.Drawing.Size(672, 32);
            this.txtNomeSessao.TabIndex = 2;
            // 
            // btnLigar
            // 
            this.btnLigar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLigar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLigar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigar.ForeColor = System.Drawing.Color.White;
            this.btnLigar.Location = new System.Drawing.Point(616, 599);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(106, 46);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesligar.BackColor = System.Drawing.Color.DarkRed;
            this.btnDesligar.Enabled = false;
            this.btnDesligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligar.ForeColor = System.Drawing.Color.White;
            this.btnDesligar.Location = new System.Drawing.Point(730, 599);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(106, 46);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // lblNomeSessao
            // 
            this.lblNomeSessao.AutoSize = true;
            this.lblNomeSessao.ForeColor = System.Drawing.Color.White;
            this.lblNomeSessao.Location = new System.Drawing.Point(91, 108);
            this.lblNomeSessao.Name = "lblNomeSessao";
            this.lblNomeSessao.Size = new System.Drawing.Size(67, 25);
            this.lblNomeSessao.TabIndex = 5;
            this.lblNomeSessao.Text = "Nome:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(60, 146);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(98, 25);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(164, 143);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(672, 32);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblLogotipo
            // 
            this.lblLogotipo.AutoSize = true;
            this.lblLogotipo.ForeColor = System.Drawing.Color.White;
            this.lblLogotipo.Location = new System.Drawing.Point(67, 185);
            this.lblLogotipo.Name = "lblLogotipo";
            this.lblLogotipo.Size = new System.Drawing.Size(91, 25);
            this.lblLogotipo.TabIndex = 9;
            this.lblLogotipo.Text = "Logotipo:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.ForeColor = System.Drawing.Color.White;
            this.lblCor.Location = new System.Drawing.Point(112, 444);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(46, 25);
            this.lblCor.TabIndex = 11;
            this.lblCor.Text = "Cor:";
            // 
            // btnSelecionarLogotipo
            // 
            this.btnSelecionarLogotipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarLogotipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelecionarLogotipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarLogotipo.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarLogotipo.Location = new System.Drawing.Point(792, 181);
            this.btnSelecionarLogotipo.Name = "btnSelecionarLogotipo";
            this.btnSelecionarLogotipo.Size = new System.Drawing.Size(44, 32);
            this.btnSelecionarLogotipo.TabIndex = 12;
            this.btnSelecionarLogotipo.Text = "...";
            this.btnSelecionarLogotipo.UseVisualStyleBackColor = false;
            this.btnSelecionarLogotipo.Click += new System.EventHandler(this.btnSelecionarLogotipo_Click);
            // 
            // selecionarLogotipoDialog
            // 
            this.selecionarLogotipoDialog.Filter = "Imagem PNG|*.png|Imagem JPG|*.jpg";
            // 
            // pnlCor
            // 
            this.pnlCor.BackColor = System.Drawing.Color.White;
            this.pnlCor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCor.Location = new System.Drawing.Point(164, 438);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(50, 32);
            this.pnlCor.TabIndex = 14;
            this.pnlCor.DoubleClick += new System.EventHandler(this.pnlCor_DoubleClick);
            // 
            // corDialog
            // 
            this.corDialog.AnyColor = true;
            this.corDialog.FullOpen = true;
            // 
            // pbLogotipo
            // 
            this.pbLogotipo.BackColor = System.Drawing.Color.White;
            this.pbLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogotipo.Location = new System.Drawing.Point(164, 215);
            this.pbLogotipo.Name = "pbLogotipo";
            this.pbLogotipo.Size = new System.Drawing.Size(257, 205);
            this.pbLogotipo.TabIndex = 15;
            this.pbLogotipo.TabStop = false;
            // 
            // lblDataHoraInicio
            // 
            this.lblDataHoraInicio.AutoSize = true;
            this.lblDataHoraInicio.ForeColor = System.Drawing.Color.White;
            this.lblDataHoraInicio.Location = new System.Drawing.Point(233, 444);
            this.lblDataHoraInicio.Name = "lblDataHoraInicio";
            this.lblDataHoraInicio.Size = new System.Drawing.Size(154, 25);
            this.lblDataHoraInicio.TabIndex = 16;
            this.lblDataHoraInicio.Text = "Data/Hora Início:";
            // 
            // dtpDataHoraInicio
            // 
            this.dtpDataHoraInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataHoraInicio.Location = new System.Drawing.Point(393, 438);
            this.dtpDataHoraInicio.Name = "dtpDataHoraInicio";
            this.dtpDataHoraInicio.Size = new System.Drawing.Size(443, 32);
            this.dtpDataHoraInicio.TabIndex = 17;
            // 
            // lblCodigoVideo
            // 
            this.lblCodigoVideo.AutoSize = true;
            this.lblCodigoVideo.ForeColor = System.Drawing.Color.White;
            this.lblCodigoVideo.Location = new System.Drawing.Point(27, 485);
            this.lblCodigoVideo.Name = "lblCodigoVideo";
            this.lblCodigoVideo.Size = new System.Drawing.Size(131, 25);
            this.lblCodigoVideo.TabIndex = 19;
            this.lblCodigoVideo.Text = "Código Vídeo:";
            // 
            // txtCodigoVideo
            // 
            this.txtCodigoVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoVideo.Location = new System.Drawing.Point(164, 482);
            this.txtCodigoVideo.Name = "txtCodigoVideo";
            this.txtCodigoVideo.Size = new System.Drawing.Size(672, 32);
            this.txtCodigoVideo.TabIndex = 18;
            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.ForeColor = System.Drawing.Color.White;
            this.lblRodape.Location = new System.Drawing.Point(79, 523);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(79, 25);
            this.lblRodape.TabIndex = 21;
            this.lblRodape.Text = "Rodapé:";
            // 
            // txtRodape
            // 
            this.txtRodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRodape.Location = new System.Drawing.Point(164, 520);
            this.txtRodape.Name = "txtRodape";
            this.txtRodape.Size = new System.Drawing.Size(672, 32);
            this.txtRodape.TabIndex = 20;
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.ForeColor = System.Drawing.Color.White;
            this.lblCaminho.Location = new System.Drawing.Point(67, 561);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(92, 25);
            this.lblCaminho.TabIndex = 23;
            this.lblCaminho.Text = "Caminho:";
            // 
            // lblCaminhoValor
            // 
            this.lblCaminhoValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaminhoValor.BackColor = System.Drawing.Color.White;
            this.lblCaminhoValor.ForeColor = System.Drawing.Color.Black;
            this.lblCaminhoValor.Location = new System.Drawing.Point(165, 561);
            this.lblCaminhoValor.Name = "lblCaminhoValor";
            this.lblCaminhoValor.Size = new System.Drawing.Size(671, 31);
            this.lblCaminhoValor.TabIndex = 24;
            // 
            // lblLogotipoValor
            // 
            this.lblLogotipoValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogotipoValor.BackColor = System.Drawing.Color.White;
            this.lblLogotipoValor.ForeColor = System.Drawing.Color.Black;
            this.lblLogotipoValor.Location = new System.Drawing.Point(164, 181);
            this.lblLogotipoValor.Name = "lblLogotipoValor";
            this.lblLogotipoValor.Size = new System.Drawing.Size(622, 31);
            this.lblLogotipoValor.TabIndex = 25;
            // 
            // SessoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLogotipoValor);
            this.Controls.Add(this.lblCaminhoValor);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.txtRodape);
            this.Controls.Add(this.lblCodigoVideo);
            this.Controls.Add(this.txtCodigoVideo);
            this.Controls.Add(this.dtpDataHoraInicio);
            this.Controls.Add(this.lblDataHoraInicio);
            this.Controls.Add(this.pbLogotipo);
            this.Controls.Add(this.pnlCor);
            this.Controls.Add(this.btnSelecionarLogotipo);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblLogotipo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblNomeSessao);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.txtNomeSessao);
            this.Controls.Add(this.lblTitulo);
            this.Name = "SessoesForm";
            this.Size = new System.Drawing.Size(888, 655);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtNomeSessao, 0);
            this.Controls.SetChildIndex(this.btnLigar, 0);
            this.Controls.SetChildIndex(this.btnDesligar, 0);
            this.Controls.SetChildIndex(this.lblNomeSessao, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.lblLogotipo, 0);
            this.Controls.SetChildIndex(this.lblCor, 0);
            this.Controls.SetChildIndex(this.picVoltar, 0);
            this.Controls.SetChildIndex(this.btnSelecionarLogotipo, 0);
            this.Controls.SetChildIndex(this.pnlCor, 0);
            this.Controls.SetChildIndex(this.pbLogotipo, 0);
            this.Controls.SetChildIndex(this.lblDataHoraInicio, 0);
            this.Controls.SetChildIndex(this.dtpDataHoraInicio, 0);
            this.Controls.SetChildIndex(this.txtCodigoVideo, 0);
            this.Controls.SetChildIndex(this.lblCodigoVideo, 0);
            this.Controls.SetChildIndex(this.txtRodape, 0);
            this.Controls.SetChildIndex(this.lblRodape, 0);
            this.Controls.SetChildIndex(this.lblCaminho, 0);
            this.Controls.SetChildIndex(this.lblCaminhoValor, 0);
            this.Controls.SetChildIndex(this.lblLogotipoValor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNomeSessao;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Label lblNomeSessao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblLogotipo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnSelecionarLogotipo;
        private System.Windows.Forms.OpenFileDialog selecionarLogotipoDialog;
        private System.Windows.Forms.Panel pnlCor;
        private System.Windows.Forms.ColorDialog corDialog;
        private System.Windows.Forms.PictureBox pbLogotipo;
        private System.Windows.Forms.Label lblDataHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpDataHoraInicio;
        private System.Windows.Forms.Label lblCodigoVideo;
        private System.Windows.Forms.TextBox txtCodigoVideo;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.TextBox txtRodape;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.Label lblCaminhoValor;
        private System.Windows.Forms.Label lblLogotipoValor;
    }
}
