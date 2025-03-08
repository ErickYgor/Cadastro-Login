using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Cadastro_e_Login.Classe
{
    class Login
    {
        public bool usuarioExistente = false;
        public string mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        Conexao conexao = new Conexao();
        MySqlDataReader dataLeitura;


        public bool verificarLogin(string login, string senha)
        {
            //Efetua a pesquisa do usuário no banco de dados
            cmd.CommandText = "SELECT nm_login, nm_senha FROM tb_usuario WHERE nm_login = @login AND nm_senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.conectar();
                dataLeitura = cmd.ExecuteReader();

                if (dataLeitura.HasRows)
                {
                    usuarioExistente = true;
                }
                conexao.desconectar();
                dataLeitura.Close();
            }
            catch (Exception ex)
            {
                this.mensagem = "Erro: " + ex;
            }

            return usuarioExistente;
        }
    }
}