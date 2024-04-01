using CleanCodeApp.Models;
using CleanCodeApp.Repository.Realization;
using CleanCodeApp.Service.Interface;

namespace CleanCodeApp.Service.Realization
{
    public class TechnologyService : ITechnologyService
    {

        private readonly RepositoryImpl<Technology> _technologyRepository;

        public TechnologyService()
        {
            _technologyRepository = new RepositoryImpl<Technology>(new List<Technology>
            {
                new Technology { Name = "Cobol" },
                new Technology { Name = "Punch Cards" },
                new Technology { Name = "Commodore" },
                new Technology { Name = "VBScript" }
            });
        }
        public bool Contains(string technology)
        {
            return _technologyRepository.Contains(new Technology { Name = technology });
        }

        public List<Technology> GetAll()
        {
            return _technologyRepository.GetAll();
        }
    }

}
