namespace TelecomApp.Shared.EditModels
{
    public class AbonentEditModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Patronymic { get; set; }
        public AddressEditModel? Address { get; set; }
        public List<PhoneNumberEditModel>? PhoneNumbers { get; set; }
    }
}