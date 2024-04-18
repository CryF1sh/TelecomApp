using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.ViewModels
{
    public class PhoneNumberViewModel
    {
        private readonly PhoneNumber _phoneNumber;

        public PhoneNumberViewModel(PhoneNumber phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public int PhoneNumberID => _phoneNumber.PhoneNumberID;
        public string Number => _phoneNumber.Number;
        public PhoneNumberType Type => _phoneNumber.Type;
        public int AbonentID => _phoneNumber.AbonentID;
    }
}
