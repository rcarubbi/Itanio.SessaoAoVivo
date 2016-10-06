namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    partial class FormMensagens
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
            this.btnSair = new System.Windows.Forms.Button();
            this.flowLayoutPanelMensagens = new System.Windows.Forms.FlowLayoutPanel();
            this.chkRolagem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(666, 544);
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 34);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // flowLayoutPanelMensagens
            // 
            this.flowLayoutPanelMensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMensagens.AutoScroll = true;
            this.flowLayoutPanelMensagens.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMensagens.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMensagens.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelMensagens.Name = "flowLayoutPanelMensagens";
            this.flowLayoutPanelMensagens.Size = new System.Drawing.Size(752, 523);
            this.flowLayoutPanelMensagens.TabIndex = 5;
            this.flowLayoutPanelMensagens.WrapContents = false;
            // 
            // chkRolagem
            // 
            this.chkRolagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRolagem.AutoSize = true;
            this.chkRolagem.ForeColor = System.Drawing.Color.White;
            this.chkRolagem.Location = new System.Drawing.Point(454, 548);
            this.chkRolagem.Name = "chkRolagem";
            this.chkRolagem.Size = new System.Drawing.Size(203, 29);
            this.chkRolagem.TabIndex = 6;
            this.chkRolagem.Text = "Rolagem automática";
            this.chkRolagem.UseVisualStyleBackColor = true;
            // 
            // FormMensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(776, 593);
            this.ControlBox = false;
            this.Controls.Add(this.chkRolagem);
            this.Controls.Add(this.flowLayoutPanelMensagens);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMensagens";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mensagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMensagens;
        private System.Windows.Forms.CheckBox chkRolagem;
    }
}