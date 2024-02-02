using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.BD.IntermediateTables
{
    public class PostByAythor : DBRecord
    {
        public string postId { get; set; }
        public string authorId { get; set; }
    }
}
