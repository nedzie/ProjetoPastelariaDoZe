using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPastelariaDoZe.WinFormsApp.Compartilhado
{
    /// <summary>
    /// Classe Funções, onde estarão os métodos que realizam determinada tarefa dentro da aplicação.
    /// </summary>
    public class Funcoes
    {
        /// <summary>
        /// Ajusta automaticamente os textos/placeholders dos itens dos formulários
        /// </summary>
        /// <param name="container">Define qual a classe base</param>
        public static void AjustaResourcesForm(Control container)
        {
            foreach (Control c in container.Controls)
            {
                AjustaResourcesForm(c);
                ComponentResourceManager resources = new(typeof(Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }
    }
}