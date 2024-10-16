using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema__Fazenda
{
    public partial class FmlMenuPrincipal : Form
    {
        public FmlMenuPrincipal()
        {
            InitializeComponent();
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
