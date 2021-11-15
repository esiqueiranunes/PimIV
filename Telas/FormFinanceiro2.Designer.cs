
namespace Telas {
    partial class FormFinanceiro2 {
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_HOSPEDAGEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTELDataSet2 = new Telas.HOTELDataSet2();
            this.hOSPEDAGEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPEDAGEMTableAdapter = new Telas.HOTELDataSet2TableAdapters.HOSPEDAGEMTableAdapter();
            this.panelEstoque.SuspendLayout();
            this.panelListar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).BeginInit();
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
            this.panelEstoque.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "CONTAS";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            this.panelListar.Controls.Add(this.comboBox2);
            this.panelListar.Controls.Add(this.btnFiltrar);
            this.panelListar.Controls.Add(this.label1);
            this.panelListar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListar.Location = new System.Drawing.Point(0, 100);
            this.panelListar.Name = "panelListar";
            this.panelListar.Size = new System.Drawing.Size(765, 75);
            this.panelListar.TabIndex = 129;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.hOSPEDAGEMBindingSource;
            this.comboBox2.DisplayMember = "ID_HOSPEDAGEM";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(33, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 105;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFiltrar.Location = new System.Drawing.Point(154, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(106, 36);
            this.btnFiltrar.TabIndex = 103;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Hospedagem";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 359);
            this.panel1.TabIndex = 130;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONTA,
            this.NOME,
            this.VALOR,
            this.STATUS,
            this.DESCRICAO,
            this.NOME_CATEGORIA,
            this.ID_HOSPEDAGEM});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(33, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_CONTA
            // 
            this.ID_CONTA.DataPropertyName = "ID_CONTA";
            this.ID_CONTA.HeaderText = "ID";
            this.ID_CONTA.Name = "ID_CONTA";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // VALOR
            // 
            this.VALOR.DataPropertyName = "VALOR";
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            // 
            // NOME_CATEGORIA
            // 
            this.NOME_CATEGORIA.DataPropertyName = "NOME_CATEGORIA";
            this.NOME_CATEGORIA.HeaderText = "CATEGORIA";
            this.NOME_CATEGORIA.Name = "NOME_CATEGORIA";
            // 
            // ID_HOSPEDAGEM
            // 
            this.ID_HOSPEDAGEM.DataPropertyName = "ID_HOSPEDAGEM";
            this.ID_HOSPEDAGEM.HeaderText = "HOSPEDAGEM";
            this.ID_HOSPEDAGEM.Name = "ID_HOSPEDAGEM";
            // 
            // hOTELDataSet2
            // 
            this.hOTELDataSet2.DataSetName = "HOTELDataSet2";
            this.hOTELDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOSPEDAGEMBindingSource
            // 
            this.hOSPEDAGEMBindingSource.DataMember = "HOSPEDAGEM";
            this.hOSPEDAGEMBindingSource.DataSource = this.hOTELDataSet2;
            // 
            // hOSPEDAGEMTableAdapter
            // 
            this.hOSPEDAGEMTableAdapter.ClearBeforeFill = true;
            // 
            // FormFinanceiro2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListar);
            this.Controls.Add(this.panelEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFinanceiro2";
            this.Text = "FormFinanceiro2";
            this.Load += new System.EventHandler(this.FormFinanceiro2_Load);
            this.panelEstoque.ResumeLayout(false);
            this.panelEstoque.PerformLayout();
            this.panelListar.ResumeLayout(false);
            this.panelListar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelListar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOSPEDAGEM;
        private HOTELDataSet2 hOTELDataSet2;
        private System.Windows.Forms.BindingSource hOSPEDAGEMBindingSource;
        private HOTELDataSet2TableAdapters.HOSPEDAGEMTableAdapter hOSPEDAGEMTableAdapter;
    }
}