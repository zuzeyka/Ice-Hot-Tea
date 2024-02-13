namespace Slush.Entity.Abstract
{
    public abstract class Profile : Author
    {
        public String name { get; set; }
        public String description { get; set; }
        public String avatar { get; set; }
        public String backgroundImage { get; set; }
        public List<object> showcases { get; set; } // изменить тип данных который будет отвечать за показ контента в витрине
    }
}
