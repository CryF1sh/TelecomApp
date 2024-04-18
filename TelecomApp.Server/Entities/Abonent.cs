namespace TelecomApp.Server.Entities
{
    public class Abonent
    {
        public int AbonentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public Address? Address { get; set; }
        public List<PhoneNumber>? PhoneNumbers { get; set; }
    }
}
