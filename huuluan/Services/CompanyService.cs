using AutoMapper;
using huuluan.Domain.Models;
using huuluan.Domain.Persistence.Repositories;
using huuluan.Domain.Repositories;
using huuluan.Domain.Services;
using huuluan.DTO;
using huuluan.ViewModels;

namespace huuluan.Services
{
    public class CompanyService : ICompanyService
    {
        private IUnitOfWork _unitOfWork;
        private ICompanyRepository _companyRepository;
        private IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public List<CompanyViewModel> GetAll()
        {
            var result = _companyRepository.GetAllCompanies();
            return _mapper.Map<List<Company>, List<CompanyViewModel>>(result);
        }

        public Company GetById(int id)
        {
            return _companyRepository.GetById(id);
        }

        public bool PostCompany(CompanyDTO companyDTO)
        {
            Company company = new Company(companyDTO.Name);
            _companyRepository.CreateCompany(company);
            return _unitOfWork.Complete();
        }
        public Company DeleteById(int id)
        {
            return _companyRepository.DeleteById(id);
        }
        public Company UpdateCom(int id, CompanyDTO companyDTO)
        {
            return _companyRepository.UpdateCom(id, companyDTO);
        }

      
    }
}
