using huuluan.Domain.Models;
using huuluan.Domain.Persistence.Context;
using huuluan.Domain.Repositories;
using huuluan.DTO;
using huuluan.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace huuluan.Domain.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.Include(x => x.Company).ToList();
        }

        public Category CreateCategory(Category category)
        {
            return _context.Categories.Add(category).Entity;
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }
        public Category DeleteById(int id)
        {
            var delete = _context.Categories.FirstOrDefault(x => x.Id == id);
            _context.Categories.Remove(delete);
            _context.SaveChanges();
            return delete;
        }
        public Category UpdateCat(int id, CategoryDTO categoryDTO)
        {
            var cat = _context.Categories.FirstOrDefault(c => c.Id == id);
            if(cat != null)
            {
                
                cat.CompanyId = categoryDTO.CompanyId;
                cat.Name = categoryDTO.Name;
            }
            
            _context.Categories.Update(cat);
            _context.SaveChanges();
            return cat;
        }
    }
}
