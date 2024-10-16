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

<<<<<<< HEAD
        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            FmlMenuPrincipal menu = new FmlMenuPrincipal();
            menu.Show();
            this.Hide();
=======
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

>>>>>>> 58c16cd1c2739be13cfec2f49da23ab5924550f4
        }
    }
}
