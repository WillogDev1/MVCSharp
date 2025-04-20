using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSharp.Handler
{
    /// <summary>
    /// Classe responsável por gerenciar o layout do menu e interagir com o usuário.
    /// </summary>
    internal class Index
    {
        /// <summary>
        /// Indica se o menu está em execução.
        /// </summary>
        private static bool RUN = true;

        /// <summary>
        /// Índice atual do menu.
        /// </summary>
        private static int CURRENT_INDEX = 0;

        /// <summary>
        /// Limite superior do menu (primeira opção).
        /// </summary>
        private static int TOP_LIMIT = 0;

        /// <summary>
        /// Limite inferior do menu (última opção).
        /// </summary>
        private static int BOTTOM_LIMIT;

        /// <summary>
        /// Exibe o layout do menu e captura a opção selecionada pelo usuário.
        /// </summary>
        /// <param name="FILE_PATH">Caminho para o arquivo contendo as opções do menu.</param>
        /// <param name="HEADER">Cabeçalho do menu a ser exibido.</param>
        /// <returns>Retorna a opção selecionada pelo usuário.</returns>
        /// 

        /// <summary>
        /// Footer da Aplicação
        /// </summary>
        string footer = ConfigurationManager.AppSettings["MenuFooter"] ?? "Autor - Desconhecido";

        public int layout(string FILE_PATH, string HEADER)
        {
            // aqui a gente monta o caminho final do arquivo, usando o HEADER como nome
            string fullFilePath = Path.Combine(FILE_PATH, HEADER + ".txt");

            // Carrega as opções do menu a partir do arquivo.
            List<string> MENU_OPTIONS = LoadMenuFromFile(fullFilePath);

            // Define o limite inferior com base na quantidade de opções.
            BOTTOM_LIMIT = MENU_OPTIONS.Count - 1;

            // Exibe o cabeçalho do menu.
            Console.WriteLine("*****************************");
            Console.WriteLine($"*       {HEADER}           *");
            Console.WriteLine("*****************************");

            // Exibe as opções do menu.
            for (int i = 0; i < MENU_OPTIONS.Count; i++)
            {
                Console.WriteLine($"  {MENU_OPTIONS[i],-24} *");
            }

            // Exibe o rodapé do menu.
            Console.WriteLine("*****************************");
            Console.WriteLine($"*     {footer,-21}*");
            Console.WriteLine("*****************************");

            // Navega pelo menu e retorna a opção selecionada.
            int USER_OPTION = NavegateMenu(RUN, CURRENT_INDEX, TOP_LIMIT, BOTTOM_LIMIT, MENU_OPTIONS);
            return USER_OPTION;
        }

        /// <summary>
        /// Carrega as opções do menu a partir de um arquivo.
        /// </summary>
        /// <param name="filePath">Caminho completo para o arquivo do menu.</param>
        /// <returns>Retorna uma lista de strings contendo as opções do menu.</returns>
        public List<string> LoadMenuFromFile(string filePath)
        {
            var menuOptions = new List<string>();

            try
            {
                // Lê todas as linhas do arquivo e adiciona à lista.
                menuOptions.AddRange(File.ReadAllLines(filePath));
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra algum problema ao ler o arquivo.
                Console.WriteLine("Error reading menu file: " + ex.Message);
            }

            return menuOptions;
        }

        /// <summary>
        /// Navega pelo menu com base nas teclas pressionadas pelo usuário.
        /// </summary>
        /// <param name="RUN">Indica se o menu está em execução.</param>
        /// <param name="currentIndex">Índice atual do menu.</param>
        /// <param name="TOP_LIMIT">Limite superior do menu.</param>
        /// <param name="BOTTOM_LIMIT">Limite inferior do menu.</param>
        /// <param name="menuOptions">Lista de opções do menu.</param>
        /// <returns>Retorna a opção selecionada pelo usuário.</returns>
        public int NavegateMenu(bool RUN, int currentIndex, int TOP_LIMIT, int BOTTOM_LIMIT, List<string> menuOptions)
        {
            while (RUN)
            {
                // Posiciona o cursor na opção atual.
                Console.SetCursorPosition(0, currentIndex + 3);
                Console.Write("->");

                // Captura a tecla pressionada pelo usuário.
                var key = Console.ReadKey(true);

                // Remove o cursor da posição anterior.
                Console.SetCursorPosition(0, currentIndex + 3);
                Console.Write(new string(' ', 2));

                if (key.Key == ConsoleKey.Escape)
                {
                    // Sai do menu se a tecla ESC for pressionada.
                    RUN = false;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    // Move para cima se a tecla de seta para cima for pressionada.
                    if (currentIndex > TOP_LIMIT)
                    {
                        currentIndex--;
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    // Move para baixo se a tecla de seta para baixo for pressionada.
                    if (currentIndex < BOTTOM_LIMIT)
                    {
                        currentIndex++;
                    }
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    // Retorna a opção selecionada se a tecla ENTER for pressionada.
                    return returnUserOption(menuOptions[currentIndex]);
                }
            }

            // Retorna 0 caso o menu seja encerrado.
            return 0;
            Console.WriteLine("\nPrograma encerrado. Até logo!");
        }

        /// <summary>
        /// Retorna a opção selecionada pelo usuário.
        /// </summary>
        /// <param name="selectedOption">Opção selecionada pelo usuário.</param>
        /// <returns>Retorna o número correspondente à opção selecionada.</returns>
        public int returnUserOption(string selectedOption)
        {
            int returnOpt;

            // Converte a opção selecionada para um número.
            returnOpt = convertUserOption(selectedOption);

            return returnOpt;
        }

        /// <summary>
        /// Converte a opção selecionada pelo usuário em um número inteiro.
        /// </summary>
        /// <param name="selectedOptionToConvert">Opção selecionada em formato de string.</param>
        /// <returns>Retorna o número correspondente à opção selecionada.</returns>
        public int convertUserOption(string selectedOptionToConvert)
        {
            // Extrai o número da string da opção selecionada.
            string numberString = selectedOptionToConvert.Split('-')[0].Trim();

            int selectedNumber;

            // Tenta converter o número extraído para um inteiro.
            int.TryParse(numberString, out selectedNumber);

            return selectedNumber;
        }
    }
}
