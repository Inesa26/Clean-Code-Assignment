using CleanCodeApp.Models;
using CleanCodeApp.Repository.Interface;

namespace CleanCodeApp.Repository.Realization
{
    public class RepositoryImpl<T> : IRepository<T> where T : Entity
    {
        private readonly List<T> _entities;

        public RepositoryImpl(List<T> entities) { _entities = entities; }
        public RepositoryImpl()
        {
            _entities = new List<T>();
        }
        public Guid Add(T entity)
        {
            _entities.Add(entity);
            return entity.Id;

        }

        public bool Contains(T entity)
        {
            return _entities.Contains(entity);
        }

        public void Delete(Guid id)
        {
            for (int i = 0; i < _entities.Count; i++)
            {
                if (_entities[i].Id == id)
                {
                    _entities.RemoveAt(i);
                    break;
                }
            }
        }

        public List<T> GetAll()
        {
            return _entities;
        }


    }
}
