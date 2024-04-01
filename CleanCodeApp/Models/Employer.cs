namespace CleanCodeApp.Models
{
    public class Employer : Entity
    {
        public string Name { get; set; }
        public Employer() { }
        public Employer(string name)
        {
            Name = name;
        }
    }
}
