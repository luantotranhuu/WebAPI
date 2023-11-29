namespace huuluan.Domain.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; }

        public Company(string name) 
        {

            Name = name;
        }
    }
}
