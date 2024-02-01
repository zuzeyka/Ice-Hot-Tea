using Ice_Hot_Tea.Entity.Abstract;
using Ice_Hot_Tea.Entity.Store.Product.Language;

namespace Ice_Hot_Tea.Entity.Forum.Posts
{
    public class Guide : Post
    {
        public List<string> images { get; set; }
        public string content { get; set; }
        public List<byte> starRating { get; set; }
        public Language language { get; set; }
        public DateTime? editedAt { get; set; }
    }
}
