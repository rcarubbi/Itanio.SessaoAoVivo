namespace Itanio.SessaoAoVivo.WinUI.Backoffice
{
    partial class SorteioForm
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
            this.tabControlUsuarios = new System.Windows.Forms.TabControl();
            this.tabOnline = new System.Windows.Forms.TabPage();
            this.lstOnline = new System.Windows.Forms.ListBox();
            this.tabTodos = new System.Windows.Forms.TabPage();
            this.lstTodos = new System.Windows.Forms.ListBox();
            this.tabSorteados = new System.Windows.Forms.TabPage();
            this.lstSorteados = new System.Windows.Forms.ListBox();
            this.btnSortear = new System.Windows.Forms.Button();
            this.gbPremiado = new System.Windows.Forms.GroupBox();
            this.lblEstadoValor = new System.Windows.Forms.Label();
            this.lblCidadeValor = new System.Windows.Forms.Label();
            this.lblEmailValor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeValor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.tabControlUsuarios.SuspendLayout();
            this.tabOnline.SuspendLayout();
            this.tabTodos.SuspendLayout();
            this.tabSorteados.SuspendLayout();
            this.gbPremiado.SuspendLayout();
            this.SuspendLayout();
            // 
            // picVoltar
            // 
            this.picVoltar.Location = new System.Drawing.Point(906, 25);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sorteios";
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Controls.Add(this.tabOnline);
            this.tabControlUsuarios.Controls.Add(this.tabTodos);
            this.tabControlUsuarios.Controls.Add(this.tabSorteados);
            this.tabControlUsuarios.Location = new System.Drawing.Point(20, 71);
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(506, 525);
            this.tabControlUsuarios.TabIndex = 3;
            // 
            // tabOnline
            // 
            this.tabOnline.Controls.Add(this.lstOnline);
            this.tabOnline.Location = new System.Drawing.Point(4, 34);
            this.tabOnline.Name = "tabOnline";
            this.tabOnline.Padding = new System.Windows.Forms.Padding(3);
            this.tabOnline.Size = new System.Drawing.Size(498, 487);
            this.tabOnline.TabIndex = 0;
            this.tabOnline.Text = "Usuários Online";
            this.tabOnline.UseVisualStyleBackColor = true;
            // 
            // lstOnline
            // 
            this.lstOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOnline.ForeColor = System.Drawing.Color.Black;
            this.lstOnline.FormattingEnabled = true;
            this.lstOnline.ItemHeight = 25;
            this.lstOnline.Location = new System.Drawing.Point(3, 3);
            this.lstOnline.Name = "lstOnline";
            this.lstOnline.Size = new System.Drawing.Size(492, 481);
            this.lstOnline.TabIndex = 0;
            // 
            // tabTodos
            // 
            this.tabTodos.Controls.Add(this.lstTodos);
            this.tabTodos.Location = new System.Drawing.Point(4, 34);
            this.tabTodos.Name = "tabTodos";
            this.tabTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodos.Size = new System.Drawing.Size(498, 487);
            this.tabTodos.TabIndex = 1;
            this.tabTodos.Text = "Todos os Usuários";
            this.tabTodos.UseVisualStyleBackColor = true;
            // 
            // lstTodos
            // 
            this.lstTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTodos.ForeColor = System.Drawing.Color.Black;
            this.lstTodos.FormattingEnabled = true;
            this.lstTodos.ItemHeight = 25;
            this.lstTodos.Location = new System.Drawing.Point(3, 3);
            this.lstTodos.Name = "lstTodos";
            this.lstTodos.Size = new System.Drawing.Size(492, 481);
            this.lstTodos.TabIndex = 0;
            // 
            // tabSorteados
            // 
            this.tabSorteados.Controls.Add(this.lstSorteados);
            this.tabSorteados.Location = new System.Drawing.Point(4, 34);
            this.tabSorteados.Name = "tabSorteados";
            this.tabSorteados.Padding = new System.Windows.Forms.Padding(3);
            this.tabSorteados.Size = new System.Drawing.Size(498, 487);
            this.tabSorteados.TabIndex = 2;
            this.tabSorteados.Text = "Sorteados";
            this.tabSorteados.UseVisualStyleBackColor = true;
            // 
            // lstSorteados
            // 
            this.lstSorteados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSorteados.ForeColor = System.Drawing.Color.Black;
            this.lstSorteados.FormattingEnabled = true;
            this.lstSorteados.ItemHeight = 25;
            this.lstSorteados.Location = new System.Drawing.Point(3, 3);
            this.lstSorteados.Name = "lstSorteados";
            this.lstSorteados.Size = new System.Drawing.Size(492, 481);
            this.lstSorteados.TabIndex = 0;
            // 
            // btnSortear
            // 
            this.btnSortear.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortear.ForeColor = System.Drawing.Color.White;
            this.btnSortear.Location = new System.Drawing.Point(563, 71);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(106, 39);
            this.btnSortear.TabIndex = 4;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = false;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // gbPremiado
            // 
            this.gbPremiado.Controls.Add(this.lblEstadoValor);
            this.gbPremiado.Controls.Add(this.lblCidadeValor);
            this.gbPremiado.Controls.Add(this.lblEmailValor);
            this.gbPremiado.Controls.Add(this.lblEstado);
            this.gbPremiado.Controls.Add(this.lblCidade);
            this.gbPremiado.Controls.Add(this.lblEmail);
            this.gbPremiado.Controls.Add(this.lblNomeValor);
            this.gbPremiado.Controls.Add(this.lblNome);
            this.gbPremiado.ForeColor = System.Drawing.Color.White;
            this.gbPremiado.Location = new System.Drawing.Point(563, 116);
            this.gbPremiado.Name = "gbPremiado";
            this.gbPremiado.Size = new System.Drawing.Size(340, 476);
            this.gbPremiado.TabIndex = 5;
            this.gbPremiado.TabStop = false;
            this.gbPremiado.Text = "Dados do Premiado";
            this.gbPremiado.Visible = false;
            // 
            // lblEstadoValor
            // 
            this.lblEstadoValor.AutoSize = true;
            this.lblEstadoValor.Location = new System.Drawing.Point(105, 186);
            this.lblEstadoValor.Name = "lblEstadoValor";
            this.lblEstadoValor.Size = new System.Drawing.Size(94, 25);
            this.lblEstadoValor.TabIndex = 7;
            this.lblEstadoValor.Text = "<Estado>";
            // 
            // lblCidadeValor
            // 
            this.lblCidadeValor.AutoSize = true;
            this.lblCidadeValor.Location = new System.Drawing.Point(105, 140);
            this.lblCidadeValor.Name = "lblCidadeValor";
            this.lblCidadeValor.Size = new System.Drawing.Size(97, 25);
            this.lblCidadeValor.TabIndex = 6;
            this.lblCidadeValor.Text = "<Cidade>";
            // 
            // lblEmailValor
            // 
            this.lblEmailValor.AutoSize = true;
            this.lblEmailValor.Location = new System.Drawing.Point(105, 97);
            this.lblEmailValor.Name = "lblEmailValor";
            this.lblEmailValor.Size = new System.Drawing.Size(84, 25);
            this.lblEmailValor.TabIndex = 5;
            this.lblEmailValor.Text = "<Email>";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(21, 186);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 25);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(21, 140);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(75, 25);
            this.lblCidade.TabIndex = 3;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblNomeValor
            // 
            this.lblNomeValor.AutoSize = true;
            this.lblNomeValor.Location = new System.Drawing.Point(105, 53);
            this.lblNomeValor.Name = "lblNomeValor";
            this.lblNomeValor.Size = new System.Drawing.Size(89, 25);
            this.lblNomeValor.TabIndex = 1;
            this.lblNomeValor.Text = "<Nome>";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 53);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.ForeColor = System.Drawing.Color.White;
            this.chkOnline.Location = new System.Drawing.Point(673, 77);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(230, 29);
            this.chkOnline.TabIndex = 6;
            this.chkOnline.Text = "Apenas usuários Online";
            this.chkOnline.UseVisualStyleBackColor = true;
            // 
            // SorteioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkOnline);
            this.Controls.Add(this.gbPremiado);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.tabControlUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "SorteioForm";
            this.Size = new System.Drawing.Size(960, 641);
            this.Load += new System.EventHandler(this.SorteioForm_Load);
            this.Controls.SetChildIndex(this.picVoltar, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.tabControlUsuarios, 0);
            this.Controls.SetChildIndex(this.btnSortear, 0);
            this.Controls.SetChildIndex(this.gbPremiado, 0);
            this.Controls.SetChildIndex(this.chkOnline, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.tabControlUsuarios.ResumeLayout(false);
            this.tabOnline.ResumeLayout(false);
            this.tabTodos.ResumeLayout(false);
            this.tabSorteados.ResumeLayout(false);
            this.gbPremiado.ResumeLayout(false);
            this.gbPremiado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControlUsuarios;
        private System.Windows.Forms.TabPage tabOnline;
        private System.Windows.Forms.TabPage tabTodos;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.GroupBox gbPremiado;
        private System.Windows.Forms.TabPage tabSorteados;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Label lblCidadeValor;
        private System.Windows.Forms.Label lblEmailValor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeValor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox lstOnline;
        private System.Windows.Forms.ListBox lstTodos;
        private System.Windows.Forms.ListBox lstSorteados;
        private System.Windows.Forms.CheckBox chkOnline;
    }
}
