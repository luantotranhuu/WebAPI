using AutoMapper;
using huuluan.Domain.Models;
using huuluan.Domain.Persistence.Repositories;
using huuluan.Domain.Repositories;
using huuluan.Domain.Services;
using huuluan.DTO;
using huuluan.ViewModels;

namespace huuluan.Services
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _unitOfWork;
        private ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public List<CategoryViewModel> GetAll()
        {
            var result = _categoryRepository.GetAllCategories();
            return _mapper.Map<List<Category>, List<CategoryViewModel>>(result);
        }

        public bool PostCategory(CategoryDTO categoryDTO)
        {
            Category category = new Category( categoryDTO.Name, categoryDTO.CompanyId);
            _categoryRepository.CreateCategory(category);
            return _unitOfWork.Complete();
        }
        public Category GetById(int id) 
        {
            return _categoryRepository.GetById(id);
        }
        public Category DeleteById(int id)
        {
           return _categoryRepository.DeleteById(id);
            
        }
        public Category UpdateCat(int id, CategoryDTO categoryDTO) 
        {
            return _categoryRepository.UpdateCat(id, categoryDTO);
        }
    }
}
