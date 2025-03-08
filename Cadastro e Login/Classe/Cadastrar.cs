using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Cadastro_e_Login.Classe
{
    class Cadastrar
    {
        MySqlCommand cmd = new MySqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem = "";
        public bool usuarioCriado;

        public string cadastrarUsuario(string login, string senha, string confirmarSenha)
        {
            if (senha.Equals(confirmarSenha))
            {
                cmd.CommandText = "INSERT INTO tb_usuario (nm_login, nm_senha) VALUES (@login, @senha)";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection = conexao.conectar(); // Definir conexão antes de executar
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                    usuarioCriado = true;
                }
                catch (MySqlException ex)
                {
                    this.mensagem = "Erro com o Banco de Dados: " + ex.Message;
                    usuarioCriado = false;
                }
            }
            else
            {
                this.mensagem = "Digite a SENHA corretamente!";
                usuarioCriado = false;
            }

            return mensagem;
        }
    }
}