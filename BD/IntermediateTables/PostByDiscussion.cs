using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.BD.IntermediateTables
{
    public class PostByDiscussion : DBRecord
    {
        public string postId { get; set; }
        public string discussionId { get; set; }
    }
}
