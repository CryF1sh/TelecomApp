
using TelecomApp.Shared.Models;

namespace TelecomApp.Shared.ViewModels
{
    public class PhoneNumberViewModel
    {
        public int PhoneNumberId { get; set; }
        public string Number { get; set; }
        public PhoneNumberType Type { get; set; }
    }
}