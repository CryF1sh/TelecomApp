namespace TelecomApp.Desktop.Models
{
    public class PhoneNumber
    {
        public int PhoneNumberID { get; set; }
        public string Number { get; set; }
        public PhoneNumberType Type { get; set; }
        public int AbonentID { get; set; }
    }
}
