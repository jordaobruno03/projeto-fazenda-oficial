using System;
using System.Windows.Forms;
using Sistema__Fazenda.Util.BD;



namespace Sistema__Fazenda
<<<<<<< HEAD
{
    public partial class FmlMenuPrincipal : Form
    {
        public FmlMenuPrincipal()
=======
{    
    public partial class fmlMenuPrincipal : Form
    {
        private readonly SqlFactory factory;
        public fmlMenuPrincipal(SqlFactory factory)
>>>>>>> 58c16cd1c2739be13cfec2f49da23ab5924550f4
        {
            InitializeComponent();
            this.factory = factory;
        }

        public fmlMenuPrincipal()
        {
        }

        private void lblMenuPrincipalTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutosMenu_Click(object sender, EventArgs e)
        {
            try
            {
                fmlMenuPrincipal fmlMenuPrincipal = new fmlMenuPrincipal();
                this.Hide();
                Crud_Produtos crud_Produtos = new Crud_Produtos(factory);
                Closed += (s, args) => this.Close();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void btnFornecedoresMenu_Click(object sender, EventArgs e)
        {
            try
            {
                fmlMenuPrincipal fmlMenuPrincipal = new fmlMenuPrincipal();
                this.Hide();
                Crud_Fornecedor crud_Fornecedor = new Crud_Fornecedor(factory);
                Closed += (s, args) => this.Close();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnPedidosMenu_Click(object sender, EventArgs e)
        {
            try
            {
                fmlMenuPrincipal fmlMenuPrincipal = new fmlMenuPrincipal();
                this.Hide();
                fmlPedidos fmlPedidos = new fmlPedidos(factory);
                Closed += (s, args) => this.Close();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnClientesMenu_Click(object sender, EventArgs e)
        {
            try
            {
                fmlMenuPrincipal fmlMenuPrincipal = new fmlMenuPrincipal();
                this.Hide();
                Crud_Clientes crud_Clientes = new Crud_Clientes(factory);
                Closed += (s, args) => this.Close();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProdutosMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFornecedoresMenu_Click(object sender, EventArgs e)
        {
            Crud_Fornecedor fornecedor = new Crud_Fornecedor();
            fornecedor.Show();
            this.Hide();
        }
    }
}
