
namespace Telas {
    partial class Form3 {
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
            this.panelCadServico = new System.Windows.Forms.Panel();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.tbEmailUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrarUser = new System.Windows.Forms.Button();
            this.panelCadastrarServico.SuspendLayout();
            this.panelCadServico.SuspendLayout();
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
            this.label9.Size = new System.Drawing.Size(332, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "CADASTRAR USUARIO";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(594, 26);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 36);
            this.btnSair.TabIndex = 105;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelCadServico
            // 
            this.panelCadServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelCadServico.Controls.Add(this.comboBoxNivel);
            this.panelCadServico.Controls.Add(this.tbEmailUser);
            this.panelCadServico.Controls.Add(this.label2);
            this.panelCadServico.Controls.Add(this.label5);
            this.panelCadServico.Controls.Add(this.btnCadastrarUser);
            this.panelCadServico.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCadServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadServico.Location = new System.Drawing.Point(0, 100);
            this.panelCadServico.Name = "panelCadServico";
            this.panelCadServico.Size = new System.Drawing.Size(765, 105);
            this.panelCadServico.TabIndex = 126;
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário",
            "Cliente"});
            this.comboBoxNivel.Location = new System.Drawing.Point(313, 54);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(234, 21);
            this.comboBoxNivel.TabIndex = 2;
            // 
            // tbEmailUser
            // 
            this.tbEmailUser.Location = new System.Drawing.Point(60, 54);
            this.tbEmailUser.Name = "tbEmailUser";
            this.tbEmailUser.Size = new System.Drawing.Size(234, 20);
            this.tbEmailUser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(310, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nível";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(57, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "E-mail";
            // 
            // btnCadastrarUser
            // 
            this.btnCadastrarUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarUser.Location = new System.Drawing.Point(594, 39);
            this.btnCadastrarUser.Name = "btnCadastrarUser";
            this.btnCadastrarUser.Size = new System.Drawing.Size(106, 36);
            this.btnCadastrarUser.TabIndex = 3;
            this.btnCadastrarUser.Text = "Cadastrar";
            this.btnCadastrarUser.UseVisualStyleBackColor = true;
            this.btnCadastrarUser.Click += new System.EventHandler(this.btnCadastrarUser_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.panelCadServico);
            this.Controls.Add(this.panelCadastrarServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panelCadastrarServico.ResumeLayout(false);
            this.panelCadastrarServico.PerformLayout();
            this.panelCadServico.ResumeLayout(false);
            this.panelCadServico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastrarServico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelCadServico;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.TextBox tbEmailUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrarUser;
    }
}