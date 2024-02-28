using Slush.Data.Entity.Profile;
using Slush.Data;

namespace Slush.DAO.ProfileDao
{
    public class VideoDao
    {
        private readonly DataContext _context;

        public VideoDao(DataContext context)
        {
            _context = context;
        }

        public virtual List<Video> GetAll()
        {
            return _context.dbVideos.ToList();
        }

        public void Add(Video video)
        {
            _context.dbVideos.Add(video);
            _context.SaveChanges();
        }
    }
}
