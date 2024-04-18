using System.Collections.Generic;
using System.Linq;
using TelecomApp.Desktop.Models;

namespace TelecomApp.Desktop.DataAccess
{
    public class AbonentService
    {
        private readonly DataContext _context;

        public AbonentService()
        {
            _context = new DataContext();
        }

        public IEnumerable<Abonent> GetAllAbonents()
        {
            return _context.Abonents.ToList();
        }

        public Abonent GetAbonentById(int id)
        {
            return _context.Abonents.Find(id);
        }

        public void AddAbonent(Abonent abonent)
        {
            _context.Abonents.Add(abonent);
            _context.SaveChanges();
        }

        public void UpdateAbonent(Abonent abonent)
        {
            _context.Entry(abonent).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteAbonent(int id)
        {
            var abonentToDelete = _context.Abonents.Find(id);
            if (abonentToDelete != null)
            {
                _context.Abonents.Remove(abonentToDelete);
                _context.SaveChanges();
            }
        }
    }
}
