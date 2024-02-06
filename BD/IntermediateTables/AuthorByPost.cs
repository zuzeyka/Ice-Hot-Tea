using Slush.Entity.Abstract;

namespace Slush.BD.IntermediateTables
{
    public class AuthorByPost : DBRecord
    {
        public string authorId {  get; set; }
        public string postId { get; set; }
    }
}
