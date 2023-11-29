using huuluan.Domain.Models;
using huuluan.DTO;
using huuluan.ViewModels;

namespace huuluan.Domain.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category CreateCategory(Category category);
        Category GetById(int id);
        Category DeleteById(int id);
        Category UpdateCat(int id, CategoryDTO categoryDTO);

    }
}
