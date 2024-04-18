using TelecomApp.Shared.Models;

namespace TelecomApp.Server.Entities
{
    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public string Number { get; set; }
        public PhoneNumberType Type { get; set; }
        public int AbonentId { get; set; }
        public Abonent? Abonent { get; set; }
    }
}
