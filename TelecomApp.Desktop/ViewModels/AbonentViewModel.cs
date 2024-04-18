using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.ViewModels
{
    public class AbonentViewModel
    {
        private readonly Abonent _abonent;

        public AbonentViewModel(Abonent abonent)
        {
            _abonent = abonent;
        }

        public int AbonentID => _abonent.AbonentID;
        public string FirstName => _abonent.FirstName;
        public string LastName => _abonent.LastName;
        public string Patronymic => _abonent.Patronymic;
    }
}
