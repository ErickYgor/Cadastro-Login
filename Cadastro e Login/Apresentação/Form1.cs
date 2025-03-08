using Cadastro_e_Login.Apresentação;
using Cadastro_e_Login.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_e_Login
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Redireciona ao Form de cadastro
            Cadastrar from_cadastrar = new Cadastrar();
            from_cadastrar.Show();
            this.Hide();
        }

        private void btn_form_entrar_Click(object sender, EventArgs e)
        {
            //Passa o login e senha para verificar no banco se o usuário existe
            Controle controle = new Controle();
            controle.Acessar(txt_login.Text, txt_senha.Text);

            if (controle.mensagem.Equals(""))
            {

                if (controle.usuarioExistente)
                {
                    MessageBox.Show("Login feito com SUCESSO", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tela_inicial telaInicial = new Tela_inicial();
                    telaInicial.Show();
                    this.Hide();
                
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
