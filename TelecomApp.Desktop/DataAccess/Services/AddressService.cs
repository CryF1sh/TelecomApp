using System.Collections.Generic;
using System.Linq;
using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.DataAccess.Services
{
    public class AddressService
    {
        private readonly DataContext _context;

        public AddressService()
        {
            _context = new DataContext();
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            return _context.Addresses.ToList();
        }

        public Address GetAddressById(int id)
        {
            return _context.Addresses.Find(id);
        }

        public void AddAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public void UpdateAddress(Address address)
        {
            _context.Entry(address).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteAddress(int id)
        {
            var addressToDelete = _context.Addresses.Find(id);
            if (addressToDelete != null)
            {
                _context.Addresses.Remove(addressToDelete);
                _context.SaveChanges();
            }
        }
    }

}
