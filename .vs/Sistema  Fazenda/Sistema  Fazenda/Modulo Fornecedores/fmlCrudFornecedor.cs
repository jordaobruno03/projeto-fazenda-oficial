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
 
        Conexao conect = new Conexao();
        string sql;
        SqlCommand cmd;
        public Crud_Fornecedor()
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
