
namespace Telas {
    partial class Form5 {
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
            this.panelCadastrarServico = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCadServico = new System.Windows.Forms.Button();
            this.panelCadServico = new System.Windows.Forms.Panel();
            this.tbDescricaoServico = new System.Windows.Forms.TextBox();
            this.tbValorServico = new System.Windows.Forms.TextBox();
            this.tbNomeServico = new System.Windows.Forms.TextBox();
            this.tbCategoriaServico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrarServico = new System.Windows.Forms.Button();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.panelCadCategoria = new System.Windows.Forms.Panel();
            this.tbNomeCategoria = new System.Windows.Forms.TextBox();
            this.comboBoxCategoriaServico = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnListarLocais = new System.Windows.Forms.Button();
            this.panelCadastrarServico.SuspendLayout();
            this.panelCadServico.SuspendLayout();
            this.panelCadCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastrarServico
            // 
            this.panelCadastrarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panelCadastrarServico.Controls.Add(this.label9);
            this.panelCadastrarServico.Controls.Add(this.button4);
            this.panelCadastrarServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastrarServico.Location = new System.Drawing.Point(0, 0);
            this.panelCadastrarServico.Name = "panelCadastrarServico";
            this.panelCadastrarServico.Size = new System.Drawing.Size(765, 100);
            this.panelCadastrarServico.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "CADASTRAR SERVIÇO";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(594, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 36);
            this.button4.TabIndex = 105;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCadServico
            // 
            this.btnCadServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnCadServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadServico.FlatAppearance.BorderSize = 0;
            this.btnCadServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadServico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadServico.Location = new System.Drawing.Point(0, 100);
            this.btnCadServico.Name = "btnCadServico";
            this.btnCadServico.Size = new System.Drawing.Size(765, 23);
            this.btnCadServico.TabIndex = 0;
            this.btnCadServico.Text = "CADASTRAR SERVIÇO";
            this.btnCadServico.UseVisualStyleBackColor = false;
            this.btnCadServico.Click += new System.EventHandler(this.btnCadServico_Click);
            // 
            // panelCadServico
            // 
            this.panelCadServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelCadServico.Controls.Add(this.tbDescricaoServico);
            this.panelCadServico.Controls.Add(this.tbValorServico);
            this.panelCadServico.Controls.Add(this.tbNomeServico);
            this.panelCadServico.Controls.Add(this.tbCategoriaServico);
            this.panelCadServico.Controls.Add(this.label6);
            this.panelCadServico.Controls.Add(this.label4);
            this.panelCadServico.Controls.Add(this.label2);
            this.panelCadServico.Controls.Add(this.label5);
            this.panelCadServico.Controls.Add(this.button1);
            this.panelCadServico.Controls.Add(this.btnCadastrarServico);
            this.panelCadServico.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCadServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadServico.Location = new System.Drawing.Point(0, 123);
            this.panelCadServico.Name = "panelCadServico";
            this.panelCadServico.Size = new System.Drawing.Size(765, 204);
            this.panelCadServico.TabIndex = 125;
            // 
            // tbDescricaoServico
            // 
            this.tbDescricaoServico.Location = new System.Drawing.Point(313, 88);
            this.tbDescricaoServico.Name = "tbDescricaoServico";
            this.tbDescricaoServico.Size = new System.Drawing.Size(387, 20);
            this.tbDescricaoServico.TabIndex = 3;
            // 
            // tbValorServico
            // 
            this.tbValorServico.Location = new System.Drawing.Point(60, 139);
            this.tbValorServico.Name = "tbValorServico";
            this.tbValorServico.Size = new System.Drawing.Size(234, 20);
            this.tbValorServico.TabIndex = 3;
            // 
            // tbNomeServico
            // 
            this.tbNomeServico.Location = new System.Drawing.Point(60, 88);
            this.tbNomeServico.Name = "tbNomeServico";
            this.tbNomeServico.Size = new System.Drawing.Size(234, 20);
            this.tbNomeServico.TabIndex = 2;
            // 
            // tbCategoriaServico
            // 
            this.tbCategoriaServico.Location = new System.Drawing.Point(60, 36);
            this.tbCategoriaServico.Name = "tbCategoriaServico";
            this.tbCategoriaServico.Size = new System.Drawing.Size(234, 20);
            this.tbCategoriaServico.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(310, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(57, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(57, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nome do serviço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(57, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Categoria";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(594, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Botão";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarServico
            // 
            this.btnCadastrarServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarServico.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarServico.Location = new System.Drawing.Point(482, 130);
            this.btnCadastrarServico.Name = "btnCadastrarServico";
            this.btnCadastrarServico.Size = new System.Drawing.Size(106, 36);
            this.btnCadastrarServico.TabIndex = 4;
            this.btnCadastrarServico.Text = "Cadastrar";
            this.btnCadastrarServico.UseVisualStyleBackColor = true;
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnCadCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadCategoria.FlatAppearance.BorderSize = 0;
            this.btnCadCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadCategoria.Location = new System.Drawing.Point(0, 327);
            this.btnCadCategoria.Name = "btnCadCategoria";
            this.btnCadCategoria.Size = new System.Drawing.Size(765, 23);
            this.btnCadCategoria.TabIndex = 6;
            this.btnCadCategoria.Text = "CADASTRAR CATEGORIA";
            this.btnCadCategoria.UseVisualStyleBackColor = false;
            this.btnCadCategoria.Click += new System.EventHandler(this.btnCadCategoria_Click);
            // 
            // panelCadCategoria
            // 
            this.panelCadCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelCadCategoria.Controls.Add(this.tbNomeCategoria);
            this.panelCadCategoria.Controls.Add(this.comboBoxCategoriaServico);
            this.panelCadCategoria.Controls.Add(this.button6);
            this.panelCadCategoria.Controls.Add(this.label8);
            this.panelCadCategoria.Controls.Add(this.btnCadastrarCategoria);
            this.panelCadCategoria.Controls.Add(this.label10);
            this.panelCadCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCadCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadCategoria.Location = new System.Drawing.Point(0, 350);
            this.panelCadCategoria.Name = "panelCadCategoria";
            this.panelCadCategoria.Size = new System.Drawing.Size(765, 93);
            this.panelCadCategoria.TabIndex = 127;
            // 
            // tbNomeCategoria
            // 
            this.tbNomeCategoria.Location = new System.Drawing.Point(254, 42);
            this.tbNomeCategoria.Name = "tbNomeCategoria";
            this.tbNomeCategoria.Size = new System.Drawing.Size(203, 20);
            this.tbNomeCategoria.TabIndex = 8;
            // 
            // comboBoxCategoriaServico
            // 
            this.comboBoxCategoriaServico.FormattingEnabled = true;
            this.comboBoxCategoriaServico.Items.AddRange(new object[] {
            "Produtos",
            "Serviços",
            "Pessoas"});
            this.comboBoxCategoriaServico.Location = new System.Drawing.Point(68, 41);
            this.comboBoxCategoriaServico.Name = "comboBoxCategoriaServico";
            this.comboBoxCategoriaServico.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCategoriaServico.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Location = new System.Drawing.Point(594, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 36);
            this.button6.TabIndex = 10;
            this.button6.Text = "Botão";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(251, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "Nome da categoria";
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(482, 32);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(106, 36);
            this.btnCadastrarCategoria.TabIndex = 9;
            this.btnCadastrarCategoria.Text = "Cadastrar";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(65, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 111;
            this.label10.Text = "Tipo da categoria";
            // 
            // btnListarLocais
            // 
            this.btnListarLocais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnListarLocais.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarLocais.FlatAppearance.BorderSize = 0;
            this.btnListarLocais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarLocais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarLocais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarLocais.Location = new System.Drawing.Point(0, 443);
            this.btnListarLocais.Name = "btnListarLocais";
            this.btnListarLocais.Size = new System.Drawing.Size(765, 23);
            this.btnListarLocais.TabIndex = 11;
            this.btnListarLocais.Text = "LISTAR SERVIÇOS";
            this.btnListarLocais.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.btnListarLocais);
            this.Controls.Add(this.panelCadCategoria);
            this.Controls.Add(this.btnCadCategoria);
            this.Controls.Add(this.panelCadServico);
            this.Controls.Add(this.btnCadServico);
            this.Controls.Add(this.panelCadastrarServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.panelCadastrarServico.ResumeLayout(false);
            this.panelCadastrarServico.PerformLayout();
            this.panelCadServico.ResumeLayout(false);
            this.panelCadServico.PerformLayout();
            this.panelCadCategoria.ResumeLayout(false);
            this.panelCadCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCadastrarServico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCadServico;
        private System.Windows.Forms.Panel panelCadServico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrarServico;
        private System.Windows.Forms.Button btnCadCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescricaoServico;
        private System.Windows.Forms.TextBox tbValorServico;
        private System.Windows.Forms.TextBox tbNomeServico;
        private System.Windows.Forms.TextBox tbCategoriaServico;
        private System.Windows.Forms.Panel panelCadCategoria;
        private System.Windows.Forms.TextBox tbNomeCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoriaServico;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnListarLocais;
    }
}