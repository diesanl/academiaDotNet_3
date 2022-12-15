namespace WinFormsDesafio2
{
    partial class FormMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCliente = new System.Windows.Forms.TabPage();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCpfCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.maskedTextBoxCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.buttonDeletarCliente = new System.Windows.Forms.Button();
            this.buttonEditarCliente = new System.Windows.Forms.Button();
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.buttonSalvarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.tabPageFornecedor = new System.Windows.Forms.TabPage();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnIdFornec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNomeFornec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCnpjFornec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmailFornec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFornecedor = new System.Windows.Forms.Panel();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.buttonDeletarFornecedor = new System.Windows.Forms.Button();
            this.buttonEditarFornecedor = new System.Windows.Forms.Button();
            this.buttonPesquisarFornecedor = new System.Windows.Forms.Button();
            this.buttonSalvarFornecedor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmailFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDescFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIDFornecedor = new System.Windows.Forms.TextBox();
            this.tabPageProduto = new System.Windows.Forms.TabPage();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDescProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProduto = new System.Windows.Forms.Panel();
            this.maskedTextBoxValorProduto = new System.Windows.Forms.MaskedTextBox();
            this.buttonDeletarProduto = new System.Windows.Forms.Button();
            this.buttonEditarProduto = new System.Windows.Forms.Button();
            this.buttonPesquisarProduto = new System.Windows.Forms.Button();
            this.buttonSalvarProduto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxProdutoIdFornecedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDescProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxIdProduto = new System.Windows.Forms.TextBox();
            this.tabPagePedido = new System.Windows.Forms.TabPage();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPedidoIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPedido = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonDeletarPedido = new System.Windows.Forms.Button();
            this.buttonEditarPedido = new System.Windows.Forms.Button();
            this.buttonPesquisarPedido = new System.Windows.Forms.Button();
            this.buttonSalvarPedido = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxIdPedido = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.panelCliente.SuspendLayout();
            this.tabPageFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.panelFornecedor.SuspendLayout();
            this.tabPageProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.panelProduto.SuspendLayout();
            this.tabPagePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.panelPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCliente);
            this.tabControlMain.Controls.Add(this.tabPageFornecedor);
            this.tabControlMain.Controls.Add(this.tabPageProduto);
            this.tabControlMain.Controls.Add(this.tabPagePedido);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageCliente
            // 
            this.tabPageCliente.Controls.Add(this.dataGridViewCliente);
            this.tabPageCliente.Controls.Add(this.panelCliente);
            this.tabPageCliente.Location = new System.Drawing.Point(4, 24);
            this.tabPageCliente.Name = "tabPageCliente";
            this.tabPageCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCliente.Size = new System.Drawing.Size(768, 398);
            this.tabPageCliente.TabIndex = 0;
            this.tabPageCliente.Text = "Cliente";
            this.tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnIDCliente,
            this.dataGridViewTextBoxColumnNomeCliente,
            this.dataGridViewTextBoxColumnCpfCliente,
            this.dataGridViewTextBoxColumnEmailCliente});
            this.dataGridViewCliente.Location = new System.Drawing.Point(6, 139);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.RowTemplate.Height = 25;
            this.dataGridViewCliente.Size = new System.Drawing.Size(593, 249);
            this.dataGridViewCliente.TabIndex = 3;
            this.dataGridViewCliente.SelectionChanged += new System.EventHandler(this.dataGridViewCliente_SelectionChanged);
            // 
            // dataGridViewTextBoxColumnIDCliente
            // 
            this.dataGridViewTextBoxColumnIDCliente.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumnIDCliente.HeaderText = "ID";
            this.dataGridViewTextBoxColumnIDCliente.Name = "dataGridViewTextBoxColumnIDCliente";
            this.dataGridViewTextBoxColumnIDCliente.ReadOnly = true;
            this.dataGridViewTextBoxColumnIDCliente.Width = 30;
            // 
            // dataGridViewTextBoxColumnNomeCliente
            // 
            this.dataGridViewTextBoxColumnNomeCliente.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumnNomeCliente.HeaderText = "Nome";
            this.dataGridViewTextBoxColumnNomeCliente.Name = "dataGridViewTextBoxColumnNomeCliente";
            this.dataGridViewTextBoxColumnNomeCliente.ReadOnly = true;
            this.dataGridViewTextBoxColumnNomeCliente.Width = 200;
            // 
            // dataGridViewTextBoxColumnCpfCliente
            // 
            this.dataGridViewTextBoxColumnCpfCliente.DataPropertyName = "cpf";
            this.dataGridViewTextBoxColumnCpfCliente.HeaderText = "CPF";
            this.dataGridViewTextBoxColumnCpfCliente.Name = "dataGridViewTextBoxColumnCpfCliente";
            this.dataGridViewTextBoxColumnCpfCliente.ReadOnly = true;
            this.dataGridViewTextBoxColumnCpfCliente.Width = 70;
            // 
            // dataGridViewTextBoxColumnEmailCliente
            // 
            this.dataGridViewTextBoxColumnEmailCliente.DataPropertyName = "email";
            this.dataGridViewTextBoxColumnEmailCliente.HeaderText = "Email";
            this.dataGridViewTextBoxColumnEmailCliente.Name = "dataGridViewTextBoxColumnEmailCliente";
            this.dataGridViewTextBoxColumnEmailCliente.ReadOnly = true;
            this.dataGridViewTextBoxColumnEmailCliente.Width = 200;
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.maskedTextBoxCpfCliente);
            this.panelCliente.Controls.Add(this.buttonDeletarCliente);
            this.panelCliente.Controls.Add(this.buttonEditarCliente);
            this.panelCliente.Controls.Add(this.buttonPesquisarCliente);
            this.panelCliente.Controls.Add(this.buttonSalvarCliente);
            this.panelCliente.Controls.Add(this.label4);
            this.panelCliente.Controls.Add(this.textBoxEmailCliente);
            this.panelCliente.Controls.Add(this.label3);
            this.panelCliente.Controls.Add(this.label2);
            this.panelCliente.Controls.Add(this.textBoxNomeCliente);
            this.panelCliente.Controls.Add(this.label1);
            this.panelCliente.Controls.Add(this.textBoxIdCliente);
            this.panelCliente.Location = new System.Drawing.Point(6, 6);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(402, 135);
            this.panelCliente.TabIndex = 2;
            // 
            // maskedTextBoxCpfCliente
            // 
            this.maskedTextBoxCpfCliente.Location = new System.Drawing.Point(48, 68);
            this.maskedTextBoxCpfCliente.Mask = "000.000.000-99";
            this.maskedTextBoxCpfCliente.Name = "maskedTextBoxCpfCliente";
            this.maskedTextBoxCpfCliente.Size = new System.Drawing.Size(194, 23);
            this.maskedTextBoxCpfCliente.TabIndex = 4;
            // 
            // buttonDeletarCliente
            // 
            this.buttonDeletarCliente.Location = new System.Drawing.Point(294, 95);
            this.buttonDeletarCliente.Name = "buttonDeletarCliente";
            this.buttonDeletarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletarCliente.TabIndex = 11;
            this.buttonDeletarCliente.Text = "Deletar";
            this.buttonDeletarCliente.UseVisualStyleBackColor = true;
            this.buttonDeletarCliente.Click += new System.EventHandler(this.buttonDeletarCliente_Click);
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.Location = new System.Drawing.Point(294, 66);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarCliente.TabIndex = 10;
            this.buttonEditarCliente.Text = "Editar";
            this.buttonEditarCliente.UseVisualStyleBackColor = true;
            this.buttonEditarCliente.Click += new System.EventHandler(this.buttonEditarCliente_Click);
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(294, 37);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarCliente.TabIndex = 9;
            this.buttonPesquisarCliente.Text = "Pesquisar";
            this.buttonPesquisarCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // buttonSalvarCliente
            // 
            this.buttonSalvarCliente.Location = new System.Drawing.Point(294, 11);
            this.buttonSalvarCliente.Name = "buttonSalvarCliente";
            this.buttonSalvarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarCliente.TabIndex = 8;
            this.buttonSalvarCliente.Text = "Salvar";
            this.buttonSalvarCliente.UseVisualStyleBackColor = true;
            this.buttonSalvarCliente.Click += new System.EventHandler(this.buttonSalvarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // textBoxEmailCliente
            // 
            this.textBoxEmailCliente.Location = new System.Drawing.Point(48, 97);
            this.textBoxEmailCliente.Name = "textBoxEmailCliente";
            this.textBoxEmailCliente.Size = new System.Drawing.Size(194, 23);
            this.textBoxEmailCliente.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(48, 39);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(194, 23);
            this.textBoxNomeCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(48, 12);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(194, 23);
            this.textBoxIdCliente.TabIndex = 1;
            // 
            // tabPageFornecedor
            // 
            this.tabPageFornecedor.Controls.Add(this.dataGridViewFornecedor);
            this.tabPageFornecedor.Controls.Add(this.panelFornecedor);
            this.tabPageFornecedor.Location = new System.Drawing.Point(4, 24);
            this.tabPageFornecedor.Name = "tabPageFornecedor";
            this.tabPageFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFornecedor.Size = new System.Drawing.Size(768, 398);
            this.tabPageFornecedor.TabIndex = 1;
            this.tabPageFornecedor.Text = "Fornecedor";
            this.tabPageFornecedor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.AllowUserToAddRows = false;
            this.dataGridViewFornecedor.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnIdFornec,
            this.dataGridViewTextBoxColumnNomeFornec,
            this.dataGridViewTextBoxColumnCnpjFornec,
            this.dataGridViewTextBoxColumnEmailFornec});
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(6, 143);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.RowTemplate.Height = 25;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(602, 249);
            this.dataGridViewFornecedor.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumnIdFornec
            // 
            this.dataGridViewTextBoxColumnIdFornec.DataPropertyName = "idFornecedor";
            this.dataGridViewTextBoxColumnIdFornec.HeaderText = "ID";
            this.dataGridViewTextBoxColumnIdFornec.Name = "dataGridViewTextBoxColumnIdFornec";
            this.dataGridViewTextBoxColumnIdFornec.ReadOnly = true;
            this.dataGridViewTextBoxColumnIdFornec.Width = 30;
            // 
            // dataGridViewTextBoxColumnNomeFornec
            // 
            this.dataGridViewTextBoxColumnNomeFornec.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumnNomeFornec.HeaderText = "Nome";
            this.dataGridViewTextBoxColumnNomeFornec.Name = "dataGridViewTextBoxColumnNomeFornec";
            this.dataGridViewTextBoxColumnNomeFornec.ReadOnly = true;
            this.dataGridViewTextBoxColumnNomeFornec.Width = 200;
            // 
            // dataGridViewTextBoxColumnCnpjFornec
            // 
            this.dataGridViewTextBoxColumnCnpjFornec.DataPropertyName = "cnpj";
            this.dataGridViewTextBoxColumnCnpjFornec.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumnCnpjFornec.Name = "dataGridViewTextBoxColumnCnpjFornec";
            this.dataGridViewTextBoxColumnCnpjFornec.ReadOnly = true;
            this.dataGridViewTextBoxColumnCnpjFornec.Width = 70;
            // 
            // dataGridViewTextBoxColumnEmailFornec
            // 
            this.dataGridViewTextBoxColumnEmailFornec.DataPropertyName = "email";
            this.dataGridViewTextBoxColumnEmailFornec.HeaderText = "Email";
            this.dataGridViewTextBoxColumnEmailFornec.Name = "dataGridViewTextBoxColumnEmailFornec";
            this.dataGridViewTextBoxColumnEmailFornec.ReadOnly = true;
            this.dataGridViewTextBoxColumnEmailFornec.Width = 200;
            // 
            // panelFornecedor
            // 
            this.panelFornecedor.Controls.Add(this.maskedTextBoxCnpj);
            this.panelFornecedor.Controls.Add(this.buttonDeletarFornecedor);
            this.panelFornecedor.Controls.Add(this.buttonEditarFornecedor);
            this.panelFornecedor.Controls.Add(this.buttonPesquisarFornecedor);
            this.panelFornecedor.Controls.Add(this.buttonSalvarFornecedor);
            this.panelFornecedor.Controls.Add(this.label5);
            this.panelFornecedor.Controls.Add(this.textBoxEmailFornecedor);
            this.panelFornecedor.Controls.Add(this.label6);
            this.panelFornecedor.Controls.Add(this.label7);
            this.panelFornecedor.Controls.Add(this.textBoxDescFornecedor);
            this.panelFornecedor.Controls.Add(this.label8);
            this.panelFornecedor.Controls.Add(this.textBoxIDFornecedor);
            this.panelFornecedor.Location = new System.Drawing.Point(6, 6);
            this.panelFornecedor.Name = "panelFornecedor";
            this.panelFornecedor.Size = new System.Drawing.Size(402, 135);
            this.panelFornecedor.TabIndex = 4;
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(48, 67);
            this.maskedTextBoxCnpj.Mask = "00.000.000/0000-00";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(194, 23);
            this.maskedTextBoxCnpj.TabIndex = 4;
            // 
            // buttonDeletarFornecedor
            // 
            this.buttonDeletarFornecedor.Location = new System.Drawing.Point(294, 95);
            this.buttonDeletarFornecedor.Name = "buttonDeletarFornecedor";
            this.buttonDeletarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletarFornecedor.TabIndex = 11;
            this.buttonDeletarFornecedor.Text = "Deletar";
            this.buttonDeletarFornecedor.UseVisualStyleBackColor = true;
            this.buttonDeletarFornecedor.Click += new System.EventHandler(this.buttonDeletarFornecedor_Click);
            // 
            // buttonEditarFornecedor
            // 
            this.buttonEditarFornecedor.Location = new System.Drawing.Point(294, 66);
            this.buttonEditarFornecedor.Name = "buttonEditarFornecedor";
            this.buttonEditarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarFornecedor.TabIndex = 10;
            this.buttonEditarFornecedor.Text = "Editar";
            this.buttonEditarFornecedor.UseVisualStyleBackColor = true;
            this.buttonEditarFornecedor.Click += new System.EventHandler(this.buttonEditarFornecedor_Click);
            // 
            // buttonPesquisarFornecedor
            // 
            this.buttonPesquisarFornecedor.Location = new System.Drawing.Point(294, 37);
            this.buttonPesquisarFornecedor.Name = "buttonPesquisarFornecedor";
            this.buttonPesquisarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarFornecedor.TabIndex = 9;
            this.buttonPesquisarFornecedor.Text = "Pesquisar";
            this.buttonPesquisarFornecedor.UseVisualStyleBackColor = true;
            this.buttonPesquisarFornecedor.Click += new System.EventHandler(this.buttonPesquisarFornecedor_Click);
            // 
            // buttonSalvarFornecedor
            // 
            this.buttonSalvarFornecedor.Location = new System.Drawing.Point(294, 11);
            this.buttonSalvarFornecedor.Name = "buttonSalvarFornecedor";
            this.buttonSalvarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarFornecedor.TabIndex = 8;
            this.buttonSalvarFornecedor.Text = "Salvar";
            this.buttonSalvarFornecedor.UseVisualStyleBackColor = true;
            this.buttonSalvarFornecedor.Click += new System.EventHandler(this.buttonSalvarFornecedor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // textBoxEmailFornecedor
            // 
            this.textBoxEmailFornecedor.Location = new System.Drawing.Point(48, 96);
            this.textBoxEmailFornecedor.Name = "textBoxEmailFornecedor";
            this.textBoxEmailFornecedor.Size = new System.Drawing.Size(194, 23);
            this.textBoxEmailFornecedor.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "CNPJ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nome:";
            // 
            // textBoxDescFornecedor
            // 
            this.textBoxDescFornecedor.Location = new System.Drawing.Point(48, 38);
            this.textBoxDescFornecedor.Name = "textBoxDescFornecedor";
            this.textBoxDescFornecedor.Size = new System.Drawing.Size(194, 23);
            this.textBoxDescFornecedor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxIDFornecedor
            // 
            this.textBoxIDFornecedor.Location = new System.Drawing.Point(48, 11);
            this.textBoxIDFornecedor.Name = "textBoxIDFornecedor";
            this.textBoxIDFornecedor.Size = new System.Drawing.Size(194, 23);
            this.textBoxIDFornecedor.TabIndex = 1;
            // 
            // tabPageProduto
            // 
            this.tabPageProduto.Controls.Add(this.dataGridViewProduto);
            this.tabPageProduto.Controls.Add(this.panelProduto);
            this.tabPageProduto.Location = new System.Drawing.Point(4, 24);
            this.tabPageProduto.Name = "tabPageProduto";
            this.tabPageProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduto.Size = new System.Drawing.Size(768, 398);
            this.tabPageProduto.TabIndex = 2;
            this.tabPageProduto.Text = "Produto";
            this.tabPageProduto.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnIdProduto,
            this.dataGridViewTextBoxColumnDescProduto,
            this.dataGridViewTextBoxColumnValorProduto,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewProduto.Location = new System.Drawing.Point(6, 143);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowTemplate.Height = 25;
            this.dataGridViewProduto.Size = new System.Drawing.Size(600, 249);
            this.dataGridViewProduto.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumnIdProduto
            // 
            this.dataGridViewTextBoxColumnIdProduto.DataPropertyName = "idProduto";
            this.dataGridViewTextBoxColumnIdProduto.HeaderText = "ID";
            this.dataGridViewTextBoxColumnIdProduto.Name = "dataGridViewTextBoxColumnIdProduto";
            this.dataGridViewTextBoxColumnIdProduto.ReadOnly = true;
            this.dataGridViewTextBoxColumnIdProduto.Width = 30;
            // 
            // dataGridViewTextBoxColumnDescProduto
            // 
            this.dataGridViewTextBoxColumnDescProduto.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumnDescProduto.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumnDescProduto.Name = "dataGridViewTextBoxColumnDescProduto";
            this.dataGridViewTextBoxColumnDescProduto.ReadOnly = true;
            this.dataGridViewTextBoxColumnDescProduto.Width = 200;
            // 
            // dataGridViewTextBoxColumnValorProduto
            // 
            this.dataGridViewTextBoxColumnValorProduto.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumnValorProduto.HeaderText = "Valor";
            this.dataGridViewTextBoxColumnValorProduto.Name = "dataGridViewTextBoxColumnValorProduto";
            this.dataGridViewTextBoxColumnValorProduto.ReadOnly = true;
            this.dataGridViewTextBoxColumnValorProduto.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "idFornecedor";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID Fornecedor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // panelProduto
            // 
            this.panelProduto.Controls.Add(this.maskedTextBoxValorProduto);
            this.panelProduto.Controls.Add(this.buttonDeletarProduto);
            this.panelProduto.Controls.Add(this.buttonEditarProduto);
            this.panelProduto.Controls.Add(this.buttonPesquisarProduto);
            this.panelProduto.Controls.Add(this.buttonSalvarProduto);
            this.panelProduto.Controls.Add(this.label9);
            this.panelProduto.Controls.Add(this.textBoxProdutoIdFornecedor);
            this.panelProduto.Controls.Add(this.label10);
            this.panelProduto.Controls.Add(this.label11);
            this.panelProduto.Controls.Add(this.textBoxDescProduto);
            this.panelProduto.Controls.Add(this.label12);
            this.panelProduto.Controls.Add(this.textBoxIdProduto);
            this.panelProduto.Location = new System.Drawing.Point(6, 6);
            this.panelProduto.Name = "panelProduto";
            this.panelProduto.Size = new System.Drawing.Size(402, 135);
            this.panelProduto.TabIndex = 4;
            // 
            // maskedTextBoxValorProduto
            // 
            this.maskedTextBoxValorProduto.Location = new System.Drawing.Point(94, 68);
            this.maskedTextBoxValorProduto.Mask = "R$00000";
            this.maskedTextBoxValorProduto.Name = "maskedTextBoxValorProduto";
            this.maskedTextBoxValorProduto.Size = new System.Drawing.Size(203, 23);
            this.maskedTextBoxValorProduto.TabIndex = 4;
            this.maskedTextBoxValorProduto.ValidatingType = typeof(int);
            // 
            // buttonDeletarProduto
            // 
            this.buttonDeletarProduto.Location = new System.Drawing.Point(315, 96);
            this.buttonDeletarProduto.Name = "buttonDeletarProduto";
            this.buttonDeletarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletarProduto.TabIndex = 11;
            this.buttonDeletarProduto.Text = "Deletar";
            this.buttonDeletarProduto.UseVisualStyleBackColor = true;
            this.buttonDeletarProduto.Click += new System.EventHandler(this.buttonDeletarProduto_Click);
            // 
            // buttonEditarProduto
            // 
            this.buttonEditarProduto.Location = new System.Drawing.Point(315, 67);
            this.buttonEditarProduto.Name = "buttonEditarProduto";
            this.buttonEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarProduto.TabIndex = 10;
            this.buttonEditarProduto.Text = "Editar";
            this.buttonEditarProduto.UseVisualStyleBackColor = true;
            this.buttonEditarProduto.Click += new System.EventHandler(this.buttonEditarProduto_Click);
            // 
            // buttonPesquisarProduto
            // 
            this.buttonPesquisarProduto.Location = new System.Drawing.Point(315, 38);
            this.buttonPesquisarProduto.Name = "buttonPesquisarProduto";
            this.buttonPesquisarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarProduto.TabIndex = 9;
            this.buttonPesquisarProduto.Text = "Pesquisar";
            this.buttonPesquisarProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisarProduto.Click += new System.EventHandler(this.buttonPesquisarProduto_Click);
            // 
            // buttonSalvarProduto
            // 
            this.buttonSalvarProduto.Location = new System.Drawing.Point(315, 12);
            this.buttonSalvarProduto.Name = "buttonSalvarProduto";
            this.buttonSalvarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarProduto.TabIndex = 8;
            this.buttonSalvarProduto.Text = "Salvar";
            this.buttonSalvarProduto.UseVisualStyleBackColor = true;
            this.buttonSalvarProduto.Click += new System.EventHandler(this.buttonSalvarProduto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID Fornecedor:";
            // 
            // textBoxProdutoIdFornecedor
            // 
            this.textBoxProdutoIdFornecedor.Location = new System.Drawing.Point(94, 97);
            this.textBoxProdutoIdFornecedor.Name = "textBoxProdutoIdFornecedor";
            this.textBoxProdutoIdFornecedor.Size = new System.Drawing.Size(203, 23);
            this.textBoxProdutoIdFornecedor.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Valor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Descrição:";
            // 
            // textBoxDescProduto
            // 
            this.textBoxDescProduto.Location = new System.Drawing.Point(94, 39);
            this.textBoxDescProduto.Name = "textBoxDescProduto";
            this.textBoxDescProduto.Size = new System.Drawing.Size(203, 23);
            this.textBoxDescProduto.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxIdProduto
            // 
            this.textBoxIdProduto.Location = new System.Drawing.Point(94, 12);
            this.textBoxIdProduto.Name = "textBoxIdProduto";
            this.textBoxIdProduto.Size = new System.Drawing.Size(203, 23);
            this.textBoxIdProduto.TabIndex = 1;
            // 
            // tabPagePedido
            // 
            this.tabPagePedido.Controls.Add(this.dataGridViewPedido);
            this.tabPagePedido.Controls.Add(this.panelPedido);
            this.tabPagePedido.Location = new System.Drawing.Point(4, 24);
            this.tabPagePedido.Name = "tabPagePedido";
            this.tabPagePedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePedido.Size = new System.Drawing.Size(768, 398);
            this.tabPagePedido.TabIndex = 3;
            this.tabPagePedido.Text = "Pedido";
            this.tabPagePedido.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.AllowUserToAddRows = false;
            this.dataGridViewPedido.AllowUserToDeleteRows = false;
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnIdPedido,
            this.dataGridViewTextBoxColumnPedidoIdCliente,
            this.dataGridViewTextBoxColumnDataPedido});
            this.dataGridViewPedido.Location = new System.Drawing.Point(6, 143);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.ReadOnly = true;
            this.dataGridViewPedido.RowTemplate.Height = 25;
            this.dataGridViewPedido.Size = new System.Drawing.Size(645, 249);
            this.dataGridViewPedido.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumnIdPedido
            // 
            this.dataGridViewTextBoxColumnIdPedido.DataPropertyName = "idPedido";
            this.dataGridViewTextBoxColumnIdPedido.HeaderText = "ID Pedido";
            this.dataGridViewTextBoxColumnIdPedido.Name = "dataGridViewTextBoxColumnIdPedido";
            this.dataGridViewTextBoxColumnIdPedido.ReadOnly = true;
            this.dataGridViewTextBoxColumnIdPedido.Width = 90;
            // 
            // dataGridViewTextBoxColumnPedidoIdCliente
            // 
            this.dataGridViewTextBoxColumnPedidoIdCliente.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumnPedidoIdCliente.HeaderText = "ID Cliente";
            this.dataGridViewTextBoxColumnPedidoIdCliente.Name = "dataGridViewTextBoxColumnPedidoIdCliente";
            this.dataGridViewTextBoxColumnPedidoIdCliente.ReadOnly = true;
            this.dataGridViewTextBoxColumnPedidoIdCliente.Width = 200;
            // 
            // dataGridViewTextBoxColumnDataPedido
            // 
            this.dataGridViewTextBoxColumnDataPedido.DataPropertyName = "data";
            this.dataGridViewTextBoxColumnDataPedido.HeaderText = "Data Pedido";
            this.dataGridViewTextBoxColumnDataPedido.Name = "dataGridViewTextBoxColumnDataPedido";
            this.dataGridViewTextBoxColumnDataPedido.ReadOnly = true;
            this.dataGridViewTextBoxColumnDataPedido.Width = 200;
            // 
            // panelPedido
            // 
            this.panelPedido.Controls.Add(this.dateTimePicker1);
            this.panelPedido.Controls.Add(this.buttonDeletarPedido);
            this.panelPedido.Controls.Add(this.buttonEditarPedido);
            this.panelPedido.Controls.Add(this.buttonPesquisarPedido);
            this.panelPedido.Controls.Add(this.buttonSalvarPedido);
            this.panelPedido.Controls.Add(this.label13);
            this.panelPedido.Controls.Add(this.textBox7);
            this.panelPedido.Controls.Add(this.label14);
            this.panelPedido.Controls.Add(this.label15);
            this.panelPedido.Controls.Add(this.textBox8);
            this.panelPedido.Controls.Add(this.label16);
            this.panelPedido.Controls.Add(this.textBoxIdPedido);
            this.panelPedido.Location = new System.Drawing.Point(6, 6);
            this.panelPedido.Name = "panelPedido";
            this.panelPedido.Size = new System.Drawing.Size(402, 135);
            this.panelPedido.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // buttonDeletarPedido
            // 
            this.buttonDeletarPedido.Location = new System.Drawing.Point(294, 95);
            this.buttonDeletarPedido.Name = "buttonDeletarPedido";
            this.buttonDeletarPedido.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletarPedido.TabIndex = 11;
            this.buttonDeletarPedido.Text = "Deletar";
            this.buttonDeletarPedido.UseVisualStyleBackColor = true;
            // 
            // buttonEditarPedido
            // 
            this.buttonEditarPedido.Location = new System.Drawing.Point(294, 66);
            this.buttonEditarPedido.Name = "buttonEditarPedido";
            this.buttonEditarPedido.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarPedido.TabIndex = 10;
            this.buttonEditarPedido.Text = "Editar";
            this.buttonEditarPedido.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisarPedido
            // 
            this.buttonPesquisarPedido.Location = new System.Drawing.Point(294, 37);
            this.buttonPesquisarPedido.Name = "buttonPesquisarPedido";
            this.buttonPesquisarPedido.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisarPedido.TabIndex = 9;
            this.buttonPesquisarPedido.Text = "Pesquisar";
            this.buttonPesquisarPedido.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarPedido
            // 
            this.buttonSalvarPedido.Location = new System.Drawing.Point(294, 11);
            this.buttonSalvarPedido.Name = "buttonSalvarPedido";
            this.buttonSalvarPedido.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarPedido.TabIndex = 8;
            this.buttonSalvarPedido.Text = "Salvar";
            this.buttonSalvarPedido.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Data:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(84, 67);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(194, 23);
            this.textBox7.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Produto (Id):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Cliente (Id):";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(84, 38);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(194, 23);
            this.textBox8.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "ID:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxIdPedido
            // 
            this.textBoxIdPedido.Location = new System.Drawing.Point(84, 11);
            this.textBoxIdPedido.Name = "textBoxIdPedido";
            this.textBoxIdPedido.ReadOnly = true;
            this.textBoxIdPedido.Size = new System.Drawing.Size(194, 23);
            this.textBoxIdPedido.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.tabPageFornecedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.panelFornecedor.ResumeLayout(false);
            this.panelFornecedor.PerformLayout();
            this.tabPageProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.panelProduto.ResumeLayout(false);
            this.panelProduto.PerformLayout();
            this.tabPagePedido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.panelPedido.ResumeLayout(false);
            this.panelPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageCliente;
        private Panel panelCliente;
        private Label label4;
        private TextBox textBoxEmailCliente;
        private Label label3;
        private Label label2;
        private TextBox textBoxNomeCliente;
        private Label label1;
        private TextBox textBoxIdCliente;
        private TabPage tabPageFornecedor;
        private TabPage tabPageProduto;
        private TabPage tabPagePedido;
        private DataGridView dataGridViewCliente;
        private Button buttonDeletarCliente;
        private Button buttonEditarCliente;
        private Button buttonPesquisarCliente;
        private Button buttonSalvarCliente;
        private MaskedTextBox maskedTextBoxCpfCliente;
        private DataGridView dataGridViewFornecedor;
        private Panel panelFornecedor;
        private MaskedTextBox maskedTextBoxCnpj;
        private Button buttonDeletarFornecedor;
        private Button buttonEditarFornecedor;
        private Button buttonPesquisarFornecedor;
        private Button buttonSalvarFornecedor;
        private Label label5;
        private TextBox textBoxEmailFornecedor;
        private Label label6;
        private Label label7;
        private TextBox textBoxDescFornecedor;
        private Label label8;
        private TextBox textBoxIDFornecedor;
        private DataGridView dataGridViewProduto;
        private Panel panelProduto;
        private MaskedTextBox maskedTextBoxValorProduto;
        private Button buttonDeletarProduto;
        private Button buttonEditarProduto;
        private Button buttonPesquisarProduto;
        private Button buttonSalvarProduto;
        private Label label9;
        private TextBox textBoxProdutoIdFornecedor;
        private Label label10;
        private Label label11;
        private TextBox textBoxDescProduto;
        private Label label12;
        private TextBox textBoxIdProduto;
        private DataGridView dataGridViewPedido;
        private Panel panelPedido;
        private Button buttonDeletarPedido;
        private Button buttonEditarPedido;
        private Button buttonPesquisarPedido;
        private Button buttonSalvarPedido;
        private Label label13;
        private TextBox textBox7;
        private Label label14;
        private Label label15;
        private TextBox textBox8;
        private Label label16;
        private TextBox textBoxIdPedido;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnIDCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnNomeCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCpfCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmailCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnIdFornec;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnNomeFornec;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnCnpjFornec;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmailFornec;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnIdProduto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnDescProduto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnValorProduto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnIdPedido;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnPedidoIdCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumnDataPedido;
    }
}