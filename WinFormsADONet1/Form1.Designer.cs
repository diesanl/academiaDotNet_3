namespace WinFormsADONet1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelLocalizacao = new System.Windows.Forms.Label();
            this.labelOrcamento = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxLocalizacao = new System.Windows.Forms.TextBox();
            this.textBoxOrcamento = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxFuncao = new System.Windows.Forms.TextBox();
            this.textBoxIdGerente = new System.Windows.Forms.TextBox();
            this.textBoxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.textBoxDataAdmissao = new System.Windows.Forms.TextBox();
            this.textBoxIdDepartamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxComissao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSalvarFuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 112);
            this.button1.TabIndex = 0;
            this.button1.Text = "pqno teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(119, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome Departamento";
            // 
            // labelLocalizacao
            // 
            this.labelLocalizacao.AutoSize = true;
            this.labelLocalizacao.Location = new System.Drawing.Point(12, 45);
            this.labelLocalizacao.Name = "labelLocalizacao";
            this.labelLocalizacao.Size = new System.Drawing.Size(68, 15);
            this.labelLocalizacao.TabIndex = 2;
            this.labelLocalizacao.Text = "Localização";
            // 
            // labelOrcamento
            // 
            this.labelOrcamento.AutoSize = true;
            this.labelOrcamento.Location = new System.Drawing.Point(12, 84);
            this.labelOrcamento.Name = "labelOrcamento";
            this.labelOrcamento.Size = new System.Drawing.Size(67, 15);
            this.labelOrcamento.TabIndex = 3;
            this.labelOrcamento.Text = "Orçamento";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(137, 6);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxLocalizacao
            // 
            this.textBoxLocalizacao.Location = new System.Drawing.Point(137, 42);
            this.textBoxLocalizacao.Name = "textBoxLocalizacao";
            this.textBoxLocalizacao.Size = new System.Drawing.Size(100, 23);
            this.textBoxLocalizacao.TabIndex = 5;
            // 
            // textBoxOrcamento
            // 
            this.textBoxOrcamento.Location = new System.Drawing.Point(137, 81);
            this.textBoxOrcamento.Name = "textBoxOrcamento";
            this.textBoxOrcamento.Size = new System.Drawing.Size(100, 23);
            this.textBoxOrcamento.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(106, 137);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(87, 34);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textBoxFuncao
            // 
            this.textBoxFuncao.Location = new System.Drawing.Point(466, 78);
            this.textBoxFuncao.Name = "textBoxFuncao";
            this.textBoxFuncao.Size = new System.Drawing.Size(100, 23);
            this.textBoxFuncao.TabIndex = 13;
            // 
            // textBoxIdGerente
            // 
            this.textBoxIdGerente.Location = new System.Drawing.Point(466, 39);
            this.textBoxIdGerente.Name = "textBoxIdGerente";
            this.textBoxIdGerente.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdGerente.TabIndex = 12;
            // 
            // textBoxNomeFuncionario
            // 
            this.textBoxNomeFuncionario.Location = new System.Drawing.Point(466, 3);
            this.textBoxNomeFuncionario.Name = "textBoxNomeFuncionario";
            this.textBoxNomeFuncionario.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomeFuncionario.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Função:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Gerente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome Funcionário:";
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(466, 189);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(100, 23);
            this.textBoxSalario.TabIndex = 19;
            // 
            // textBoxDataAdmissao
            // 
            this.textBoxDataAdmissao.Location = new System.Drawing.Point(466, 150);
            this.textBoxDataAdmissao.Name = "textBoxDataAdmissao";
            this.textBoxDataAdmissao.Size = new System.Drawing.Size(100, 23);
            this.textBoxDataAdmissao.TabIndex = 18;
            // 
            // textBoxIdDepartamento
            // 
            this.textBoxIdDepartamento.Location = new System.Drawing.Point(466, 114);
            this.textBoxIdDepartamento.Name = "textBoxIdDepartamento";
            this.textBoxIdDepartamento.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdDepartamento.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Salário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data Admissão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Departamento:";
            // 
            // textBoxComissao
            // 
            this.textBoxComissao.Location = new System.Drawing.Point(466, 229);
            this.textBoxComissao.Name = "textBoxComissao";
            this.textBoxComissao.Size = new System.Drawing.Size(100, 23);
            this.textBoxComissao.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Comissão:";
            // 
            // buttonSalvarFuncionario
            // 
            this.buttonSalvarFuncionario.Location = new System.Drawing.Point(341, 276);
            this.buttonSalvarFuncionario.Name = "buttonSalvarFuncionario";
            this.buttonSalvarFuncionario.Size = new System.Drawing.Size(122, 34);
            this.buttonSalvarFuncionario.TabIndex = 22;
            this.buttonSalvarFuncionario.Text = "Salvar Funcionário";
            this.buttonSalvarFuncionario.UseVisualStyleBackColor = true;
            this.buttonSalvarFuncionario.Click += new System.EventHandler(this.buttonSalvarFuncionario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalvarFuncionario);
            this.Controls.Add(this.textBoxComissao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSalario);
            this.Controls.Add(this.textBoxDataAdmissao);
            this.Controls.Add(this.textBoxIdDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFuncao);
            this.Controls.Add(this.textBoxIdGerente);
            this.Controls.Add(this.textBoxNomeFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxOrcamento);
            this.Controls.Add(this.textBoxLocalizacao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelOrcamento);
            this.Controls.Add(this.labelLocalizacao);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label labelNome;
        private Label labelLocalizacao;
        private Label labelOrcamento;
        private TextBox textBoxNome;
        private TextBox textBoxLocalizacao;
        private TextBox textBoxOrcamento;
        private Button buttonSalvar;
        private TextBox textBoxFuncao;
        private TextBox textBoxIdGerente;
        private TextBox textBoxNomeFuncionario;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxSalario;
        private TextBox textBoxDataAdmissao;
        private TextBox textBoxIdDepartamento;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxComissao;
        private Label label7;
        private Button buttonSalvarFuncionario;
    }
}