using huuluan.Domain.Models;
using huuluan.DTO;
using huuluan.ViewModels;

namespace huuluan.Domain.Services
{
    public interface ICompanyService
    {
        List<CompanyViewModel> GetAll();
        bool PostCompany(CompanyDTO companyDTO);
        Company GetById(int id);
        Company DeleteById(int id);
        Company UpdateCom(int id, CompanyDTO companyDTO);
        

    }
}
