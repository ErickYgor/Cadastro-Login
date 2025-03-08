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
    public partial class Cadastrar: Form
    {

        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btn_entrar_cadastrar_Click(object sender, EventArgs e)
        {
            Login form_login = new Login();
            form_login.Show();
            this.Hide();
        }

        private void btn_form_cadastrar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            string mensagem;
            mensagem = controle.CadastrarUsuario(txt_login_cadastrar.Text, txt_senha_cadastrar.Text, txt_confirmar_senha_cadastrar.Text);

            if (controle.usuarioCriado)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login form_login = new Login();
                form_login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
