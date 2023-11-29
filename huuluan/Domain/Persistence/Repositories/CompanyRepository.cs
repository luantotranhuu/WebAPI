using huuluan.Domain.Models;
using huuluan.Domain.Persistence.Context;
using huuluan.Domain.Repositories;
using huuluan.DTO;
using huuluan.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace huuluan.Domain.Persistence.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
        }
        public List<Company> GetAllCompanies()
        {
            return _context.Companies.Include(x => x.Categories).ToList();
        }

        public Company CreateCompany(Company company)
        {
            return _context.Companies.Add(company).Entity;
        }
        public Company GetById(int id)
        {
            return _context.Companies.FirstOrDefault(x => x.Id == id);
        }
        public Company DeleteById(int id)
        {
            var de = _context.Companies.FirstOrDefault(x => x.Id == id);
            _context.Companies.Remove(de);
            _context.SaveChanges();
            return de;
        }
        public Company UpdateCom(int id, CompanyDTO companyDTO)
        {
            var com = _context.Companies.FirstOrDefault(c => c.Id == id);
            if (com != null)
            {
                com.Name = companyDTO.Name;
            }

            _context.Companies.Update(com);
            _context.SaveChanges();
            return com;
        }
    }

}
