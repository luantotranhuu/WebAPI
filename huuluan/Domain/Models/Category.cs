namespace huuluan.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public Category( string name, int companyId) 
        {
            CompanyId = companyId;
        
            Name = name;    
        }
    }
}
