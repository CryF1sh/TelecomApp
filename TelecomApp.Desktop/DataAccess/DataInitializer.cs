using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.DataAccess
{
    internal class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var abonents = new List<Abonent>();
            var random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                var abonent = new Abonent
                {
                    FirstName = "FirstName" + i,
                    LastName = "LastName" + i,
                    Patronymic = "Patronymic" + i
                };
                abonents.Add(abonent);
            }
            context.Abonents.AddRange(abonents);
            context.SaveChanges();

            var addresses = new List<Address>();
            var cities = new List<string> { "Moscow", "Kazan", "Vyatskiye Polyany" };
            var streets = new List<string> { "Street1", "Street2", "Street3", "Street4" };
            for (int i = 1; i <= 100; i++)
            {
                var address = new Address
                {
                    Apartment = random.Next(1, 100).ToString(),
                    House = random.Next(1, 500).ToString(),
                    Street = streets[random.Next(streets.Count)],
                    City = cities[random.Next(cities.Count)],
                    PostalCode = random.Next(10000, 99999).ToString(),
                    AbonentID = random.Next(1, 100)
                };
                addresses.Add(address);
            }
            context.Addresses.AddRange(addresses);
            context.SaveChanges();

            var phoneNumbers = new List<PhoneNumber>();
            var phoneTypes = Enum.GetValues(typeof(PhoneNumberType)).Cast<PhoneNumberType>().ToList();
            for (int i = 1; i <= 100; i++)
            {
                var phoneNumber = new PhoneNumber
                {
                    Number = "1234567" + random.Next(100, 999).ToString(),
                    Type = phoneTypes[random.Next(phoneTypes.Count)],
                    AbonentID = random.Next(1, 100)
                };
                phoneNumbers.Add(phoneNumber);
            }
            context.PhoneNumbers.AddRange(phoneNumbers);
            context.SaveChanges();

            var streetsList = new List<Street>();
            for (int i = 1; i <= 50; i++)
            {
                var street = new Street
                {
                    Name = "Street" + i
                };
                streetsList.Add(street);
            }
            context.Streets.AddRange(streetsList);
            context.SaveChanges();
        }
    }
}
