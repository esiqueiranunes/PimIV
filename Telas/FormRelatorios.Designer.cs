
namespace Telas {
    partial class FormRelatorios {
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
            this.panelRelatorios = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelListar = new System.Windows.Forms.Panel();
            this.btnListarPessoas = new System.Windows.Forms.Button();
            this.btnListarConta = new System.Windows.Forms.Button();
            this.btnListarHospedagem = new System.Windows.Forms.Button();
            this.btnListarLocal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelRelatorios.SuspendLayout();
            this.panelListar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRelatorios
            // 
            this.panelRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panelRelatorios.Controls.Add(this.label1);
            this.panelRelatorios.Controls.Add(this.label9);
            this.panelRelatorios.Controls.Add(this.btnSair);
            this.panelRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRelatorios.Location = new System.Drawing.Point(0, 0);
            this.panelRelatorios.Name = "panelRelatorios";
            this.panelRelatorios.Size = new System.Drawing.Size(765, 100);
            this.panelRelatorios.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "Escolha um tipo de relatório";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "RELATÓRIOS";
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
            this.btnSair.TabIndex = 200;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelListar
            // 
            this.panelListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelListar.Controls.Add(this.btnListarPessoas);
            this.panelListar.Controls.Add(this.btnListarConta);
            this.panelListar.Controls.Add(this.btnListarHospedagem);
            this.panelListar.Controls.Add(this.btnListarLocal);
            this.panelListar.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListar.Location = new System.Drawing.Point(0, 100);
            this.panelListar.Name = "panelListar";
            this.panelListar.Size = new System.Drawing.Size(765, 172);
            this.panelListar.TabIndex = 129;
            // 
            // btnListarPessoas
            // 
            this.btnListarPessoas.BackColor = System.Drawing.Color.Teal;
            this.btnListarPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnListarPessoas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListarPessoas.Location = new System.Drawing.Point(33, 120);
            this.btnListarPessoas.Name = "btnListarPessoas";
            this.btnListarPessoas.Size = new System.Drawing.Size(700, 27);
            this.btnListarPessoas.TabIndex = 113;
            this.btnListarPessoas.Text = "PESSOAS";
            this.btnListarPessoas.UseVisualStyleBackColor = false;
            this.btnListarPessoas.Click += new System.EventHandler(this.btnListarPessoas_Click);
            // 
            // btnListarConta
            // 
            this.btnListarConta.BackColor = System.Drawing.Color.Teal;
            this.btnListarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnListarConta.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListarConta.Location = new System.Drawing.Point(33, 87);
            this.btnListarConta.Name = "btnListarConta";
            this.btnListarConta.Size = new System.Drawing.Size(700, 27);
            this.btnListarConta.TabIndex = 112;
            this.btnListarConta.Text = "CONTAS";
            this.btnListarConta.UseVisualStyleBackColor = false;
            this.btnListarConta.Click += new System.EventHandler(this.btnListarConta_Click);
            // 
            // btnListarHospedagem
            // 
            this.btnListarHospedagem.BackColor = System.Drawing.Color.Teal;
            this.btnListarHospedagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarHospedagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnListarHospedagem.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListarHospedagem.Location = new System.Drawing.Point(33, 54);
            this.btnListarHospedagem.Name = "btnListarHospedagem";
            this.btnListarHospedagem.Size = new System.Drawing.Size(700, 27);
            this.btnListarHospedagem.TabIndex = 111;
            this.btnListarHospedagem.Text = "HOSPEDAGEM";
            this.btnListarHospedagem.UseVisualStyleBackColor = false;
            this.btnListarHospedagem.Click += new System.EventHandler(this.btnListarHospedagem_Click);
            // 
            // btnListarLocal
            // 
            this.btnListarLocal.BackColor = System.Drawing.Color.Teal;
            this.btnListarLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnListarLocal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnListarLocal.Location = new System.Drawing.Point(33, 21);
            this.btnListarLocal.Name = "btnListarLocal";
            this.btnListarLocal.Size = new System.Drawing.Size(700, 27);
            this.btnListarLocal.TabIndex = 110;
            this.btnListarLocal.Text = "LOCAL";
            this.btnListarLocal.UseVisualStyleBackColor = false;
            this.btnListarLocal.Click += new System.EventHandler(this.btnListarLocal_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 359);
            this.panel1.TabIndex = 130;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(337, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "RELATÓRIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(33, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelListar);
            this.Controls.Add(this.panelRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.panelRelatorios.ResumeLayout(false);
            this.panelRelatorios.PerformLayout();
            this.panelListar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRelatorios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelListar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListarHospedagem;
        private System.Windows.Forms.Button btnListarLocal;
        private System.Windows.Forms.Button btnListarConta;
        private System.Windows.Forms.Button btnListarPessoas;
        private System.Windows.Forms.Label label1;
    }
}