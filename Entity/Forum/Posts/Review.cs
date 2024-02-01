using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.Entity.Forum.Posts
{
    public class Review : Post
    {
        public bool isPositive { get; set; }
        public string authorId { get; set; }
        public string description { get; set; }
        public int counterOfPositiveMarks { get; set; }
        public int counterOfNegativeMarks { get; set; }
    }
}
