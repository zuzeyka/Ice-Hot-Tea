using Slush.Data.Entity;
using Slush.Data;

namespace Slush.DAO.RequirementsDao
{
    public class MaximumSystemRequirementDao
    {
        private readonly DataContext _context;

        public MaximumSystemRequirementDao(DataContext context)
        {
            _context = context;
        }

        public List<MaximumSystemRequirement> GetAll()
        {
            return _context.dbMaximumSystemRequirements.ToList();
        }

        public void Add(MaximumSystemRequirement systemRequirements)
        {
            _context.dbMaximumSystemRequirements.Add(systemRequirements);
            _context.SaveChanges();
        }
    }
}
