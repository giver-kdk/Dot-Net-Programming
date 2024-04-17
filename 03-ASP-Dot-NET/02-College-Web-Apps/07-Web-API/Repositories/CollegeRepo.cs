using _07_Web_API.Models;

namespace _07_Web_API.Repositories
{
    public class CollegeRepo : IRepository<College>
    {
        // Dependency Injection 
        CollegeDbContext _context = null;
        public CollegeRepo(CollegeDbContext context)
        {
            _context = context;
        }
        // Interface Implementation
        public void AddRecord(College model)
        {
            // Add the College from the context. Here, still DB is not updated
            _context.Add(model);
            // Use 'SaveChanges()' method if any data modifications are done
            _context.SaveChanges();
        }

        public void DeleteRecord(College model)
        {
            _context.Remove(model);
            _context.SaveChanges();
        }

        public List<College> GetAllRecords()
        {
            List<College> allColleges = _context.Colleges.ToList();
            return allColleges;

        }

        public College GetSingleRecord(int id)
        {
            // Similar tp using 'WHERE' clause in SQL to find based on 'id'
            College p = _context.Colleges.Find(id);
            return p;
        }

        public College UpdateRecord(College model)
        {
            _context.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
