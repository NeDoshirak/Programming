using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для загрузки контакта из файла.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Сериализатор контактов для загрузки данных.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Делегат для установки загруженного контакта.
        /// </summary>
        private Action<Contact> _setContact;

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
        /// Выполняет загрузку контакта из файла и передает его через делегат.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object parameter)
        {
            var contact = _serializer.LoadContact();
            _setContact(contact);
        }

        /// <summary>
        /// Инициализирует новый экземпляр команды для загрузки контакта.
        /// </summary>
        /// <param name="serializer">Сериализатор контактов.</param>
        /// <param name="setContact">Делегат для установки загруженного контакта.</param>
        public LoadCommand(ContactSerializer serializer, Action<Contact> setContact)
        {
            _serializer = serializer;
            _setContact = setContact;
        }
    }
}
