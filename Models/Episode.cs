
namespace Models
{
    public class Episode
    {
        private string name;
        private string description;
        public string Name {  
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Episode(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public Episode() { }
    }
}
