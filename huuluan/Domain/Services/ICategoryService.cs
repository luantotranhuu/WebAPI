using huuluan.Domain.Models;
using huuluan.DTO;
using huuluan.ViewModels;

namespace huuluan.Domain.Services
{
    public interface ICategoryService
    {
        List<CategoryViewModel> GetAll();
        bool PostCategory(CategoryDTO categoryDTO);
        Category GetById(int id);
        Category DeleteById(int id);
        Category UpdateCat(int id, CategoryDTO categoryDTO);
    }
}
