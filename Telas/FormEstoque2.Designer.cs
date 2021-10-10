
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
            this.panelContagemEstoque = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnListarProdutos = new System.Windows.Forms.Button();
            this.panelContagemEstoque.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 369);
            this.panel1.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(202, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Quantidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(45, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nome Produto";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bebidas",
            "Comida",
            "Limpeza",
            "Higiene"});
            this.comboBox2.Location = new System.Drawing.Point(48, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 21);
            this.comboBox2.TabIndex = 105;
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
            this.UNIDADE,
            this.VALIDADE,
            this.ESTOQUE,
            this.FORNECEDOR});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(48, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 82);
            this.dataGridView1.TabIndex = 0;
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
            // FORNECEDOR
            // 
            this.FORNECEDOR.HeaderText = "FORNECEDOR";
            this.FORNECEDOR.Name = "FORNECEDOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(270, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Validade";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(273, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 108;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(598, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 27);
            this.button4.TabIndex = 109;
            this.button4.Text = "Adicionar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(48, 208);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(673, 112);
            this.dataGridView2.TabIndex = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "MARCA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "UNIDADE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "VALIDADE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ESTOQUE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "FORNECEDOR";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(270, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "CONTAGEM DE ESTOQUE ATUAL";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(598, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 27);
            this.button2.TabIndex = 113;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnListarProdutos
            // 
            this.btnListarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnListarProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarProdutos.FlatAppearance.BorderSize = 0;
            this.btnListarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarProdutos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarProdutos.Location = new System.Drawing.Point(0, 469);
            this.btnListarProdutos.Name = "btnListarProdutos";
            this.btnListarProdutos.Size = new System.Drawing.Size(765, 23);
            this.btnListarProdutos.TabIndex = 134;
            this.btnListarProdutos.Text = "LISTAR PRODUTOS ";
            this.btnListarProdutos.UseVisualStyleBackColor = false;
            // 
            // FormEstoque2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.btnListarProdutos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContagemEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque2";
            this.Text = "FormEstoque2";
            this.panelContagemEstoque.ResumeLayout(false);
            this.panelContagemEstoque.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContagemEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnListarProdutos;
    }
}