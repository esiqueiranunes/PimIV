
namespace Telas {
    partial class Form4 {
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
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowCadLocal = new System.Windows.Forms.Button();
            this.panelCadLocal = new System.Windows.Forms.Panel();
            this.tbNomeLocal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescricaoLocal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxTipoLocal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnShowCadCategoriaLocal = new System.Windows.Forms.Button();
            this.panelCadCategoriaLocal = new System.Windows.Forms.Panel();
            this.tbDescontoLocal = new System.Windows.Forms.TextBox();
            this.tbValorLocal = new System.Windows.Forms.TextBox();
            this.tbCategoriaLocal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrarCategoriaLocal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCadLocal.SuspendLayout();
            this.panelCadCategoriaLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "CADASTRAR LOCAL";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(618, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 36);
            this.button4.TabIndex = 15;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 100);
            this.panel1.TabIndex = 116;
            // 
            // btnShowCadLocal
            // 
            this.btnShowCadLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnShowCadLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowCadLocal.FlatAppearance.BorderSize = 0;
            this.btnShowCadLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCadLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCadLocal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowCadLocal.Location = new System.Drawing.Point(0, 100);
            this.btnShowCadLocal.Name = "btnShowCadLocal";
            this.btnShowCadLocal.Size = new System.Drawing.Size(765, 23);
            this.btnShowCadLocal.TabIndex = 1;
            this.btnShowCadLocal.Text = "NOVO LOCAL";
            this.btnShowCadLocal.UseVisualStyleBackColor = false;
            this.btnShowCadLocal.Click += new System.EventHandler(this.btnShowCadEndereco_Click);
            // 
            // panelCadLocal
            // 
            this.panelCadLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelCadLocal.Controls.Add(this.label7);
            this.panelCadLocal.Controls.Add(this.tbNomeLocal);
            this.panelCadLocal.Controls.Add(this.label1);
            this.panelCadLocal.Controls.Add(this.tbDescricaoLocal);
            this.panelCadLocal.Controls.Add(this.label13);
            this.panelCadLocal.Controls.Add(this.comboBoxTipoLocal);
            this.panelCadLocal.Controls.Add(this.label3);
            this.panelCadLocal.Controls.Add(this.btnCadastrar);
            this.panelCadLocal.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCadLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadLocal.Location = new System.Drawing.Point(0, 123);
            this.panelCadLocal.Name = "panelCadLocal";
            this.panelCadLocal.Size = new System.Drawing.Size(765, 137);
            this.panelCadLocal.TabIndex = 120;
            // 
            // tbNomeLocal
            // 
            this.tbNomeLocal.Location = new System.Drawing.Point(55, 27);
            this.tbNomeLocal.Name = "tbNomeLocal";
            this.tbNomeLocal.Size = new System.Drawing.Size(161, 20);
            this.tbNomeLocal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(52, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Descrição";
            // 
            // tbDescricaoLocal
            // 
            this.tbDescricaoLocal.Location = new System.Drawing.Point(55, 76);
            this.tbDescricaoLocal.Multiline = true;
            this.tbDescricaoLocal.Name = "tbDescricaoLocal";
            this.tbDescricaoLocal.Size = new System.Drawing.Size(299, 40);
            this.tbDescricaoLocal.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(230, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "Tipo";
            // 
            // comboBoxTipoLocal
            // 
            this.comboBoxTipoLocal.FormattingEnabled = true;
            this.comboBoxTipoLocal.Items.AddRange(new object[] {
            "SOLTEIRO",
            "DUPLO",
            "TRIPLO",
            "VIP"});
            this.comboBoxTipoLocal.Location = new System.Drawing.Point(222, 26);
            this.comboBoxTipoLocal.Name = "comboBoxTipoLocal";
            this.comboBoxTipoLocal.Size = new System.Drawing.Size(132, 21);
            this.comboBoxTipoLocal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(52, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Nome local";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Location = new System.Drawing.Point(451, 27);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 36);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnShowCadCategoriaLocal
            // 
            this.btnShowCadCategoriaLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnShowCadCategoriaLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowCadCategoriaLocal.FlatAppearance.BorderSize = 0;
            this.btnShowCadCategoriaLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCadCategoriaLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCadCategoriaLocal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowCadCategoriaLocal.Location = new System.Drawing.Point(0, 260);
            this.btnShowCadCategoriaLocal.Name = "btnShowCadCategoriaLocal";
            this.btnShowCadCategoriaLocal.Size = new System.Drawing.Size(765, 23);
            this.btnShowCadCategoriaLocal.TabIndex = 7;
            this.btnShowCadCategoriaLocal.Text = "NOVA CATEGORIA";
            this.btnShowCadCategoriaLocal.UseVisualStyleBackColor = false;
            this.btnShowCadCategoriaLocal.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelCadCategoriaLocal
            // 
            this.panelCadCategoriaLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelCadCategoriaLocal.Controls.Add(this.tbDescontoLocal);
            this.panelCadCategoriaLocal.Controls.Add(this.tbValorLocal);
            this.panelCadCategoriaLocal.Controls.Add(this.tbCategoriaLocal);
            this.panelCadCategoriaLocal.Controls.Add(this.label6);
            this.panelCadCategoriaLocal.Controls.Add(this.numericUpDownQuantidade);
            this.panelCadCategoriaLocal.Controls.Add(this.label2);
            this.panelCadCategoriaLocal.Controls.Add(this.label4);
            this.panelCadCategoriaLocal.Controls.Add(this.label5);
            this.panelCadCategoriaLocal.Controls.Add(this.btnCadastrarCategoriaLocal);
            this.panelCadCategoriaLocal.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCadCategoriaLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadCategoriaLocal.Location = new System.Drawing.Point(0, 283);
            this.panelCadCategoriaLocal.Name = "panelCadCategoriaLocal";
            this.panelCadCategoriaLocal.Size = new System.Drawing.Size(765, 137);
            this.panelCadCategoriaLocal.TabIndex = 122;
            // 
            // tbDescontoLocal
            // 
            this.tbDescontoLocal.Location = new System.Drawing.Point(278, 83);
            this.tbDescontoLocal.Name = "tbDescontoLocal";
            this.tbDescontoLocal.Size = new System.Drawing.Size(76, 20);
            this.tbDescontoLocal.TabIndex = 11;
            // 
            // tbValorLocal
            // 
            this.tbValorLocal.Location = new System.Drawing.Point(55, 83);
            this.tbValorLocal.Name = "tbValorLocal";
            this.tbValorLocal.Size = new System.Drawing.Size(217, 20);
            this.tbValorLocal.TabIndex = 10;
            // 
            // tbCategoriaLocal
            // 
            this.tbCategoriaLocal.Location = new System.Drawing.Point(55, 27);
            this.tbCategoriaLocal.Name = "tbCategoriaLocal";
            this.tbCategoriaLocal.Size = new System.Drawing.Size(217, 20);
            this.tbCategoriaLocal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(275, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Desconto Máx";
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(278, 28);
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownQuantidade.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(52, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Valor base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(275, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Quant Pessoas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(52, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Nome categoria";
            // 
            // btnCadastrarCategoriaLocal
            // 
            this.btnCadastrarCategoriaLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarCategoriaLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCategoriaLocal.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarCategoriaLocal.Location = new System.Drawing.Point(451, 27);
            this.btnCadastrarCategoriaLocal.Name = "btnCadastrarCategoriaLocal";
            this.btnCadastrarCategoriaLocal.Size = new System.Drawing.Size(185, 36);
            this.btnCadastrarCategoriaLocal.TabIndex = 12;
            this.btnCadastrarCategoriaLocal.Text = "Cadastrar";
            this.btnCadastrarCategoriaLocal.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoriaLocal.Click += new System.EventHandler(this.btnCadastrarCategoriaLocal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(261, 11);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "(escolha ou digite)";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.panelCadCategoriaLocal);
            this.Controls.Add(this.btnShowCadCategoriaLocal);
            this.Controls.Add(this.panelCadLocal);
            this.Controls.Add(this.btnShowCadLocal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCadLocal.ResumeLayout(false);
            this.panelCadLocal.PerformLayout();
            this.panelCadCategoriaLocal.ResumeLayout(false);
            this.panelCadCategoriaLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowCadLocal;
        private System.Windows.Forms.Panel panelCadLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescricaoLocal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxTipoLocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnShowCadCategoriaLocal;
        private System.Windows.Forms.Panel panelCadCategoriaLocal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrarCategoriaLocal;
        private System.Windows.Forms.TextBox tbNomeLocal;
        private System.Windows.Forms.TextBox tbDescontoLocal;
        private System.Windows.Forms.TextBox tbValorLocal;
        private System.Windows.Forms.TextBox tbCategoriaLocal;
        private System.Windows.Forms.Label label7;
    }
}