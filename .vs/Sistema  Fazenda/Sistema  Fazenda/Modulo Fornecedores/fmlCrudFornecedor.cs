using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema__Fazenda
{
    public partial class Crud_Fornecedor : Form
    {
<<<<<<< HEAD
 
        Conexao conect = new Conexao();
        string sql;
        SqlCommand cmd;
        public Crud_Fornecedor()
=======
        public Crud_Fornecedor(Util.BD.SqlFactory factory)
>>>>>>> 58c16cd1c2739be13cfec2f49da23ab5924550f4
        {
            InitializeComponent();
        }

        private void IncluirFornecedor_Click(object sender, EventArgs e)
        {
            conect.AbrirConexao();
            sql = "INSERT INTO Fornecedor1 (NomeCliente, Cnpj, Produto) VALUES (@NomeCliente, @Cnpj, @Produto)";
            cmd = new SqlCommand(sql, conect.conect);
            cmd.Parameters.AddWithValue("@NomeCliente", txtNomeFornecedor.Text);
            cmd.Parameters.AddWithValue("@Cnpj", txtCNPJFornecedor.Text);
            cmd.Parameters.AddWithValue("@Produto", txtProdutoFornecedor.Text);

            cmd.ExecuteNonQuery();
            conect.FecharConexao();

            txtNomeFornecedor.Clear();
            txtCNPJFornecedor.Clear();
            txtProdutoFornecedor.Clear();

        }
    }
}
