using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_e_Login.Apresentação
{
    public partial class Tela_inicial: Form
    {
        public Tela_inicial()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Login form_login = new Login();
            form_login.Show();
            this.Hide();
        }
    }
}
