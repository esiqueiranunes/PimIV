
namespace Telas {
    partial class Form7 {
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
            this.btnSair = new System.Windows.Forms.Button();
            this.panelCadCategoria = new System.Windows.Forms.Panel();
            this.tbNomeCategoria = new System.Windows.Forms.TextBox();
            this.comboBoxCategoriaServico = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCadastrarServico.SuspendLayout();
            this.panelCadCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastrarServico
            // 
            this.panelCadastrarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.panelCadastrarServico.Controls.Add(this.label9);
            this.panelCadastrarServico.Controls.Add(this.btnSair);
            this.panelCadastrarServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastrarServico.Location = new System.Drawing.Point(0, 0);
            this.panelCadastrarServico.Name = "panelCadastrarServico";
            this.panelCadastrarServico.Size = new System.Drawing.Size(765, 100);
            this.panelCadastrarServico.TabIndex = 124;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "CADASTRAR CATEGORIA";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(586, 26);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 36);
            this.btnSair.TabIndex = 105;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelCadCategoria
            // 
            this.panelCadCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelCadCategoria.Controls.Add(this.tbNomeCategoria);
            this.panelCadCategoria.Controls.Add(this.comboBoxCategoriaServico);
            this.panelCadCategoria.Controls.Add(this.button6);
            this.panelCadCategoria.Controls.Add(this.label8);
            this.panelCadCategoria.Controls.Add(this.button7);
            this.panelCadCategoria.Controls.Add(this.label10);
            this.panelCadCategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCadCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadCategoria.Location = new System.Drawing.Point(0, 100);
            this.panelCadCategoria.Name = "panelCadCategoria";
            this.panelCadCategoria.Size = new System.Drawing.Size(765, 85);
            this.panelCadCategoria.TabIndex = 135;
            this.panelCadCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadCategoria_Paint);
            // 
            // tbNomeCategoria
            // 
            this.tbNomeCategoria.Location = new System.Drawing.Point(228, 31);
            this.tbNomeCategoria.Name = "tbNomeCategoria";
            this.tbNomeCategoria.Size = new System.Drawing.Size(221, 20);
            this.tbNomeCategoria.TabIndex = 108;
            // 
            // comboBoxCategoriaServico
            // 
            this.comboBoxCategoriaServico.FormattingEnabled = true;
            this.comboBoxCategoriaServico.Items.AddRange(new object[] {
            "Produto",
            "Servico",
            "Pessoa",
            "Conta"});
            this.comboBoxCategoriaServico.Location = new System.Drawing.Point(42, 30);
            this.comboBoxCategoriaServico.Name = "comboBoxCategoriaServico";
            this.comboBoxCategoriaServico.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCategoriaServico.TabIndex = 104;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Location = new System.Drawing.Point(586, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 36);
            this.button6.TabIndex = 87;
            this.button6.Text = "Botão";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(228, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Nome da categoria";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.Window;
            this.button7.Location = new System.Drawing.Point(474, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 36);
            this.button7.TabIndex = 86;
            this.button7.Text = "Cadastrar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(39, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Tipo da categoria";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.panelCadCategoria);
            this.Controls.Add(this.panelCadastrarServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.panelCadastrarServico.ResumeLayout(false);
            this.panelCadastrarServico.PerformLayout();
            this.panelCadCategoria.ResumeLayout(false);
            this.panelCadCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastrarServico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelCadCategoria;
        private System.Windows.Forms.TextBox tbNomeCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoriaServico;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label10;
    }
}