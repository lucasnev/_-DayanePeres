﻿namespace HairLumos.Views.Funcoes_Basicas
{
    partial class Cadastro_ServiçosParceiros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskPercentual = new System.Windows.Forms.MaskedTextBox();
            this.mskTotalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskValorConta = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIncluirServico = new System.Windows.Forms.Button();
            this.mskValorServico = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbReceber = new System.Windows.Forms.RadioButton();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.cbbTipoServico = new System.Windows.Forms.ComboBox();
            this.btnSelecionaPessoa = new System.Windows.Forms.Button();
            this.ttbPessoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvServico = new System.Windows.Forms.DataGridView();
            this.codtiposervico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposerv_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposerv_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiposerv_temposervico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(11, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.dgvServico);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelecionar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnPesquisar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSair);
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovo);
            this.splitContainer1.Size = new System.Drawing.Size(584, 467);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnIncluirServico);
            this.groupBox1.Controls.Add(this.mskValorServico);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbbTipoServico);
            this.groupBox1.Controls.Add(this.btnSelecionaPessoa);
            this.groupBox1.Controls.Add(this.ttbPessoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 227);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVIÇOS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mskPercentual);
            this.groupBox3.Controls.Add(this.mskTotalLiquido);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.mskValorConta);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(20, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 103);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "INFOME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Valor em (%)";
            // 
            // mskPercentual
            // 
            this.mskPercentual.Enabled = false;
            this.mskPercentual.Location = new System.Drawing.Point(6, 77);
            this.mskPercentual.Name = "mskPercentual";
            this.mskPercentual.Size = new System.Drawing.Size(159, 20);
            this.mskPercentual.TabIndex = 41;
            // 
            // mskTotalLiquido
            // 
            this.mskTotalLiquido.Enabled = false;
            this.mskTotalLiquido.Location = new System.Drawing.Point(235, 46);
            this.mskTotalLiquido.Name = "mskTotalLiquido";
            this.mskTotalLiquido.Size = new System.Drawing.Size(136, 20);
            this.mskTotalLiquido.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Total Líquido Serviço (R$)";
            // 
            // mskValorConta
            // 
            this.mskValorConta.Location = new System.Drawing.Point(6, 36);
            this.mskValorConta.Name = "mskValorConta";
            this.mskValorConta.Size = new System.Drawing.Size(159, 20);
            this.mskValorConta.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Valor a PAGAR ou a RECEBER (R$)";
            // 
            // btnIncluirServico
            // 
            this.btnIncluirServico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIncluirServico.Location = new System.Drawing.Point(458, 154);
            this.btnIncluirServico.Name = "btnIncluirServico";
            this.btnIncluirServico.Size = new System.Drawing.Size(97, 38);
            this.btnIncluirServico.TabIndex = 14;
            this.btnIncluirServico.Text = "Incluir Serviço";
            this.btnIncluirServico.UseVisualStyleBackColor = false;
            this.btnIncluirServico.Click += new System.EventHandler(this.btnIncluirServico_Click);
            // 
            // mskValorServico
            // 
            this.mskValorServico.Location = new System.Drawing.Point(274, 83);
            this.mskValorServico.Name = "mskValorServico";
            this.mskValorServico.Size = new System.Drawing.Size(136, 20);
            this.mskValorServico.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Valor Total do Serviço (R$)*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbReceber);
            this.groupBox2.Controls.Add(this.rbPagar);
            this.groupBox2.Location = new System.Drawing.Point(424, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 65);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Pagar ou Receber?";
            // 
            // rbReceber
            // 
            this.rbReceber.AutoSize = true;
            this.rbReceber.Location = new System.Drawing.Point(61, 36);
            this.rbReceber.Name = "rbReceber";
            this.rbReceber.Size = new System.Drawing.Size(66, 17);
            this.rbReceber.TabIndex = 24;
            this.rbReceber.TabStop = true;
            this.rbReceber.Text = "Receber";
            this.rbReceber.UseVisualStyleBackColor = true;
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.Location = new System.Drawing.Point(6, 36);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(53, 17);
            this.rbPagar.TabIndex = 23;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "Pagar";
            this.rbPagar.UseVisualStyleBackColor = true;
            // 
            // cbbTipoServico
            // 
            this.cbbTipoServico.FormattingEnabled = true;
            this.cbbTipoServico.Location = new System.Drawing.Point(20, 82);
            this.cbbTipoServico.Name = "cbbTipoServico";
            this.cbbTipoServico.Size = new System.Drawing.Size(241, 21);
            this.cbbTipoServico.TabIndex = 32;
            this.cbbTipoServico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbTipoServico_MouseClick);
            // 
            // btnSelecionaPessoa
            // 
            this.btnSelecionaPessoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecionaPessoa.Location = new System.Drawing.Point(483, 30);
            this.btnSelecionaPessoa.Name = "btnSelecionaPessoa";
            this.btnSelecionaPessoa.Size = new System.Drawing.Size(72, 27);
            this.btnSelecionaPessoa.TabIndex = 31;
            this.btnSelecionaPessoa.Text = "Localizar";
            this.btnSelecionaPessoa.UseVisualStyleBackColor = false;
            this.btnSelecionaPessoa.Click += new System.EventHandler(this.btnSelecionaPessoa_Click);
            // 
            // ttbPessoa
            // 
            this.ttbPessoa.Location = new System.Drawing.Point(20, 34);
            this.ttbPessoa.MaxLength = 100;
            this.ttbPessoa.Name = "ttbPessoa";
            this.ttbPessoa.Size = new System.Drawing.Size(439, 20);
            this.ttbPessoa.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tipo Serviço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Parceiro*";
            // 
            // dgvServico
            // 
            this.dgvServico.AllowUserToAddRows = false;
            this.dgvServico.AllowUserToDeleteRows = false;
            this.dgvServico.BackgroundColor = System.Drawing.Color.White;
            this.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codtiposervico,
            this.tiposerv_descricao,
            this.tiposerv_valor,
            this.tiposerv_temposervico});
            this.dgvServico.Location = new System.Drawing.Point(21, 247);
            this.dgvServico.Name = "dgvServico";
            this.dgvServico.ReadOnly = true;
            this.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServico.Size = new System.Drawing.Size(468, 138);
            this.dgvServico.TabIndex = 12;
            // 
            // codtiposervico
            // 
            this.codtiposervico.DataPropertyName = "codtiposervico";
            this.codtiposervico.HeaderText = "Cód";
            this.codtiposervico.Name = "codtiposervico";
            this.codtiposervico.ReadOnly = true;
            this.codtiposervico.Width = 50;
            // 
            // tiposerv_descricao
            // 
            this.tiposerv_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tiposerv_descricao.DataPropertyName = "tiposerv_descricao";
            this.tiposerv_descricao.HeaderText = "Tipo Serviço";
            this.tiposerv_descricao.Name = "tiposerv_descricao";
            this.tiposerv_descricao.ReadOnly = true;
            // 
            // tiposerv_valor
            // 
            this.tiposerv_valor.DataPropertyName = "tiposerv_valor";
            this.tiposerv_valor.HeaderText = "Valor Serviço (R$)";
            this.tiposerv_valor.Name = "tiposerv_valor";
            this.tiposerv_valor.ReadOnly = true;
            // 
            // tiposerv_temposervico
            // 
            this.tiposerv_temposervico.DataPropertyName = "tiposerv_temposervico";
            this.tiposerv_temposervico.HeaderText = "Tempo Estimado";
            this.tiposerv_temposervico.Name = "tiposerv_temposervico";
            this.tiposerv_temposervico.ReadOnly = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelecionar.Location = new System.Drawing.Point(496, 288);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(72, 27);
            this.btnSelecionar.TabIndex = 12;
            this.btnSelecionar.Text = "Seleciona";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisar.Location = new System.Drawing.Point(305, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(65, 38);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(376, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 38);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Location = new System.Drawing.Point(496, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 38);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Location = new System.Drawing.Point(234, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(65, 38);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterar.Location = new System.Drawing.Point(163, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(65, 38);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGravar.Location = new System.Drawing.Point(92, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(65, 38);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(21, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(65, 38);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // Cadastro_ServiçosParceiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(607, 491);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Cadastro_ServiçosParceiros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HL - CADASTRO SERVIÇOS PARCEIROS";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtiposervico;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposerv_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposerv_velor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposerv_temposervico;
        public System.Windows.Forms.Button btnSelecionar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnAlterar;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbReceber;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.ComboBox cbbTipoServico;
        public System.Windows.Forms.Button btnSelecionaPessoa;
        public System.Windows.Forms.TextBox ttbPessoa;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnIncluirServico;
        public System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiposerv_valor;
        private System.Windows.Forms.MaskedTextBox mskValorConta;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTotalLiquido;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskValorServico;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskPercentual;
    }
}