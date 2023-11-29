using huuluan.Domain.Models;
using huuluan.DTO;
using huuluan.ViewModels;

namespace huuluan.Domain.Repositories
{
    public interface ICompanyRepository
    {
        List<Company> GetAllCompanies();
        Company CreateCompany(Company company);
        Company GetById(int id);
        Company DeleteById(int id);
        Company UpdateCom(int id, CompanyDTO companyDTO);
    }
}
