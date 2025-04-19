using MVCSharp.App.Controller;
using MVCSharp.App.Controller.Login;

namespace Program
{
    /// <summary>
    /// Classe principal do programa que inicializa o menu e controla o fluxo principal da aplicação.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Caminho para o diretório onde as views do menu estão localizadas.
        /// </summary>
        private static string PATH_MENU = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\App\View");

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

            Login login = new Login();

            if (HAS_LOGIN == true)
            {
                login.login();
            }
            else
            {
                // Instancia o handler responsável pelo layout do menu.
                MVCSharp.Handler.Index index = new MVCSharp.Handler.Index();

                // Instancia o controlador do menu.
                Controller indexController = new Controller();

                // Obtém a opção selecionada pelo usuário no menu.
                int OPTION = index.layout(PATH_MENU, "MENU");

                // Chama o método do controlador para processar a opção selecionada.
                indexController.index(OPTION);
            }
        }
    }
}
