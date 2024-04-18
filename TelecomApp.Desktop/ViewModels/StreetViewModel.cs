using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.ViewModels
{
    public class StreetViewModel
    {
        private readonly Street _street;

        public StreetViewModel(Street street)
        {
            _street = street;
        }

        public int StreetID => _street.StreetID;
        public string Name => _street.Name;
    }
}
