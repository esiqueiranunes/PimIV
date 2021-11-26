
namespace Telas {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnOption = new System.Windows.Forms.Button();
            this.panelMenuFinanceiro = new System.Windows.Forms.Panel();
            this.btnContas = new System.Windows.Forms.Button();
            this.btnTransacao = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.panelMenuEstoque = new System.Windows.Forms.Panel();
            this.btnContagemEstoque = new System.Windows.Forms.Button();
            this.btnAnaliseEstoque = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.panelMenuHospedagem = new System.Windows.Forms.Panel();
            this.btnAtualizarHospedagem = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnHospedagem = new System.Windows.Forms.Button();
            this.panelMenuCadastro = new System.Windows.Forms.Panel();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnLocais = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPessoas = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelMenuFinanceiro.SuspendLayout();
            this.panelMenuEstoque.SuspendLayout();
            this.panelMenuHospedagem.SuspendLayout();
            this.panelMenuCadastro.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panelSideMenu.Controls.Add(this.btnOption);
            this.panelSideMenu.Controls.Add(this.panelMenuFinanceiro);
            this.panelSideMenu.Controls.Add(this.btnFinanceiro);
            this.panelSideMenu.Controls.Add(this.panelMenuEstoque);
            this.panelSideMenu.Controls.Add(this.btnEstoque);
            this.panelSideMenu.Controls.Add(this.panelMenuHospedagem);
            this.panelSideMenu.Controls.Add(this.btnHospedagem);
            this.panelSideMenu.Controls.Add(this.panelMenuCadastro);
            this.panelSideMenu.Controls.Add(this.btnCadastro);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(169, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnOption
            // 
            this.btnOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOption.FlatAppearance.BorderSize = 0;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOption.Location = new System.Drawing.Point(0, 552);
            this.btnOption.Name = "btnOption";
            this.btnOption.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOption.Size = new System.Drawing.Size(152, 35);
            this.btnOption.TabIndex = 5;
            this.btnOption.Text = "Relatórios";
            this.btnOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelMenuFinanceiro
            // 
            this.panelMenuFinanceiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelMenuFinanceiro.Controls.Add(this.btnContas);
            this.panelMenuFinanceiro.Controls.Add(this.btnTransacao);
            this.panelMenuFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuFinanceiro.Location = new System.Drawing.Point(0, 487);
            this.panelMenuFinanceiro.Name = "panelMenuFinanceiro";
            this.panelMenuFinanceiro.Size = new System.Drawing.Size(152, 65);
            this.panelMenuFinanceiro.TabIndex = 8;
            // 
            // btnContas
            // 
            this.btnContas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContas.FlatAppearance.BorderSize = 0;
            this.btnContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContas.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnContas.Location = new System.Drawing.Point(0, 30);
            this.btnContas.Name = "btnContas";
            this.btnContas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnContas.Size = new System.Drawing.Size(152, 30);
            this.btnContas.TabIndex = 1;
            this.btnContas.Text = "Contas Hospedagens";
            this.btnContas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContas.UseVisualStyleBackColor = true;
            this.btnContas.Click += new System.EventHandler(this.btnContas_Click);
            // 
            // btnTransacao
            // 
            this.btnTransacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransacao.FlatAppearance.BorderSize = 0;
            this.btnTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacao.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTransacao.Location = new System.Drawing.Point(0, 0);
            this.btnTransacao.Name = "btnTransacao";
            this.btnTransacao.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTransacao.Size = new System.Drawing.Size(152, 30);
            this.btnTransacao.TabIndex = 0;
            this.btnTransacao.Text = "Transação";
            this.btnTransacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransacao.UseVisualStyleBackColor = true;
            this.btnTransacao.Click += new System.EventHandler(this.btnTransacao_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFinanceiro.Location = new System.Drawing.Point(0, 452);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFinanceiro.Size = new System.Drawing.Size(152, 35);
            this.btnFinanceiro.TabIndex = 4;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // panelMenuEstoque
            // 
            this.panelMenuEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelMenuEstoque.Controls.Add(this.btnContagemEstoque);
            this.panelMenuEstoque.Controls.Add(this.btnAnaliseEstoque);
            this.panelMenuEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuEstoque.Location = new System.Drawing.Point(0, 387);
            this.panelMenuEstoque.Name = "panelMenuEstoque";
            this.panelMenuEstoque.Size = new System.Drawing.Size(152, 65);
            this.panelMenuEstoque.TabIndex = 6;
            // 
            // btnContagemEstoque
            // 
            this.btnContagemEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContagemEstoque.FlatAppearance.BorderSize = 0;
            this.btnContagemEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContagemEstoque.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnContagemEstoque.Location = new System.Drawing.Point(0, 30);
            this.btnContagemEstoque.Name = "btnContagemEstoque";
            this.btnContagemEstoque.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnContagemEstoque.Size = new System.Drawing.Size(152, 30);
            this.btnContagemEstoque.TabIndex = 1;
            this.btnContagemEstoque.Text = "Contagem de estoque";
            this.btnContagemEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContagemEstoque.UseVisualStyleBackColor = true;
            this.btnContagemEstoque.Click += new System.EventHandler(this.btnContagemEstoque_Click);
            // 
            // btnAnaliseEstoque
            // 
            this.btnAnaliseEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaliseEstoque.FlatAppearance.BorderSize = 0;
            this.btnAnaliseEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliseEstoque.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnaliseEstoque.Location = new System.Drawing.Point(0, 0);
            this.btnAnaliseEstoque.Name = "btnAnaliseEstoque";
            this.btnAnaliseEstoque.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAnaliseEstoque.Size = new System.Drawing.Size(152, 30);
            this.btnAnaliseEstoque.TabIndex = 0;
            this.btnAnaliseEstoque.Text = "Análise de estoque";
            this.btnAnaliseEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnaliseEstoque.UseVisualStyleBackColor = true;
            this.btnAnaliseEstoque.Click += new System.EventHandler(this.btnAnaliseEstoque_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEstoque.Location = new System.Drawing.Point(0, 352);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(152, 35);
            this.btnEstoque.TabIndex = 3;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // panelMenuHospedagem
            // 
            this.panelMenuHospedagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelMenuHospedagem.Controls.Add(this.btnAtualizarHospedagem);
            this.panelMenuHospedagem.Controls.Add(this.btnReservar);
            this.panelMenuHospedagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHospedagem.Location = new System.Drawing.Point(0, 285);
            this.panelMenuHospedagem.Name = "panelMenuHospedagem";
            this.panelMenuHospedagem.Size = new System.Drawing.Size(152, 67);
            this.panelMenuHospedagem.TabIndex = 4;
            // 
            // btnAtualizarHospedagem
            // 
            this.btnAtualizarHospedagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizarHospedagem.FlatAppearance.BorderSize = 0;
            this.btnAtualizarHospedagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarHospedagem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAtualizarHospedagem.Location = new System.Drawing.Point(0, 30);
            this.btnAtualizarHospedagem.Name = "btnAtualizarHospedagem";
            this.btnAtualizarHospedagem.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAtualizarHospedagem.Size = new System.Drawing.Size(152, 30);
            this.btnAtualizarHospedagem.TabIndex = 1;
            this.btnAtualizarHospedagem.Text = "Atualizar hospedagem";
            this.btnAtualizarHospedagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarHospedagem.UseVisualStyleBackColor = true;
            this.btnAtualizarHospedagem.Click += new System.EventHandler(this.btnAtualizarHospedagem_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnReservar.Location = new System.Drawing.Point(0, 0);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReservar.Size = new System.Drawing.Size(152, 30);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnHospedagem
            // 
            this.btnHospedagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHospedagem.FlatAppearance.BorderSize = 0;
            this.btnHospedagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospedagem.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHospedagem.Location = new System.Drawing.Point(0, 250);
            this.btnHospedagem.Name = "btnHospedagem";
            this.btnHospedagem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHospedagem.Size = new System.Drawing.Size(152, 35);
            this.btnHospedagem.TabIndex = 2;
            this.btnHospedagem.Text = "Hospedagem";
            this.btnHospedagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospedagem.UseVisualStyleBackColor = true;
            this.btnHospedagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelMenuCadastro
            // 
            this.panelMenuCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelMenuCadastro.Controls.Add(this.btnCategorias);
            this.panelMenuCadastro.Controls.Add(this.btnProdutos);
            this.panelMenuCadastro.Controls.Add(this.btnServicos);
            this.panelMenuCadastro.Controls.Add(this.btnLocais);
            this.panelMenuCadastro.Controls.Add(this.btnUsuarios);
            this.panelMenuCadastro.Controls.Add(this.btnPessoas);
            this.panelMenuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuCadastro.Location = new System.Drawing.Point(0, 72);
            this.panelMenuCadastro.Name = "panelMenuCadastro";
            this.panelMenuCadastro.Size = new System.Drawing.Size(152, 178);
            this.panelMenuCadastro.TabIndex = 2;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCategorias.Location = new System.Drawing.Point(0, 150);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(152, 22);
            this.btnCategorias.TabIndex = 5;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnProdutos.Location = new System.Drawing.Point(0, 120);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnProdutos.Size = new System.Drawing.Size(152, 30);
            this.btnProdutos.TabIndex = 4;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicos.FlatAppearance.BorderSize = 0;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnServicos.Location = new System.Drawing.Point(0, 90);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnServicos.Size = new System.Drawing.Size(152, 30);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnLocais
            // 
            this.btnLocais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocais.FlatAppearance.BorderSize = 0;
            this.btnLocais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocais.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLocais.Location = new System.Drawing.Point(0, 60);
            this.btnLocais.Name = "btnLocais";
            this.btnLocais.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLocais.Size = new System.Drawing.Size(152, 30);
            this.btnLocais.TabIndex = 2;
            this.btnLocais.Text = "Locais";
            this.btnLocais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocais.UseVisualStyleBackColor = true;
            this.btnLocais.Click += new System.EventHandler(this.btnLocais_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 30);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(152, 30);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPessoas
            // 
            this.btnPessoas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPessoas.FlatAppearance.BorderSize = 0;
            this.btnPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPessoas.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPessoas.Location = new System.Drawing.Point(0, 0);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPessoas.Size = new System.Drawing.Size(152, 30);
            this.btnPessoas.TabIndex = 0;
            this.btnPessoas.Text = "Pessoas";
            this.btnPessoas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoas.UseVisualStyleBackColor = true;
            this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCadastro.Location = new System.Drawing.Point(0, 37);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCadastro.Size = new System.Drawing.Size(152, 35);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastros";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(152, 37);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(169, 0);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(765, 561);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(765, 561);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.Text = "Hotelaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelMenuFinanceiro.ResumeLayout(false);
            this.panelMenuEstoque.ResumeLayout(false);
            this.panelMenuHospedagem.ResumeLayout(false);
            this.panelMenuCadastro.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMenuCadastro;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnLocais;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPessoas;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnHospedagem;
        private System.Windows.Forms.Panel panelMenuFinanceiro;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button btnTransacao;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Panel panelMenuEstoque;
        private System.Windows.Forms.Button btnContagemEstoque;
        private System.Windows.Forms.Button btnAnaliseEstoque;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuHospedagem;
        private System.Windows.Forms.Button btnAtualizarHospedagem;
        private System.Windows.Forms.Button btnReservar;
    }
}

