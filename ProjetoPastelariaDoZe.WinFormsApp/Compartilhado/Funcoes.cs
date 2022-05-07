using System.ComponentModel;

namespace ProjetoPastelariaDoZe.WinFormsApp.Compartilhado
{
    /// <summary>
    /// Classe Funções, onde estarão os métodos que realizam determinada tarefa dentro da aplicação.
    /// </summary>
    public class Funcoes
    {
        #region Ajustes visuais
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
        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado,
        /// adicionando nos tipos informados os eventos Enter e Leave,
        /// e vinculando  aos manipuladores
        /// </summary>
        /// <param name="container">Informa o container inicial
        /// geralmente 'this' para pegar todos os campos da tela, ou então, por exemplo, o nome do 'panel' ou 'usercontrol'</param>
        public static void EventoFocoCampos(Control container)
        {
            foreach (Control c in container.Controls)
            {
                EventoFocoCampos(c); //Recursividade
                switch (c)
                {
                    case TextBoxBase:
                    case ComboBox:
                    case RadioButton:
                    case CheckBox:
                        //case ButtonBase: Fica muito louco
                        c.Enter += new EventHandler(CampoEventoEnter!);
                        c.Leave += new EventHandler(CampoEventoLeave!);
                        break;
                }
            }
        }
        /// <summary>
        /// Altera a cor do BackColor quando campo ganha foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">O evento que foi capturado</param>
        /// <example>textBoxUsuario.Enter += new System.EventHandler(Funcoes.CampoEventoEnter);</example>
        public static void CampoEventoEnter(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt) // MaskedBox, TextBox
                txt.BackColor = Color.LightCyan;
            else if (sender is ComboBox cb)
                cb.BackColor = Color.LightCyan;
            else if (sender is RadioButton rb)
                rb.ForeColor = Color.LightCyan;
            else if (sender is ButtonBase btn)
                btn.BackColor = Color.LightCyan;
        }
        /// <summary>
        /// Altera a do do BackColor quando o campo perde foco
        /// </summary>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">O evento que foi capturado</param>
        /// <example>textBoxUsuario.Leave += new System.EventHandler(Funcoes.CampoEventoLeave);</example>
        public static void CampoEventoLeave(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt) // MaskedBox, TextBox
                txt.BackColor = Color.LightGray;
            else if (sender is ComboBox cb)
                cb.BackColor = Color.LightGray;
            else if (sender is RadioButton rb)
                rb.ForeColor = Color.LightGray;
            else if (sender is ButtonBase btn)
                btn.BackColor = Color.LightGray;
        }
        #endregion
        #region Ajustes de teclado
        /// <summary>
        /// Tratar eventos de teclado, no caso tecla ENTER funcionando como TAB e tecla ESC para fechar
        /// </summary>
        /// <remarks>KeyPreview do formulário para 'true'</remarks>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example>No construtor do formulário:
        /// this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);</example>
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            Control x = (Control)sender; // Cast | Obtém o control que mandou o evento, x.FindForm recebe o evento onde x foi gerado
            Form form = x.FindForm();
            if (e.KeyCode == Keys.Enter) // Se a tecla pressionada for 'Enter'
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            else if(e.KeyCode == Keys.Escape) // Se foi pressionado 'Esc'
            {
                form.Close(); // Feche
            }
        }
        #endregion
    }
}