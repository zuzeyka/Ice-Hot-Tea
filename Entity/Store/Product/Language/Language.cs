using Slush.Entity.Abstract;

namespace Slush.Data.Entity
{
    public class Language : DBRecord
    {
        public String name { get; set; }

        public Language(String id,
                        String name,
                        DateTime createdAt)
        {
            this.id = id;
            this.name = name;
            this.createdAt = createdAt;
        }
    }
}
