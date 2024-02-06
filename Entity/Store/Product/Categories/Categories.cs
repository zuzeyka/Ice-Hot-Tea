using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class Categories : DBRecord
    {
        protected String name { get; set; }
        protected String description { get; set; }

    }

}
