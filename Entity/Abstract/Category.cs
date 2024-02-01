namespace Ice_Hot_Tea.Entity.Abstract
{
    public abstract class Category : BDRecord
    {
        public string name { get; set; }
        public string attachedItemId { get; set; }
    }
}
