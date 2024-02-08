using Slush.Entity.Abstract;

namespace Slush.BD.IntermediateTables
{
    public class PostByDiscussion : DBRecord
    {
        public string postId { get; set; }
        public string discussionId { get; set; }
    }
}
