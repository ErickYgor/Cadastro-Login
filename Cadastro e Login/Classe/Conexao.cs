using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cadastro_e_Login.Classe
{
    public class Conexao
    {
        private const string servidor = "localhost";
        private const string bancoDados = "db_cadastrologin";
        private const string usuario = "root";
        private const string senha = "";

        static string conexaoBanco = $"server={servidor};user id = {usuario};database = {bancoDados};password = {senha};Allow Zero Datetime=true";
        public MySqlConnection conexao;

        public Conexao()
        {
            conexao = new MySqlConnection(conexaoBanco);
        }

        public MySqlConnection conectar()
        {
            if(conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;

        }

        public void desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
