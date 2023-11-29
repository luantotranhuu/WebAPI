using huuluan.Domain.Persistence.Context;
using huuluan.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace huuluan.Domain.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context) 
        {
            _context = context;
        }
        public bool Complete()
        {
            _context.SaveChanges();
            return true;
        }
    }
}
