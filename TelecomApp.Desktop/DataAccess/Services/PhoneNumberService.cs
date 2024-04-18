using System.Collections.Generic;
using System.Linq;
using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.DataAccess.Services
{
    public class PhoneNumberService
    {
        private readonly DataContext _context;

        public PhoneNumberService()
        {
            _context = new DataContext();
        }

        public IEnumerable<PhoneNumber> GetAllPhoneNumbers()
        {
            return _context.PhoneNumbers.ToList();
        }

        public PhoneNumber GetPhoneNumberById(int id)
        {
            return _context.PhoneNumbers.Find(id);
        }

        public void AddPhoneNumber(PhoneNumber phoneNumber)
        {
            _context.PhoneNumbers.Add(phoneNumber);
            _context.SaveChanges();
        }

        public void UpdatePhoneNumber(PhoneNumber phoneNumber)
        {
            _context.Entry(phoneNumber).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeletePhoneNumber(int id)
        {
            var phoneNumberToDelete = _context.PhoneNumbers.Find(id);
            if (phoneNumberToDelete != null)
            {
                _context.PhoneNumbers.Remove(phoneNumberToDelete);
                _context.SaveChanges();
            }
        }
    }
}
