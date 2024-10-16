using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema__Fazenda
{
    internal class Conexao
    {
        public string conec = "Data Source=BRUNO;Initial Catalog=fazenda;Integrated Security=True;Encrypt=False";
        public SqlConnection conect = null;
        public void AbrirConexao()
        {
            conect = new SqlConnection(conec);
            conect.Open();
        }    
        public void FecharConexao()
        {
            conect = new SqlConnection(conec);
            conect.Close();
            conect.Dispose();
            
        }
    }
}
