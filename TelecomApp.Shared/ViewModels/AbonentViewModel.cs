namespace TelecomApp.Shared.ViewModels
{
    public class AbonentViewModel
    {
        public int AbonentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }
        public AddressViewModel? Address { get; set; }
        public List<PhoneNumberViewModel>? PhoneNumbers { get; set; }
    }
}