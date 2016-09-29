namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    partial class MenuPrincipal
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
            this.tileSessoes = new Carubbi.MetroLayoutEngine.Tile();
            this.flowLayoutPanelTiles = new System.Windows.Forms.FlowLayoutPanel();
            this.tileSorteios = new Carubbi.MetroLayoutEngine.Tile();
            this.tileMensagens = new Carubbi.MetroLayoutEngine.Tile();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.flowLayoutPanelTiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // picVoltar
            // 
            this.picVoltar.Location = new System.Drawing.Point(899, 25);
            // 
            // tileSessoes
            // 
            this.tileSessoes.BackColor = System.Drawing.Color.LightSlateGray;
            this.tileSessoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSessoes.Icone = global::Itanio.SessaoAoVivo.WinUI.Backoffice.Properties.Resources._1475003396_door;
            this.tileSessoes.Location = new System.Drawing.Point(37, 38);
            this.tileSessoes.Margin = new System.Windows.Forms.Padding(37, 38, 6, 38);
            this.tileSessoes.Modo = Carubbi.MetroLayoutEngine.ModoTile.Pequeno;
            this.tileSessoes.Name = "tileSessoes";
            this.tileSessoes.Size = new System.Drawing.Size(176, 176);
            this.tileSessoes.TabIndex = 1;
            this.tileSessoes.Titulo = "Sessões";
            this.tileSessoes.TileClick += new System.EventHandler(this.tileSessoes_TileClick);
            // 
            // flowLayoutPanelTiles
            // 
            this.flowLayoutPanelTiles.Controls.Add(this.tileSessoes);
            this.flowLayoutPanelTiles.Controls.Add(this.tileSorteios);
            this.flowLayoutPanelTiles.Controls.Add(this.tileMensagens);
            this.flowLayoutPanelTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTiles.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTiles.Name = "flowLayoutPanelTiles";
            this.flowLayoutPanelTiles.Size = new System.Drawing.Size(953, 622);
            this.flowLayoutPanelTiles.TabIndex = 2;
            // 
            // tileSorteios
            // 
            this.tileSorteios.BackColor = System.Drawing.Color.DarkRed;
            this.tileSorteios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileSorteios.Icone = global::Itanio.SessaoAoVivo.WinUI.Backoffice.Properties.Resources._1475003394_trophy;
            this.tileSorteios.Location = new System.Drawing.Point(256, 38);
            this.tileSorteios.Margin = new System.Windows.Forms.Padding(37, 38, 6, 38);
            this.tileSorteios.Modo = Carubbi.MetroLayoutEngine.ModoTile.Pequeno;
            this.tileSorteios.Name = "tileSorteios";
            this.tileSorteios.Size = new System.Drawing.Size(176, 176);
            this.tileSorteios.TabIndex = 2;
            this.tileSorteios.Titulo = "Sorteios";
            this.tileSorteios.TileClick += new System.EventHandler(this.tileSorteios_TileClick);
            // 
            // tileMensagens
            // 
            this.tileMensagens.BackColor = System.Drawing.Color.Navy;
            this.tileMensagens.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileMensagens.Icone = global::Itanio.SessaoAoVivo.WinUI.Backoffice.Properties.Resources._1475021081_Messages;
            this.tileMensagens.Location = new System.Drawing.Point(475, 38);
            this.tileMensagens.Margin = new System.Windows.Forms.Padding(37, 38, 6, 38);
            this.tileMensagens.Modo = Carubbi.MetroLayoutEngine.ModoTile.Pequeno;
            this.tileMensagens.Name = "tileMensagens";
            this.tileMensagens.Size = new System.Drawing.Size(176, 176);
            this.tileMensagens.TabIndex = 3;
            this.tileMensagens.Titulo = "Mensagens";
            this.tileMensagens.TileClick += new System.EventHandler(this.tileMensagens_TileClick);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelTiles);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMainPage = true;
            this.Name = "MenuPrincipal";
            this.Size = new System.Drawing.Size(953, 622);
            this.Controls.SetChildIndex(this.picVoltar, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanelTiles, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.flowLayoutPanelTiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Carubbi.MetroLayoutEngine.Tile tileSessoes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTiles;
        private Carubbi.MetroLayoutEngine.Tile tileSorteios;
        private Carubbi.MetroLayoutEngine.Tile tileMensagens;
    }
}
