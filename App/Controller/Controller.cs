using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSharp.App.Controller
{
    /// <summary>
    /// Controlador responsável por gerenciar as ações relacionadas ao menu.
    /// </summary>
    internal class Controller
    {
        /// <summary>
        /// Método principal do controlador que processa a opção selecionada pelo usuário no menu.
        /// </summary>
        /// <param name="OPTION">Opção selecionada pelo usuário.</param>
        public void index(int OPTION)
        {
            // Processa a opção selecionada pelo usuário.
            switch (OPTION)
            {
                case 1:
                    // Ação para a opção 1.
                    break;

                case 2:
                    // Ação para a opção 2.
                    break;

                case 3:
                    // Ação para a opção 3.
                    break;

                case 4:
                    // Ação para a opção 4.
                    break;

                case 5:
                    // Ação para a opção 5.
                    break;

                default:
                    // Ação padrão caso a opção não seja reconhecida.
                    break;
            }
        }
    }
}
