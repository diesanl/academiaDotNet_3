using System.Data;
using System.Drawing.Text;
using WinFormsDesafio2.Objects;

namespace WinFormsDesafio2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClientesDGV();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = tabControlMain.SelectedIndex;
            TabPage selected = tabControlMain.SelectedTab;

            if (selected.Equals(tabPageCliente))
            {
                MessageBox.Show(selected.Text, "Alert");
                LoadDGVCliente();
            }
            else if (selected.Equals(tabPageFornecedor))
            {
                MessageBox.Show(selected.Text, "Alert");
                LoadDGVFornecedor();
            }
            else if (selected.Equals(tabPageProduto))
            {
                MessageBox.Show(selected.Text, "Alert");
                LoadDGVProduto();
            }
            else if (selected.Equals(tabPagePedido))
            {
                MessageBox.Show(selected.Text, "Alert");
                LoadDGVPedido();
            }
        }

        private void LoadDGVPedido()
        {
            Pedido pedido = new Pedido();
            DataTable dt = new DataTable();

            dt = pedido.LoadPedidos();

            dataGridViewPedido.DataSource = dt;
            dataGridViewPedido.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)
                DataGridViewAutoSizeColumnMode.DisplayedCells);
        }

        private void LoadDGVProduto()
        {
            Produto produto = new Produto();
            DataTable dt = new DataTable();

            dt = produto.LoadProdutos();

            dataGridViewProduto.DataSource = dt;
            dataGridViewProduto.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)
                DataGridViewAutoSizeColumnMode.DisplayedCells);
        }

        private void LoadDGVFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();
            DataTable dt = new DataTable();

            dt = fornecedor.LoadFornecedores();

            dataGridViewFornecedor.DataSource = dt;
            dataGridViewFornecedor.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)
                DataGridViewAutoSizeColumnMode.DisplayedCells);


        }

        private void LoadDGVCliente()
        {
            LoadClientesDGV();
        }
        private void LoadClientesDGV()
        {
            Cliente cliente = new Cliente();

            DataTable dt = new DataTable();
            dt = cliente.LoadClientes();

            dataGridViewCliente.DataSource = dt;

            dataGridViewCliente.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)
                DataGridViewAutoSizeColumnMode.DisplayedCells);
        }

        private void buttonSalvarCliente_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(textBoxNomeCliente.Text)) ||
            (String.IsNullOrEmpty(StringWithoutMask(maskedTextBoxCpfCliente))) ||
            (String.IsNullOrEmpty(textBoxEmailCliente.Text)))
            {
                MessageBox.Show("Todos os campos são obrigatórios!!!", "Alert");
            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Nome = textBoxNomeCliente.Text;
                cliente.Cpf = StringWithoutMask(maskedTextBoxCpfCliente);
                cliente.Email = textBoxEmailCliente.Text;
                if (cliente.addCustomer())
                {
                    MessageBox.Show("Cliente adicionado com sucesso!!!", "Alert!!!");
                    LoadClientesDGV();
                    ClearPanel(this.panelCliente);
                }
                else
                    MessageBox.Show("Cliente não foi adicionado!!!", "Alert!!!");
            }
        }


        private String StringWithoutMask(MaskedTextBox mask)
        {
            mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string notFormattedString = mask.Text;
            mask.TextMaskFormat = MaskFormat.IncludeLiterals;

            return notFormattedString;
        }

        private void dataGridViewCliente_SelectionChanged(object sender, EventArgs e)
        {
            string id = this.dataGridViewCliente.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show("" + id, "Alerta");
        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(this.dataGridViewCliente.CurrentRow.Cells[0].Value.ToString());


            if (null != cliente.Id)
            {
                if (cliente.deleteCustomer())
                {
                    MessageBox.Show("Cliente " + cliente.Id + " excluído c sucesso!!!", "Alert");
                    LoadClientesDGV();
                }
                else
                    MessageBox.Show("Cliente " + cliente.Id + " não foi excluído!!!", "Alert");
            }
            else
            {
                MessageBox.Show("Cliente de Id " + cliente.Id + " não foi encontrado!!!", "Alert");
            }

        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(this.dataGridViewCliente.CurrentRow.Cells[0].Value.ToString());
            cliente.Nome = textBoxNomeCliente.Text;
            cliente.Cpf = StringWithoutMask(maskedTextBoxCpfCliente);
            cliente.Email = textBoxEmailCliente.Text;

            if (null != cliente.Id)
            {
                if (cliente.updateCustomer())
                {
                    MessageBox.Show("Cliente de Id " + cliente.Id + " atualizado com sucesso!!!", "Alert");
                    LoadClientesDGV();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o Cliente de Id " + cliente.Id, "Alert");
                }
            }
            else
            {
                MessageBox.Show("Cliente de Id " + cliente.Id + " não foi encontrado!!!", "Alert");
            }
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
            if /*(null != cliente.Id)*/
                ((!String.IsNullOrWhiteSpace(textBoxIdCliente.Text)) && (!String.IsNullOrEmpty(textBoxIdCliente.Text)))
            {
                Cliente cliente = new Cliente();
                cliente.Id = int.Parse(textBoxIdCliente.Text);

                cliente = cliente.searchCustomer();

                if (null != cliente)
                {
                    textBoxNomeCliente.Text = cliente.Nome;
                    textBoxEmailCliente.Text = cliente.Email;
                    maskedTextBoxCpfCliente.Text = cliente.Cpf;
                }
                else
                {
                    MessageBox.Show("Informe um Id válido", "Alert");
                }
            }
            else
            {
                MessageBox.Show("Informe um Id válido", "Alert");
            }
        }

        private void buttonSalvarFornecedor_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(textBoxDescFornecedor.Text)) ||
                (String.IsNullOrEmpty(StringWithoutMask(maskedTextBoxCnpj))) ||
                (String.IsNullOrEmpty(textBoxEmailFornecedor.Text)))
            {
                MessageBox.Show("Todos os campos são obrigatórios!!!", "Alert");
            }
            else
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Descricao = textBoxDescFornecedor.Text;
                fornecedor.Cnpj = StringWithoutMask(maskedTextBoxCnpj);
                fornecedor.Email = textBoxEmailFornecedor.Text;
                if (fornecedor.addSupplier())
                {
                    MessageBox.Show("Fornecedor adicionado com sucesso!!!", "Alert!!!");
                    LoadDGVFornecedor();
                    ClearPanel(this.panelFornecedor);
                }
                else
                    MessageBox.Show("Cliente não foi adicionado!!!", "Alert!!!");
            }
        }

        private void ClearPanel(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBoxBase)
                {
                    (item as TextBoxBase).Clear();
                }
            }
        }

        private void buttonDeletarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Id = int.Parse(this.dataGridViewFornecedor.CurrentRow.Cells[0].Value.ToString());


            if (null != fornecedor.Id)
            {
                if (fornecedor.deleteSupplier())
                {
                    MessageBox.Show("Fornecedor " + fornecedor.Id + " excluído c sucesso!!!", "Alert");
                    LoadDGVFornecedor();
                }
                else
                    MessageBox.Show("Fornecedor " + fornecedor.Id + " não foi excluído!!!", "Alert");
            }
            else
            {
                MessageBox.Show("Fornecedor de Id " + fornecedor.Id + " não foi encontrado!!!", "Alert");
            }
        }

        private void buttonEditarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Id = int.Parse(this.dataGridViewFornecedor.CurrentRow.Cells[0].Value.ToString());
            fornecedor.Descricao = textBoxDescFornecedor.Text;
            fornecedor.Cnpj = StringWithoutMask(maskedTextBoxCnpj);
            fornecedor.Email = textBoxEmailFornecedor.Text;

            if ((String.IsNullOrEmpty(textBoxDescFornecedor.Text)) ||
                (String.IsNullOrEmpty(StringWithoutMask(maskedTextBoxCnpj))) ||
                (String.IsNullOrEmpty(textBoxEmailFornecedor.Text)))
            {
                MessageBox.Show("Todos os campos são obrigatórios!!!", "Alert");
            }
            else
            {
                if (null != fornecedor.Id)
                {
                    if (fornecedor.updateSupplier())
                    {
                        MessageBox.Show("Fornecedor de Id " + fornecedor.Id + " atualizado com sucesso!!!", "Alert");
                        ClearPanel(this.panelFornecedor);
                        LoadDGVFornecedor();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar o Fornecedor de Id " + fornecedor.Id, "Alert");
                    }
                }
                else
                {
                    MessageBox.Show("Fornecedor de Id " + fornecedor.Id + " não foi encontrado!!!", "Alert");
                }
            }
        }

        private void buttonPesquisarFornecedor_Click(object sender, EventArgs e)
        {

            if /*(null != cliente.Id)*/
                ((!String.IsNullOrWhiteSpace(textBoxIDFornecedor.Text)) && (!String.IsNullOrEmpty(textBoxIDFornecedor.Text)))
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Id = int.Parse(textBoxIDFornecedor.Text);
                fornecedor = fornecedor.searchSupplier();

                if (null != fornecedor)
                {
                    textBoxDescFornecedor.Text = fornecedor.Descricao;
                    textBoxEmailFornecedor.Text = fornecedor.Email;
                    maskedTextBoxCnpj.Text = fornecedor.Cnpj;
                }
                else
                {
                    MessageBox.Show("Informe um Id válido", "Alert");
                }
            }
            else
            {
                MessageBox.Show("Informe um Id válido", "Alert");
            }
        }

        private void buttonSalvarProduto_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(textBoxDescProduto.Text)) ||
                (String.IsNullOrEmpty(StringWithoutMask(maskedTextBoxValorProduto))) ||
                (String.IsNullOrEmpty(textBoxProdutoIdFornecedor.Text)))
            {
                MessageBox.Show("Todos os campos são obrigatórios!!!", "Alert");
            }
            else
            {
                Produto produto = new Produto();
                produto.Descricao = textBoxDescProduto.Text;
                string valorProduto = StringWithoutMask(maskedTextBoxValorProduto);
                produto.Valor = Convert.ToDouble(valorProduto);
                produto.Fornecedor = new Fornecedor(int.Parse(textBoxProdutoIdFornecedor.Text));
                if (produto.addProduct())
                {
                    MessageBox.Show("produto adicionado com sucesso!!!", "Alert!!!");
                    LoadDGVProduto();
                    ClearPanel(this.panelProduto);
                }
                else
                    MessageBox.Show("produto não foi adicionado!!!", "Alert!!!");
            }
        }

        private void buttonPesquisarProduto_Click(object sender, EventArgs e)
        {
            if
                ((!String.IsNullOrWhiteSpace(textBoxIdProduto.Text)) &&
                (!String.IsNullOrEmpty(textBoxIdProduto.Text)))
            {
                Produto produto = new Produto();
                produto.Id = int.Parse(textBoxIdProduto.Text);
                produto = produto.searchProduct();

                if (null != produto)
                {
                    textBoxDescProduto.Text = produto.Descricao;
                    maskedTextBoxValorProduto.Text = produto.Valor.ToString();
                    textBoxProdutoIdFornecedor.Text = produto.Fornecedor.Id.ToString();
                }
                else
                {
                    MessageBox.Show("Informe um Id válido", "Alert");
                    ClearPanel(this.panelProduto);
                }
            }
            else
            {
                MessageBox.Show("Informe um Id válido", "Alert");
                ClearPanel(this.panelProduto);
            }

        }

        private void buttonEditarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = int.Parse(this.dataGridViewProduto.CurrentRow.Cells[0].Value.ToString());
            produto = produto.searchProduct();

            if (null != produto)
            {
                //this.panelProduto = fillProdutoPanel(produto, this.panelProduto);

                produto.Descricao = textBoxDescProduto.Text;
                produto.Valor = Convert.ToDouble(StringWithoutMask(maskedTextBoxValorProduto));
                produto.Fornecedor = new Fornecedor(int.Parse(textBoxProdutoIdFornecedor.Text));

                if (produto.updateProduct())
                {
                    MessageBox.Show("Produto de Id " + produto.Id + " atualizado com sucesso!!!", "Alert");
                    LoadDGVProduto();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o Produto de Id " + produto.Id, "Alert");
                }
            }
            else
            {
                MessageBox.Show("Produto de Id " + produto.Id + " não foi encontrado!!!", "Alert");
            }

        }

        private Panel fillProdutoPanel(Produto produto, Panel panel)
        {
            panel.Controls.Add(textBoxIdProduto); /*.Text = produto.Id.ToString()*/
            textBoxIdProduto.Text = produto.Id.ToString();
            textBoxDescProduto.Text = produto.Descricao;
            maskedTextBoxValorProduto.Text = produto.Valor.ToString();
            textBoxProdutoIdFornecedor.Text = produto.Fornecedor.Id.ToString();

            return null;
        }

        private void buttonDeletarProduto_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto();
            produto.Id = int.Parse(this.dataGridViewProduto.CurrentRow.Cells[0].Value.ToString());


            if (null != produto.Id)
            {

                if (MessageBox.Show("Deseja excluir o Produto de ID "
                                    + produto.Id + "?", "Question",
                                    MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    if (produto.deleteProduct())
                    {
                        MessageBox.Show("Produto " + produto.Id + " excluído c sucesso!!!", "Alert");
                        LoadDGVProduto();
                    }
                    else
                        MessageBox.Show("Produto " + produto.Id + " não foi excluído!!!", "Alert");

                }
            }
            else
            {
                MessageBox.Show("Produto de Id " + produto.Id + " não foi encontrado!!!", "Alert");
            }

        }
    }
}
