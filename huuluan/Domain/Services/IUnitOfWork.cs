namespace huuluan.Domain.Services
{
    public interface IUnitOfWork
    {
        public bool Complete();
    }
}
