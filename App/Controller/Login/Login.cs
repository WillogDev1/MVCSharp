using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MVCSharp.App.Controller;
using MVCSharp.App.Controller.Login;
using System.Data;

namespace MVCSharp.App.Controller.Login
{
    internal class Login
    {
        private string user = "admin";
        private string password = "123";

        private string userInput = null;
        private string passwordInput = null;

        private static string PATH_MENU = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\App\View");
        public void login()
        {
            Console.WriteLine("Usuário");
            userInput = Console.ReadLine();

            Console.WriteLine("Senha");
            passwordInput = Console.ReadLine();

            if (userInput == user && passwordInput == password)
            {
                // Instancia o handler responsável pelo layout do menu.
                MVCSharp.Handler.Index index = new MVCSharp.Handler.Index();

                // Instancia o controlador do menu.
                Controller indexController = new Controller();

                Console.Clear();
                // Obtém a opção selecionada pelo usuário no menu.
                int OPTION = index.layout(PATH_MENU, "MENU");
               
                // Chama o método do controlador para processar a opção selecionada.
                indexController.index(OPTION);
            }
            else
            {
                Console.WriteLine("Usuário ou Senha invalido");
            }
        }
    }
}
