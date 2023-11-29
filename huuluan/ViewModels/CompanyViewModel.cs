namespace huuluan.ViewModels
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}
