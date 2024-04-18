using System.ComponentModel.DataAnnotations;

namespace TelecomApp.Desktop.Models
{
    public enum PhoneNumberType
    {
        [Display(Name = "Мобильный")] Mobile,
        [Display(Name = "Рабочий")] Work,
        [Display(Name = "Домашний")] Home
    }
}
