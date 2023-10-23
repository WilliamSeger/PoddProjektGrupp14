namespace Models
{
    public class Category
    {
        private string name;

        public Category(string name)
        {
            this.name = name;
        }

        public Category()
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}