
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
            this.components = new System.ComponentModel.Container();
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelListar = new System.Windows.Forms.Panel();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnListarGeral = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELDataSet3 = new Telas.HOTELDataSet3();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNI_MEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSTableAdapter = new Telas.HOTELDataSet3TableAdapters.PRODUTOSTableAdapter();
            this.cATEGORIATableAdapter = new Telas.HOTELDataSet3TableAdapters.CATEGORIATableAdapter();
            this.cATEGORIABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panelEstoque.SuspendLayout();
            this.panelListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource1)).BeginInit();
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
            this.panelListar.Controls.Add(this.label2);
            this.panelListar.Controls.Add(this.btnListar);
            this.panelListar.Controls.Add(this.btnListarGeral);
            this.panelListar.Controls.Add(this.comboBox1);
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
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Teal;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnListar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListar.Location = new System.Drawing.Point(392, 29);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(123, 27);
            this.btnListar.TabIndex = 116;
            this.btnListar.Text = "Filtrar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnListarGeral
            // 
            this.btnListarGeral.BackColor = System.Drawing.Color.Teal;
            this.btnListarGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnListarGeral.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListarGeral.Location = new System.Drawing.Point(521, 29);
            this.btnListarGeral.Name = "btnListarGeral";
            this.btnListarGeral.Size = new System.Drawing.Size(212, 27);
            this.btnListarGeral.TabIndex = 115;
            this.btnListarGeral.Text = "Listar";
            this.btnListarGeral.UseVisualStyleBackColor = false;
            this.btnListarGeral.Click += new System.EventHandler(this.btnListarGeral_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COMIDA",
            "BEBIDA"});
            this.comboBox1.Location = new System.Drawing.Point(60, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 104;
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.hOTELDataSet3;
            // 
            // hOTELDataSet3
            // 
            this.hOTELDataSet3.DataSetName = "HOTELDataSet3";
            this.hOTELDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(181, 33);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(205, 20);
            this.tbNomeProduto.TabIndex = 102;
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
            this.ID_PRODUTO,
            this.NOME,
            this.MARCA,
            this.UNI_MEDIDA,
            this.VALIDADE,
            this.ESTOQUE,
            this.VALOR,
            this.FK_CATEGORIA,
            this.FORNECEDOR});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(33, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_PRODUTO
            // 
            this.ID_PRODUTO.DataPropertyName = "id_produto";
            this.ID_PRODUTO.HeaderText = "ID";
            this.ID_PRODUTO.Name = "ID_PRODUTO";
            this.ID_PRODUTO.Width = 40;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "nome";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // MARCA
            // 
            this.MARCA.DataPropertyName = "marca";
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.Width = 60;
            // 
            // UNI_MEDIDA
            // 
            this.UNI_MEDIDA.DataPropertyName = "uni_medida";
            this.UNI_MEDIDA.HeaderText = "UNIDADE";
            this.UNI_MEDIDA.Name = "UNI_MEDIDA";
            this.UNI_MEDIDA.Width = 60;
            // 
            // VALIDADE
            // 
            this.VALIDADE.DataPropertyName = "validade";
            this.VALIDADE.HeaderText = "VALIDADE";
            this.VALIDADE.Name = "VALIDADE";
            // 
            // ESTOQUE
            // 
            this.ESTOQUE.DataPropertyName = "estoque";
            this.ESTOQUE.HeaderText = "ESTOQUE";
            this.ESTOQUE.Name = "ESTOQUE";
            this.ESTOQUE.Width = 50;
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "valor";
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.Width = 60;
            // 
            // FK_CATEGORIA
            // 
            this.FK_CATEGORIA.DataPropertyName = "nome_categoria";
            this.FK_CATEGORIA.HeaderText = "CATEGORIA";
            this.FK_CATEGORIA.Name = "FK_CATEGORIA";
            // 
            // FORNECEDOR
            // 
            this.FORNECEDOR.DataPropertyName = "fornecedor";
            this.FORNECEDOR.HeaderText = "FORNECEDOR";
            this.FORNECEDOR.Name = "FORNECEDOR";
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
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // cATEGORIABindingSource1
            // 
            this.cATEGORIABindingSource1.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource1.DataSource = this.hOTELDataSet3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(68, 57);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "escolha ou digite";
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
            this.Load += new System.EventHandler(this.FormEstoque1_Load);
            this.panelEstoque.ResumeLayout(false);
            this.panelEstoque.PerformLayout();
            this.panelListar.ResumeLayout(false);
            this.panelListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNI_MEDIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnListarGeral;
        private HOTELDataSet3 hOTELDataSet3;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private HOTELDataSet3TableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private HOTELDataSet3TableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource1;
        private System.Windows.Forms.Label label2;
    }
}