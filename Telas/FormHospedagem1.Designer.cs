
namespace Telas {
    partial class FormHospedagem1 {
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
            this.btnCadReserva = new System.Windows.Forms.Button();
            this.panelCadReserva = new System.Windows.Forms.Panel();
            this.tbDataSaida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDataEntrada = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnListarReservas = new System.Windows.Forms.Button();
            this.panelListarReserva = new System.Windows.Forms.Panel();
            this.comboBoxSituacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.hOTELDataSet = new Telas.HOTELDataSet();
            this.lOCALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOCALTableAdapter = new Telas.HOTELDataSetTableAdapters.LOCALTableAdapter();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.lOCALBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownHospedes = new System.Windows.Forms.NumericUpDown();
            this.tbCpfTitular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hotelDataSet1 = new Telas.HOTELDataSet();
            this.tbHoraSaida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbHoraEntrada = new System.Windows.Forms.TextBox();
            this.panelHospedagem.SuspendLayout();
            this.panelCadReserva.SuspendLayout();
            this.panelListarReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCALBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHospedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
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
            this.panelHospedagem.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(54, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 31);
            this.label9.TabIndex = 100;
            this.label9.Text = "HOSPEDAGEM";
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
            // btnCadReserva
            // 
            this.btnCadReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnCadReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadReserva.FlatAppearance.BorderSize = 0;
            this.btnCadReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadReserva.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadReserva.Location = new System.Drawing.Point(0, 100);
            this.btnCadReserva.Name = "btnCadReserva";
            this.btnCadReserva.Size = new System.Drawing.Size(765, 23);
            this.btnCadReserva.TabIndex = 1;
            this.btnCadReserva.Text = "RESERVAR";
            this.btnCadReserva.UseVisualStyleBackColor = false;
            this.btnCadReserva.Click += new System.EventHandler(this.btnCadReserva_Click);
            // 
            // panelCadReserva
            // 
            this.panelCadReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelCadReserva.Controls.Add(this.tbHoraSaida);
            this.panelCadReserva.Controls.Add(this.label11);
            this.panelCadReserva.Controls.Add(this.label12);
            this.panelCadReserva.Controls.Add(this.tbHoraEntrada);
            this.panelCadReserva.Controls.Add(this.numericUpDownHospedes);
            this.panelCadReserva.Controls.Add(this.comboBoxLocal);
            this.panelCadReserva.Controls.Add(this.tbDataSaida);
            this.panelCadReserva.Controls.Add(this.label8);
            this.panelCadReserva.Controls.Add(this.label7);
            this.panelCadReserva.Controls.Add(this.label6);
            this.panelCadReserva.Controls.Add(this.tbDataEntrada);
            this.panelCadReserva.Controls.Add(this.comboBoxStatus);
            this.panelCadReserva.Controls.Add(this.label4);
            this.panelCadReserva.Controls.Add(this.label3);
            this.panelCadReserva.Controls.Add(this.tbCPF);
            this.panelCadReserva.Controls.Add(this.label2);
            this.panelCadReserva.Controls.Add(this.button1);
            this.panelCadReserva.Controls.Add(this.btnReservar);
            this.panelCadReserva.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelCadReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadReserva.Location = new System.Drawing.Point(0, 123);
            this.panelCadReserva.Name = "panelCadReserva";
            this.panelCadReserva.Size = new System.Drawing.Size(765, 196);
            this.panelCadReserva.TabIndex = 126;
            // 
            // tbDataSaida
            // 
            this.tbDataSaida.Location = new System.Drawing.Point(378, 110);
            this.tbDataSaida.Name = "tbDataSaida";
            this.tbDataSaida.Size = new System.Drawing.Size(159, 20);
            this.tbDataSaida.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(567, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "Quantidade hóspedes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(375, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 109;
            this.label7.Text = "Data saída";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(57, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Data entrada";
            // 
            // tbDataEntrada
            // 
            this.tbDataEntrada.Location = new System.Drawing.Point(60, 110);
            this.tbDataEntrada.Name = "tbDataEntrada";
            this.tbDataEntrada.Size = new System.Drawing.Size(160, 20);
            this.tbDataEntrada.TabIndex = 6;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Reservada",
            "Checkin",
            "Checkout",
            "Cancelada",
            "Pendente"});
            this.comboBoxStatus.Location = new System.Drawing.Point(363, 66);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(196, 21);
            this.comboBoxStatus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(363, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(233, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Local";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(60, 67);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(167, 20);
            this.tbCPF.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(57, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "CPF Titular";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(584, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Botão";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReservar.Location = new System.Drawing.Point(472, 145);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(106, 36);
            this.btnReservar.TabIndex = 10;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnListarReservas
            // 
            this.btnListarReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(37)))), ((int)(((byte)(76)))));
            this.btnListarReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarReservas.FlatAppearance.BorderSize = 0;
            this.btnListarReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarReservas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarReservas.Location = new System.Drawing.Point(0, 319);
            this.btnListarReservas.Name = "btnListarReservas";
            this.btnListarReservas.Size = new System.Drawing.Size(765, 23);
            this.btnListarReservas.TabIndex = 12;
            this.btnListarReservas.Text = "LISTAR RESERVAS";
            this.btnListarReservas.UseVisualStyleBackColor = false;
            this.btnListarReservas.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelListarReserva
            // 
            this.panelListarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.panelListarReserva.Controls.Add(this.label10);
            this.panelListarReserva.Controls.Add(this.tbID);
            this.panelListarReserva.Controls.Add(this.tbCpfTitular);
            this.panelListarReserva.Controls.Add(this.label5);
            this.panelListarReserva.Controls.Add(this.comboBoxSituacao);
            this.panelListarReserva.Controls.Add(this.label1);
            this.panelListarReserva.Controls.Add(this.button5);
            this.panelListarReserva.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelListarReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListarReserva.Location = new System.Drawing.Point(0, 342);
            this.panelListarReserva.Name = "panelListarReserva";
            this.panelListarReserva.Size = new System.Drawing.Size(765, 75);
            this.panelListarReserva.TabIndex = 128;
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.FormattingEnabled = true;
            this.comboBoxSituacao.Items.AddRange(new object[] {
            "Reservada",
            "Cancelada",
            "Em andamento",
            "Todas"});
            this.comboBoxSituacao.Location = new System.Drawing.Point(60, 38);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSituacao.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Situação";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(472, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 36);
            this.button5.TabIndex = 16;
            this.button5.Text = "Listar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // hOTELDataSet
            // 
            this.hOTELDataSet.DataSetName = "HOTELDataSet";
            this.hOTELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOCALBindingSource
            // 
            this.lOCALBindingSource.DataMember = "LOCAL";
            this.lOCALBindingSource.DataSource = this.hOTELDataSet;
            // 
            // lOCALTableAdapter
            // 
            this.lOCALTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.DataSource = this.lOCALBindingSource1;
            this.comboBoxLocal.DisplayMember = "NOME";
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Location = new System.Drawing.Point(236, 67);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 3;
            this.comboBoxLocal.ValueMember = "NOME";
            // 
            // lOCALBindingSource1
            // 
            this.lOCALBindingSource1.DataMember = "LOCAL";
            this.lOCALBindingSource1.DataSource = this.hOTELDataSet;
            // 
            // numericUpDownHospedes
            // 
            this.numericUpDownHospedes.Location = new System.Drawing.Point(570, 66);
            this.numericUpDownHospedes.Name = "numericUpDownHospedes";
            this.numericUpDownHospedes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHospedes.TabIndex = 5;
            // 
            // tbCpfTitular
            // 
            this.tbCpfTitular.Location = new System.Drawing.Point(190, 38);
            this.tbCpfTitular.Name = "tbCpfTitular";
            this.tbCpfTitular.Size = new System.Drawing.Size(167, 20);
            this.tbCpfTitular.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(187, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 103;
            this.label5.Text = "CPF Titular";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(363, 38);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(82, 20);
            this.tbID.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(362, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 117;
            this.label10.Text = "ID Hospedagem";
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HOTELDataSet";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbHoraSaida
            // 
            this.tbHoraSaida.Location = new System.Drawing.Point(543, 110);
            this.tbHoraSaida.Name = "tbHoraSaida";
            this.tbHoraSaida.Size = new System.Drawing.Size(147, 20);
            this.tbHoraSaida.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(540, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 116;
            this.label11.Text = "Hora saída";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(223, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "Hora entrada";
            // 
            // tbHoraEntrada
            // 
            this.tbHoraEntrada.Location = new System.Drawing.Point(226, 110);
            this.tbHoraEntrada.Name = "tbHoraEntrada";
            this.tbHoraEntrada.Size = new System.Drawing.Size(144, 20);
            this.tbHoraEntrada.TabIndex = 7;
            // 
            // FormHospedagem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.panelListarReserva);
            this.Controls.Add(this.btnListarReservas);
            this.Controls.Add(this.panelCadReserva);
            this.Controls.Add(this.btnCadReserva);
            this.Controls.Add(this.panelHospedagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHospedagem1";
            this.Text = "FormHospedagem1";
            this.Load += new System.EventHandler(this.FormHospedagem1_Load);
            this.panelHospedagem.ResumeLayout(false);
            this.panelHospedagem.PerformLayout();
            this.panelCadReserva.ResumeLayout(false);
            this.panelCadReserva.PerformLayout();
            this.panelListarReserva.ResumeLayout(false);
            this.panelListarReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOCALBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHospedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHospedagem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadReserva;
        private System.Windows.Forms.Panel panelCadReserva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnListarReservas;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelListarReserva;
        private System.Windows.Forms.ComboBox comboBoxSituacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDataSaida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDataEntrada;
        private HOTELDataSet hOTELDataSet;
        private System.Windows.Forms.BindingSource lOCALBindingSource;
        private HOTELDataSetTableAdapters.LOCALTableAdapter lOCALTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDownHospedes;
        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.BindingSource lOCALBindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbCpfTitular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHoraSaida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbHoraEntrada;
        private HOTELDataSet hotelDataSet1;
    }
}