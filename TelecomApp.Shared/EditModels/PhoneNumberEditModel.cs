
using TelecomApp.Shared.Models;

namespace TelecomApp.Shared.EditModels
{
    public class PhoneNumberEditModel
    {
        public string Number { get; set; } = null!;
        public PhoneNumberType Type { get; set; }
    }
}