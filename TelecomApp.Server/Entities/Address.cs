namespace TelecomApp.Server.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Apartment { get; set; }
        public string House { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public Abonent? Abonent { get; set; }
    }
}
