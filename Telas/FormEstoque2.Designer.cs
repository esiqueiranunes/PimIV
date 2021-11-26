
namespace Telas {
    partial class FormEstoque2 {
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
            this.components = new System.ComponentModel.Container();
            this.panelContagemEstoque = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pRODUTOSBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELnomeProdutos1 = new Telas.HOTELnomeProdutos();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnListarGeral = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNI_MEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTELDataSet3 = new Telas.HOTELDataSet3();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSTableAdapter = new Telas.HOTELDataSet3TableAdapters.PRODUTOSTableAdapter();
            this.hOTELnomeProdutos = new Telas.HOTELnomeProdutos();
            this.pRODUTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSTableAdapter1 = new Telas.HOTELnomeProdutosTableAdapters.PRODUTOSTableAdapter();
            this.pRODUTOSBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELnomeProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELnomeProdutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContagemEstoque.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELnomeProdutos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELnomeProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELnomeProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELnomeProdutosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContagemEstoque
            // 
            this.panelContagemEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panelContagemEstoque.Controls.Add(this.label9);
            this.panelContagemEstoque.Controls.Add(this.btnSair);
            this.panelContagemEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContagemEstoque.Location = new System.Drawing.Point(0, 0);
            this.panelContagemEstoque.Name = "panelContagemEstoque";
            this.panelContagemEstoque.Size = new System.Drawing.Size(765, 100);
            this.panelContagemEstoque.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(375, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "CONTAGEM DE ESTOQUE";
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnListarGeral);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 438);
            this.panel1.TabIndex = 131;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "REFRIGERANTE",
            "SUCO",
            "SALGADO",
            "COXINHA",
            "CERVEJA",
            "VINHO"});
            this.comboBox1.Location = new System.Drawing.Point(48, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 115;
            // 
            // pRODUTOSBindingSource4
            // 
            this.pRODUTOSBindingSource4.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource4.DataSource = this.hOTELnomeProdutos1;
            // 
            // hOTELnomeProdutos1
            // 
            this.hOTELnomeProdutos1.DataSetName = "HOTELnomeProdutos";
            this.hOTELnomeProdutos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Teal;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnListar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListar.Location = new System.Drawing.Point(208, 35);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(123, 27);
            this.btnListar.TabIndex = 114;
            this.btnListar.Text = "Filtrar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAtualizar.Location = new System.Drawing.Point(48, 378);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(673, 27);
            this.btnAtualizar.TabIndex = 113;
            this.btnAtualizar.Text = "Atualizar produto selecionado";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnListarGeral
            // 
            this.btnListarGeral.BackColor = System.Drawing.Color.Teal;
            this.btnListarGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnListarGeral.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListarGeral.Location = new System.Drawing.Point(337, 35);
            this.btnListarGeral.Name = "btnListarGeral";
            this.btnListarGeral.Size = new System.Drawing.Size(384, 27);
            this.btnListarGeral.TabIndex = 109;
            this.btnListarGeral.Text = "Listar";
            this.btnListarGeral.UseVisualStyleBackColor = false;
            this.btnListarGeral.Click += new System.EventHandler(this.btnListarGeral_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nome Produto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.MARCA,
            this.UNI_MEDIDA,
            this.VALIDADE,
            this.ESTOQUE,
            this.VALOR,
            this.FORNECEDOR,
            this.ID_PRODUTO});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(48, 119);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(673, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // MARCA
            // 
            this.MARCA.DataPropertyName = "MARCA";
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            // 
            // UNI_MEDIDA
            // 
            this.UNI_MEDIDA.DataPropertyName = "UNI_MEDIDA";
            this.UNI_MEDIDA.HeaderText = "UNIDADE";
            this.UNI_MEDIDA.Name = "UNI_MEDIDA";
            // 
            // VALIDADE
            // 
            this.VALIDADE.DataPropertyName = "VALIDADE";
            this.VALIDADE.HeaderText = "VALIDADE";
            this.VALIDADE.Name = "VALIDADE";
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.DataPropertyName = "ESTOQUE";
            this.ESTOQUE.HeaderText = "ESTOQUE";
            this.ESTOQUE.Name = "ESTOQUE";
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // FORNECEDOR
            // 
            this.FORNECEDOR.DataPropertyName = "FORNECEDOR";
            this.FORNECEDOR.HeaderText = "FORNECEDOR";
            this.FORNECEDOR.Name = "FORNECEDOR";
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.DataPropertyName = "ID_PRODUTO";
            this.ID_PRODUTO.HeaderText = "ID";
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            // 
            // hOTELDataSet3
            // 
            this.hOTELDataSet3.DataSetName = "HOTELDataSet3";
            this.hOTELDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this.hOTELDataSet3;
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // hOTELnomeProdutos
            // 
            this.hOTELnomeProdutos.DataSetName = "HOTELnomeProdutos";
            this.hOTELnomeProdutos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUTOSBindingSource1
            // 
            this.pRODUTOSBindingSource1.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource1.DataSource = this.hOTELnomeProdutos;
            // 
            // pRODUTOSTableAdapter1
            // 
            this.pRODUTOSTableAdapter1.ClearBeforeFill = true;
            // 
            // pRODUTOSBindingSource2
            // 
            this.pRODUTOSBindingSource2.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource2.DataSource = this.hOTELnomeProdutos;
            // 
            // hOTELnomeProdutosBindingSource
            // 
            this.hOTELnomeProdutosBindingSource.DataSource = this.hOTELnomeProdutos;
            this.hOTELnomeProdutosBindingSource.Position = 0;
            // 
            // hOTELnomeProdutosBindingSource1
            // 
            this.hOTELnomeProdutosBindingSource1.DataSource = this.hOTELnomeProdutos;
            this.hOTELnomeProdutosBindingSource1.Position = 0;
            // 
            // pRODUTOSBindingSource3
            // 
            this.pRODUTOSBindingSource3.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource3.DataSource = this.hOTELnomeProdutos;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "escolha ou digite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(57, 94);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 119;
            this.label3.Text = "altere: validade, estoque e/ou valor";
            // 
            // FormEstoque2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContagemEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque2";
            this.Text = "FormEstoque2";
            this.Load += new System.EventHandler(this.FormEstoque2_Load);
            this.panelContagemEstoque.ResumeLayout(false);
            this.panelContagemEstoque.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELnomeProdutos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELnomeProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELnomeProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELnomeProdutosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContagemEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnListarGeral;
        private System.Windows.Forms.Button btnListar;
        private HOTELDataSet3 hOTELDataSet3;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private HOTELDataSet3TableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private HOTELnomeProdutos hOTELnomeProdutos;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource1;
        private HOTELnomeProdutosTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter1;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource2;
        private System.Windows.Forms.BindingSource hOTELnomeProdutosBindingSource;
        private System.Windows.Forms.BindingSource hOTELnomeProdutosBindingSource1;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource3;
        private System.Windows.Forms.ComboBox comboBox1;
        private HOTELnomeProdutos hOTELnomeProdutos1;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNI_MEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}