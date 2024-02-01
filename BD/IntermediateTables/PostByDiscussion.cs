using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.BD.IntermediateTables
{
    public class PostByDiscussion : BDRecord
    {
        public string postId { get; set; }
        public string discussionId { get; set; }
    }
}
