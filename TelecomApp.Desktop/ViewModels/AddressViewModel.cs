using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.ViewModels
{
    public class AddressViewModel
    {
        private readonly Address _address;

        public AddressViewModel(Address address)
        {
            _address = address;
        }

        public int AddressID => _address.AddressID;
        public string Apartment => _address.Apartment;
        public string House => _address.House;
        public string Street => _address.Street;
        public string City => _address.City;
        public string PostalCode => _address.PostalCode;
        public int AbonentID => _address.AbonentID;

    }
}
