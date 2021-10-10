
namespace Telas {
    partial class FormEstoque1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelListar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEstoque.SuspendLayout();
            this.panelListar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEstoque
            // 
            this.panelEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panelEstoque.Controls.Add(this.label9);
            this.panelEstoque.Controls.Add(this.btnSair);
            this.panelEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEstoque.Location = new System.Drawing.Point(0, 0);
            this.panelEstoque.Name = "panelEstoque";
            this.panelEstoque.Size = new System.Drawing.Size(765, 100);
            this.panelEstoque.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(332, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "ANÁLISE DE ESTOQUE";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(627, 26);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 36);
            this.btnSair.TabIndex = 106;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelListar
            // 
            this.panelListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelListar.Controls.Add(this.comboBox1);
            this.panelListar.Controls.Add(this.btnFiltrar);
            this.panelListar.Controls.Add(this.tbNomeProduto);
            this.panelListar.Controls.Add(this.label1);
            this.panelListar.Controls.Add(this.label5);
            this.panelListar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListar.Location = new System.Drawing.Point(0, 100);
            this.panelListar.Name = "panelListar";
            this.panelListar.Size = new System.Drawing.Size(765, 75);
            this.panelListar.TabIndex = 128;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(57, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Tipo de Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(178, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nome produto";
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(181, 33);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(205, 20);
            this.tbNomeProduto.TabIndex = 102;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFiltrar.Location = new System.Drawing.Point(424, 18);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(106, 36);
            this.btnFiltrar.TabIndex = 103;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bebidas",
            "Comida",
            "Limpeza",
            "Higiene"});
            this.comboBox1.Location = new System.Drawing.Point(60, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 104;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 359);
            this.panel1.TabIndex = 129;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.MARCA,
            this.UNIDADE,
            this.VALIDADE,
            this.ESTOQUE,
            this.VALOR,
            this.CATEGORIA,
            this.FORNECEDOR});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(33, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // UNIDADE
            // 
            this.UNIDADE.HeaderText = "UNIDADE";
            this.UNIDADE.Name = "UNIDADE";
            // 
            // VALIDADE
            // 
            this.VALIDADE.HeaderText = "VALIDADE";
            this.VALIDADE.Name = "VALIDADE";
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.HeaderText = "ESTOQUE";
            this.ESTOQUE.Name = "ESTOQUE";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            // 
            // FORNECEDOR
            // 
            this.FORNECEDOR.HeaderText = "FORNECEDOR";
            this.FORNECEDOR.Name = "FORNECEDOR";
            // 
            // FormEstoque1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListar);
            this.Controls.Add(this.panelEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque1";
            this.Text = "FormEstoque1";
            this.panelEstoque.ResumeLayout(false);
            this.panelEstoque.PerformLayout();
            this.panelListar.ResumeLayout(false);
            this.panelListar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelListar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
    }
}