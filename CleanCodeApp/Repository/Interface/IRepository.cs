using CleanCodeApp.Models;

namespace CleanCodeApp.Repository.Interface
{
    public interface IRepository<T> where T : Entity
    {
        bool Contains(T entity);
        List<T> GetAll();
        void Delete(Guid id);
        Guid Add(T entity);
    }
}
