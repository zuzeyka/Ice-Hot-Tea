using Ice_Hot_Tea.Entity.Abstract;

namespace Ice_Hot_Tea.BD.IntermediateTables
{
    public class AuthorByPost : DBRecord
    {
        public string authorId {  get; set; }
        public string postId { get; set; }
    }
}
