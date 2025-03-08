using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_e_Login;

namespace Cadastro_e_Login.Modelo
{
    class Controle
    {
        public bool usuarioCriado;
        public bool usuarioExistente;
        public string mensagem = "";

        public bool Acessar(string login, string senha)
        {
            //Verifica se o usuário é existente para permitir ou não o acesso, usando a classe de Login
            Classe.Login loginComandos = new Classe.Login();
            usuarioExistente = loginComandos.verificarLogin(login, senha);

            if (!loginComandos.mensagem.Equals(""))
            {
                this.mensagem = loginComandos.mensagem;
            }

            return usuarioExistente;
        }
        
        public string CadastrarUsuario(string login, string senha, string confirmarSenha)
        {
            Classe.Cadastrar cadastrar = new Classe.Cadastrar();
            this.mensagem = cadastrar.cadastrarUsuario(login, senha, confirmarSenha);

            if (cadastrar.usuarioCriado)
            {
                this.usuarioCriado = true;
            }
            return mensagem;
        }
    }
}
