using System.Configuration;
using MVCSharp.App.Controller;
using MVCSharp.App.Controller.Login;
using MVCSharp.Database;

namespace Program
{
    /// <summary>
    /// Classe principal do programa que inicializa o menu e controla o fluxo principal da aplicação.
    /// </summary>
    class Program
    {


        /// <summary>
        /// Habilita Login antes de Bootar sistema
        /// </summary>
        private static bool HAS_LOGIN = true;

        /// <summary>
        /// Método principal que executa o programa.
        /// </summary>
        /// <param name="args">Argumentos de linha de comando.</param>
        static void Main(string[] args)
        {
            Conn conexao = new Conn();
            conexao.TestConnection();

            Login login = new Login();

            if (HAS_LOGIN == true)
            {
                login.login();
            }
            else
            {
                login.login();
            }
        }
    }
}
