📌 Projeto de Cadastro e Login

Aplicação desenvolvida em C# (Windows Forms) com integração ao MySQL para gerenciamento de usuários.
O sistema permite realizar cadastro, login e validação de credenciais diretamente no banco de dados, garantindo uma experiência funcional e segura.

💡 Projeto desenvolvido para estudos e implementação de autenticação básica em aplicações desktop.

⚙️ Configuração do Banco de Dados

Para que o projeto funcione corretamente, é necessário configurar a conexão com o banco de dados MySQL.

No arquivo Conexao.cs, você pode alterar os dados conforme o seu ambiente local:

private const string servidor = "localhost";
private const string bancoDados = "db_cadastrologin";
private const string usuario = "root";
private const string senha = "";


🔧 Observação: Esses dados podem (e devem) ser alterados conforme a configuração do seu MySQL local.
📁 O banco de dados original está anexado ao projeto para importação.
