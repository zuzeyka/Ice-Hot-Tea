using Slush.Entity.Abstract;

namespace Slush.BD.IntermediateTables
{
    public class PostByAythor : DBRecord
    {
        public string postId { get; set; }
        public string authorId { get; set; }
    }
}
