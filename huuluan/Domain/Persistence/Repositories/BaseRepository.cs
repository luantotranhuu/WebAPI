using huuluan.Domain.Persistence.Context;

namespace huuluan.Domain.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
