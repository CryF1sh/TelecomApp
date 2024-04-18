using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomApp.Shared.Models
{
    public enum PhoneNumberType
    {
        [Display(Name = "Мобильный")] Mobile,
        [Display(Name = "Рабочий")] Work,
        [Display(Name = "Домашний")] Home
    }
}
