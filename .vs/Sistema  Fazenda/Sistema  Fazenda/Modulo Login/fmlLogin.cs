using System;
using System.Windows.Forms;
using Sistema__Fazenda.Util.BD;

namespace Sistema__Fazenda
{
    public partial class fmlLogin : Form
    {
        private readonly SqlFactory factory;

        public fmlLogin()
        {
        }

        public fmlLogin( SqlFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            try
            {                
                this.Hide();
                fmlMenuPrincipal fmlMenuPrincipal = new fmlMenuPrincipal();
                fmlMenuPrincipal.Closed += (s, args) => this.Close();
                fmlMenuPrincipal.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }

        }
    }
}
