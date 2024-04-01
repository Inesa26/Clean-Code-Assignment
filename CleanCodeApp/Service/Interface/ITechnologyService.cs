using CleanCodeApp.Models;

namespace CleanCodeApp.Service.Interface
{
    public interface ITechnologyService
    {
        public bool Contains(string technology);
        public List<Technology> GetAll();
    }
}
