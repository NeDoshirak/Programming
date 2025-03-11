using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для сохранения контакта в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Сериализатор контактов для сохранения данных.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Контакт, который необходимо сохранить.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Событие, которое возникает при изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>Всегда возвращает <c>true</c>, так как команда может выполняться в любой момент.</returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Выполняет сохранение контакта в файл.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object parameter)
        {
            _serializer.SaveContact(_contact);
        }

        /// <summary>
        /// Инициализирует новый экземпляр команды для сохранения контакта.
        /// </summary>
        /// <param name="serializer">Сериализатор контактов.</param>
        /// <param name="contact">Контакт, который необходимо сохранить.</param>
        public SaveCommand(ContactSerializer serializer, Contact contact)
        {
            _serializer = serializer;
            _contact = contact;
        }
    }
}
