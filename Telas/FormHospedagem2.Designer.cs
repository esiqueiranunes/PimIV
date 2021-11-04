
namespace Telas {
    partial class FormHospedagem2 {
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
            this.panelHospedagem = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizarHospedagem = new System.Windows.Forms.Button();
            this.panelAtualizarHospedagem = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDHospedagem = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.hOTELDataSet = new Telas.HOTELDataSet();
            this.hOTELDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELDataSet1 = new Telas.HOTELDataSet1();
            this.hOTELDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELDataSet2 = new Telas.HOTELDataSet2();
            this.hOSPEDAGEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPEDAGEMTableAdapter = new Telas.HOTELDataSet2TableAdapters.HOSPEDAGEMTableAdapter();
            this.hOSPEDAGEMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_HOSPEDAGEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_LOCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_SAIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANT_PESSOAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHospedagem.SuspendLayout();
            this.panelAtualizarHospedagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHospedagem
            // 
            this.panelHospedagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panelHospedagem.Controls.Add(this.label9);
            this.panelHospedagem.Controls.Add(this.btnSair);
            this.panelHospedagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHospedagem.Location = new System.Drawing.Point(0, 0);
            this.panelHospedagem.Name = "panelHospedagem";
            this.panelHospedagem.Size = new System.Drawing.Size(765, 100);
            this.panelHospedagem.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "ATUALIZAR HOSPEDAGEM";
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
            // btnAtualizarHospedagem
            // 
            this.btnAtualizarHospedagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnAtualizarHospedagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtualizarHospedagem.FlatAppearance.BorderSize = 0;
            this.btnAtualizarHospedagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarHospedagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarHospedagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizarHospedagem.Location = new System.Drawing.Point(0, 100);
            this.btnAtualizarHospedagem.Name = "btnAtualizarHospedagem";
            this.btnAtualizarHospedagem.Size = new System.Drawing.Size(765, 23);
            this.btnAtualizarHospedagem.TabIndex = 126;
            this.btnAtualizarHospedagem.Text = "ATUALIZAR HOSPEDAGEM";
            this.btnAtualizarHospedagem.UseVisualStyleBackColor = false;
            this.btnAtualizarHospedagem.Click += new System.EventHandler(this.btnAtualizarHospedagem_Click);
            // 
            // panelAtualizarHospedagem
            // 
            this.panelAtualizarHospedagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelAtualizarHospedagem.Controls.Add(this.checkBox1);
            this.panelAtualizarHospedagem.Controls.Add(this.button2);
            this.panelAtualizarHospedagem.Controls.Add(this.dateTimePicker1);
            this.panelAtualizarHospedagem.Controls.Add(this.button1);
            this.panelAtualizarHospedagem.Controls.Add(this.tbCPF);
            this.panelAtualizarHospedagem.Controls.Add(this.label2);
            this.panelAtualizarHospedagem.Controls.Add(this.tbIDHospedagem);
            this.panelAtualizarHospedagem.Controls.Add(this.button4);
            this.panelAtualizarHospedagem.Controls.Add(this.label5);
            this.panelAtualizarHospedagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAtualizarHospedagem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtualizarHospedagem.Location = new System.Drawing.Point(0, 123);
            this.panelAtualizarHospedagem.Name = "panelAtualizarHospedagem";
            this.panelAtualizarHospedagem.Size = new System.Drawing.Size(765, 139);
            this.panelAtualizarHospedagem.TabIndex = 127;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox1.Location = new System.Drawing.Point(267, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 106;
            this.checkBox1.Text = "Pagamento realizado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(462, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 27);
            this.button2.TabIndex = 105;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 104;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(462, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 27);
            this.button1.TabIndex = 103;
            this.button1.Text = "Check-out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(150, 43);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(235, 20);
            this.tbCPF.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(147, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "CPF Titular";
            // 
            // tbIDHospedagem
            // 
            this.tbIDHospedagem.Location = new System.Drawing.Point(60, 43);
            this.tbIDHospedagem.Name = "tbIDHospedagem";
            this.tbIDHospedagem.Size = new System.Drawing.Size(81, 20);
            this.tbIDHospedagem.TabIndex = 100;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(462, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 27);
            this.button4.TabIndex = 99;
            this.button4.Text = "Check-in";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(57, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "ID Hospedagem";
            // 
            // hOTELDataSet
            // 
            this.hOTELDataSet.DataSetName = "HOTELDataSet";
            this.hOTELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOTELDataSetBindingSource
            // 
            this.hOTELDataSetBindingSource.DataSource = this.hOTELDataSet;
            this.hOTELDataSetBindingSource.Position = 0;
            // 
            // hOTELDataSet1
            // 
            this.hOTELDataSet1.DataSetName = "HOTELDataSet1";
            this.hOTELDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOTELDataSet1BindingSource
            // 
            this.hOTELDataSet1BindingSource.DataSource = this.hOTELDataSet1;
            this.hOTELDataSet1BindingSource.Position = 0;
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
            // hOSPEDAGEMBindingSource1
            // 
            this.hOSPEDAGEMBindingSource1.DataMember = "HOSPEDAGEM";
            this.hOSPEDAGEMBindingSource1.DataSource = this.hOTELDataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HOSPEDAGEM,
            this.NOME,
            this.CPF,
            this.NOME_LOCAL,
            this.STATUS,
            this.DATA_ENTRADA,
            this.HORA_ENTRADA,
            this.DATA_SAIDA,
            this.HORA_SAIDA,
            this.QUANT_PESSOAS});
            this.dataGridView1.Location = new System.Drawing.Point(26, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 240);
            this.dataGridView1.TabIndex = 128;
            // 
            // ID_HOSPEDAGEM
            // 
            this.ID_HOSPEDAGEM.DataPropertyName = "ID_HOSPEDAGEM";
            this.ID_HOSPEDAGEM.HeaderText = "ID";
            this.ID_HOSPEDAGEM.Name = "ID_HOSPEDAGEM";
            this.ID_HOSPEDAGEM.Width = 35;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "TITULAR";
            this.NOME.Name = "NOME";
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // NOME_LOCAL
            // 
            this.NOME_LOCAL.DataPropertyName = "LOCAL";
            this.NOME_LOCAL.HeaderText = "LOCAL";
            this.NOME_LOCAL.Name = "NOME_LOCAL";
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            // 
            // DATA_ENTRADA
            // 
            this.DATA_ENTRADA.DataPropertyName = "DATA_ENTRADA";
            this.DATA_ENTRADA.HeaderText = "DATA ENTRADA";
            this.DATA_ENTRADA.Name = "DATA_ENTRADA";
            // 
            // HORA_ENTRADA
            // 
            this.HORA_ENTRADA.DataPropertyName = "HORA_ENTRADA";
            this.HORA_ENTRADA.HeaderText = "HORA ENTRADA";
            this.HORA_ENTRADA.Name = "HORA_ENTRADA";
            // 
            // DATA_SAIDA
            // 
            this.DATA_SAIDA.DataPropertyName = "DATA_SAIDA";
            this.DATA_SAIDA.HeaderText = "DATA SAIDA";
            this.DATA_SAIDA.Name = "DATA_SAIDA";
            // 
            // HORA_SAIDA
            // 
            this.HORA_SAIDA.DataPropertyName = "HORA_SAIDA";
            this.HORA_SAIDA.HeaderText = "HORA SAIDA";
            this.HORA_SAIDA.Name = "HORA_SAIDA";
            // 
            // QUANT_PESSOAS
            // 
            this.QUANT_PESSOAS.DataPropertyName = "QUANT_PESSOAS";
            this.QUANT_PESSOAS.HeaderText = "PESSOAS";
            this.QUANT_PESSOAS.Name = "QUANT_PESSOAS";
            // 
            // FormHospedagem2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelAtualizarHospedagem);
            this.Controls.Add(this.btnAtualizarHospedagem);
            this.Controls.Add(this.panelHospedagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHospedagem2";
            this.Text = "FormHospedagem2";
            this.Load += new System.EventHandler(this.FormHospedagem2_Load);
            this.panelHospedagem.ResumeLayout(false);
            this.panelHospedagem.PerformLayout();
            this.panelAtualizarHospedagem.ResumeLayout(false);
            this.panelAtualizarHospedagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHospedagem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizarHospedagem;
        private System.Windows.Forms.Panel panelAtualizarHospedagem;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDHospedagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource hOTELDataSet1BindingSource;
        private HOTELDataSet1 hOTELDataSet1;
        private HOTELDataSet hOTELDataSet;
        private System.Windows.Forms.BindingSource hOTELDataSetBindingSource;
        private HOTELDataSet2 hOTELDataSet2;
        private System.Windows.Forms.BindingSource hOSPEDAGEMBindingSource;
        private HOTELDataSet2TableAdapters.HOSPEDAGEMTableAdapter hOSPEDAGEMTableAdapter;
        private System.Windows.Forms.BindingSource hOSPEDAGEMBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOSPEDAGEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_LOCAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_ENTRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_ENTRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_SAIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORA_SAIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANT_PESSOAS;
    }
}