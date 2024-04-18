using System.Collections.Generic;
using System.Linq;
using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.DataAccess.Services
{
    public class StreetService
    {
        private readonly DataContext _context;

        public StreetService()
        {
            _context = new DataContext();
        }

        public IEnumerable<Street> GetAllStreets()
        {
            return _context.Streets.ToList();
        }

        public Street GetStreetById(int id)
        {
            return _context.Streets.Find(id);
        }

        public void AddStreet(Street street)
        {
            _context.Streets.Add(street);
            _context.SaveChanges();
        }

        public void UpdateStreet(Street street)
        {
            _context.Entry(street).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteStreet(int id)
        {
            var streetToDelete = _context.Streets.Find(id);
            if (streetToDelete != null)
            {
                _context.Streets.Remove(streetToDelete);
                _context.SaveChanges();
            }
        }
    }
}
