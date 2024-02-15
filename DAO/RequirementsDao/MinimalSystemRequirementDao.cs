using Slush.Data.Entity;
using Slush.Data;

namespace Slush.DAO.RequirementsDao
{
    public class MinimalSystemRequirementDao
    {
        private readonly DataContext _context;

        public MinimalSystemRequirementDao(DataContext context)
        {
            _context = context;
        }

        public List<MinimalSystemRequirement> GetAll()
        {
            return _context.dbMinimalSystemRequirements.ToList();
        }

        public void Add(MinimalSystemRequirement systemRequirements)
        {
            _context.dbMinimalSystemRequirements.Add(systemRequirements);
            _context.SaveChanges();
        }
    }
}
