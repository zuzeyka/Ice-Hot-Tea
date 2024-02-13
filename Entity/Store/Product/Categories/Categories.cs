using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class Categories : DBRecord
    {
        public String name { get; set; }
        public String description { get; set; }

        public Categories() { }
    }

}
    