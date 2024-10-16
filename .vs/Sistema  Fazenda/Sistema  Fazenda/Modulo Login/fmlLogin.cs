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
    public partial class fmlLogin : Form
    {
        public fmlLogin()
        {
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            FmlMenuPrincipal menu = new FmlMenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
